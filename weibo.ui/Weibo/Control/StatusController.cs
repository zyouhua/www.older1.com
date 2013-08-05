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
    public class StatusController : ApiController
    {
        [HttpPost]
        public ErrorCode_ _createStatus(string nName, uint nDeviceId, uint nDeviceType, StatusS nStatusS)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            return accountService_._createAccount(nName, nNickname, nPassward);
        }

        public ErrorCode_ _logoutAccount(string nName, uint nDeviceId, uint nDeviceType)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            return accountService_._logoutAccount(nName, nDeviceId, nDeviceType);
        }
    }
}
