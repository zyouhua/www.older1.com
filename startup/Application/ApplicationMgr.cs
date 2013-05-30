using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace startup
{
    public class ApplicationMgr
    {
        public ApplicationMgr()
        {
            mApplications = new List<Application>();
        }
        List<Application> mApplications;
    }
}
