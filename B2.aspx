<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="B2.aspx.cs" Inherits="WebApplication1.B2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bank Account Form</h2>
            <p>Account:
                <asp:TextBox ID="balance" runat="server" TextMode="Number"></asp:TextBox>
                <asp:Button ID="deposit" runat="server" OnClick="deposit_Click" Text="Deposite" />
                <asp:Button ID="withdraw" runat="server" OnClick="withdraw_Click" Text="Withdraw" />
            </p>
            <p>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </p>
        </div>
        <asp:Label ID="lblres" runat="server" ForeColor="Red"></asp:Label>
    </form>
    <script src="script.js"></script>
</body>
</html>
