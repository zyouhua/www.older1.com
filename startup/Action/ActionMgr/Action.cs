using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace startup
{
    public class Action
    {
        public Action()
        {
            mApplicationId = 0;
            mActionType = 0;
            mActionId = 0;
            mActionValue = 0;
        }

        uint mApplicationId;
        ushort mActionType;
        ushort mActionId;
        ushort mActionValue;
    }
}
