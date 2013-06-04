namespace startup
{
    public interface IStream : IDirty
    {
        void _serialize(ISerialize nSerialize);
    }
}
