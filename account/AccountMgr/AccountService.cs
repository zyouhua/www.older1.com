using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace account
{
    public class AccountService
    {
        public ErrorCode_ _createAccount(string nAccountName, string nPassward)
        {
            uint hashName_ = HashString._runHash(nAccountName, 0x100);
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = hashName_ % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._createAccount(nAccountName, nPassward);
        }

        public __tuple<ErrorCode_, AccountC> _loginAccount(string nAccountName, string nPassward)
        {
            uint hashName_ = HashString._runHash(nAccountName, 0x100);
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = hashName_ % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._loginAccount(nAccountName, nPassward);
        }

        public bool _isAccountLogin(uint nHashName, uint nHashAccount, uint nAccountId)
        {
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = nHashName % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            Account account_ = accountMgr_._getAccount(nHashAccount);
            if (null == account_)
            {
                return false;
            }
            if (account_._getAccountId() != nAccountId)
            {
                return false;
            }
            return true;
        }

        public void _runInit()
        {
            string accountConfigUrl_ = @"rid://account.accoutConfig";
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            platformSingleton_._loadHeadstream<AccountConfig>(accountConfig_, accountConfigUrl_);

            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            for (uint i = 0; i < accountMgrCount_; ++i)
            {
                AccountMgr accountMgr_ = new AccountMgr();
                mAccountMgrs[i] = accountMgr_;
            }
        }

        public AccountService()
        {
            mAccountMgrs = new Dictionary<uint, AccountMgr>();
        }

        Dictionary<uint, AccountMgr> mAccountMgrs;
    }
}
