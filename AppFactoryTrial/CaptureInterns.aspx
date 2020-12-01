<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaptureInterns.aspx.cs" Inherits="AppFactoryTrial.InternsCapture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="contents/StyleLandingpage.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
                         <nav>
                
               <ul>  
                
                   <li><a href="./CaptureInterns.aspx" >Sign up</a>
                       <ul>
                           
                           <li>Interns</li>
                           <li>Mentors</li>
                           <li> Managers</li>
                       </ul>
                   </li>
                   
                   <li><a href="./AboutProgram.aspx">About Program</a></li>
                   <li><a href="./LandingPage.aspx">Take me Home</a></li>
                <li><a >Conact us </a></li>
                  

               </ul>
              
            </nav>
        </div>
        <h4>Tackle this form below and join us</h4>
       &nbsp;<section>
                <div class="label">
                    <asp:Label ID="Label5" runat="server" CssClass="Formdividers" Text="Personal Details"></asp:Label>
                    <br />
             <asp:Label ID="Label1" runat="server" Text="First Name:" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
             <br />
        
        <asp:TextBox ID="FirstName"  runat="server" CssClass="textbox" placeholder="Enter Your name" OnTextChanged="FirstName_TextChanged"></asp:TextBox>
       
                    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FirstName" CssClass="label" ErrorMessage="Please enter first name ">*</asp:RequiredFieldValidator>
       
                    
        <br />
        <asp:Label ID="Label2" runat="server" Text="Surname:  " CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
             <br />
        <asp:TextBox ID="Surname" runat="server" OnTextChanged="TextBox2_TextChanged" CssClass="textbox" placeholder="Enter Your surname"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Surname" ErrorMessage="Please Enter your surname">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Middle Name:" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
             <br />
        <asp:TextBox ID="MiddleName" runat="server" OnTextChanged="MiddleName_TextChanged" CssClass="textbox" placeholder="Enter Your middle name" ></asp:TextBox>
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Role" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large"></asp:Label>
                    <br />
                    <asp:DropDownList ID="Roles" runat="server" CssClass="textbox">
                        <asp:ListItem Value="1">Intern</asp:ListItem>
                        <asp:ListItem Value="2">Mentor</asp:ListItem>
                        <asp:ListItem Value="3">Manager</asp:ListItem>
                    </asp:DropDownList>
             <br />
                    
             <asp:Calendar ID="Calendar1" runat="server" Caption="Date of Birth" CaptionAlign="Top" CellPadding="0" Height="2px" style="margin-right: 0px" Width="250px"></asp:Calendar>
                    <asp:Label ID="Label6" runat="server" CssClass="Formdividers" Text="Contact Details"></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large" Text="Email"></asp:Label>
                    <br />
                    <asp:TextBox ID="Email" runat="server" CssClass="textbox" OnTextChanged="Email_TextChanged"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" CssClass="label" ErrorMessage="Invalid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Email" ErrorMessage="Please enter Email"> .</asp:RequiredFieldValidator>
                    <br />
                    <asp:CheckBox ID="IsbusinessEmail" runat="server" CssClass="activeques" Font-Names="Yu Gothic" Text="Is it a business email?" Font-Size="Medium" />
                    <br />
                    <asp:Label ID="Label7" runat="server" CssClass="label" Font-Names="Yu Gothic" Font-Size="Large" Text="Alternate Email"></asp:Label>
                    <br />
                    <asp:TextBox ID="AltEmail" runat="server" CssClass="textbox" OnTextChanged="AltEmail_TextChanged"></asp:TextBox>
             <br />
                    <asp:Label ID="Label8" runat="server" Font-Names="Yu Gothic" Font-Size="Large" Text="Phone Number"></asp:Label>
                    <br />
                    <asp:TextBox ID="PhoneNumber" runat="server" CssClass="textbox" OnTextChanged="PhoneNumber_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="PhoneNumber" ErrorMessage="Phone Number Required">*</asp:RequiredFieldValidator>
                    <br />
                    <asp:CheckBox ID="IsnoActive" runat="server" CssClass="activeques" Font-Names="Yu Gothic" Text="Is it active?" Font-Size="Medium" />
                    <br />
                    <asp:Label ID="Label9" runat="server" Font-Names="Yu Gothic" Font-Size="Large" Text="Alternate Number"></asp:Label>
                    <br />
                    <asp:TextBox ID="AltPhoneNumber" runat="server" CssClass="textbox" OnTextChanged="AltPhoneNumber_TextChanged"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" CssClass="button" Height="60px" Text="Submit" OnClick="Button1_Click" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" Font-Names="Yu Gothic" Font-Size="Medium" ForeColor="Red" Width="440px" />
        </div>
        </section>
    
       

    </form>
</body>
</html>
