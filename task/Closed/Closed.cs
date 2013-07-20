using System;

using platform;

namespace task
{
    public class Closed : Stream, IKeyU32
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, @"id");
            nSerialize._serialize(ref mType, @"type");
            nSerialize._serialize(ref mBeg, @"begin");
            nSerialize._serialize(ref mCount, @"count");
        }

        public uint _keyU32()
        {
            return mId;
        }

        public void _runClose()
        {
            if (null != m_tRunClose)
            {
                this.m_tRunClose();
            }
            mOpen = false;
        }

        public void _runOpen()
        {
            if (null != m_tRunOpen)
            {
                this.m_tRunOpen();
            }
            mOpen = true;
        }

        public bool _isOpen()
        {
            return mOpen;
        }

        public Closed()
        {
            m_tRunClose = null;
            m_tRunOpen = null;
            mId = 0xFFFFFFFF;
            mType = 0xFFFFFFFFFFFFFFFF;
            mBeg = DateTime.Now;
            mCount = 0xFFFFFFFF;
            mOpen = false;
        }

        public _RunSlot m_tRunClose;
        public _RunSlot m_tRunOpen;

        uint mId;
        ulong mType;
        DateTime mBeg;
        uint mCount;
        bool mOpen;
    }
}
