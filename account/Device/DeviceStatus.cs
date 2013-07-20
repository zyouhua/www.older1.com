namespace account
{
    public class DeviceStatus
    {
        public void _setType(uint nType)
        {
            mType = nType;
        }

        public uint _getType()
        {
            return mType;
        }

        public void _setId(uint nId)
        {
            mId = nId;
        }

        public uint _getId()
        {
            return mId;
        }

        public DeviceStatus()
        {
            mId = 0;
            mType = 0;
        }
        uint mId;
        uint mType;
    }
}
