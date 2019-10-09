<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weekly_calendar.aspx.cs" Inherits="n01359105.weekly_calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Please enter your work/study schedule</h1>
        
        <asp:CheckBoxList runat="server" ID="working_days">
            <asp:ListItem Value="Monday">Monday</asp:ListItem>
            <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
            <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
            <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
            <asp:ListItem Value="Friday">Friday</asp:ListItem>
            <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
            <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
        </asp:CheckBoxList>

        <asp:Button runat="server" Text="Submit" />

        <div runat="server" id="summary"></div>
    </form>
</body>
</html>
