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
                                    <div class="tab-pane fade" id="two">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex">
                                                <h6 class="author"><a href="profile.html">Mili Raoulin</a></h6>
                                                <div class="post-settings-bar">
                                                    <span></span>
                                                    <span></span>
                                                    <span></span>
                                                    <div class="post-settings arrow-shape">
                                                        <ul>
                                                            <li><button>copy link to adda</button></li>
                                                            <li><button>edit post</button></li>
                                                            <li><button>embed adda</button></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                        </div>
                                    </div>
                                    <div class="tab-pane fade" id="three">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex">
                                                <h6 class="author"><a href="profile.html">Mili Raoulin</a></h6>
                                                <div class="post-settings-bar">
                                                    <span></span>
                                                    <span></span>
                                                    <span></span>
                                                    <div class="post-settings arrow-shape">
                                                        <ul>
                                                            <li><button>copy link to adda</button></li>
                                                            <li><button>edit post</button></li>
                                                            <li><button>embed adda</button></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                        </div>
                                    </div>
                                    <div class="tab-pane fade" id="four">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex">
                                                <h6 class="author"><a href="profile.html">Mili Raoulin</a></h6>
                                                <div class="post-settings-bar">
                                                    <span></span>
                                                    <span></span>
                                                    <span></span>
                                                    <div class="post-settings arrow-shape">
                                                        <ul>
                                                            <li><button>copy link to adda</button></li>
                                                            <li><button>edit post</button></li>
                                                            <li><button>embed adda</button></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                        </div>
                                    </div>
                                    <div class="tab-pane fade" id="five">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex">
                                                <h6 class="author"><a href="profile.html">Mili Raoulin</a></h6>
                                                <div class="post-settings-bar">
                                                    <span></span>
                                                    <span></span>
                                                    <span></span>
                                                    <div class="post-settings arrow-shape">
                                                        <ul>
                                                            <li><button>copy link to adda</button></li>
                                                            <li><button>edit post</button></li>
                                                            <li><button>embed adda</button></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                            <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                        </div>
                                    </div>
                                    <div class="tab-pane fade" id="six">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex">
                                                <h6 class="author"><a href="profile.html">Contact</a></h6>
                                                <div class="post-settings-bar">
                                                    <span></span>
                                                    <span></span>
                                                    <span></span>
                                                    <div class="post-settings arrow-shape">
                                                        <ul>
                                                         <%--   <li><button>copy link to adda</button></li>
                                                            <li><button>edit post</button></li>
                                                            <li><button>embed adda</button></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                            </div>
                                            <p>Mobile</p>
                                            <p>Email</p>
                                      </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- about author details start -->

            <!-- photo section start -->
            <div class="photo-section">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="content-box">
                                <h5 class="content-title">My Posts</h5>
                                <div class="content-body">
                                    <div class="row mt--30">
                                        <div class="col-sm-6 col-md-4">
                                            <div class="photo-group">
                                                <div class="gallery-toggle">
                                                    <div class="d-none product-thumb-large-view">
                                                        <img src="assets/images/photos/photo-1.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-3.jpg" alt="Photo Gallery">
                                                    </div>
                                                    <div class="gallery-overlay">
                                                        <img src="assets/images/photos/photo-1.jpg" alt="Photo Gallery">
                                                        <div class="view-icon"></div>
                                                    </div>
                                                    <div class="photo-gallery-caption">
                                                        <h3 class="photos-caption">office hangout (06)</h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6 col-md-4">
                                            <div class="photo-group">
                                                <div class="gallery-toggle">
                                                    <div class="d-none product-thumb-large-view">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-5.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-6.jpg" alt="Photo Gallery">
                                                    </div>
                                                    <div class="gallery-overlay">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                        <div class="view-icon"></div>
                                                    </div>
                                                    <div class="photo-gallery-caption">
                                                        <h3 class="photos-caption">dream land (12)</h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6 col-md-4">
                                            <div class="photo-group">
                                                <div class="gallery-toggle">
                                                    <div class="d-none product-thumb-large-view">
                                                        <img src="assets/images/photos/photo-3.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-6.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                    </div>
                                                    <div class="gallery-overlay">
                                                        <img src="assets/images/photos/photo-3.jpg" alt="Photo Gallery">
                                                        <div class="view-icon"></div>
                                                    </div>
                                                    <div class="photo-gallery-caption">
                                                        <h3 class="photos-caption">travel zone (34)</h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6 col-md-4">
                                            <div class="photo-group">
                                                <div class="gallery-toggle">
                                                    <div class="d-none product-thumb-large-view">
                                                        <img src="assets/images/photos/photo-4.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-1.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                    </div>
                                                    <div class="gallery-overlay">
                                                        <img src="assets/images/photos/photo-4.jpg" alt="Photo Gallery">
                                                        <div class="view-icon"></div>
                                                    </div>
                                                    <div class="photo-gallery-caption">
                                                        <h3 class="photos-caption">pure nature (17)</h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6 col-md-4">
                                            <div class="photo-group">
                                                <div class="gallery-toggle">
                                                    <div class="d-none product-thumb-large-view">
                                                        <img src="assets/images/photos/photo-5.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-4.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                    </div>
                                                    <div class="gallery-overlay">
                                                        <img src="assets/images/photos/photo-5.jpg" alt="Photo Gallery">
                                                        <div class="view-icon"></div>
                                                    </div>
                                                    <div class="photo-gallery-caption">
                                                        <h3 class="photos-caption">family tour (37)</h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6 col-md-4">
                                            <div class="photo-group">
                                                <div class="gallery-toggle">
                                                    <div class="d-none product-thumb-large-view">
                                                        <img src="assets/images/photos/photo-6.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-3.jpg" alt="Photo Gallery">
                                                        <img src="assets/images/photos/photo-2.jpg" alt="Photo Gallery">
                                                    </div>
                                                    <div class="gallery-overlay">
                                                        <img src="assets/images/photos/photo-6.jpg" alt="Photo Gallery">
                                                        <div class="view-icon"></div>
                                                    </div>
                                                    <div class="photo-gallery-caption">
                                                        <h3 class="photos-caption">chill zone (06)</h3>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-12">
                                            <div class="load-more text-center">
                                                <button class="load-more-btn">load more</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- photo section end -->

            <!-- photo section start -->
         <%--   <div class="friends-section">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="content-box">
                                <h5 class="content-title">friends</h5>
                                <div class="content-body">
                                    <div class="row mt--20">
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-1.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">Kate Midiltoin</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-4.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">Jon Wileyam</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-7.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">william henry</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-22.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">Kate Midiltoin</a></h6>
                                                    <button class="add-frnd">friend request sent</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-10.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">Omio Morganik</a></h6>
                                                    <button class="add-frnd">friend request sent</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-13.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">william henry</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-18.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">erik jonson</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-25.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">peter looks</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-16.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">jhon doe</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-12.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">william henry</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-9.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">william henry</a></h6>
                                                    <button class="add-frnd">friend request sent</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-17.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">musa kollins</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-11.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">petter jhon</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-20.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">henry william</a></h6>
                                                    <button class="add-frnd">friend request sent</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-32.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">cristian paul</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-31.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">willson merry</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-29.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">jhonsina boss</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-26.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">william jowel</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-19.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">ashim pual</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-lg-3 col-sm-6">
                                            <div class="friend-list-view">
                                                <!-- profile picture end -->
                                                <div class="profile-thumb">
                                                    <a href="#">
                                                        <figure class="profile-thumb-middle">
                                                            <img src="assets/images/profile/profile-small-23.jpg" alt="profile picture">
                                                        </figure>
                                                    </a>
                                                </div>
                                                <!-- profile picture end -->

                                                <div class="posted-author">
                                                    <h6 class="author"><a href="profile.html">Barak Obama</a></h6>
                                                    <button class="add-frnd">add friend</button>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-12">
                                            <div class="load-more text-center">
                                                <button class="load-more-btn">load more</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           --%> <!-- photo section end -->

            <!-- favorite book section start -->
          <%--  <div class="faborite-books">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="content-box">
                                <h5 class="content-title">favorite books</h5>
                                <div class="content-body">
                                    <div class="row favorite-item-carousel">
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/books/book-1.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/books/book-2.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/books/book-3.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/books/book-4.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/books/book-5.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/books/book-6.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-12">
                                            <div class="load-more text-center">
                                                <button class="load-more-btn">load more</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            --%><!-- favorite book section end -->

            <!-- favorite book section start -->
         <%--   <div class="faborite-books">
                <div class="container">
                    <div class="row">
                        <div class="col-12">
                            <div class="content-box">
                                <h5 class="content-title">favorite sports</h5>
                                <div class="content-body">
                                    <div class="row favorite-item-carousel">
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/sports/sport-1.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/sports/sport-2.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/sports/sport-3.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/sports/sport-4.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/sports/sport-5.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                        <div class="col">
                                            <figure class="favorite-item">
                                                <a href="#">
                                                    <img src="assets/images/sports/sport-6.jpg" alt="">
                                                </a>
                                            </figure>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-12">
                                            <div class="load-more text-center">
                                                <button class="load-more-btn">load more</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           --%> <!-- favorite book section end -->
        </div>--%>

    </main>

    <!-- Scroll to top start -->
    <div class="scroll-top not-visible">
        <i class="bi bi-finger-index"></i>
    </div>
    <!-- Scroll to Top End -->
</asp:Content>
