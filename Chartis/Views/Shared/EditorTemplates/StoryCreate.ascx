<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Chartis.ViewModels.Story.StoryCreate>" %>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <%: Html.HiddenFor(model => model.SprintId) %>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Name) %>
                <%: Html.ValidationMessageFor(model => model.Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Notes) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Notes) %>
                <%: Html.ValidationMessageFor(model => model.Notes) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>


