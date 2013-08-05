namespace platform
{
    public class PropertyId<__t> : Property
    {
        public static void _runInit()
        {
            mPropertyId = HashString._runCommon(typeof(__t).FullName);
        }

        public static uint _getPropertyId()
        {
            return mPropertyId;
        }

        static uint mPropertyId;
    }
}
