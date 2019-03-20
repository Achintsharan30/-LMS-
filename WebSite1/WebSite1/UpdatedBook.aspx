<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatedBook.aspx.cs" Inherits="UpdatedBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblbookmessageupdate" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 182px; top: 112px; position: absolute" Text="Congratulation yours book has been UPDATED"></asp:Label>
        </div>
        <asp:Button ID="btnHpp" runat="server" OnClick="btnHpp_Click" style="z-index: 1; left: 378px; top: 238px; position: absolute" Text="Homepage" />
    </form>
</body>
</html>
