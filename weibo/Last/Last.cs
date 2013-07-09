using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weibo
{
    public class Last
    {
        public List<Status> _getStatus()
        {
            return mStatus;
        }

        public Last()
        {
            mStatus = new List<Status>();
        }

        List<Status> mStatus;
    }
}
