using System.Collections.Generic;

using platform;

namespace account
{
    public class AccountService
    {
        public ErrorCode_ _createAccount(string nAccountName, string nNickname, string nPassward)
        {
            uint hashName_ = HashString._runServerID(nAccountName);
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = hashName_ % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._createAccount(nAccountName, nNickname, nPassward);
        }

        public __tuple<ErrorCode_, Account> _loginAccount(string nAccountName, string nPassward, uint nDeviceType)
        {
            uint hashName_ = HashString._runServerID(nAccountName);
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = hashName_ % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._loginAccount(nAccountName, nPassward, nDeviceType);
        }

        public ErrorCode_ _logoutAccount(string nAccountName, uint nDeviceId, uint nDeviceType)
        {
            uint hashName_ = HashString._runServerID(nAccountName);
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = hashName_ % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._logoutAccount(nAccountName, nDeviceId, nDeviceType);
        }

        public Account _getAccount(string nAccountName, uint nDeviceId, uint nDeviceType)
        {
            uint hashName_ = HashString._runServerID(nAccountName);
            AccountConfig accountConfig_ = __singleton<AccountConfig>._instance();
            uint accountMgrCount_ = accountConfig_._getAccountMgrCount();
            uint accountMgrIndex_ = hashName_ % accountMgrCount_;
            AccountMgr accountMgr_ = mAccountMgrs[accountMgrIndex_];
            return accountMgr_._getAccount(nAccountName, nDeviceId, nDeviceType);
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
                accountMgr_._setId(i);
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
