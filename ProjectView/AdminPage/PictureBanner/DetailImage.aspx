<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/PictureBanner/PictureBanner_MasterPage.Master" AutoEventWireup="true" CodeBehind="DetailImage.aspx.cs" Inherits="ProjectView.AdminPage.PictureBanner.DetailImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li class="open"><a href="../Index.aspx">All Location        </a></li>
            <li><a href="NewLocation.aspx">Create Location   </a></li>
        </ul>
    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="PictureBanner_Index.aspx">All images     </a></li>
            <li><a href="NewImageBanner.aspx">New images  </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Booking </a>
        <ul>
            <li><a href="../Booking/AllBooking.aspx">All Booking </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Contact </a>
        <ul>
            <li class="open"><a href="../Contact/AllContact.aspx">All Contact </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Review  </a>
        <ul>
            <li class="open"><a href="../Index_review.aspx">All review</a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>User    </a>
        <ul>
            <li class="open"><a href="blank.html">All User</a></li>
            <li><a href="login.html">Create New User</a></li>
        </ul>
    </li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="name" runat="server"></asp:Label>
    </div>
    <img id="image" runat="server" />
</asp:Content>
