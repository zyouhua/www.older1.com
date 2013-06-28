using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using account;
using platform;

namespace weibo.ui
{
    public class AccountController : ApiController
    {
        // GET api/values/5/4
        public ErrorCode_ _createAccount(string nName, string nPassward)
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            return accountService_._createAccount(nName, nPassward);
        }
    }
}
