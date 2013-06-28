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

            MySqlInsert mySqlInsert_ = new MySqlInsert();
            mySqlInsert_._selectStream(accountB_._streamName());
            accountB_._serialize(mySqlInsert_);
            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            SqlStatus_ status_ = mySqlSingleton_._runSql(mySqlInsert_);
            if (SqlStatus_.mSucess_ == status_)
            {
                return ErrorCode_.mSucess_;
            }
            else
            {
                return ErrorCode_.mFail_;
            }
        }

        public __tuple<ErrorCode_, AccountC> _loginAccount(string nAccountName, string nPassward)
        {
            AccountB accountB_ = new AccountB();
            MySqlSelect mySqlSelect_ = new MySqlSelect();
            mySqlSelect_._selectStream(accountB_._streamName());

            uint accountId_ = HashString._runHash(nAccountName, 0x200);
            MySqlWhere mySqlWhere_ = new MySqlWhere();
            mySqlSelect_._selectStream(accountB_._loginWhere(accountId_));

            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            SqlStatus_ status_ = mySqlSingleton_._runSql(mySqlSelect_, mySqlWhere_, accountB_);

            string passward_ = accountB_._getPassward();
            uint loginPassward_ = HashString._runHash(nPassward, 0x200);
            uint hashPassward_ = HashString._runHash(passward_, 0x200);
            ErrorCode_ errorCode_ = ErrorCode_.mNone_;
            AccountC accountC_ = null;
            if (hashPassward_ == loginPassward_)
            {
                errorCode_ = ErrorCode_.mSucess_;
                Account account_ = this._getAccount(accountId_);
                if (null == account_)
                {
                    account_ = new Account();
                    account_._setAccountId(accountId_);
                    account_._setTicks(DateTime.Now.Ticks);
                    mAccounts[accountId_] = account_;
                }
                accountC_ = account_._getAccountC();
            }
            else
            {
                errorCode_ = ErrorCode_.mPassward_;
            }
            return new __tuple<ErrorCode_, AccountC>(errorCode_, accountC_);
        }

        public Account _getAccount(uint nAccount)
        {
            if (mAccounts.ContainsKey(nAccount))
            {
                return mAccounts[nAccount];
            }
            return null;
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
