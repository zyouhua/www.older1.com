using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace startup
{
    public class Activity
    {
        public Activity()
        {
            mId = 0;
            mTaskId = 0;
            mTask = null;
        }
        uint mId;
        uint mTaskId;
        Task mTask;
    }
}
