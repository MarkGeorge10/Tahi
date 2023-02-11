<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddType.aspx.cs" Inherits="Tahi.AddType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <main>
        <div class="main-wrapper pb-0 mb-0">
            <div class="timeline-wrapper">
                <div class="timeline-page-wrapper">
                    <div class="container-fluid p-0">
                        <div class="row no-gutters">
                    
                            <div class="col-lg-10 order-1 order-lg-2 d-flex align-items-center justify-content-center">
                                <div class="signup-form-wrapper" style="padding-top: 50px;">
                                    <h1 class="create-acc text-center">Add New Type</h1>
                                    <div class="signup-inner text-center" style="max-width: 100%;">
                                        <h3 class="title">Wellcome to ELTAHI Admin Dashboard</h3>
                                        <form class="signup-inner--form">
                                            <div class="row">
                                                 <div class="col-12">
                                                    <asp:TextBox ID="txttype" placeholder="Add type" class="single-field" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:CheckBox ID="chkflag" class="single-field" runat="server" />
                                                </div>
                                            
                                                <div class="col-md-6">
                                                    <asp:DropDownList ID="DropDownList1" class="nice-select" runat="server" DataSourceID="SqlDataSource1"
                                                        DataTextField="ElTahiStatus" DataValueField="ElTahiStatusID"></asp:DropDownList>

                                                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:db_a8d12b_amahmyConnectionString %>'
                                                        SelectCommand="SELECT [ElTahiStatus], [ElTahiStatusID] FROM [ElTahiStatus]">
                                                    </asp:SqlDataSource>
                                                </div>
                                      
                                         
                                                <div class="col-12">
                                                     <asp:Button ID="btnsave" class="submit-btn" runat="server" Text="Button" 
                                                         OnClick="btnsave_Click"   />
                                                 
                                                </div>
                                            </div>
                                            <%--<h6 class="terms-condition">I have read & accepted the <a href="#">terms of use</a></h6>--%>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                      </div>
        </div>
    </main>

</asp:Content>
