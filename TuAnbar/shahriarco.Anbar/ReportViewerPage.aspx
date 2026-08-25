<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewerPage.aspx.cs" Inherits="shahriarco.Anbar.ReportViewerPage" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%--<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="scriptManager" runat="server" EnablePartialRendering="true"/>    
        <div>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" width="100%" height="600"></rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
