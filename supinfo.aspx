<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOther.Master" AutoEventWireup="true" CodeBehind="supinfo.aspx.cs" Inherits="Tahi.supinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <main style="margin-top: -50px;">
        <div class="main-wrapper pt-80">


            <div class="container">
                <div class="row">
                    <div class="col-lg-10 order-6 order-lg-2" style="direction: ltr; align-items: left;">
                        <div class="card widget-item">

                            <h4 class="widget-title">Please Complate Your Info<asp:Label ID="Label1" runat="server"
                                Text=""
                                Visible="False"></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text=""
                                    Visible="False"></asp:Label>
                            </h4>

                            <div class="widget-body">
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                                 
                                             <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="lbljtitle" runat="server" Text="Name*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex;">
                                                <asp:TextBox ID="TxtName" placeholder="Add Name" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B"></asp:TextBox>
                                            </div>
                                      </div>
                                </div>
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                                 
                                            <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">

                                                <asp:Label ID="lblphone" runat="server" Text="Phone*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex;">


                                                <asp:TextBox ID="txtPhone" placeholder="Add Phone" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B" ></asp:TextBox>

                                            </div>
                                     </div>
                                </div>
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                                  
                                             <div class="col-12" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="Lbltag" runat="server" Text="Tagline*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:TextBox ID="Txttag" placeholder="Add Tagline" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 80%; max-width: 100%;min-height:80px"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B" TextMode="MultiLine"></asp:TextBox>
                                            </div>
                                     </div>
                                </div>
                                 <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                                
                                            <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="LblWebSite" runat="server" Text="WebSite URL*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex;">

                                                <asp:TextBox ID="TxtWebSite" placeholder="Add WebSite URL" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B"></asp:TextBox>
                                            </div>
                                    </div>
                                    </div>
                                 

                         
                               
                                            

                             


                                <%-- over View --%>
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 5%">
                                    <div class="col-12">
                                        <div class="row row-5">
                                            <asp:Label ID="lblsteps" runat="server" Text="Description*"></asp:Label>

                                        </div>
                                        <div class="row row-5">
                                            <asp:TextBox ID="txtarea" name="share" class="share-field-big custom-scroll" Style="border: 3px solid #b7cf57;"
                                                placeholder="Add Description."
                                                runat="server" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                     

                                    </div>
                                </div>
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                                  
                                             <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="lblIndustry" runat="server" Text="Industry*"></asp:Label>
                                            </div>
                                            <div class="row row-5" style="display: flex;">

                                                <asp:TextBox ID="txtIndustry" placeholder="Add Industry" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B"></asp:TextBox>
                                            </div>
                                      </div>

                                </div>

                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                              
                                             <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="lblcompsize" runat="server" Text="Company Size*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex;">
                                                <asp:DropDownList ID="ddlcompsize" Style="background-color: #58595b; color: #b8d057;
                                            font-weight: bold; width: 80%;"
                                             CssClass="dd-colo" runat="server">
                                                    <asp:ListItem>1-50 employees</asp:ListItem>
                                                    <asp:ListItem>51-200 employees</asp:ListItem>
                                                    <asp:ListItem>201-500 employees</asp:ListItem>
                                                    <asp:ListItem>501-1000 employees</asp:ListItem>
                                                    <asp:ListItem>+ 1001 employees</asp:ListItem>
                                                </asp:DropDownList>
                                               
                                            </div>
                                     </div>
                                </div>
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">

                                   
                                           <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="lblwptype" runat="server" Text="Company Type*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex;">
                                                <asp:TextBox ID="txtCompanyType" placeholder="Add Company Type" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B"></asp:TextBox>
                                            </div>
                                     </div>
                                </div>

                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">

                                 
                                          <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                <asp:Label ID="LblYe" runat="server" Text="Year founded*"></asp:Label>

                                            </div>
                                            <div class="row row-5" style="display: flex;">
                                                <asp:TextBox ID="TxtYear" placeholder="Add Year founded" class="single-field "
                                                    Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                    color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                    runat="server" Font-Bold="True" ForeColor="#58595B"></asp:TextBox>
                                            </div>
                                     </div>
                                </div>
                                <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">

                                     <div class="col-12" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                        <asp:Label ID="lblspe" runat="server" Text="Specialities*"></asp:Label>

                                    </div>
                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                        <asp:TextBox ID="txtspe" placeholder="Add Specialities" class="single-field "
                                            Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                            color: #58595b; height: 41px; padding-left: 5%; width: 80%; max-width: 100%;
                                            min-height: 80px"
                                            runat="server" Font-Bold="True" ForeColor="#58595B" TextMode="MultiLine"></asp:TextBox>
                                    </div>
</div>
                                </div>


                                <%-- location --%>
                                                                        <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 3%">
                                           <div class="col-6" >
                                                
                                                    <div class="row row-5" style="display: flex; margin-bottom: 5%; margin-left: 5%;">
                                                        <asp:Label ID="lbljobloc" runat="server" Text="Location*"></asp:Label>

                                                    </div>
                                                    <div class="row row-5" style="display: flex;">

                                                        <asp:TextBox ID="txtjobloc" placeholder="Add Location" class="single-field "
                                                            Style="color: #58595B; font-weight: bold; border: 1px solid #dddddd; border-radius: 10px;
                                                            color: #58595b; height: 41px; padding-left: 5%; width: 85%; max-width: 100%;"
                                                            runat="server" Font-Bold="True" ForeColor="#58595B"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                          

                                <%--  --%>
                          <%-- End Recipe --%>

                        <div class="row row-5" style="margin-bottom: 5%; margin-top: 5%; margin-left: 5%">
                            <div class="col-12">
                                <asp:Button ID="btncancel" class="post-share-btn" data-dismiss="modal" runat="server"
                                    Text="cancel" Style="border: 1px solid #dddddd; border-radius: 10px; color: #58595b;
                                    height: 41px; padding-left: 5%; font-weight: bold" />
                                <asp:Button ID="btnpost" Style="border: 1px solid #dddddd; border-radius: 10px; color: #58595b;
                                    height: 41px; padding-left: 5%; font-weight: bold"
                                    class="post-share-btn"
                                    runat="server" Text="post" OnClick="btnpost_Click1" />


                            </div>

                        </div>
                               </div>
                    </div>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                </div>
            </div>
            <%-- End Recipes Section --%>
        </div>
           </div>
                           
                       
    </main>


</asp:Content>
