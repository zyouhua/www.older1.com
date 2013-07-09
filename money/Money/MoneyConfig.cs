using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public List<Money> _getMoneys()
        {
            return mMoneys;
        }

        public MoneyConfig()
        {
            mMoneys = new List<Money>();
        }

        List<Money> mMoneys;
    }
}
