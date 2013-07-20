using System.Reflection;

using platform;

namespace weibo
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            string mysqlUrl_ = @"url://www.wanmei.com/weibo\weibo/config*MySqlConfig.xml";
            MySqlSingleton mySqlSingleton_ = __singleton<MySqlSingleton>._instance();
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._loadHeadstream<MySqlSingleton>(mySqlSingleton_, mysqlUrl_);

            StatusMgr._runInit();
        }
    }
}
