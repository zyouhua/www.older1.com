namespace platform
{
    public class AppUrl : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mAppUrl, @"url");
        }

        public override string _streamName()
        {
            return @"appUrl";
        }

        public string _getAppUrl()
        {
            return mAppUrl;
        }

        public AppUrl()
        {
            mAppUrl = null;
        }

        string mAppUrl;
    }
}
