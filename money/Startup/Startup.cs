using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace money
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            PropertyService propertyService_ = __singleton<PropertyService>._instance();
            propertyService_._register<MoneyMgr>();

            string moneyConfigUrl_ = @"rid://money.moneyConfig";
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            MoneyConfig moneyConfig_ = __singleton<MoneyConfig>._instance();
            platformSingleton_._loadHeadstream<MoneyConfig>(moneyConfig_, moneyConfigUrl_);
        }
    }
}
