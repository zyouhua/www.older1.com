using System.Reflection;

using platform;

namespace account
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            DeviceMgr deviceMgr_ = __singleton<DeviceMgr>._instance();
            deviceMgr_._runInit();

            AccountService accountService_ = __singleton<AccountService>._instance();
            accountService_._runInit();
        }
    }
}
