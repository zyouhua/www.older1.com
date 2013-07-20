using System.Collections.Generic;

using platform;

namespace account
{
    public class DeviceService
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

        public DeviceService()
        {
            mDeviceTypes = new SortedSet<uint>();
        }

        SortedSet<uint> mDeviceTypes;
    }
}
