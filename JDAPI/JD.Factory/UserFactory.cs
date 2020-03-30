using JD.Entity.Entity;
using JD.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Factory
{
    /// <summary>
    /// 用户工厂
    /// </summary>
    public class UserFactory
    {
        #region identity
        IUserService _iUserService;
        public UserFactory(IUserService userService)
        {
            this._iUserService = userService;
        }
        #endregion

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public int Register(string loginName, string passWord)
        {
            if (string.IsNullOrEmpty(loginName) || string.IsNullOrEmpty(passWord))
                return 0;

            T_User user = new T_User();
            user.LoginName = loginName;
            user.LoginPassword = passWord;
           return this._iUserService.Register(user);
        }

    }
}
