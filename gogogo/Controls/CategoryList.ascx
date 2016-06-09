<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs"
     Inherits="gogogo.Controls.CategoryList" %>


<% foreach (string category in GetCategories()) {
       Response.Write(CreateLinkHtml(category));       
}%>
