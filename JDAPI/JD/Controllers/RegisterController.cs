using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JD.Entity.Entity;
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
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        #region Identity
        UserFactory _userFactory;
        public RegisterController(UserFactory userFactory)
        {
            this._userFactory = userFactory;
        }
        #endregion


        [HttpPost]
        public ResponseBase JDRegister(UserModel data)
        {
            var resp = new ResponseBase();
            if (string.IsNullOrEmpty(data.LoginName) || string.IsNullOrEmpty(data.PassWord))
                throw CustomErrorException.Create(ProtocolError.ParamIsEmpty);

            int result = this._userFactory.Register(data.LoginName, data.PassWord);
            if (result > 0)
                resp.Message = "注册成功";
            return resp;
        }
    }
}