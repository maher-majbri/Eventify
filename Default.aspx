<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section id="hero" class="text-muted p-5 ">

</section>
<section id="latest-events" class="text-muted p-5 ">
    <div class="container">
        <h1 class="text-center title-text">Latest Events</h1>
        <div class="row text-center">
            <div class="col-md-4 p-5">
                <h3>New Books</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore</p>
                <h6>Trainer Name</h6>
                <span>d7/4/2023</span>
            </div>
            <div class="col-md-4 p-5">
                <h3>Old Books</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore</p>
                <h6>Trainer Name</h6>
                <span>d7/4/2023</span>
            </div>
            <div class="col-md-4 p-5">
                <h3>Reading</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore</p>
                    <h6>Trainer Name</h6>
                <span>d7/4/2023</span>
            </div>
        </div>
    </div>
</section>
<section id="member" class="text-muted bg-light p-5 text-center">
    <p class="m-5 display-3">Don't miss great events!</p>
    <a href="RegisterMember.aspx" class="btn btn-lg px-5 btn-success mb-4">Join Now</a>
</section>
<section id="trainer" class="text-muted bg-secondary p-5 text-center">
    <p class="m-5 display-3 text-white">Share knowledge!</p>
    <a href="RegisterTrainer.aspx" class="btn btn-lg px-5 btn-light mb-4">Join Now</a>

</section>
</asp:Content>

