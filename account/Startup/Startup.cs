using System.Reflection;

using platform;

namespace account
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            DeviceService deviceService_ = __singleton<DeviceService>._instance();
            deviceService_._runInit();

            AccountService accountService_ = __singleton<AccountService>._instance();
            accountService_._runInit();
        }
    }
}
