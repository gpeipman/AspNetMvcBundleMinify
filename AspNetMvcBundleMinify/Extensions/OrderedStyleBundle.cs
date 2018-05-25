using System.Web.Optimization;

namespace AspNetMvcBundleMinify
{
    public class OrderedStyleBundle : StyleBundle
    {
        public OrderedStyleBundle(string virtualPath) : this(virtualPath, null)
        {
        }

        public OrderedStyleBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath)
        {
            Orderer = new AsIsBundleOrderer();
        }
    }
}