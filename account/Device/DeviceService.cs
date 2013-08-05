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
            mDeviceTypes.Add(HashString._runComputer());
            mDeviceTypes.Add(HashString._runCellphone());
        }

        public DeviceService()
        {
            mDeviceTypes = new SortedSet<uint>();
        }

        SortedSet<uint> mDeviceTypes;
    }
}
