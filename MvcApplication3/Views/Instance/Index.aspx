<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication3.Models.InstanceInfo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
<h2>Index</h2>
     <% using( Html.BeginForm() ){ %>
    <%: Html.AntiForgeryToken() %>

    <table>
        <tr>
            <th><%:Html.DisplayNameFor( m=>m.InstanceID) %></th>
             <th><%:Html.DisplayNameFor(m => m.InstanceName) %></th>
             <th><%:Html.DisplayNameFor(m => m.VCPU) %></th>
             <th><%:Html.DisplayNameFor(m => m.DISK) %></th>
            <th><%:Html.DisplayNameFor(m => m.RAM) %></th>
            <th><%:Html.DisplayNameFor(m => m.TimeSinceCreated) %></th>
        </tr>
    </table>

    <fieldset>
        <legend>Usage</legend>

        <% foreach (var item in Model) {%>
          <% Html.RenderPartial("ListView",item); %>
               
          <% } %>

       

    </fieldset>
    



    <%} %>



</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
