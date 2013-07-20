using System.Collections.Generic;

using platform;

namespace money
{
    public class MoneyMgr : PropertyId<MoneyMgr>
    {
        public MoneyMgr()
        {
            mMoneys = new Dictionary<uint, Money>();
            MoneyConfig moneyConfig_ = __singleton<MoneyConfig>._instance();
            Dictionary<uint, Money> moneys_ = moneyConfig_._getMoneys();
            foreach (KeyValuePair<uint, Money> i in moneys_)
            {
                mMoneys[i.Key] = i.Value;
            }
        }

        Dictionary<uint, Money> mMoneys;
    }
}
