
namespace platform
{
    public interface ISqlStream
    {
        void _serialize(ISqlSerialize nSqlSerialize);

        string _streamName();
    }
}
