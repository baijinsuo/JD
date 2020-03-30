using JD.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JD.ErrorException
{
    /// <summary>
    /// 协议常数定义
    /// </summary>
    public static class ProtocolConst
    {
        /// <summary>
        /// 协议当前版本 v2
        /// </summary>
        public static readonly int CurrentVersion = 2;

        /// <summary>
        /// 协议错误返回的Httpcode
        /// </summary>
        public static readonly System.Net.HttpStatusCode HttpCode_CustomError = (System.Net.HttpStatusCode)440;

        /// <summary>
        /// 客户端提交session的cookie名称
        /// </summary>
        public static readonly string SESSION_COOKIE_NAME = "sid";

        /// <summary>
        /// 客户端提交Session的自定义头名称
        /// </summary>
        public static readonly string SESSION_HEADER_NAME = "x-sid";

        /// <summary>
        /// 服务端返回错误代码的header名称
        /// </summary>
        public static readonly string ERROR_HEADER_NAME = "x-error-code";
    }

    /// <summary>
    /// 协议错误码定义
    /// </summary>
    public enum ProtocolError
    {
        #region 通用错误
        /// <summary>
        /// 一般错误，详细错误信息参看具体错误提示
        /// </summary>
        [EnumRemark("一般错误,详细错误信息参看具体错误提示")]
        Common = 1000,
        /// <summary>
        /// 没有权限
        /// </summary>
        [EnumRemark("没有权限")]
        NotPermit = 1001,
        /// <summary>
        /// 数据不存在:1002
        /// </summary>
        [EnumRemark("数据不存在")]
        NotExists = 1002,
        /// <summary>
        /// 会话不存在
        /// </summary>
        [EnumRemark("会话不存在")]
        SessionNotExists = 1003,
        /// <summary>
        /// 用户尚未登录
        /// </summary>
        [EnumRemark("用户尚未登录")]
        NotLogin = 1004,
        /// <summary>
        /// 频繁发送手机短信
        /// </summary>
        [EnumRemark("频繁发送手机短信")]
        SmsTimeLimit = 1005,
        /// <summary>
        /// 参数为空
        /// </summary>
        [EnumRemark("参数为空")]
        ParamIsEmpty = 1006,
        #endregion

        #region 会话模块
        /// <summary>
        /// 非法的客户端
        /// </summary>
        [EnumRemark("非法的客户端")]
        InvalidClient = 1101,
        /// <summary>
        /// 客户端协议版本不支持
        /// </summary>
        [EnumRemark("客户端协议版本不支持")]
        ObsoleteProtocolVer = 1102,
        /// <summary>
        /// 客户端版本号不支持
        /// </summary>
        [EnumRemark("客户端版本号不支持")]
        ObsoleteClientVer = 1103,
        /// <summary>
        /// 服务端禁止新的登录会话
        /// </summary>
        [EnumRemark("服务端禁止新的登录会话")]
        DisabledNewClient = 1104,
        /// <summary>
        /// 用户名或者密码错误
        /// </summary>
        [EnumRemark("用户名或者密码错误")]
        LoginFailed = 1105,
        /// <summary>
        /// 会话被踢出
        /// </summary>
        [EnumRemark("会话被踢出")]
        SessionKickedOut = 1106,
        /// <summary>
        /// 用户被禁用
        /// </summary>
        [EnumRemark("用户被禁用")]
        UserDisabled = 1107,
        /// <summary>
        /// 平台错误
        /// </summary>
        [EnumRemark("平台错误")]
        PlatError = 1108,
        #endregion

        #region 用户模块
        /// <summary>
        /// 手机号不合法或者不受支持
        /// </summary>
        [EnumRemark("手机号不合法或者不受支持")]
        InvalidPhoneNumber = 1201,
        /// <summary>
        /// 手机号已被其他用户注册
        /// </summary>
        [EnumRemark("手机号已被其他用户注册")]
        PhoneNumberExists = 1202,
        /// <summary>
        /// 尚未获取验证码
        /// </summary>
        [EnumRemark("尚未获取验证码")]
        NotGetVerifyCode = 1203,
        /// <summary>
        /// 用户名重复
        /// </summary>
        [EnumRemark("用户名重复")]
        LoginNameExists = 1204,
        /// <summary>
        /// 手机验证码错误或者无效
        /// </summary>
        [EnumRemark("手机验证码错误或者无效")]
        InvalidVerifyCode = 1205,
        /// <summary>
        /// 密码不能为空
        /// </summary>
        [EnumRemark("密码不能为空")]
        PasswordIsEmpty = 1206,
        /// <summary>
        /// 账号不存在
        /// </summary>
        [EnumRemark("账号不存在")]
        LoginNameNotExists = 1207,
        /// <summary>
        /// 该账号未在教师端注册
        /// </summary>
        [EnumRemark("该账号未在教师端注册")]
        TeacherLoginNameNotExists = 1208,
        /// <summary>
        /// 该功能属于VIP
        /// </summary>
        [EnumRemark("该功能属于VIP")]
        NonSupportAuth = 1209,
        #endregion
    }
}
