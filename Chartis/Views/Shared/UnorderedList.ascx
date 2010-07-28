<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable>" %>

<ul>
<% foreach (var item in Model) { %>
    <li><%= Html.DisplayFor(x => item) %></li>
<% } %>
</ul>