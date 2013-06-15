using System;
using System.Reflection;

namespace platform
{
    public class AssemblyUfl : Ufl
    {
        public override void _runLoad(string nUrl)
        {
            UrlParser urlParser_ = new UrlParser(nUrl);
            string assemblyPath_ = urlParser_._returnResult();
            AssemblyName assemblyName_ = AssemblyName.GetAssemblyName(assemblyPath_);
            AppDomain appDomain_ = AppDomain.CurrentDomain;
            Assembly[] assemblies_ = appDomain_.GetAssemblies();
            foreach (Assembly i in assemblies_)
            {
                if (string.Compare(i.FullName, assemblyName_.FullName) == 0)
                {
                    mAssembly = i;
                }
            }
            if (null == mAssembly)
            {
                mAssembly = Assembly.LoadFrom(assemblyPath_);
            }
            base._runLoad(nUrl);
        }

        public object _findClass(string nId)
        {
            return mAssembly.CreateInstance(nId);
        }

        public __t _findClass<__t>(string nId) where __t : class
        {
            object result_ = mAssembly.CreateInstance(nId);
            return (result_ as __t);
        }

        protected string _getNamespace()
        {
            AssemblyName assemblyName_ = mAssembly.GetName();
            return assemblyName_.Name;
        }

        public AssemblyUfl()
        {
            mAssembly = null;
        }

        Assembly mAssembly;
    }
}
