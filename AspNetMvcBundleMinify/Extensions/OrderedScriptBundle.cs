using System.Web.Optimization;

namespace AspNetMvcBundleMinify
{
    public class OrderedScriptBundle : ScriptBundle
    {
        public OrderedScriptBundle(string virtualPath) : this(virtualPath, null)
        {
        }

        public OrderedScriptBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath)
        {
            Orderer = new AsIsBundleOrderer();
        }
    }


}