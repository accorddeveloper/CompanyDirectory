<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Homework.FrontEnd.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wonderlic Team</title>
    <link href="CSS/Details_Wonderlic.css" rel="stylesheet" type="text/css" />
    <link href='http://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'/>
    <link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css'/>
</head>
<body>
    <form id="Details" runat="server">
    <div>
        <asp:Label ID="Error" runat="server" Text="Label"></asp:Label><br />
        ID: <asp:Label ID="EmployeeID" runat="server" Text="Label" Font-Bold="True"></asp:Label><br />
        Name: <asp:Label ID="FirstName" runat="server" Text="Label" Font-Bold="True"></asp:Label>
         <asp:Label ID="LastName" runat="server" Text="Label" Font-Bold="True"></asp:Label><br />
        Extension: <asp:Label ID="Extension" runat="server" Text="Label" Font-Bold="True"></asp:Label><br />
        <asp:Image ID="EmployeePicture"  runat="server" height="200px"  AlternateText="Employee Image" BorderColor="#333333" BorderStyle="Double" BorderWidth="5px" /><br />
        <asp:button id="backButton" runat="server" text="Back" OnClientClick="JavaScript:window.history.back(1);return false;"></asp:button>
         
    </div>
    </form>
</body>
</html>
