<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomepageBook.aspx.cs" Inherits="HomepageBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLms" runat="server" BackColor="#3399FF" Font-Bold="True" Font-Size="XX-Large" Font-Underline="False" style="z-index: 1; left: 56px; top: 85px; position: absolute; height: 64px; width: 582px" Text="LIBRARY MANAGEMENT SYSYTEM "></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 23px; top: 265px; position: absolute; height: 25px; right: 1175px;" Text="DeleteBooks" />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 24px; top: 192px; position: absolute; width: 106px;" Text="AddBooks" />
        <asp:Button ID="btnView" runat="server" style="z-index: 1; left: 637px; top: 267px; position: absolute; width: 110px;" Text="ViewAllBooks" OnClick="btnView_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnupdateBooks" runat="server" OnClick="btnupdateBooks_Click" style="z-index: 1; left: 631px; position: absolute; top: 191px; width: 112px" Text="Update Books" />
        <asp:ListBox ID="LstBook" runat="server" OnSelectedIndexChanged="LstBook_SelectedIndexChanged" style="z-index: 1; left: 262px; top: 188px; position: absolute; height: 120px; width: 247px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 238px; top: 343px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
