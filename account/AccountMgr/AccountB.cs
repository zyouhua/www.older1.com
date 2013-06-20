using platform;

namespace account
{
    public class AccountB : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mAccountName, @"name");
            nSerialize._serialize(ref mPassward, @"passward");
        }

        public override string _streamName()
        {
            return "account";
        }

        public void _setAccountName(string nAccountName)
        {
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
            mAccountName = null;
            mPassward = null;
        }

        string mAccountName;
        string mPassward;
    }
}
