<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PizzaChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Times New Roman", Times, serif;
            text-align: left;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            text-align: center;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style4 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
            <h1 class="auto-style2">Papa Bob&#39;s Pizza &amp; Software</h1>
            <p class="auto-style1">
                &nbsp;</p>
        </div>
        <asp:RadioButton ID="smallSize" runat="server" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="medSize" runat="server" GroupName="pizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="largeSize" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinCrust" runat="server" GroupName="crustType" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepCrust" runat="server" GroupName="crustType" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoni" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onions" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenPeppers" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redPeppers" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchovies" runat="server" Text="Anchovies (+$2)" />
        <h2 class="auto-style3">Papa Bob&#39;s <span class="auto-style4">Special Deal</span></h2>
        <br />
        Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies - OR Pepperonie, Red Peppers, and Onions to your pizza.<br />
        <br />
        <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        <br />
        <asp:Label ID="errorLabel" runat="server"></asp:Label>
        <br />
        <br />
        Total: $<asp:Label ID="totalLabel" runat="server" Text="0.00"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</form>
</body>
</html>
