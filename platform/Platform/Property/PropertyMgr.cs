using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace platform
{
    public abstract class PropertyMgr
    {
        public __t _getProperty<__t>() where __t : PropertyId<__t>
        {
            __t result_ = default(__t);
            int propertyId_ = PropertyId<__t>._getPropertyId();
            if (mPropertys.ContainsKey(propertyId_))
            {
                result_ = mPropertys[propertyId_] as __t;
            }
            return result_;
        }

        public void _addProperty<__t>(PropertyId<__t> nPropertyId)
        {
            int propertyId_ = PropertyId<__t>._getPropertyId();
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
            mPropertys = new Dictionary<int, Property>();
        }

        Dictionary<int, Property> mPropertys;
    }
}
