using System;

using platform;

namespace account
{
    public class AccountB : ISqlStream
    {
        public static uint _accountId(string nAccountName)
        {
            return HashString._runNameId(nAccountName);
        }

        public ErrorCode_ _checkPassward(string nPassward)
        {
            ErrorCode_ result_ = ErrorCode_.mSucess_;
            uint loginPassward_ = HashString._runPasswardId(nPassward);
            uint hashPassward_ = HashString._runPasswardId(mPassward);
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
            nSqlSerialize._serialize(ref mAccountId, @"id");
            nSqlSerialize._serialize(ref mAccountName, @"accountName");
            nSqlSerialize._serialize(ref mNickName, @"nickName");
            nSqlSerialize._serialize(ref mPassward, @"passward");
            nSqlSerialize._serialize(ref mTicks, @"createTime");
            nSqlSerialize._serialize(ref mClusterID, @"clusterID");
            nSqlSerialize._serialize(ref mServerID, @"serverID");
            nSqlSerialize._serialize(ref mDatabaseId, @"databaseId");
            nSqlSerialize._serialize(ref mTableId, @"tableId");
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

        public uint _getClusterID()
        {
            return mClusterID;
        }

        public uint _getServerID()
        {
            return mServerID;
        }

        public uint _getDatabaseId()
        {
            return mDatabaseId;
        }

        public uint _getTableId()
        {
            return mTableId;
        }

        public void _setAccountName(string nAccountName)
        {
            mAccountId = _accountId(nAccountName);
            mClusterID = HashString._runClusterID(nAccountName);
            mServerID = HashString._runServerID(nAccountName);
            mDatabaseId = HashString._runDatabaseId(nAccountName);
            mTableId = HashString._runTableId(nAccountName);
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
            mClusterID = 0;
            mServerID = 0;
            mDatabaseId = 0;
            mTableId = 0;
            mTicks = 0;
        }

        uint mAccountMgrId;
        uint mAccountId;
        string mAccountName;
        string mNickName;
        string mPassward;
        uint mClusterID;
        uint mServerID;
        uint mDatabaseId;
        uint mTableId;
        long mTicks;
    }
}
