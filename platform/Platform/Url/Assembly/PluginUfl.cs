namespace platform
{
    public class PluginUfl : AssemblyUfl
    {
        public override void _runLoad(string nUrl)
        {
            base._runLoad(nUrl);
            this._runPlugin();
        }

        private void _runPlugin()
        {
            IStartup start_ = base._findClass<IStartup>(@"Plugin");
            if (null != start_)
            {
                start_._runStart();
            }
        }
    }
}
