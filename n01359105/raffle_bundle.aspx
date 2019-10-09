<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="raffle_bundle.aspx.cs" Inherits="n01359105.raffle_bundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <label>Enter number of tickets:</label>
            <asp:Textbox runat="server" ID="numberOf_tickets"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter number of tickets" ControlToValidate="numberOf_tickets"></asp:RequiredFieldValidator>
         </section>
        
         <asp:Button runat="server" Text="Submit" />

         <div id="summary" runat="server">
         </div>
    </form>
</body>
</html>
