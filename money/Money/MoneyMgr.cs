using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace money
{
    public class MoneyMgr : PropertyId<MoneyMgr>
    {
        public MoneyMgr()
        {
            mMoneys = new List<Money>();
            MoneyConfig moneyConfig_ = __singleton<MoneyConfig>._instance();
            moneyConfig_._getMoneys().ForEach(i => mMoneys.Add(i._clone()));
        }

        List<Money> mMoneys;
    }
}
