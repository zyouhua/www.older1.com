namespace platform
{
    public interface IProcess
    {
        void _waitForExit(int nMilliseconds);

        void _startRun();
    }
}
