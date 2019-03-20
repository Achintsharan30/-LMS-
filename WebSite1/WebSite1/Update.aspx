<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAuthor" runat="server" style="z-index: 1; left: 78px; top: 76px; position: absolute; width: 40px" Text="AuthorName"></asp:Label>
        <asp:Label ID="lblBooktil" runat="server" style="z-index: 1; left: 79px; top: 220px; position: absolute; height: 22px" Text="BookTitle"></asp:Label>
        <asp:Label ID="lblBookCat" runat="server" style="z-index: 1; left: 78px; top: 111px; position: absolute" Text="BookCategeory"></asp:Label>
        <asp:Label ID="lblBookRelDate" runat="server" style="z-index: 1; left: 78px; top: 184px; position: absolute" Text="BookReleaseDate"></asp:Label>
        <asp:Label ID="lblBookPub" runat="server" style="z-index: 1; left: 78px; top: 147px; position: absolute; height: 20px; width: 38px" Text="BookPublisher"></asp:Label>
        <p>
            <asp:Button ID="btnHp" runat="server" OnClick="btnHp_Click" style="z-index: 1; left: 251px; top: 314px; position: absolute; height: 28px; width: 66px" Text="Cancel" />
        </p>
        <asp:TextBox ID="txtAn" runat="server" style="z-index: 1; left: 209px; top: 78px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBc" runat="server" style="z-index: 1; left: 212px; top: 116px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtbp" runat="server" style="z-index: 1; left: 213px; top: 151px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBt" runat="server" style="z-index: 1; left: 210px; top: 222px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:TextBox ID="txtbrd" runat="server" style="z-index: 1; left: 212px; top: 190px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" style="z-index: 1; left: 122px; top: 315px; position: absolute" Text="Update " />
    </form>
</body>
</html>
