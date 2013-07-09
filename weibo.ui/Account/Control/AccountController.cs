using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using weibo;
using account;
using platform;

namespace weibo.ui
{
    public class AccountController : ApiController
    {
        [HttpGet]
        public ErrorCode_ _createAccount(string nName, string nNickname, string nPassward)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            return accountService_._createAccount(nName, nNickname, nPassward);
        }

        [HttpGet]
        public ErrorCode_ _loginAccount(string nName, string nPassward, uint nDeviceType)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            __tuple<ErrorCode_, Account> accountInfo_ = accountService_._loginAccount(nName, nPassward, nDeviceType);
            if (ErrorCode_.mSucess_ == accountInfo_._get_0())
            {

            }
            return ErrorCode_.mSucess_;
        }

        [HttpGet]
        public ErrorCode_ _logoutAccount(string nName, uint nDeviceId, uint nDeviceType)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            return accountService_._logoutAccount(nName, nDeviceId, nDeviceType);
        }
    }
}
