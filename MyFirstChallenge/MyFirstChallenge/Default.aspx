﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What is your age?&nbsp;
            <asp:TextBox ID="ageBox" runat="server"></asp:TextBox>
            <br />
            <br />
            How much money do you have in your pocket?&nbsp;
            <asp:TextBox ID="moneyBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="fortuneButton" runat="server" OnClick="fortuneButton_Click" Text="Click here for your fortune!" />
            <br />
            <br />
            <asp:Label ID="fortuneResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
