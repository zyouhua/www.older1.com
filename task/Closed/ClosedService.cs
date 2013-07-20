using System.Collections.Generic;

using platform;

namespace task
{
    public class ClosedService : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mCloseds, "closeds");
        }

        public override string _streamName()
        {
            return @"closed";
        }

        public ClosedService()
        {
            mCloseds = new Dictionary<uint, Closed>();
        }

        Dictionary<uint, Closed> mCloseds;
    }
}
