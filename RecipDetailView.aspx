<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecipDetailView.aspx.cs" Inherits="Tahi.RecipDetailView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/ratingStyle.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    .css-flex-table {
display: flex;
width: 80%;
}

.css-flex-table-header,
.css-flex-table-body {
display: flex;
flex: 0 0 100%;
}

.css-flex-table,
.css-flex-table-body {
flex-wrap: wrap;
}

.css-flex-table-header div {
padding: 6px;
text-align: center;
font-weight: bold;
background-color: rgb(184, 208, 87);
    color: white;
}

.css-flex-table-header div,
.css-flex-table-body div {
flex: 0 1 100px;
padding: 0 6px;
border: .5px solid rgb(0, 0, 0);
box-sizing: border-box;
    }.css-flex-table-header div:nth-of-type(4n),
.css-flex-table-body div:nth-of-type(4n) {
flex: 0 1 calc(100% - 308px);
}
        .cc {
            
    background-color: #d6ddde;

        }

        

 </style>
      <main>
        <div class="main-wrapper pt-80">
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 order-2 order-lg-1">
                        <aside class="widget-area">
                            <!-- widget single item start -->
                            <div class="card card-profile widget-item p-0">
                                <div class="profile-banner">
                                    <figure class="profile-banner-small">
                                        <a href="profile.html">
                                            <img src="assets/images/banner/banner-small.jpg" alt="">
                                        </a>
                                        <a href="profile.html" class="profile-thumb-2">
                                            <img src="assets/images/profile/profile-midle-1.jpg" alt="">
                                        </a>
                                    </figure>
                                    <div class="profile-desc text-center">
                                        <h6 class="author"><a href="profile.html">Dimbel Lebmid</a></h6>
                                        <p>Any one can join with but Social network us if you want Any one can join with us if you want</p>
                                    </div>
                                </div>
                            </div>
                            <!-- widget single item start -->

                            <!-- widget single item start -->
                            <div class="card widget-item">
                                <h4 class="widget-title">Suggestions</h4>
                                <div class="widget-body">
                                    <ul class="like-page-list-wrapper">
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-33.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Travel The World</a></h3>
                                                <p class="list-subtitle"><a href="#">adventure</a></p>
                                            </div>
                                            <button class="like-button active">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-30.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Foodcort Nirala</a></h3>
                                                <p class="list-subtitle"><a href="#">food</a></p>
                                            </div>
                                            <button class="like-button">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-5.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Rolin Theitar</a></h3>
                                                <p class="list-subtitle"><a href="#">drama</a></p>
                                            </div>
                                            <button class="like-button">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-29.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Active Mind</a></h3>
                                                <p class="list-subtitle"><a href="#">fitness</a></p>
                                            </div>
                                            <button class="like-button">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <!-- widget single item end -->

                            <!-- widget single item start -->
                            <div class="card widget-item">
                                <h4 class="widget-title">latest top news</h4>
                                <div class="widget-body">
                                    <ul class="like-page-list-wrapper">
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-28.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">2 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-31.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">20 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-27.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">30 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-34.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">40 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-32.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">39 min ago</p>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <!-- widget single item end -->
                        </aside>
                    </div>

                    <div class="col-lg-6 order-1 order-lg-2">
                       

                        <!-- post status start -->
                        <div class="card">
                        <div id="postview" runat="server">
                            <div id="prof" runat="server">
                     
                                </div>
                            <div class='post-content' id="detail" runat="server">
                              
                            </div>
                            <div class='post-content'>
                                <h5>Ingredients</h5> <br />
                                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Name" SortExpression="ElTahiPostRecipIngrName">
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" Text='<%# Bind("ElTahiPostRecipIngrName") %>' ID="TextBox4"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" Text='<%# Bind("ElTahiPostRecipIngrName") %>' ID="Label4"></asp:Label>
                                            </ItemTemplate>

                                            <ControlStyle Width="100px"></ControlStyle>

                                            <FooterStyle Width="100px"></FooterStyle>

                                            <HeaderStyle Width="100px"></HeaderStyle>

                                            <ItemStyle Width="100px"></ItemStyle>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Details" SortExpression="Details">
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" Text='<%# Bind("ElTahiRecipeIngDetails") %>' ID="TextBox1"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" Text='<%# Bind("ElTahiRecipeIngDetails") %>' ID="Label1"></asp:Label>
                                            </ItemTemplate>

                                            <ControlStyle Width="100px"></ControlStyle>

                                            <FooterStyle Width="100px"></FooterStyle>

                                            <HeaderStyle Width="100px"></HeaderStyle>

                                            <ItemStyle Width="100px"></ItemStyle>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Wight" SortExpression="ElTahiPostRecipWight">
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" Text='<%# Bind("ElTahiPostRecipWight") %>' ID="TextBox2"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" Text='<%# Bind("ElTahiPostRecipWight") %>' ID="Label2"></asp:Label>
                                            </ItemTemplate>

                                            <ControlStyle Width="100px"></ControlStyle>

                                            <FooterStyle Width="100px"></FooterStyle>

                                            <HeaderStyle Width="100px"></HeaderStyle>

                                            <ItemStyle Width="100px"></ItemStyle>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Unit" SortExpression="ELTahiPostWightUnit">
                                            <EditItemTemplate>
                                                <asp:TextBox runat="server" Text='<%# Bind("ELTahiPostWightUnit") %>' ID="TextBox3"></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label runat="server" Text='<%# Bind("ELTahiPostWightUnit") %>' ID="Label3"></asp:Label>
                                            </ItemTemplate>

                                            <ControlStyle Width="100px"></ControlStyle>

                                            <FooterStyle Width="100px"></FooterStyle>

                                            <HeaderStyle Width="100px"></HeaderStyle>

                                            <ItemStyle Width="100px"></ItemStyle>
                                        </asp:TemplateField>

                                    </Columns>
                                        <EditRowStyle BackColor="#7C6F57"></EditRowStyle>

                                    <FooterStyle BackColor="#b8d057" Font-Bold="True"  ForeColor="White"></FooterStyle>

                                    <HeaderStyle BackColor="#b8d057" Font-Bold="True" ForeColor="White"></HeaderStyle>

                                    <PagerStyle HorizontalAlign="Center" BackColor="#666666" ForeColor="White"></PagerStyle>

                                    <RowStyle BackColor="#e3eaeb"></RowStyle>

                                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                                    <SortedAscendingCellStyle BackColor="#F8FAFA"></SortedAscendingCellStyle>

                                    <SortedAscendingHeaderStyle BackColor="#246B61"></SortedAscendingHeaderStyle>

                                    <SortedDescendingCellStyle BackColor="#D4DFE1"></SortedDescendingCellStyle>

                                    <SortedDescendingHeaderStyle BackColor="#15524A"></SortedDescendingHeaderStyle>
                                </asp:GridView>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                    
                                    SelectCommand="SELECT [ElTahiPostRecipIngrName], [ElTahiPostRecipWight], [ELTahiPostWightUnit], [ElTahiRecipeIngDetails] FROM [ElTahiPostRecipIngradient] WHERE ([ElTahiRecipePostID] = @ElTahiRecipePostID)">
                                    <SelectParameters>
                                        <asp:QueryStringParameter DefaultValue="0" Name="ElTahiRecipePostID" 
                                            QueryStringField="RecID" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </div>

                          






                            <div class='post-content' id="detail1" runat="server">
                              
                            </div>

                             <div class="post-content">
                            
                                 
                                    <div class="css-flex-table">

<div class="css-flex-table-header">
<div>Name</div>
 <div>details</div>
<div>weight</div>
<div>unit</div>

</div>

<div class="css-flex-table-body" runat="server" id="diving">

</div>
</div>
                                  
                              
                            
                            </div>
                               <div class='post-content'>
                                <h5>Rating</h5>

                                   <div class="row">
                                      <div class="rate" runat="server" id="alreadyrated"></div>
                                      <div class="rate" runat="server" id="rating">



                                        <asp:RadioButton ID="star5" runat="server" Text="5"  GroupName="rate"/>  

                                         <asp:RadioButton ID="star4" runat="server" Text="4" GroupName="rate"/>  


                                       <asp:RadioButton ID="star3" runat="server" Text="3" GroupName="rate"/>  


                                        <asp:RadioButton ID="star2" runat="server" Text="2" GroupName="rate"/>



                                        <asp:RadioButton ID="star1" runat="server" Text="1" GroupName="rate"/>

                                      </div>
                                      <asp:Button ID="ratebtn" Style="border: 1px solid #dddddd; border-radius: 1px;
                                                    color: #58595b;  padding-left: 5%; font-weight: bold;" 
                                          class="edit-btn" runat="server" Text="Add rate" OnClick="rating_Click" />
                                  </div>

                                   <%--<asp:Label ID="lblResult" runat="server" />--%>
 
                               
                               
                            </div>
                           
                            </div>
                        <!-- post status end -->
                            <div class="row">
                                <br />
                                <br />
                            </div>
                            <div id="divcom" class="card" >
                          <div class="row">
                              <asp:TextBox ID="Txtcom" Style="max-width:100%;min-width:100%;min-height:100px;" runat="server"></asp:TextBox>
                              <br />
                              <asp:Button ID="brnaddcom" Style="border: 1px solid #dddddd; border-radius: 1px;
                                            color: #58595b;  padding-left: 5%; font-weight: bold;" 
                                  class="edit-btn" runat="server" Text="Add Comment" OnClick="brnaddcom_Click" />
                          </div>
                      </div>
                          
                            <div class="row" id="divVcom" runat="server" >
                           
                            </div>
                        </div>
                    
                    <div class="col-lg-3 order-2">
                        <aside class="widget-area">
                            <!-- widget single item start -->
                            <div class="card widget-item">
                                <h4 class="widget-title">Recent Notifications</h4>
                                <div class="widget-body">
                                    <ul class="like-page-list-wrapper">
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-9.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">5 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-35.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">10 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-15.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">18 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-6.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">25 min ago</p>
                                            </div>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-34.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Any one can join with us if you want</a></h3>
                                                <p class="list-subtitle">39 min ago</p>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <!-- widget single item end -->

                            <!-- widget single item start -->
                          <%--  <div class="card widget-item">
                                <h4 class="widget-title">Advertizement</h4>
                                <div class="widget-body">
                                    <div class="add-thumb">
                                        <a href="#">
                                            <img src="assets/images/banner/advertise.jpg" alt="advertisement">
                                        </a>
                                    </div>
                                </div>
                            </div>--%>
                            <!-- widget single item end -->

                            <!-- widget single item start -->
                            <div class="card widget-item">
                                <h4 class="widget-title">Followers</h4>
                                <div class="widget-body">
                                    <ul class="like-page-list-wrapper">
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-33.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Ammeya Jakson</a></h3>
                                                <p class="list-subtitle"><a href="#">10 mutual</a></p>
                                            </div>
                                            <button class="like-button">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-30.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Jashon Muri</a></h3>
                                                <p class="list-subtitle"><a href="#">2 mutual</a></p>
                                            </div>
                                            <button class="like-button active">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-5.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Rolin Theitar</a></h3>
                                                <p class="list-subtitle"><a href="#">drama</a></p>
                                            </div>
                                            <button class="like-button">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                        <li class="unorder-list">
                                            <!-- profile picture end -->
                                            <div class="profile-thumb">
                                                <a href="#">
                                                    <figure class="profile-thumb-small">
                                                        <img src="assets/images/profile/profile-small-29.jpg" alt="profile picture">
                                                    </figure>
                                                </a>
                                            </div>
                                            <!-- profile picture end -->

                                            <div class="unorder-list-info">
                                                <h3 class="list-title"><a href="#">Active Mind</a></h3>
                                                <p class="list-subtitle"><a href="#">fitness</a></p>
                                            </div>
                                            <button class="like-button">
                                                <img class="heart" src="assets/images/icons/heart.png" alt="">
                                                <img class="heart-color" src="assets/images/icons/heart-color.png" alt="">
                                            </button>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <!-- widget single item end -->
                        </aside>
                    </div>
                </div>
            </div>
        </div>

    </main>
</asp:Content>
