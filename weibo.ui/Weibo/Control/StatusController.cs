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
            Account account_ = accountService_._getAccount(nName, nDeviceId, nDeviceType);
            StatusMgr statusMgr_ = account_._getProperty<StatusMgr>();
            return ErrorCode_.mSucess_;
        }
    }
}
