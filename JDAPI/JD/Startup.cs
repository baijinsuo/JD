using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace JD
{
    public class Startup
    {
        /// <summary>
        /// log4net  https://blog.csdn.net/qq_42606051/article/details/82385279
        /// </summary>
        public static ILoggerRepository repository { get; set; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            #region log4net
            repository = LogManager.CreateRepository("Baijinsuo_Log4net");
            XmlConfigurator.Configure(repository, new FileInfo("log4net\\log4net.config"));
            log4net.InitRepository.LogRepository = repository;
            #endregion
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //替换控制器所有者,属性注入的时候需要此代码，一定要加在AddMvc前面
            //services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());

            services.AddMvc(o =>
            {
                //引入异常处理类
                o.Filters.Add(typeof(ErrorException.GlobalExceptions));
            });

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1.1.0",
                    Title = "JD WebAPI",
                    Description = "框架集合",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact { Name = "JDBai", Email = "2573815219@qq.com", Url = "http://www.cnblogs.com/RayWang" }
                });



                //添加读取控制、方法注释服务
                var basePath = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, basePath);
                c.IncludeXmlComments(xmlPath, true);

                //添加读取实体类注释服务
                var entityXmlPath = Path.Combine(AppContext.BaseDirectory, "JD.Entity.xml");
                c.IncludeXmlComments(entityXmlPath);
                //添加控制器层注释（true表示显示控制器注释）
                //c.DocumentFilter<SwaggerHelp.SwaggerDocTag>();//第二种方式和第三种方式显示控制器的注释说明


                //手动高亮
                //添加header验证信息
                //c.OperationFilter<SwaggerHeader>();
                var security = new Dictionary<string, IEnumerable<string>> { { "Bearer", new string[] { } }, };
                c.AddSecurityRequirement(security);//添加一个必须的全局安全信息，和AddSecurityDefinition方法指定的方案名称要一致，这里是Bearer。
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 参数结构: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = "header",//jwt默认存放Authorization信息的位置(请求头中)
                    Type = "apiKey"
                });
            });
            #endregion

            #region 跨域
            services.AddMemoryCache();
            services.AddCors(options =>
            {
                //AnyCore策略名称
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()//允许所有站点跨域请求
                    //builder.WithOrigins(new string[] { "http://localhost:60482" })//允许部分站点跨域请求
                    .AllowAnyMethod()//允许所有请求方法
                    .AllowAnyHeader()//允许所有请求头
                    .AllowCredentials();//允许Cookie信息
                });
            });
            #endregion

            services.AddDirectoryBrowser();
            var containerBuilder = new ContainerBuilder();

            //1.模块化注入
            containerBuilder.RegisterModule<JD.Autofac.CustomAutofacModule>();

            ////2.属性注入控制器，要对所有控制器进行注册，因为上面替换了控制器的所有者
            //containerBuilder.RegisterType<ExamServer.Controllers.LoginController>().PropertiesAutowired();
            //containerBuilder.RegisterType<ExamServer.Controllers.HomeController>().PropertiesAutowired();


            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Test}/{action=Index}/{id?}");
            });
            app.UseStaticFiles();

            //app.UseMvc();
            app.UseCors("CorsPolicy");

            #region Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiHelp V1");
            });
            #endregion
        }
    }
}
