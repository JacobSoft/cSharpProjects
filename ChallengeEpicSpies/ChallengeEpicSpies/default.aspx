<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeEpicSpies._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: "Times New Roman", Times, serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
            <h2 class="auto-style1">Spy New Assignment Form</h2>
            <p class="auto-style2">
                Spy Code Name:
                <asp:TextBox ID="spyName" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style2">
                New Assignment Name: <asp:TextBox ID="assignName" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style2">
                End Date of Previous Assignment:</p>
            <p class="auto-style2">
                <asp:Calendar ID="firstCal" runat="server"></asp:Calendar>
            </p>
            <p class="auto-style2">
                Start Date of New Assignment:</p>
            <p class="auto-style2">
                <asp:Calendar ID="secondCal" runat="server"></asp:Calendar>
            </p>
            <p class="auto-style2">
                Projected End Date of New Assignment:</p>
            <p class="auto-style2">
                <asp:Calendar ID="thirdCal" runat="server"></asp:Calendar>
            </p>
            <p class="auto-style2">
                <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy!" />
            </p>
            <p class="auto-style2">
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
