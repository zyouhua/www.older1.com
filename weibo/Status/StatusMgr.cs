using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace weibo
{
    public class StatusMgr : PropertyId<StatusMgr>
    {
        public StatusMgr()
        {

        }

        SortedSet<ulong> mIds;
    }
}
