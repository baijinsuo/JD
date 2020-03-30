using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JD.ErrorException
{
    /// <summary>
    /// 服务端错误
    /// </summary>
    public class CustomErrorException : Exception
    {
        /// <summary>
        /// 构服务端错误
        /// </summary>
        private CustomErrorException(ProtocolError errorCode, string errorDescription)
        {
            this.Code = errorCode;
            this.Description = errorDescription;
        }

        /// <summary>
        /// 错误码
        /// </summary>
        public readonly ProtocolError Code;
        /// <summary>
        /// 错误描述
        /// </summary>
        public readonly string Description;

        /// <summary>
        /// 创建服务端错误
        /// </summary>
        public static CustomErrorException Create(ProtocolError errorCode)
        {
            return Create(errorCode, string.Empty);
        }

        /// <summary>
        /// 创建服务端错误
        /// </summary>
        public static CustomErrorException Create(ProtocolError errorCode, string errorDescription)
        {
            return new CustomErrorException(errorCode, errorDescription);
        }
    }
}
