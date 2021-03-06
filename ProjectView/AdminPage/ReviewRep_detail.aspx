﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin_masterPage.Master" AutoEventWireup="true" CodeBehind="ReviewRep_detail.aspx.cs" Inherits="ProjectView.AdminPage.ReviewRep_detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li class="open"><a href="Index.aspx">All Location</a></li>
            <li><a href="Location/NewLocation.aspx">Create Location</a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="PictureBanner/PictureBanner_Index.aspx">All images     </a></li>
            <li><a href="PictureBanner/NewImageBanner.aspx">New images  </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Booking</a>
        <ul>
            <li class="open"><a href="Booking/AllBooking.aspx">All Booking</a></li>
        </ul>
    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Review</a>
        <ul>
            <li class="open"><a href="Index_review.aspx">All review</a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>User    </a>
        <ul>
            <li class="open"><a href="User/User_index.aspx">All User</a></li>
            <li><a href="User/CreateUser.aspx">Create New User</a></li>
        </ul>
    </li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">Information of Booking</div>
        <div class="panel-body">
            <div class="form-group">
                <div class="form-group">
                    <label>Username :</label>
                    <input readonly="true" style="border: none" id="txtname" runat="server" />
                </div>
                <div class="form-group">
                    <label>Message :</label>
                    <textarea readonly="true" id="txtMesage" runat="server" style="background-color: lavender" class="form-control" rows="20"></textarea>
                </div>
            </div>

        </div>
    </div>

    <div class="panel panel-default">
        <div class="panel-heading">Reply</div>

        <div class="panel-body">
            <div class="form-group">
                <div class="form-group">
                    <label>From :</label>
                    <input readonly="true" style="border: none" id="txtEmailEnd" runat="server" />
                </div>
                
                        <div class="form-group">
                            <label>Message :</label>
                            <textarea id="txtREPLY" runat="server" style="background-color: aliceblue" class="form-control" rows="20"><%#Eval("Content") %></textarea>
                        </div>
                <asp:Label ID="txtError" Text="Message is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>
</asp:Content>
