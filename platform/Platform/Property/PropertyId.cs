using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace platform
{
    public class PropertyId<__t> : Property
    {
        public static void _setPropertyId(int nPropertyId)
        {
            mPropertyId = nPropertyId;
        }

        public static int _getPropertyId()
        {
            return mPropertyId;
        }

        static int mPropertyId;
    }
}
