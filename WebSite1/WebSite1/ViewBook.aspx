<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewBook.aspx.cs" Inherits="ViewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblview" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 109px; top: 49px; position: absolute; height: 48px; width: 265px" Text="VIEW BOOK DETAILS "></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="buttonhp" runat="server" OnClick="buttonhp_Click" style="z-index: 1; left: 281px; top: 401px; position: absolute" Text="Home Page" />
        <p>
            &nbsp;</p>
        <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 251px; top: 152px; position: absolute; width: 256px; height: 193px"></asp:ListBox>
    </form>
</body>
</html>
