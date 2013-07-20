using System.Collections.Generic;

namespace task
{
    public class ConditionSingleton
    {
        public IConditon _getCondition(string nType)
        {
            IConditon result_ = null;
            if (mConditions.ContainsKey(nType))
            {
                result_ = mConditions[nType];
            }
            return result_;
        }

        public void _registerConditon(IConditon nConditon)
        {
            mConditions[nConditon._getName()] = nConditon;
        }

        public void _loadDefaultCondition()
        {
            this._registerConditon(new AndCondition());
            this._registerConditon(new NoCondition());
            this._registerConditon(new OrCondition());
        }

        public ConditionSingleton()
        {
            mConditions = new Dictionary<string, IConditon>();
        }

        Dictionary<string, IConditon> mConditions;
    }
}
