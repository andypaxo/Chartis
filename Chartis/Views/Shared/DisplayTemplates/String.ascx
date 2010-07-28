<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<System.String>" %>

<dfn><%: ViewData.ModelMetadata.DisplayName ?? ViewData.ModelMetadata.PropertyName %></dfn> <%: Model %>