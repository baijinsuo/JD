using JD.Entity.Entity;
using JD.IService.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.IService
{
    public interface IUserService: IBaseService<T_User>
    {
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="PassWord">密码</param>
        /// <returns></returns>
        T_User Login(string loginName, string PassWord);

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        int Register(T_User user);
    }
}
