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
            uint hashAccount_ = HashString._runHash(nAccountName, 0x200);
            return ErrorCode_.mSucess_;
        }

        public Account _getAccount(uint nAccount)
        {
            if (mAccounts.ContainsKey(nAccount))
            {
                return mAccounts[nAccount];
            }
            return null;
        }

        public AccountMgr()
        {
            mAccounts = new Dictionary<uint, Account>();
        }

        Dictionary<uint, Account> mAccounts;
    }
}
