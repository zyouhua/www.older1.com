using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace account
{
    public class AccountC
    {
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
            mAccountId = 0;
            mTicks = 0;
        }

        uint mAccountId;
        long mTicks;
    }
}
