<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="gogogo.Pages.Listing"
      MasterPageFile="~/Pages/Store.Master"  %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Register TagPrefix="GS" TagName="CategoryLinks" Src="~/Controls/CategoryList.ascx" %>
<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
     <div id="categories" class="topPanelbutton">
                <GS:CategoryLinks runat="server" />
            </div>
    <div id="content">
        <%
            Response.Write(String.Format(@"<table class='table' border='1'>"));
            int j=0;
            foreach (gogogo.Models.Post post in GetPosts())
            {
                if (j == 0)
                {
                    Response.Write(String.Format(@"<tr>
                 <th><div class='newPanel'>
                 <div class='zagalovok' >{0}</div>
                 <div class='pictche' style='{6}'></div>
                 <div class='avtorpictche' ></div>
                 <div class='avtorLabel'>{1}</div>
                 <div class='karmaavtorLabel'>{2}</div>
                 <div class='prosmotrLabel'>{3}</div>
                 <div class='reitLabel'>{4}</div>
                 <div class='textnews' >{5}</div>
                  </div></th>", post.Zaglav, "автор", "карма: 999","Просмотров: "+ post.Prosmotrov,"карма:"+ post.Karma, post.Kratk, "background-color: transparent; background-image: url(" + post.URL + ");"));
                }
                else
                {
                    if (j == 1)
                    {
                        Response.Write(String.Format(@"
                <th><div class='newPanel'>
                <div class='zagalovok' >{0}</div>
                  <div class='pictche' style='{6}'></div>
                <div class='avtorpictche' ></div>
                <div class='avtorLabel'>{1}</div>
                <div class='karmaavtorLabel'>{2}</div>
                <div class='prosmotrLabel'>{3}</div>
                <div class='reitLabel'>{4}</div>
                <div class='textnews' >{5}</div>
                </div></th> ", post.Zaglav, "автор", "карма:999", "Просмотров: "+ post.Prosmotrov, "карма:"+post.Karma, post.Kratk, "background-color: transparent; background-image: url(" + post.URL + ");"));
                    }
                    else
                    {
                        if (j == 2)
                        {
                            Response.Write(String.Format(@"
                <th><div class='newPanel'>
                <div class='zagalovok' >{0}</div>
                <div class='pictche' style='{6}'></div>
                <div class='avtorpictche' ></div>
                <div class='avtorLabel'>{1}</div>
                <div class='karmaavtorLabel'>{2}</div>
                <div class='prosmotrLabel'>{3}</div>
                <div class='reitLabel'>{4}</div>
                <div class='textnews' >{5}</div>
                </div></th></tr>", post.Zaglav, "автор", "карма:999", "Просмотров: "+ post.Prosmotrov, "карма:"+post.Karma, post.Kratk, "background-color: transparent; background-image: url(" + post.URL + ");"));
                        }
                    }
                }
                j++;
                if (j == 3)
                {
                    j = 0;
                }
            }
            Response.Write(String.Format(@" </table>"));
        %>
    </div>
   <div class="pager">
       <%
            for (int i = 1; i <= MaxPage; i++)
            {
                string path = RouteTable.Routes.GetVirtualPath(null, null,
                    new RouteValueDictionary() { { "page", i } }).VirtualPath;
                Response.Write(
                    String.Format("<a href='{0}' {1}>{2}</a>",
                        path, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
</div>
</asp:Content>