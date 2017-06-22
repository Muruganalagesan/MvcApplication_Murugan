<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable< MvcApplication3.Models.Dog>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    My Dog List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>My Dog List with Age details:</h2>
     <ul> 
       <% foreach (var item in Model)
	{%>
      
          <li>
                <%  Html.RenderPartial("DogList",item); %>
          </li>   
   
		 
	<%} %>
          </ul>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
 
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
