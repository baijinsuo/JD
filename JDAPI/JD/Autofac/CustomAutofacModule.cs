using Autofac;
using Autofac.Extras.DynamicProxy;
using JD.Factory;
using JD.IService;
using JD.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JD.Autofac
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomAutofacModule: Module
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>().EnableInterfaceInterceptors();
            builder.RegisterType<ProductService>().As<IProductService>().EnableInterfaceInterceptors();
            builder.RegisterType<ProductImageService>().As<IProductImageService>().EnableInterfaceInterceptors();
            builder.RegisterType<CategoryService>().As<ICategoryService>().EnableInterfaceInterceptors();

            //注册工厂
            builder.RegisterType<UserFactory>();
            builder.RegisterType<ProductFactory>();
        }
    }
}
