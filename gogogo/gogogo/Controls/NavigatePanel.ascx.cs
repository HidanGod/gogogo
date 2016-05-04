using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using gogogo.Models.Repository;

namespace gogogo.Controls
{
    public partial class NavigatePanel : System.Web.UI.UserControl
    {
        protected string CreateHomeLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, null).VirtualPath;
            return string.Format("<a href='{0}'>Главная</a>", path);
        }
        protected string CreateMyPageLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, null).VirtualPath;
            return string.Format("<a href='{0}'>Моя страница</a>", path);
        }
        protected string CreateMyPostsLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, null).VirtualPath;
            return string.Format("<a href='{0}'>Мои посты</a>", path);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}