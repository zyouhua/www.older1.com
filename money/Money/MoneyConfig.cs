using System.Collections.Generic;

using platform;

namespace money
{
    public class MoneyConfig : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mMoneys, @"moneys");
        }

        public override string _streamName()
        {
            return @"moneyConfig";
        }

        public Dictionary<uint, Money> _getMoneys()
        {
            return mMoneys;
        }

        public MoneyConfig()
        {
            mMoneys = new Dictionary<uint, Money>();
        }

        Dictionary<uint, Money> mMoneys;
    }
}
