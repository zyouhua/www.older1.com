using System;

using platform;

namespace account
{
    public class AccountB : ISqlStream
    {
        public static uint _accountId(string nAccountName)
        {
            return HashString._runHash(nAccountName, 0x200);
        }

        public ErrorCode_ _checkPassward(string nPassward)
        {
            ErrorCode_ result_ = ErrorCode_.mSucess_;
            uint loginPassward_ = HashString._runHash(nPassward, 0x300);
            uint hashPassward_ = HashString._runHash(mPassward, 0x300);
            if (loginPassward_ != hashPassward_)
            {
                result_ = ErrorCode_.mPassward_;
            }
            return result_;
        }

        public string _loginWhere()
        {
            string result_ = "`Id` = ";
            result_ += Convert.ToString(mAccountId);
            return result_;
        }

        public void _serialize(ISqlSerialize nSqlSerialize)
        {
            nSqlSerialize._serialize(ref mAccountId, @"Id");
            nSqlSerialize._serialize(ref mAccountName, @"Name");
            nSqlSerialize._serialize(ref mPassward, @"Passward");
            nSqlSerialize._serialize(ref mTicks, @"CreateTime");
        }

        public string _streamName()
        {
            return ("Account_" + mAccountMgrId);
        }

        public void _setMgrId(uint nId)
        {
            mAccountMgrId = nId;
        }

        public uint _getAccountId()
        {
            return mAccountId;
        }

        public void _setAccountName(string nAccountName)
        {
            mAccountId = _accountId(nAccountName);
            mAccountName = nAccountName;
        }

        public string _getAccountName()
        {
            return mAccountName;
        }

        public void _setNickName(string nNickName)
        {
            mNickName = nNickName;
        }

        public string _getNickName()
        {
            return mNickName;
        }

        public void _setPassward(string nPassward)
        {
            mPassward = nPassward;
        }

        public string _getPassward()
        {
            return mPassward;
        }

        public void _setTicks(long nTicks)
        {
            mTicks = nTicks;
        }

        public long _getTicks()
        {
            return mTicks;
        }

        public AccountB()
        {
            mAccountId = 0;
            mAccountName = null;
            mNickName = null;
            mPassward = null;
            mAccountMgrId = 0;
            mTicks = 0;
        }

        uint mAccountMgrId;
        uint mAccountId;
        string mAccountName;
        string mNickName;
        string mPassward;
        long mTicks;
    }
}
