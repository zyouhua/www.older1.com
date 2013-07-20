using System.Collections.Generic;

using platform;

namespace task
{
    public class TaskMgr : PropertyId<ActionMgr>
    {
        public void _acceptTask(uint nTaskId)
        {

        }

        public void cancelTask(uint nTaskId)
        {

        }

        public void finishTask(uint nTaskId)
        {

        }

        public void _runActionId(ActionId nActionId)
        {
            foreach (KeyValuePair<uint, Task> i in mTasks)
            {
                i.Value._runActionId(nActionId);
            }
        }

        public TaskMgr()
        {
            mTasks = new Dictionary<uint, Task>();
        }

        Dictionary<uint, Task> mTasks;
    }
}
