<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddRole.aspx.cs" Inherits="Tahi.AddRole" %>
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
                                    <h1 class="create-acc text-center">Add New Role</h1>
                                    <div class="signup-inner text-center" style="max-width: 100%;">
                                        <h3 class="title">Wellcome to ELTAHI Admin Dashboard</h3>
                                        <div class="signup-inner--form">
                                            <div class="row">
                                                <div class="col-12">
                                                    <asp:TextBox ID="txtRole" placeholder="Add Role" class="single-field" runat="server"></asp:TextBox>
                                                </div>
                                                 <div class="col-12">
                                                    <asp:TextBox ID="txtRoleDes" placeholder="Add Role Descraption" class="single-field" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="col-md-6">
                                                    <asp:CheckBox ID="chkflag" class="single-field" runat="server" />
                                                </div>
                                             
                                           
                                                <div class="col-12">
                                                    <asp:Button ID="btnsave" class="submit-btn" runat="server" Text="Button" 
                                                        OnClick="btnsave_Click" />
                                                   
                                                </div>
                                            </div>
                                            <%--<h6 class="terms-condition">I have read & accepted the <a href="#">terms of use</a></h6>--%>
                                        </div>
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
