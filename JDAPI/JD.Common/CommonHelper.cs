using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JD.Common
{
    public class CommonHelper
    {

        /// <summary>
        /// 填充指定长度的字符串
        /// </summary>
        /// <param name="key"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GetStringFillLength(int key, int length)
        {
            return key.ToString("D" + length.ToString());
        }

        //邮箱格式正则
        public static bool IsValidEmail(string strIn)
        {
            if (string.IsNullOrEmpty(strIn) || strIn.Length > 50) return false;
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        /// <summary>
        /// 验证手机号码格式合法（以1开头的11位数字）
        /// </summary>
        public static bool IsValidTel2(string strIn)
        {
            if (string.IsNullOrEmpty(strIn)) return false;
            // Return true if strIn is in valid mobile phone number format.
            return Regex.IsMatch(strIn, @"^1\d{10,10}$");
        }

        //手机格式正则
        [Obsolete]
        public static bool IsValidTel(string strIn)
        {
            if (string.IsNullOrEmpty(strIn)) return false;
            // Return true if strIn is in valid mobile phone number format.
            return Regex.IsMatch(strIn, @"^1[3|4|5|8][0-9]\d{8,8}$");
        }

        /// <summary>
        /// 验证身份证号码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsValidIDCard(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            return Regex.IsMatch(value, @"(^\d{15}$)|(^\d{18}$)|(^\d{17}(\d|X|x)$)");
        }

        /// <summary>
        /// 验证指定字符串是否为有效的物理路径
        /// </summary>
        /// <param name="strPath">路径字符串</param>
        /// <param name="extension">拓展名名(.txt)</param>
        /// <returns></returns>
        public static bool IsValidPhysicalPath(string strPath, string extension)
        {
            if (Regex.IsMatch(strPath, string.Format(@"^[a-z]\:\\([^\\:*?""<>|]+\\)*([^\\:*?""<>|]+\{0})$", extension), RegexOptions.IgnoreCase))
                return true;
            return false;
        }

        public static bool TryParse(object obj, bool defaultValue)
        {
            if (obj == null)
                return defaultValue;
            bool d;
            if (!bool.TryParse(obj.ToString(), out d))
                d = defaultValue;
            return d;
        }

        public static double TryParse(string strValue, double defaultValue)
        {
            double d;
            if (!double.TryParse(strValue, out d))
                d = defaultValue;
            return d;
        }
        public static float TryParse(string strValue, float defaultValue)
        {
            float f;
            if (!float.TryParse(strValue, out f))
                f = defaultValue;
            return f;
        }

        public static decimal TryParse(string strValue, decimal defaultValue)
        {
            decimal v;
            if (!decimal.TryParse(strValue, out v))
                return defaultValue;
            else
                return v;
        }

        /// <summary>
        /// 字符串转换成Guid，支持自定义base64编码的GUID字符串
        /// </summary>
        public static Guid TryParse(string strValue, Guid defaultValue)
        {
            if (string.IsNullOrEmpty(strValue)) return defaultValue;

            if (strValue.Length == 24 && strValue[0] == 'E' && strValue[1] == 'Q')
            {
                strValue = strValue.Replace('_', '+').Replace('-', '/');
                byte[] data = Convert.FromBase64String(strValue);
                byte[] guidData = new byte[16];
                Array.Copy(data, 2, guidData, 0, 16);
                return new Guid(guidData);
            }
            else
            {
#if !NF2
                Guid guid;
                if (Guid.TryParse(strValue, out guid))
                    return guid;
                else
                    return defaultValue;
#else
                try
                {
                    return new Guid(strValue);
                }
                catch
                {
                    return defaultValue;
                    throw;
                }
#endif
            }
        }

        public static bool TryParse(string strValue, out Guid value)
        {
            try
            {
                value = new Guid(strValue);
                return true;
            }
            catch
            {
                value = Guid.Empty;
                return false;
            }
        }
        public static DateTime TryParse(string strValue, DateTime defaultValue)
        {
            DateTime d;
            if (DateTime.TryParse(strValue, out d))
            {
                return d;
            }
            else
            {
                return defaultValue;
            }
        }

        public static int TryParse(string strValue, int defaultValue)
        {
            int i;
            if (TryParse(strValue, out i))
                return i;
            else
                return defaultValue;
        }

        public static bool TryParse(string strValue, out int returnValue)
        {
            return int.TryParse(strValue, out returnValue);
        }

        public static int TryParseInt(string strVal)
        {
            return TryParseInt(strVal, 0);
        }
        public static int TryParseInt(string strVal, int nDefaultValue)
        {
            int i;
            if (int.TryParse(strVal, out i))
                return i;
            else
                return nDefaultValue;
        }

        /// <summary>
        /// 验证Guid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool ValDataGuid(Guid id)
        {
            if (id == null || id == Guid.Empty)
                return false;
            else
                return true;
        }
    }
}
