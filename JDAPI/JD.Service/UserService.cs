using JD.Entity.Entity;
using JD.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Service
{
    /// <summary>
    /// 用户服务
    /// </summary>
    public class UserService : AbstractService<T_User>, IUserService
    {
        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        public T_User Login(string loginName, string PassWord)
        {
            return SqlHelper.Instance.Queryable<T_User>().First(r => r.LoginName == loginName && r.LoginPassword == PassWord);
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Register(T_User user)
        {
          return  SqlHelper.Instance.Insertable<T_User>(user).ExecuteCommand();
        }
    }
}
