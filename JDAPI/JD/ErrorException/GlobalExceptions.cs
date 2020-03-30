using JD.log4net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace JD.ErrorException
{
    public class GlobalExceptions : IExceptionFilter
    {
        private readonly IHostingEnvironment _env;
        public GlobalExceptions(IHostingEnvironment env)
        {
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            var json = new JsonErrorResponse();
            //这里面是自定义的操作记录日志
            if (context.Exception.GetType() == typeof(UserOperationException))
            {
                json.Message = context.Exception.Message;
                if (_env.IsDevelopment())
                {
                    json.DevelopmentMessage = context.Exception.StackTrace;//堆栈信息
                }
                context.Result = new BadRequestObjectResult(json);//返回异常数据
            }
            else
            {
                if (context.Exception is CustomErrorException)
                {
                    var cee = (CustomErrorException)context.Exception;
                    json.Code = (int)cee.Code;
                    json.Message = $"{(int)cee.Code}{Common.RemarkExtension.GetRemark(cee.Code)}";
                    json.DevelopmentMessage = cee.StackTrace;//堆栈信息
                }
                else
                {
                    json.Message = "发生了未知内部错误";
                    json.Code = 500;
                    json.DevelopmentMessage = context.Exception.StackTrace;//堆栈信息
                }
                context.Result = new InternalServerErrorObjectResult(json);
            }
            //采用log4net 进行错误日志记录
            LogHelper.ErrorLog(json.Message, context.Exception);
        }

        public class InternalServerErrorObjectResult : ObjectResult
        {
            public InternalServerErrorObjectResult(object value) : base(value)
            {
                StatusCode = StatusCodes.Status500InternalServerError;
            }
        }
    }
}
