<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Tahi.signup" %>


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
      <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="assets/css/vendor/bootstrap.min.css">
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
	
	
				<div class="right ">
					  <h5>New user</h5>
					<br />
                    <br />
					<div class="inputs ">
                        
                      
                          
                             <asp:DropDownList ID="DdlTyp" class="nice-select" runat="server" DataSourceID="SqlDataSource2"
                                               DataTextField="ElTahiType" DataValueField="ElTahiTypesID" 
                                               OnSelectedIndexChanged="DdlTyp_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                                 
                             <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                                SelectCommand="SELECT [ElTahiTypesID], [ElTahiType] FROM [ElTahiType]"></asp:SqlDataSource>
                   
                       <div class="col-12" id="Rusttyp" runat="server" visible="False">
                            <asp:DropDownList ID="DropDownList1" class="nice-select" runat="server" DataSourceID="SqlDataSource2"
                                              DataTextField="ElTahiType" DataValueField="ElTahiTypesID"></asp:DropDownList>
                            <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                               SelectCommand="SELECT * FROM [ElTahiRestuarantType]"></asp:SqlDataSource>
                                                    <%--<asp:TextBox ID="TextBox1"  class="single-field" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>--%>
                       </div>
                                                  
                                                <div class="col-12" id="Rstsuplname" runat="server" visible="False">
                                                    <asp:TextBox ID="txtCompname"  class="single-field" placeholder="Sup / Restuarant Name" runat="server" ></asp:TextBox>
                                                 
                                                </div>
                                                     <div class="col-12" id="address" runat="server" visible="False">
                                                    <asp:TextBox ID="txtaddress"  class="single-field" placeholder="Address" runat="server" ></asp:TextBox>
                                                 
                                                </div>
                                                <div class="col-12">
                                                    <asp:TextBox ID="TxtEmal"  class="single-field" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>
                                                 
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:TextBox ID="TxtFName" class="single-field" placeholder="First Name" runat="server"></asp:TextBox>
                                                </div>
                                                  <div class="col-md-6">
                                                    <asp:TextBox ID="TextSName" class="single-field" placeholder="Secound Name" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:TextBox ID="TxtLName" class="single-field" placeholder="Last Name" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:TextBox ID="TxtMobile" class="single-field" placeholder="Mobile" runat="server" TextMode="Phone"></asp:TextBox>
                                                </div>
                                                 <div class="col-12">
                                                     <asp:TextBox ID="TxtBdate" class="single-field"  runat="server" TextMode="Date"></asp:TextBox>
                                                 
                                                </div>
                                                 <div class="col-12">
                                                    <asp:TextBox ID="TxtBio" class="single-field" placeholder="Bio" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                                    <div class="col-12">
                                                    <asp:TextBox ID="TxtUserName" class="single-field" placeholder="UserName" runat="server"></asp:TextBox>
                                                </div>
                                                    <div class="col-12">
                                                    <asp:TextBox ID="TxtPassword"  class="single-field" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                                                </div>
                                                     <div class="col-12">
                                                    <asp:TextBox ID="txtpass"  class="single-field" placeholder="Confirm Password" runat="server" TextMode="Password"></asp:TextBox>
                                                </div>
                                                
                                                <div class="col-md-6">
                                                    <asp:DropDownList ID="DDlCountry" class="nice-select" runat="server" DataSourceID="SqlDataSource1"
                                                        DataTextField="country_enName" DataValueField="ContID"></asp:DropDownList>
                                                  
                                                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                                        SelectCommand="SELECT * FROM [Countries]"></asp:SqlDataSource>
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:DropDownList ID="DdlNationalty" class="nice-select" runat="server" DataSourceID="SqlDataSource3"
                                                        DataTextField="country_enNationality" DataValueField="ContID"></asp:DropDownList>
                                                   
                                                    <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                                        SelectCommand="SELECT [ContID], [country_enNationality] FROM [Countries]"></asp:SqlDataSource>
                                                </div>
                                               
                                                   
                                
                                     
                            
                                                
                           
                   
					</div>
			
						<br><br>
			
	
			
						<br>
                   
                       <asp:Button ID="BtnCrtacc" class="login-btn" runat="server" 
                                                        Text="Create Account" OnClick="BtnCrtacc_Click" />
                    
						
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
