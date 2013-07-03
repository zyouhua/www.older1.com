using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace account
{
    public class AccountC
    {
        public ErrorCode_ m_tErrorCode
        {
            get
            {
                return mErrorCode;
            }
            set
            {
                mErrorCode = value;
            }
        }

        public uint m_tAccountId
        {
            get
            {
                return mAccountId;
            }
            set
            {
                mAccountId = value;
            }
        }

        public long m_tTicks
        {
            get
            {
                return mTicks;
            }
            set
            {
                mTicks = value;
            }
        }

        public AccountC()
        {
            mErrorCode = ErrorCode_.mSucess_;
            mAccountId = 0;
            mTicks = 0;
        }

        ErrorCode_ mErrorCode;
        uint mAccountId;
        long mTicks;
    }
}
