using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JD.Factory;
using JD.IService;
using JD.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JD.Controllers
{
    /// <summary>
    /// 首页管理
    /// </summary>
    [EnableCors("CorsPolicy")] //允许跨域
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        #region Identity
        UserFactory _userFactory;
        public TestController(UserFactory userFactory)
        {
            this._userFactory = userFactory;
        }
        #endregion

        /// <summary>
        /// 测试接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "this is Test Success";
            //var userlist = this._userFactory.GetByIds();
            //var user = this._userFactory.GetById(1000);
            //if (user == null)
            //    return string.Empty;
            //else
            //    return user.LoginName + user.LoginPassword;
        }
    }
}