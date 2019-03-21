<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Buttonhomepages" runat="server" OnClick="Buttonhomepage_Click" style="z-index: 1; left: 243px; top: 327px; position: absolute" Text="Homepage" />
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Algerian" Font-Size="Large" style="z-index: 1; left: 40px; top: 78px; position: absolute" Text="DELETE BOOK DETAILS "></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" style="z-index: 1; left: 118px; top: 326px; position: absolute; height: 26px" Text="Delete" />
            <asp:Label ID="lblBookid" runat="server" style="z-index: 1; left: 112px; top: 266px; position: absolute" Text="BookId"></asp:Label>
            <asp:TextBox ID="TextBoxBookid" runat="server" style="z-index: 1; left: 192px; top: 272px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
