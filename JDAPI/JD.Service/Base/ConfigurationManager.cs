using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Service.Base
{
    public class ConfigurationManager
    {
        public readonly static IConfiguration Configuration;
        static ConfigurationManager()
        {
            Configuration = new ConfigurationBuilder()
            .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
            .Build();
        }

        /// <summary>
        /// 获取数据库连接字符串
        /// </summary>
        /// <returns></returns>
        public static string GetConfigConnectionString()
        {
            return Configuration.GetConnectionString("connStr");
        }
    }
}
