<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="coordinate_assignment.aspx.cs" Inherits="n01359105.coordinate_assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>coordinate_assignment</title>
    <link rel="stylesheet" type="text/css" href="Content/Site.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <label>Input value for x-axis:</label> 
            <asp:Textbox runat="server" ID="input_x"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter value for x-axis" ControlToValidate="input_x"></asp:RequiredFieldValidator>
        </section>
        <section>
            <label>Input value for y-axis:</label>
            <asp:Textbox runat="server" ID="input_y"></asp:Textbox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ErrorMessage="Please enter value for y-axis" ControlToValidate="input_y"></asp:RequiredFieldValidator>
        </section>
        <div id="summary" runat="server">
        </div>

        <asp:Button runat="server" Text="Submit" />
    </form>
</body>
</html>
