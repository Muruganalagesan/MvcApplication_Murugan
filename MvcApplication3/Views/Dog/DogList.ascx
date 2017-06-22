<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MvcApplication3.Models.Dog>" %>
<%: Model.Name %> is <%: Model.Age ==1? Model.Age + " year" :Model.Age +"' year's" %> old