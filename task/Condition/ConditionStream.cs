using platform;

namespace task
{
    public class ConditionStream : Stream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mActionId, @"actionId");
            nSerialize._serialize(ref mType, @"type");
        }

        public ActionId _getAction()
        {
            return mActionId;
        }

        public string _getType()
        {
            return mType;
        }

        public ConditionStream()
        {
            mActionId = null;
            mType = null;
        }

        ActionId mActionId;
        string mType;
    }
}
