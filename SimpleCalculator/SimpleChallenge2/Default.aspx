<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleChallenge2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                &nbsp;</p>
            <p style="font-family: Arial, Helvetica, sans-serif">
                First value:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p style="font-family: Arial, Helvetica, sans-serif">
                Second value:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p style="font-family: Arial, Helvetica, sans-serif">
                <asp:Button ID="addBtn" runat="server" OnClick="addBtn_Click" Text="+" />
&nbsp;
                <asp:Button ID="subBtn" runat="server" OnClick="subBtn_Click" Text="-" />
&nbsp;
                <asp:Button ID="multBtn" runat="server" OnClick="multBtn_Click" Text="*" />
&nbsp;
                <asp:Button ID="divBtn" runat="server" OnClick="divBtn_Click" style="width: 18px" Text="/" />
            </p>
            <p style="font-family: Arial, Helvetica, sans-serif">
                &nbsp;</p>
            <p style="font-family: Arial, Helvetica, sans-serif">
                <asp:Label ID="resultLabel" runat="server" BackColor="Lime" Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
