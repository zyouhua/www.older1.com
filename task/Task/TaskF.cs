using System.Collections.Generic;
using platform;

namespace task
{
    public class TaskF : Stream, IKeyU32
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mActionIds, @"actionIds");
            nSerialize._serialize(ref mTaskId, @"id");
        }

        public uint _keyU32()
        {
            return mTaskId;
        }

        public void _runActionId(Task nTask, ActionId nActionId)
        {
            foreach (KeyValuePair<uint, ActionId> i in mActionIds)
            {
                uint count_ = i.Value._runActionId(nActionId);
                if (count_ > 0)
                {
                    nTask._runCount(i.Key, count_);
                }
            }
        }

        public uint _getTaskId()
        {
            return mTaskId;
        }

        public TaskF()
        {
            mActionIds = new Dictionary<uint, ActionId>();
            mTaskId = 0;
        }

        Dictionary<uint, ActionId> mActionIds;
        uint mTaskId;
    }
}
