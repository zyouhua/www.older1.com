using System.Collections.Generic;

using platform;

namespace task
{
    public class TaskFMgr : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mTaskFs, @"tasks");
        }

        public override string _streamName()
        {
            return "taskMgr";
        }

        public TaskFMgr()
        {
            mTaskFs = new Dictionary<uint, TaskF>();
        }

        Dictionary<uint, TaskF> mTaskFs;
    }
}
