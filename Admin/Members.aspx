<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/SiteAdmin.master" AutoEventWireup="true" CodeFile="Members.aspx.cs" Inherits="Admin_Members" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <asp:TextBox ID="txtID" runat="server" Visible="false">*</asp:TextBox>

    <div class="container">

        <h1 class="text-secondary m-5 text-center">Members</h1>
        <hr />
        <div class="row g-3">
            <div class="col-md-6">
                <label for="txtName" class="form-label">Member name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtName" CssClass="text-danger m-4" Text="*"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-6">
                <label for="txtEmail" class="form-label">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)" Text="*"></asp:RegularExpressionValidator>
            </div>
            <div class="col-md-6">
                <label for="txtPassword" class="form-label">Password:</label>
                <asp:TextBox ID="txtPassword"  runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
                <label for="txtPhone" class="form-label">Phone:</label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>

        <div class="form-group row m-5">
            <div class="col-md-4">
            </div>
            <div class="col-md-8 mb-5">
                <asp:Button ID="btnInsert" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="btnInsert_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Modify" CssClass="btn btn-success" Enabled="false" OnClick="btnUpdate_Click" />
                <asp:button id="btnDelete" runat="server" text="Disable" cssclass="btn btn-danger" Enabled="false" onclick="btnDelete_Click" onclientclick="return confirm('Are you sure that you want to delete this member?');" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-info" OnClick="btnClear_Click" />
            </div>
        </div>

     <div class="mb-3 row text-center">
        <asp:Panel ID="pnlMessageError" runat="server" CssClass="alert alert-danger" Visible="false">
            <asp:Label ID="lblMessageError" runat="server" Text=""></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlMessageOk" runat="server" CssClass="alert alert-success" Visible="false">
            <asp:Label ID="lblMessageOk" runat="server" Text=""></asp:Label>
        </asp:Panel>
    </div>

        <hr class="my-5" />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsMembers" Width="100%" CssClass="table table-hover table-bordered">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Member Name" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="~/Admin/Members.aspx?id={0}" HeaderText="Edit" NavigateUrl="~/Admin/Members.aspx" Text="Edit" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsMembers" runat="server" SelectMethod="Select" TypeName="MemberData"></asp:ObjectDataSource>





    </div>

</asp:Content>

