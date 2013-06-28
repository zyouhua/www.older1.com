using System;

using platform;

namespace account
{
    public class AccountB : ISqlStream
    {
        public string _loginWhere(uint nAccountId)
        {
            string result_ = "`Id` = `";
            result_ += Convert.ToString(nAccountId);
            result_ += "`";
            return result_;
        }

        public void _serialize(ISqlSerialize nSqlSerialize)
        {
            nSqlSerialize._serialize(ref mAccountId, @"Id");
            nSqlSerialize._serialize(ref mAccountName, @"Name");
            nSqlSerialize._serialize(ref mPassward, @"Passward");
        }

        public string _streamName()
        {
            return "Account";
        }

        public uint _getAccountId()
        {
            return mAccountId;
        }

        public void _setAccountName(string nAccountName)
        {
            mAccountId = HashString._runHash(nAccountName, 0x200);
            mAccountName = nAccountName;
        }

        public string _getAccountName()
        {
            return mAccountName;
        }

        public void _setPassward(string nPassward)
        {
            mPassward = nPassward;
        }

        public string _getPassward()
        {
            return mPassward;
        }

        public AccountB()
        {
            mAccountId = 0;
            mAccountName = null;
            mPassward = null;
        }

        uint mAccountId;
        string mAccountName;
        string mPassward;
    }
}
