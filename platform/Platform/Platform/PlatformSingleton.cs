namespace platform
{
    public class PlatformSingleton
    {
        public __t _findHeadstream<__t>(string nUrl) where __t : IHeadstream
        {
        }

        public void _newHeadstream<__t>(__t nT, string nUrl) where __t : IHeadstream
        {
        }

        public __t _loadHeadstream<__t>(string nHeadstream, string nUrl) where __t : IHeadstream
        {
        }

        public void _loadHeadstream<__t>(__t nT, string nUrl) where __t : IHeadstream
        {
        }

        public void _saveHeadstream<__t>(__t nT, string nUrl) where __t : IHeadstream
        {
        }

        public void _delHeadstream(string nUrl)
        {
        }

        public void _newUdl<__t>(__t nT, string nUrl) where __t : IUdl
        {
        }

        public void _loadUdl<__t>(__t nT, string nUrl) where __t : IUdl
        {
        }

        public void _saveUdl<__t>(__t nT, string nUrl) where __t : IUdl
        {
        }

        public void _deleteUdl<__t>(__t nT, string nUrl) where __t : IUdl
        {
        }

        public __t _findStdUdl<__t>(string nUrl) where __t : IStdUdl
        {
        }

        public void _newStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl
        {
        }

        public __t _loadStdUdl<__t>(string nStdUdl, string nUrl) where __t : IStdUdl
        {
        }

        public void _loadStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl
        {
        }

        public void _saveStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl
        {
        }

        public void _deleteStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl
        {
        }

        public __t _findContent<__t>(string nUrl)
        {
        }

        public string _findContentImage(string nName)
        {
        }

        public void _loadBindingManager(string nUrl)
        {
        }

        public string[] _rootUrls()
        {
        }

        public string[] _files(string nUrl)
        {
        }

        public string[] _arcs(string nUrl)
        {
        }

        public string[] _dirUrls(string nUrl)
        {
        }

        public string[] _fileUrls(string nUrl)
        {
        }

        public string _findUrl(string nUrl)
        {
        }

        public __t _findInterface<__t>(string nUrl)
        {
        }

        public object _findIcon(string nUrl)
        {
        }

        public object _findPng(string nUrl)
        {
        }

        public ICulture _currentCulture()
        {
        }

        public void _sleep(int nSecond)
        {
        }

        public IThread _createThread()
        {
        }

        public IProcess _createProcess(string nCommand, string nArguments)
        {
        }

        public ISerialize _getReader(SerializeType_ nSerializeType)
        {
        }

        public ISerialize _getWriter(SerializeType_ nSerializeType)
        {
        }

        public PlatformSingleton()
        {
        }
    }
}
