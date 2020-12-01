<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="AppFactoryTrial.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Landing Page</title>
 
<%--    <link href="Content/bootstrap.min.css" rel="stylesheet" />
       <link href="contents/StyleLandingpage.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>--%>
      <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
      <link href="contents/StyleLandingpage.css" rel="stylesheet" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

</head>
<body >
<%--    <img src="contents/images/pic1.jpeg"/>--%>
    <form id="form1" runat="server">
      
        <div> 
             

  
 <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
    <div <%--class="navbar-brand" --%>>
        <img height="5"  src="contents/images/tshimologongwhite.gif" />
    </div>
        
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="#">Home</a></li>
       <li><a href="./AboutProgram.aspx">About Program</a></li>
      <li><a href="./ViewUsers.aspx">View Participants</a></li>
    </ul>
    <ul class="nav navbar-nav navbar-right">
      <li><a href="./CaptureInterns.aspx"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
      <li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
    </ul>
  </div>
</nav>


  <%--           <nav>
                
               <ul>  
                
                   <li><a href="./CaptureInterns.aspx" >Sign up</a>
                       <ul>
                           
                           <li><a href="./CaptureInterns.aspx" >Interns</a></li>
                           <li><a href="./CaptureInterns.aspx" >Mentors</a></li>
                           <li><a href="./CaptureInterns.aspx" > Managers</a></li>
                       </ul>
                   </li>
                   
                   <li><a href="./AboutProgram.aspx">About Program</a></li>
                <li><a > </a>Contact us</li>
                  

               </ul>
              
            </nav>--%>
            <br />
            <br />
            <section>
                <h2>Welcome to the Tshimologong AppFactory</h2>
                <hr /><br />
                <div >
                        
                <p>Wits University’s Tshimologong Digital Innovation Precinct, has launched a AppFactory internship programme, sponsored by Samsung South Africa.
                    This initiative aims to improve the state of software development in South Africa, giving eight interns an opportunity to work with a senior developer over a 9-month period.
                </p>
               <%-- <img src="contents/images/handshakee.png"/>--%>
          
            
                   <button type="button" onclick="./AboutProgram.aspx" class="button">Learn more </button>
                </div>
            
            </section>
        </div>
    </form>
</body>
</html>
