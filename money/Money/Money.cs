using platform;

namespace money
{
    public class Money : Stream, IKeyU32
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mId, @"Id");
            nSerialize._serialize(ref mValue, @"value");
            nSerialize._serialize(ref mTotal, @"total");
            nSerialize._serialize(ref mDayInc, @"dayInc");
            nSerialize._serialize(ref mDayDec, @"dayDec");
            nSerialize._serialize(ref mMaxInc, @"maxInc");
            nSerialize._serialize(ref mMaxDec, @"maxDec");
        }

        public uint _keyU32()
        {
            return mId;
        }

        public void _setId(uint nId)
        {
            mId = nId;
        }

        public uint _getId()
        {
            return mId;
        }

        public void _setValue(uint nValue)
        {
            mValue = nValue;
        }

        public uint _getValue()
        {
            return mValue;
        }

        public void _setTotal(uint nTotal)
        {
            mTotal = nTotal;
        }

        public uint _getTotal()
        {
            return mTotal;
        }

        public void _setDayInc(uint nDayInc)
        {
            mDayInc = nDayInc;
        }

        public uint _getDayInc()
        {
            return mDayInc;
        }

        public void _setDayDec(uint nDayDec)
        {
            mDayDec = nDayDec;
        }

        public uint _getDayDec()
        {
            return mDayDec;
        }

        public void _setMaxInc(uint nMaxInc)
        {
            mMaxInc = nMaxInc;
        }

        public uint _getMaxInc()
        {
            return mMaxInc;
        }

        public void _setMaxDec(uint nMaxDec)
        {
            mMaxDec = nMaxDec;
        }

        public uint _getMaxDec()
        {
            return mMaxDec;
        }

        public Money _clone()
        {
            Money money_ = new Money();
            money_.mId = mId;
            money_.mValue = mValue;
            money_.mTotal = mTotal;
            money_.mDayInc = mDayInc;
            money_.mDayDec = mDayDec;
            money_.mMaxInc = mMaxInc;
            money_.mMaxDec = mMaxDec;
            return money_;
        }

        public Money()
        {
            mId = 0;
            mValue = 0;
            mTotal = 0;
            mDayInc = 0;
            mDayDec = 0;
            mMaxInc = 0;
            mMaxDec = 0;
        }

        uint mId;
        uint mValue;
        uint mTotal;
        uint mDayInc;
        uint mDayDec;
        uint mMaxInc;
        uint mMaxDec;
    }
}
