using System;
using System.Collections.Generic;

using platform;

namespace task
{
    public class ActionMgr : PropertyId<ActionMgr>
    {
        public void _runActionIds(List<ActionId> nActionIds)
        {
            foreach (ActionId i in nActionIds)
            {
                this._runActionId(i);
            }
        }

        public void _runActionId(ActionId nActionId)
        {
            uint id_ = nActionId._getId();
            if (mActions.ContainsKey(id_))
            {
                mActions[id_]._runActionId(nActionId);
            }
            else
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(@"ActionMgr _runActionId ContainsKey");
                throw new Exception();
            }
        }

        public bool _isActionIds(List<ConditionStream> nConditionStreams)
        {
            ConditionSingleton conditionSingleton_ = __singleton<ConditionSingleton>._instance();
            bool result_ = false;
            foreach (ConditionStream i in nConditionStreams)
            {
                IConditon condition_ = conditionSingleton_._getCondition(i._getType());
                if (null != condition_)
                {
                    ActionId actionId_ = i._getAction();
                    bool temp_ = this._isActionId(actionId_);
                    result_ = condition_._validate(result_, temp_);
                }
            }
            return result_;
        }

        bool _isActionId(ActionId nActionId)
        {
            bool result_ = false;
            uint id_ = nActionId._getId();
            if (mActions.ContainsKey(id_))
            {
                result_ = mActions[id_]._isActionId(nActionId);
            }
            else
            {
                LogSingleton logSingleton_ = __singleton<LogSingleton>._instance();
                logSingleton_._logError(@"ActionMgr _isActionId ContainsKey");
                throw new Exception();
            }
            return result_;
        }

        public ActionMgr()
        {
            mActions = new Dictionary<uint, IAction>();
        }

        Dictionary<uint, IAction> mActions;
    }
}
