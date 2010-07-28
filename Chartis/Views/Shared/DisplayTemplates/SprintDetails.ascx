<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Chartis.ViewModels.Sprint.SprintDetails>" %>

<%: Html.DisplayFor(Model => Model.StartDate) %>

<% Html.RenderPartial("UnorderedList", this.Model.Stories); %>