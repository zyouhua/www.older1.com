using platform;

namespace task
{
    public class ActionId : Stream, IKeyU32
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mCount, @"count");
            nSerialize._serialize(ref mType, @"type");
            nSerialize._serialize(ref mId, @"id");
        }

        public uint _keyU32()
        {
            return mId;
        }

        public uint _runActionId(ActionId nActionId)
        {
            uint result_ = 0;
            if ( (mId == nActionId.mId) && (mType == nActionId.mType) )
            {
                result_ = nActionId.mCount;
            }
            return result_;
        }

        public void _setCount(uint nCount)
        {
            mCount = nCount;
        }

        public uint _getCount()
        {
            return mCount;
        }

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

        public ActionId()
        {
            mCount = 0;
            mType = 0;
            mId = 0;
        }

        uint mCount;
        uint mType;
        uint mId;
    }
}
