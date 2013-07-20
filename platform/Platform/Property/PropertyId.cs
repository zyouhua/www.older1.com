namespace platform
{
    public class PropertyId<__t> : Property
    {
        public static void _runInit()
        {
            mPropertyId = HashString._runHash(typeof(__t).FullName, 0x100);
        }

        public static uint _getPropertyId()
        {
            return mPropertyId;
        }

        static uint mPropertyId;
    }
}
