<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Simple Calculator</h1>
        <p>
            First Value:&nbsp;
            <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:&nbsp;
            <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="subButton" runat="server" OnClick="subButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multButton" runat="server" OnClick="multButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divButton" runat="server" OnClick="divButton_Click" Text="/" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
