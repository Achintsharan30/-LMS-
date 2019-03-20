<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddedBook.aspx.cs" Inherits="AddedBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" BackColor="#66FF33" BorderStyle="None" Font-Size="X-Large" ForeColor="Black" style="z-index: 1; left: 286px; top: 117px; position: absolute; height: 43px; width: 772px" Text="Congratulation yours book has been successfully been added.."></asp:Label>
            <asp:Button ID="buttonHp" runat="server" OnClick="buttonHp_Click" style="z-index: 1; left: 569px; top: 200px; position: absolute" Text="HomePage" />
        </div>
    </form>
</body>
</html>
