<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MvcApplication3.Models.InstanceInfo>" %>

<table>
    <tr></tr>
</table>

<%: Model.InstanceID  %> <%: Model.InstanceName  %>/t <%: Model.VCPU  %>/t <%: Model.DISK  %>/t <%: Model.RAM  %> /t<%: Model.TimeSinceCreated  %> <br />