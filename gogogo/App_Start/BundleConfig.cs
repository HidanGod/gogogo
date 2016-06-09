//using System.Web.Optimization;
using System;
using System.Web.Routing;
namespace GameStore
{
    public class BundleConfig
    {
        public static void RegisterBundles(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            routes.MapPageRoute("MyPage", "MyPage", "~/Pages/MyPage.aspx");
            routes.MapPageRoute("Posts", "Posts", "~/Pages/Posts.aspx");
        }
    }
}