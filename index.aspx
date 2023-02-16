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
    <!-- google fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,300i,400,400i,500,500i,700,700i,900" rel="stylesheet">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="assets/css/vendor/bootstrap.min.css">
    <!-- Icon Font CSS -->
    <link rel="stylesheet" href="assets/css/vendor/bicon.min.css">
    <!-- Flat Icon CSS -->
    <link rel="stylesheet" href="assets/css/vendor/flaticon.css">
    <!-- audio & video player CSS -->
    <link rel="stylesheet" href="assets/css/plugins/plyr.css">
    <!-- Slick CSS -->
    <link rel="stylesheet" href="assets/css/plugins/slick.min.css">
    <!-- nice-select CSS -->
    <link rel="stylesheet" href="assets/css/plugins/nice-select.css">
    <!-- perfect scrollbar css -->
    <link rel="stylesheet" href="assets/css/plugins/perfect-scrollbar.css">
    <!-- light gallery css -->
    <link rel="stylesheet" href="assets/css/plugins/lightgallery.min.css">
    <!-- Main Style CSS -->
    <link rel="stylesheet" href="assets/css/style.css">


</head>
<body>
     <main>
         <form id="form2" runat="server">
        <div class="main-wrapper pb-0 mb-0">
            <div class="timeline-wrapper">
                <div class="timeline-header">
                    <div class="container-fluid p-0">
                        <div class="row no-gutters align-items-center">
                            <div class="col-lg-6">
                                <div class="timeline-logo-area d-flex align-items-center">
                                    <div class="timeline-logo col-lg-4">
                                        <a href="index.html">
                                            <img src="assets/images/logo/logo.png" alt="timeline logo">
                                        </a>
                                    </div>
                                    <div class="timeline-tagline">
                                        <h6 class="tagline">It’s helps you to connect and share with the people in your life</h6>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="login-area">
                                    <div class="row align-items-center">
                                        <div class="col-12 col-sm">
                                            <asp:TextBox ID="Txtuslog" runat="server" placeholder="Email" class="single-field" TextMode="Email"></asp:TextBox>
                                            <%--<input type="text" placeholder="Email or Userame" class="single-field">--%>
                                        </div>
                                        <div class="col-12 col-sm">
                                            <asp:TextBox ID="Txtlogpass" placeholder="Password" class="single-field" runat="server" TextMode="Password"></asp:TextBox>
                                            <%--<input type="password" placeholder="Password" class="single-field">--%>
                                        </div>
                                        <div class="col-12 col-sm-auto">
                                            <asp:Button ID="Btnlogin" class="login-btn" runat="server" Text="Login" 
                                                OnClick="Btnlogin_Click" />
                                            <%--<button class="login-btn">Login</button>--%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="timeline-page-wrapper">
                    <div class="container-fluid p-0">
                        <div class="row no-gutters">
                            <div class="col-lg-6 order-2 order-lg-1">
                                <div class="timeline-bg-content bg-img" data-bg="assets/images/timeline/adda-timeline.jpg">
                                    <%--<h3 class="timeline-bg-title">Let’s see what’s happening to you and your world. Welcome in ELTAHI.</h3>--%>
                                </div>
                            </div>
                            <div class="col-lg-6 order-1 order-lg-2 d-flex align-items-center justify-content-center">
                                <div class="signup-form-wrapper">
                                    <%--<h1 class="create-acc text-center">Create An Account</h1>--%>
                                    <div class="signup-inner text-center">
                                        <h3 class="title">Create An Account</h3>
                                        <div class="signup-inner--form" >

                                            <div class="row">
                                                <div class="col-12">
                                                    <asp:DropDownList ID="DdlTyp" class="nice-select" runat="server" DataSourceID="SqlDataSource2"
                                                        DataTextField="ElTahiType" DataValueField="ElTahiTypesID" 
                                                        OnSelectedIndexChanged="DdlTyp_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                                 
                                                    <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                                        SelectCommand="SELECT [ElTahiTypesID], [ElTahiType] FROM [ElTahiType]"></asp:SqlDataSource>
                                                </div>
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
                                                <div class="col-12">
                                                    <asp:Button ID="BtnCrtacc" class="submit-btn" runat="server" 
                                                        Text="Create Account" OnClick="BtnCrtacc_Click" />
                                                </div>
                                            </div>
                                            <h6 class="terms-condition">I have read & accepted the <a href="#">terms of use</a></h6>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
   </form>
              </main>

    <!-- JS
============================================ -->

    <!-- Modernizer JS -->
    <script src="assets/js/vendor/modernizr-3.6.0.min.js"></script>
    <!-- jQuery JS -->
    <script src="assets/js/vendor/jquery-3.3.1.min.js"></script>
    <!-- Popper JS -->
    <script src="assets/js/vendor/popper.min.js"></script>
    <!-- Bootstrap JS -->
    <script src="assets/js/vendor/bootstrap.min.js"></script>
    <!-- Slick Slider JS -->
    <script src="assets/js/plugins/slick.min.js"></script>
    <!-- nice select JS -->
    <script src="assets/js/plugins/nice-select.min.js"></script>
    <!-- audio video player JS -->
    <script src="assets/js/plugins/plyr.min.js"></script>
    <!-- perfect scrollbar js -->
    <script src="assets/js/plugins/perfect-scrollbar.min.js"></script>
    <!-- light gallery js -->
    <script src="assets/js/plugins/lightgallery-all.min.js"></script>
    <!-- image loaded js -->
    <script src="assets/js/plugins/imagesloaded.pkgd.min.js"></script>
    <!-- isotope filter js -->
    <script src="assets/js/plugins/isotope.pkgd.min.js"></script>
    <!-- Main JS -->
    <script src="assets/js/main.js"></script>
 <%--   <form id="form1" runat="server">
    <div>
    
    </div>
    </form>--%>
</body>
</html>
