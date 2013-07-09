namespace platform
{
    public class PropertyService
    {
        public void _register<__t>()
        {
            PropertyId<__t>._setPropertyId(mId);
            ++mId;
        }

        public PropertyService()
        {
            mId = 0;
        }

        int mId;
    }
}
