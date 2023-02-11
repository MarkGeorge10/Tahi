<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOther.Master" AutoEventWireup="true" CodeBehind="ProfileX.aspx.cs" Inherits="Tahi.ProfileX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                                        <li><a href="#two" data-toggle="tab">Overview</a></li>
                                        <li><a href="#three" data-toggle="tab">Location</a></li>
                                 <%--       <li><a href="#four" data-toggle="tab">licenses & certification</a></li>
                                        <li><a href="#five" data-toggle="tab">skills</a></li>
                                        <li><a href="#six" data-toggle="tab">Courses</a></li>
                                         <li><a href="#seven" data-toggle="tab">languages</a></li>--%>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-9">
                            <div class="about-description">
                                <div class="tab-content">
                                    <div class="tab-pane fade active show" id="one">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex" id="persdetail" runat="server">
                                         
                                        </div>
                                    </div>
                                       
                                    <div class="tab-pane fade" id="two">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex" id="twoOver" runat="server">
                                         
                                            </div>
                                     </div>
                                    
                                    <div class="tab-pane fade" id="three">
                                        <div class="work-zone">
                                            <div class="author-desc-title d-flex" id="threeloc" runat="server">
                                        
                                            </div>
                                    </div>
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
        
        <!-- favorite book section end -->
        </div>


    <!-- Scroll to top start -->
    <div class="scroll-top not-visible">
        <i class="bi bi-finger-index"></i>
    </div>
    <!-- Scroll to Top End -->


</asp:Content>
