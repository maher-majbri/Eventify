<%@ Page Title="" Language="C#" MasterPageFile="~/Member/SiteMember.master" AutoEventWireup="true" CodeFile="Events.aspx.cs" Inherits="Member_Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">

        <h1>Events</h1>

        <div class="row">

            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="odsEvents">
                <ItemTemplate>
                    <div class="col-md-4 mb-2">
                        <div class="card">
                            <div class="card-body">
                                <h2 class="text-primary"><%# Eval("Title") %></h2>
                                <p class="text-muted"><%# Eval("EventDate") %></p>
                                <p class="text-secondary"><%# Eval("TrainerName") %></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>




        </div>

        <asp:ObjectDataSource ID="odsEvents" runat="server" SelectMethod="Select" TypeName="EventData"></asp:ObjectDataSource>


    </div>
</asp:Content>

