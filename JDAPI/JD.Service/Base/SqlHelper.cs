using JD.Service.Base;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Service
{
    public class SqlHelper
    {
        public static SqlSugarClient Instance
        {
            get => new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigurationManager.GetConfigConnectionString(), //Data Source=SKY-20190714ZPH;Initial Catalog=JD;Integrated Security=True
                DbType = DbType.SqlServer,         //必填, 数据库类型
                IsAutoCloseConnection = true       //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                                                   // InitKeyType = InitKeyType.SystemTable    //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
            });
        }
    }
}
