<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Battleships - Rosemary Holliday</title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>Battleships!</h1>
            <p>Your opponent's battleships have been placed at random... Shoot them!</p>
            <p>To shoot, enter a coordinate in the format of "a5" and then click the "Shoot" button.</p>
            <p>Columns go from A-J and the rows go from 0-9.</p>
            <asp:TextBox ID="txtUserGuess" runat="server"></asp:TextBox><asp:Button ID="btnShoot" runat="server" Text="Shoot" OnClick="btnShoot_Click" />
        </div>
        <asp:Panel ID="pnlError" runat="server"></asp:Panel>
        <asp:Panel ID="pnlGrid" runat="server"></asp:Panel>
    </form>
</body>
</html>
