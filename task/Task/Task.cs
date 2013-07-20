using System.Collections.Generic;

namespace task
{
    public class Task
    {
        public void _runActionId(ActionId nActionId)
        {
            mTaskF._runActionId(this, nActionId);
        }

        public void _runCount(uint nIdex, uint nCount)
        {
            uint count_ = 0;
            if (mCounts.ContainsKey(nIdex))
            {
                count_ = mCounts[nIdex];
            }
            count_ += nCount;
            mCounts[nIdex] = count_;
        }

        public uint _getTaskId()
        {
            return mTaskId;
        }

        public Task(TaskF nTaskF)
        {
            mCounts = new Dictionary<uint, uint>();
            mTaskId = nTaskF._getTaskId();
            mTaskF = nTaskF;
        }

        Dictionary<uint, uint> mCounts;
        TaskF mTaskF;
        uint mTaskId;
    }
}
