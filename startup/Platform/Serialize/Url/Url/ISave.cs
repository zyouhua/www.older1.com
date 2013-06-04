namespace startup
{
    public interface ISave : IDirty
    {
        void _runSave(string nUrl);

        event _RunSlot m_tRunSave;

        void _runSave();
    }
}
