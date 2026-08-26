<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewerPage.aspx.cs" Inherits="quc.ReportViewerPage" %>

<%@ register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="scriptManager" runat="server" />    

        <rsweb:ReportViewer runat="server" ID="ReportViewerControl1"  width="100%" Height="610px" ZoomPercent="50" ShowToolBar="True">
             <LocalReport ReportPath="rptAbBill.rdlc">
            </LocalReport>
        </rsweb:ReportViewer>

    </div>
    </form>
</body>

<%--<script>

    function pageLoad() {

        //if ($.browser.mozilla && !$("#ff_print").length) {
        if (!$("#ff_print").length) {

            try {
                var ControlName = 'ReportViewerControl1';
                var innerTbody = '<tbody><tr><td><input type="image" style="border-width: 0px; padding: 2px; height: 16px; width: 16px;" alt="Print" src="Reserved.ReportViewerWebControl.axd?OpType=Resource&amp;Version=9.0.30729.1&amp;Name=Microsoft.Reporting.WebForms.Icons.Print.gif" title="Print"></td></tr></tbody>';
                var innerTable = '<table title="Print" onclick="PrintFunc(\'' + ControlName + '\'); return false;" id="ff_print" style="border: 1px solid rgb(236, 233, 216); background-color: rgb(236, 233, 216); cursor: default;">' + innerTbody + '</table>'
                var outerDiv = '<div style="display: inline; font-size: 8pt; height: 30px;" class=" "><table cellspacing="0" cellpadding="0" style="display: inline;"><tbody><tr><td height="28px">' + innerTable + '</td></tr></tbody></table></div>';

                $("#ReportViewerControl1_ctl05 > div").append(outerDiv);

            }
            catch (e) { alert(e); }
        }

    }

    function PrintFunc() {
        var strFrameName = ("printer-" + (new Date()).getTime());
        var jFrame = $("<iframe name='" + strFrameName + "'>");
        jFrame
        .css("width", "1px")
        .css("height", "1px")
        .css("position", "absolute")
        .css("left", "-2000px")
        .appendTo($("body:first"));

        var objFrame = window.frames[strFrameName];
        var objDoc = objFrame.document;
        var jStyleDiv = $("<div>").append($("style").clone());

        objDoc.open();
        objDoc.write($("head").html());
        objDoc.write($("#VisibleReportContentReportViewerControl1_ctl09").html());
        objDoc.close();
        objFrame.print();

        setTimeout(function () { jFrame.remove(); }, (60 * 1000));
    }
</script>--%>

<script src="Scripts/jquery-1.10.2.min.js"></script>

</html>
