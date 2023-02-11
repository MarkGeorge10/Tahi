<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Tahi.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>ELTAHI</title>
    <meta name="robots" content="noindex, follow" />
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- Favicon -->
    <link rel="shortcut icon" type="image/x-icon" href="assets/images/favicon.ico">

    <!-- CSS
	============================================ -->
    
    <!-- Main Style CSS -->
    <link href="assets/css/authStyles.css" rel="stylesheet" />

</head>
<body>
     <main>
		  <form id="form2" runat="server">
               <div class="box-form">
				<div class="left">
					<div class="overlay">
					<h1>ElTAHI</h1>
					<p>It’s helps you to connect and share with the people in your life</p>
		
					</div>
				</div>
	
	
				<div class="right">
					<h5>Login</h5>
					<p>Don't have an account? <a href="signup.aspx">Create Your Account</a> it takes less than a minute</p>
					<div class="inputs">
						 <asp:TextBox ID="Txtuslog" runat="server" placeholder="Email" class="single-field" TextMode="Email"></asp:TextBox>
						<br>
						<asp:TextBox ID="Txtlogpass" placeholder="Password" class="single-field" runat="server" TextMode="Password"></asp:TextBox>
					</div>
			
						<br><br>
			
	
			
						<br>
						<asp:Button ID="Btnlogin" class="login-btn" runat="server" Text="Login" 
															OnClick="Btnlogin_Click" />
				</div>
	
				</div>

		  </form>
        
     </main>

    <!-- JS
============================================ -->

   
 <%--   <form id="form1" runat="server">
    <div>
    
    </div>
    </form>--%>
</body>
</html>
