namespace startup
{
    public interface IUrl : ICreate, ILoad, ISave, IDelete
    {
        string _getUrl();
    }
}
