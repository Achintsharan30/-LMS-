<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddBook.aspx.cs" Inherits="AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblBrd" runat="server" style="z-index: 1; left: 39px; top: 404px; position: absolute" Text="Book Release Date "></asp:Label>
            <asp:Label ID="lblBookTitle" runat="server" style="z-index: 1; left: 39px; top: 175px; position: absolute" Text="Book Title"></asp:Label>
            <asp:Label ID="lblBookPub" runat="server" style="z-index: 1; left: 39px; top: 340px; position: absolute" Text="Book Publisher"></asp:Label>
            <asp:Label ID="lblBookID" runat="server" style="z-index: 1; left: 38px; top: 126px; position: absolute; height: 25px" Text="Book ID:"></asp:Label>
            <asp:Label ID="lblAuthorname" runat="server" style="z-index: 1; top: 221px; position: absolute; left: 40px; " Text="Author Name"></asp:Label>
            <asp:Label ID="lblAbd" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#00CC00" style="z-index: 1; left: 153px; top: 58px; position: absolute" Text="ADD BOOKS DETAILS"></asp:Label>
        </div>
        <asp:Button ID="buttonAdd" runat="server" OnClick="buttonAdd_Click" style="z-index: 1; left: 138px; top: 474px; position: absolute; width: 110px" Text="Add" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblBookCatg" runat="server" style="z-index: 1; left: 37px; top: 279px; position: absolute; width: 144px; height: 26px" Text="Book Cateogeory "></asp:Label>
            <asp:Button ID="buttonHomepage" runat="server" OnClick="buttonHomepage_Click" style="z-index: 1; left: 380px; top: 472px; position: absolute" Text="Home Page " />
            <asp:TextBox ID="txtBookid" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 274px; top: 136px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtBooktitle" runat="server" style="z-index: 1; left: 277px; top: 180px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtAuthorname" runat="server" style="z-index: 1; left: 276px; top: 225px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtBookPub" runat="server" style="z-index: 1; left: 273px; top: 334px; position: absolute; width: 171px; height: 20px"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 271px; top: 393px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtBookCategeory" runat="server" style="z-index: 1; left: 277px; top: 275px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
