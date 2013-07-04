using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using platform;

namespace account
{
    public class DeviceMgr
    {
        public bool _contain(uint nDeviceType)
        {
            return mDeviceTypes.Contains(nDeviceType);
        }

        public void _runInit()
        {
            uint computerType_ = HashString._runHash(@"computer", 0x100);
            //86943643
            mDeviceTypes.Add(computerType_);
            uint cellphoneType_ = HashString._runHash(@"cellphone", 0x150);
            //2197838273
            mDeviceTypes.Add(cellphoneType_);
        }

        public DeviceMgr()
        {
            mDeviceTypes = new SortedSet<uint>();
        }

        SortedSet<uint> mDeviceTypes;
    }
}
