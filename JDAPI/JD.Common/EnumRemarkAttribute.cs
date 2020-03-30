using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JD.Common
{
    public static class RemarkExtension
    {
        /// <summary>
        /// 通过反射获取枚举描述特性值
        /// </summary>
        /// <param name="e"></param>
        /// <returns>枚举值的描述</returns>
        public static string GetRemark(this Enum e)
        {
            Type type = e.GetType();
            FieldInfo field = type.GetField(e.ToString());
            if (field.IsDefined(typeof(EnumRemarkAttribute), true))
            {
                EnumRemarkAttribute attribute = (EnumRemarkAttribute)field.GetCustomAttribute(typeof(EnumRemarkAttribute), true);
                return attribute.GetRemark();
            }
            else
            {
                return e.ToString();
            }
        }
    }


    /// <summary>
    /// 枚举描述特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    public class EnumRemarkAttribute : Attribute
    {
        private string _Remark = null;
        /// <summary>
        /// 初始化新实例。
        /// </summary>
        /// <param name="remark">描述</param>
        public EnumRemarkAttribute(string remark)
        {
            this._Remark = remark;
        }
        /// <summary>
        /// 描述文本
        /// </summary>
        public string GetRemark()
        {
            return this._Remark;
        }
    }
}
