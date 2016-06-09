using System;
using System.Collections.Generic;
using gogogo.Models;
using gogogo.Models.Repository;
using System.Linq;

namespace gogogo.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int pageSize =6;

        protected int CurrentPage
        {
            get
            {
                int page;
                page = GetPageFromRequest();
                return page > MaxPage ? MaxPage : page;
            }
        }


        // Новое свойство, возвращающее наибольший номер допустимой страницы
        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)repository.Posts.Count() / pageSize);
            }
        }
        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ??
                Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }
        protected IEnumerable<Post> GetPosts()
        {
            return FilterPosts()
                .OrderBy(g => g.PostId)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }
        // Новый вспомогательный метод для фильтрации игр по категориям
        private IEnumerable<Post> FilterPosts()
        {
            IEnumerable<Post> posts = repository.Posts;
            string currentCategory = (string)RouteData.Values["category"] ??
                Request.QueryString["category"];
            return currentCategory == null ? posts :
                posts.Where(p => p.Category == currentCategory);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}