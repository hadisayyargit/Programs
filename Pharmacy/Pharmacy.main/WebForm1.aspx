<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pharmacy.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <input type="file" id="aa" />
        <asp:FileUpload ID="FileUpload1" runat="server"  />

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
    <input id="Text1" type="text"  style="" disabled="disabled" />
</body>
</html>
