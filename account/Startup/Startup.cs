using System.Reflection;

using platform;

namespace account
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            AccountService accountService_ = __singleton<AccountService>._instance();
            accountService_._runInit();
        }
    }
}
