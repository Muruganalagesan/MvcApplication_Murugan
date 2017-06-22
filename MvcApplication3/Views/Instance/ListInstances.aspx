<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcApplication3.Models.InstanceInfo1>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    ListInstances
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>ListInstances</h2>
    <% using( Html.BeginForm()) { %>
    <%: Html.AntiForgeryToken()%>
    <%: Html.ValidationSummary(true) %>

    <%: Html.LabelFor( m=>m.InstanceID) %>
     <%: Html.EditorFor( m=>m.InstanceID) %>
    <%: Html.ValidationMessageFor(m=>m.InstanceID) %>

    <p>
            <input type="submit" value="Save" />
        </p>

    <%} %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
