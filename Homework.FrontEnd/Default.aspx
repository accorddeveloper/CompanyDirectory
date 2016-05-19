<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Homework.FrontEnd._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Wonderlic Team</title>
    <link href="CSS/Default_Wonderlic.css" rel="stylesheet" type="text/css" />
    <link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css' />
    <meta name="viewport" 
    content="initial-scale=1.0, maximum-scale=1.0, user-scalable=no, width=device-width"/> 
</head>
<body>
<form id="MainForm" runat="server">
<div>

    <h2>Please fill one or more search fields.</h2>
    <asp:TextBox Class="text" ID="SearchLastName" runat="server" placeholder="last name" BackColor="#E4E4E4" ></asp:TextBox><p/>
    <asp:TextBox ID="SearchFirstName" runat="server" placeholder="first name" BackColor="#E4E4E4" ></asp:TextBox><p/>
    <asp:TextBox ID="SearchDepartment" runat="server" placeholder="department" BackColor="#E4E4E4" ></asp:TextBox><p/>
    <asp:Button ID="SearchButton" runat="server" Text="Search" onclick="SearchButton_Click" />
    <asp:Button ID="ClearButton" runat="server" Text="Clear All" onclick="ClearButton_Click" /><p/>
    <asp:GridView ID="SearchResultGridView" runat="server"  AutoGenerateColumns="false"
        ShowHeaderWhenEmpty="true" RowStyle-Wrap="false" CellPadding="3">
        <columns>
            <asp:hyperlinkfield datatextfield="EmployeeID" 
                datanavigateurlfields="EmployeeID"
                DataNavigateUrlFormatString= "~/Details.aspx?employeeId={0}"        
                headertext="EmployeeID" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            <asp:BoundField DataField="FirstName" HeaderText="First Name" />
            <asp:BoundField DataField="Department" HeaderText="Department" />
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Extension" HeaderText="Extension" />
        </columns>
    </asp:GridView>

</div>    
</form>
</body>
</html>
