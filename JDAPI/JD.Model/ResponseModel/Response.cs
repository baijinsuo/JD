using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Model.ResponseModel
{
    public class Response
    {
        /// <summary>
        /// 教师action
        /// </summary>
        abstract public class BaseClass
        {
            private int _Code = 200;
            /// <summary>
            /// 200 OK ，其他 error
            /// </summary>
            public int Code
            {
                get { return _Code; }
                set { _Code = value; }
            }

            /// <summary>
            /// 内容
            /// </summary>
            public string Message { get; set; }

        }

        /// <summary>
        /// 公用响应
        /// </summary>
        public class ResponseBase : BaseClass
        {

        }

        /// <summary>
        /// 公用响应(包含数据)
        /// </summary>
        public class ResponseDataBase : BaseClass
        {
            /// <summary>
            /// 返回数据
            /// </summary>
            public object Data { get; set; }

        }
    }
}
