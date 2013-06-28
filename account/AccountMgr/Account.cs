namespace account
{
    public class Account
    {
        public AccountC _getAccountC()
        {
            AccountC accountC_ = new AccountC();
            accountC_.m_tAccountId = mAccountId;
            accountC_.m_tTicks = mTicks;
            return accountC_;
        }

        public void _setTicks(long nTicks)
        {
            mTicks = nTicks;
        }

        public long _getTicks()
        {
            return mTicks;
        }

        public void _setAccountId(uint nAccountId)
        {
            mAccountId = nAccountId;
        }

        public uint _getAccountId()
        {
            return mAccountId;
        }

        public Account()
        {
            mAccountId = 0;
            mTicks = 0;
        }

        uint mAccountId;
        long mTicks;
    }
}
