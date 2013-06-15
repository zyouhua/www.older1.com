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
            string namespace_ = this._getNamespace();
            string pluginClass_ = namespace_ + ".Plugin";
            IStartup start_ = base._findClass<IStartup>(pluginClass_);
            if (null != start_)
            {
                start_._runStart();
            }
        }
    }
}
