using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JD.ErrorException;
using JD.Factory;
using JD.IService;
using JD.Model.ReceiveModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static JD.Model.ResponseModel.Response;

namespace JD.Controllers
{
    /// <summary>
    /// 用户登录
    /// </summary>
    [EnableCors("CorsPolicy")] //允许跨域
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region Identity
        IUserService _iUserService;
        public LoginController(IUserService userService)
        {
            this._iUserService = userService;
        }
        #endregion


        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public ResponseDataBase Login(UserModel user)
        {
            var resp = new ResponseDataBase();
            if (string.IsNullOrEmpty(user.LoginName) || string.IsNullOrEmpty(user.PassWord))
                throw CustomErrorException.Create(ProtocolError.ParamIsEmpty);

            var model = this._iUserService.Login(user.LoginName, user.PassWord);
            if (model == null)
                throw CustomErrorException.Create(ProtocolError.LoginFailed);
            else
                resp.Data = model;

            return resp;
        }
    }
}