using platform;

namespace money
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            string moneyConfigUrl_ = @"rid://money.moneyConfig";
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            MoneyConfig moneyConfig_ = __singleton<MoneyConfig>._instance();
            platformSingleton_._loadHeadstream<MoneyConfig>(moneyConfig_, moneyConfigUrl_);

            MoneyMgr._runInit();
        }
    }
}
