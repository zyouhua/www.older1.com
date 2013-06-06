namespace platform
{
    public class PluginUfl : AssemblyUfl
    {
        public override void _runLoad(string nUrl)
        {
            base._runLoad(nUrl);
            if (null == mAssembly)
            {
                mAssembly = Assembly.LoadFrom(assemblyPath_);
                string namespace_ = assemblyName_.Name;
                string pluginClass_ = namespace_ + ".Plugin";
                IStartup plugin_ = mAssembly.CreateInstance(pluginClass_) as IStartup;
                if (null != plugin_)
                {
                    plugin_._runStart();
                }
            }
        }
    }
}
