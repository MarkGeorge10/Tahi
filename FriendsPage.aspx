<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FriendsPage.aspx.cs" Inherits="Tahi.FriendsPage"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
      <main style="margin-top: -50px;">
        <div class="main-wrapper pt-80">
            <div class="container">
                <center>
                     <div class="col-lg-8 order-1 order-lg-2">
                      

                        <!-- post status start -->
                        <div id="postview" runat="server">

                            <div class='card' hidden>
                                <div class='post-meta'>
                                    <div class='post-title d-flex align-items-center'>
                                    <div class='profile-thumb'><a href = '#' >
                                        <figure class='profile-thumb-middle'>
                                            <img src = 'assets/images/profile/" + Url + "' alt='profile picture'/>

                                        </figure></a>

                                    </div>
                                    <div class='posted-author'>
                                        <h6 class='author'><a href = '#'> " + Name + " </a></h6 >

                                    </div>
                                    </div>
                              </div>
                            </div>


                        <!-- post status end -->

                      

                    </div>


                    
                </div>
                      </div>

                </center>
                 
                </div>    
        </div>

    </main>

</asp:Content>
