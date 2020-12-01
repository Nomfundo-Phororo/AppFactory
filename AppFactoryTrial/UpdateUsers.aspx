<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateUsers.aspx.cs" Inherits="AppFactoryTrial.UpdateUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UpdateUser</title>
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="contents/StyleLandingpage.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       

        <div class="label">


            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="Label6" runat="server" CssClass="Formdividers" Text="Personal Details"></asp:Label>
                    <br />
             <asp:Label ID="Label8" runat="server" Text="First Name:" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
             :
            <asp:TextBox ID="Fname" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
        <asp:Label ID="Label2" runat="server" Text="Surname:  " CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
             &nbsp;<asp:TextBox ID="LName" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
        <asp:Label ID="Label3" runat="server" Text="Middle Name:" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
             &nbsp;<asp:TextBox ID="MiddleName" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
                    <asp:Label ID="Label10" runat="server" Text="Role" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
                    &nbsp;<asp:DropDownList ID="Roles" runat="server" CssClass="textbox" Font-Size="Large">
                <asp:ListItem Value="1">Intern</asp:ListItem>
                <asp:ListItem Value="2">Mentor</asp:ListItem>
                <asp:ListItem Value="3">Manager</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Calendar ID="Calendar1" runat="server" Caption="Date Of Birth"></asp:Calendar>
                    <asp:Label ID="Label7" runat="server" CssClass="Formdividers" Text="Contact Details"></asp:Label>
                    <br />
            <br />
                    <asp:Label ID="Label4" runat="server" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large" Text="Email:"></asp:Label>
                    &nbsp;<asp:TextBox ID="email" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
                    <asp:Label ID="Label11" runat="server" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large" Text="Alternate Email:"></asp:Label>
                    &nbsp;<asp:TextBox ID="AltEmail" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
                    <asp:Label ID="Label12" runat="server" Font-Names="Yu Gothic" Font-Size="Large" Text="Phone Number:"></asp:Label>
                    &nbsp;<asp:TextBox ID="Pnumber" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
                    <asp:Label ID="Label9" runat="server" Font-Names="Yu Gothic" Font-Size="Large" Text="Alternate Number:"></asp:Label>
                    &nbsp;<asp:TextBox ID="AltPnumber" runat="server" CssClass="textbox" Font-Size="Large"></asp:TextBox>
            <br />
            <asp:Button ID="btnCancel" runat="server"  Text="Cancel" OnClick="btnCancel_Click" />
&nbsp;<asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />


        </div>



    </form>
</body>
</html>
