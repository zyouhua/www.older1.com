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
        public AccountC _loginAccount(string nName, string nPassward, uint nDeviceType)
        {
            AccountC result_ = new AccountC();
            AccountService accountService_ = __singleton<AccountService>._instance();
            __tuple<ErrorCode_, Account> accountInfo_ = accountService_._loginAccount(nName, nPassward, nDeviceType);
            result_.m_tErrorCode = accountInfo_._get_0();
            if (ErrorCode_.mSucess_ == accountInfo_._get_0())
            {
                accountInfo_._get_1()._getAccountC(result_, nDeviceType);
            }
            return result_;
        }

        [HttpGet]
        public ErrorCode_ _logoutAccount(string nName, uint nDeviceId, uint nDeviceType)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            return accountService_._logoutAccount(nName, nDeviceId, nDeviceType);
        }
    }
}
