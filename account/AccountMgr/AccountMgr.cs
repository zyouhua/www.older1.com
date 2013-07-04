using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace account
{
    public class AccountMgr
    {
        public ErrorCode_ _createAccount(string nAccountName, string nPassward)
        {
            AccountB accountB_ = new AccountB();
            accountB_._setAccountName(nAccountName);
            accountB_._setPassward(nPassward);
            accountB_._setMgrId(mId);
            accountB_._setTicks(DateTime.Now.Ticks);

            MySqlInsert mySqlInsert_ = new MySqlInsert();
            mySqlInsert_._selectStream(accountB_._streamName());
            accountB_._serialize(mySqlInsert_);

            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            SqlStatus_ sqlStatus_ = mySqlSingleton_._runSql(mySqlInsert_);
            return _getErrorCode(sqlStatus_);
        }

        public AccountC _loginAccount(string nAccountName, string nPassward, uint nDeviceType)
        {
            AccountC result_ = null;
            ErrorCode_ errorCode_ = this._checkDevice(nDeviceType);
            if (ErrorCode_.mSucess_ == errorCode_)
            {
                __tuple<SqlStatus_, AccountB> accountDB_ = this._LoginAccountB(nAccountName);
                errorCode_ = this._getErrorCode(accountDB_._get_0());
                if (ErrorCode_.mSucess_ == errorCode_)
                {
                    AccountB accountB_ = accountDB_._get_1();
                    errorCode_ = accountB_._checkPassward(nPassward);
                }
            }
            if (ErrorCode_.mSucess_ == errorCode_)
            {
                uint accountId_ = AccountB._accountId(nAccountName);
                Account account_ = this._getAccount(accountId_);
                if (null == account_)
                {
                    account_ = new Account();
                    account_._setAccountId(accountId_);
                    account_._addDeviceType(nDeviceType);
                    mAccounts[accountId_] = account_;
                }
                account_._setTicks(DateTime.Now.Ticks);
                result_ = account_._getAccountC(nDeviceType);
            }
            else
            {
                result_ = new AccountC();
            }
            result_.m_tErrorCode = errorCode_;
            return result_;
        }

        public ErrorCode_ _logoutAccount(string nAccountName, uint nDeviceId, uint nDeviceType)
        {
            ErrorCode_ result_ = ErrorCode_.mSucess_;
            Account account_ = this._getAccount(nAccountName);
            if (null == account_)
            {
                result_ = ErrorCode_.mFail_;
            }
            if (ErrorCode_.mSucess_ == result_)
            {
                result_ = account_._logout(nDeviceId, nDeviceType);
            }
            return result_;
        }

        ErrorCode_ _checkDevice(uint nDeviceType)
        {
            ErrorCode_ result_ = ErrorCode_.mSucess_;
            DeviceMgr deviceMgr_ = __singleton<DeviceMgr>._instance();
            if (!deviceMgr_._contain(nDeviceType))
            {
                result_ = ErrorCode_.mDevice_;
            }
            return result_;
        }

        __tuple<SqlStatus_, AccountB> _LoginAccountB(string nAccountName)
        {
            AccountB accountB_ = new AccountB();
            accountB_._setMgrId(mId);
            accountB_._setAccountName(nAccountName);

            MySqlSelect mySqlSelect_ = new MySqlSelect();
            mySqlSelect_._selectStream(accountB_._streamName());
            accountB_._serialize(mySqlSelect_);

            MySqlWhere mySqlWhere_ = new MySqlWhere();
            mySqlWhere_._selectStream(accountB_._loginWhere());

            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            SqlStatus_ sqlStatus_ = mySqlSingleton_._runSql(mySqlSelect_, mySqlWhere_, accountB_);

            return new __tuple<SqlStatus_, AccountB>(sqlStatus_, accountB_);
        }

        ErrorCode_ _getErrorCode(SqlStatus_ nSqlStatus)
        {
            ErrorCode_ result_ = ErrorCode_.mSucess_;
            if (SqlStatus_.mFail_ == nSqlStatus)
            {
                result_ = ErrorCode_.mFail_;
            }
            return result_;
        }

        public Account _getAccount(string nAccountName)
        {
            Account result_ = null;
            uint accountId_ = AccountB._accountId(nAccountName);
            if (mAccounts.ContainsKey(accountId_))
            {
                result_ = mAccounts[accountId_];
            }
            return result_;
        }

        public Account _getAccount(uint nAccount)
        {
            Account result_ = null;
            if (mAccounts.ContainsKey(nAccount))
            {
                result_ = mAccounts[nAccount];
            }
            return result_;
        }

        public void _setId(uint nId)
        {
            mId = nId;
        }
        
        public AccountMgr()
        {
            mAccounts = new Dictionary<uint, Account>();
            mId = 0;
        }

        Dictionary<uint, Account> mAccounts;
        uint mId;
    }
}
