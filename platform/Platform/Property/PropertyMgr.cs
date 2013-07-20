using System;
using System.Collections.Generic;

namespace platform
{
    public class PropertyMgr
    {
        public __t _getProperty<__t>() where __t : PropertyId<__t>
        {
            __t result_ = default(__t);
            uint propertyId_ = PropertyId<__t>._getPropertyId();
            if (mPropertys.ContainsKey(propertyId_))
            {
                result_ = mPropertys[propertyId_] as __t;
            }
            return result_;
        }

        public void _addProperty<__t>(PropertyId<__t> nPropertyId)
        {
            uint propertyId_ = PropertyId<__t>._getPropertyId();
            if (mPropertys.ContainsKey(propertyId_))
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(@"PropertyMgr _AddProperty ContainsKey");
                throw new Exception();
            }
            mPropertys[propertyId_] = nPropertyId;
        }

        public PropertyMgr()
        {
            mPropertys = new Dictionary<uint, Property>();
        }

        Dictionary<uint, Property> mPropertys;
    }
}
