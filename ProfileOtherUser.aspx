<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProfileOtherUser.aspx.cs" Inherits="Tahi.profileOtherUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

        <link rel="stylesheet" href="assets/css/components/buttonStyle.css">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
            <!-- profile menu area end -->
     

           <!-- sendary menu start -->
         
            <!-- sendary menu end -->

            <!-- about author details start -->
            <div class="about-author-details">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-3">
                            <div class="card widget-item">
                                <div class="about-me">
                                    <ul class="nav flex-column about-author-menu">
                                        <li><a href="#one" data-toggle="tab" class="active">contact info</a></li>
                                        <li><a href="#two" data-toggle="tab">Expert</a></li>
                                        <li><a href="#three" data-toggle="tab">Education</a></li>
                                        <li><a href="#four" data-toggle="tab">licenses & certification</a></li>
                                        <li><a href="#five" data-toggle="tab">skills</a></li>
                                        <li><a href="#six" data-toggle="tab">Courses</a></li>
                                         <li><a href="#seven" data-toggle="tab">languages</a></li>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-9">

                            <center>
                                <asp:Button ID="followBtn" class="button" runat="server" Text="Follow" OnClick="followClick"
                                                />
                            </center>

                            <center>
                                <asp:Button ID="unFollowBtn" class="button" runat="server" Text="Followed" OnClick="unFollowClick"
                                                />
                            </center>
                         
                                            
                                  
                            <div class="about-description">
                                
                                <div class="tab-content">

                                    
                                    <div class="tab-pane fade active show" id="one">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex" id="persdetail" runat="server">
                                         
                                            </div>
                                        </div>
                                    </div>
                                 </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                            
                                   
                                   
                                    
                                   

    <!-- Scroll to top start -->
    <div class="scroll-top not-visible">
        <i class="bi bi-finger-index"></i>
    </div>
    <!-- Scroll to Top End -->
</asp:Content>
