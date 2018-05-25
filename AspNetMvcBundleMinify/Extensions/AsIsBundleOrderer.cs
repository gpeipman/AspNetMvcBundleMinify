using System.Collections.Generic;
using System.Web.Optimization;

namespace AspNetMvcBundleMinify
{
    public sealed class AsIsBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}