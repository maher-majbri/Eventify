<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RegisterMember.aspx.cs" Inherits="RegisterMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="container row">
    <div class="col-md-6 col-sm-8 col-xs-10 mx-auto">


    <h1 class="text-center title-text my-3">Register with us</h1>
    <p class="text-center my-3">please type your info.</p>

    <div class="mb-3 row">
        <label for="txtName" class="col-sm-3 col-form-label">Name:</label>
        <div class="col-sm-9">
            <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="mb-3 row">
        <label for="txtEmail" class="col-sm-3 col-form-label">Email:</label>
        <div class="col-sm-9">
            <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="mb-3 row">
        <label for="txtPassword" class="col-sm-3 col-form-label">Password:</label>
        <div class="col-sm-9">
            <asp:TextBox ID="txtPassword" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="mb-3 row">
        <label for="txtPhone" class="col-sm-3 col-form-label">Phone:</label>
        <div class="col-sm-9">
            <asp:TextBox ID="txtPhone" runat="server" class="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="mb-3 row">
        <label class="col-sm-3 col-form-label"></label>
        <div class="col-sm-9">
            <asp:Button ID="btnRegister" CssClass="btn btn-success m-4 w-100 mx-auto" runat="server" Text="Register" />
        </div>
    </div>


    </div>
</div>

</asp:Content>

