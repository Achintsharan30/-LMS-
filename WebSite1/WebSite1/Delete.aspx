<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonDelete" runat="server" style="z-index: 1; left: 402px; top: 300px; position: absolute; width: 87px" Text="Delete" OnClick="ButtonDelete_Click" />
            <asp:Button ID="Buttonhomepage" runat="server" OnClick="Buttonhomepage_Click" style="z-index: 1; left: 571px; top: 301px; position: absolute" Text="Home Page" />
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 456px; top: 214px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 458px; top: 161px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblBookid" runat="server" style="z-index: 1; left: 308px; top: 221px; position: absolute" Text="Book ID:"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Algerian" Font-Size="Large" style="z-index: 1; left: 479px; top: 84px; position: absolute" Text="DELETE BOOK DETAILS "></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblBooktitle" runat="server" style="z-index: 1; left: 306px; top: 165px; position: absolute" Text="Book Title "></asp:Label>
        </p>
    </form>
</body>
</html>
