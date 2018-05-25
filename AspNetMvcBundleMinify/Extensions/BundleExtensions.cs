using System.Web.Optimization;

namespace AspNetMvcBundleMinify
{
    public static class BundleExtensions
    {
        public static Bundle IncludeWithRewrite(this Bundle bundle, string virtualPath)
        {
            bundle.Include(virtualPath, new CssRewriteUrlTransform());

            return bundle;
        }
    }
}