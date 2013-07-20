using platform;

namespace task
{
    public class Startup : IStartup
    {
        public void _runStart()
        {
            ConditionSingleton conditionSingleton_ = __singleton<ConditionSingleton>._instance();
            conditionSingleton_._loadDefaultCondition();

            ActionMgr._runInit();

            TaskMgr._runInit();
        }
    }
}
