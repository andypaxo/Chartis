<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Chartis.ViewModels.Sprint.SprintSummary>" %>

<%= Html.ActionLink(Model.Title, "Details", new { id = Model.Id } ) %>

