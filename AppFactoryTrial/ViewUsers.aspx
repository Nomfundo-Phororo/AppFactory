<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="AppFactoryTrial.ViewUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <link href="contents/StyleLandingpage.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.js"></script>
</head>
<body>
    <form id="form1" runat="server">

                <div>   <nav>
               <ul>  
                  <li><a href="./CaptureInterns.aspx" >Sign up</a>
                       <ul>
                          
                           <li><a href="./CaptureInterns.aspx" >Interns</a></li>
                           <li><a href="./CaptureInterns.aspx" >Mentors</a></li>
                           <li><a href="./CaptureInterns.aspx" > Managers</a></li>
                       </ul>
                   </li>
                
                   <li><a href="./AboutProgram.aspx">About the program</a></li>
                     <li><a>Contact Us</a></li>
                <li><a href="./LandingPage.aspx">Take me Home </a></li>
                  

               </ul>
              
            </nav>
        </div>
      

  

        <div class="Persontable">        
            <asp:Table ID="Person" runat="server" BorderWidth="2px" CellPadding="4" CellSpacing="4" Width="70%" Font-Names="Yu Gothic" ForeColor="White" BackColor="#999999" Caption="All Participants" CaptionAlign="Top"  GridLines="Horizontal">
                <asp:TableRow ID="TableRow1" runat="server" CssClass="Row1" Height="2px">
                    <asp:TableCell runat="server" BackColor="#006666" >First Name</asp:TableCell>
                    <asp:TableCell runat="server" BackColor="#006666">Last Name</asp:TableCell>
                    <asp:TableCell runat="server" BackColor="#006666">Date of Birth</asp:TableCell>
                     <asp:TableCell runat="server" BackColor="#006666">Position</asp:TableCell>
                    <asp:TableCell runat="server" BackColor="#006666">Update</asp:TableCell>
           
                </asp:TableRow>


            </asp:Table>
            <br />
              <br />
              <br />
        </div>
    </form>
</body>
</html>
