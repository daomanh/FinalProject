<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/User/User_MasterPage.Master" AutoEventWireup="true" CodeBehind="UserDetail.aspx.cs" Inherits="ProjectView.AdminPage.User.UserDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li class="open"><a href="../Index.aspx">All Location        </a></li>
            <li><a href="NewLocation.aspx">Create Location   </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="../PictureBanner/PictureBanner_Index.aspx">All images     </a></li>
            <li><a href="../PictureBanner/NewImageBanner.aspx">New images  </a></li>
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
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>User    </a>
        <ul>
            <li class="open"><a href="User_index.aspx">All User</a></li>
            <li><a href="CreateUser.aspx">Create New User</a></li>
        </ul>
    </li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="page-title">User : 
        <asp:Label runat="server" ID="un"></asp:Label>
    </h2>

    <!-- Zero Configuration Table -->
    <div class="panel panel-default">
        <div class="panel-heading">Information User</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">

                        <label>Username :</label>
                        <input  class="form-control" readonly id="txtUsername" runat="server" />
                    </div>

                    <div class="form-group">
                        <label>Fullname :</label>
                        <input  class="form-control" readonly id="txtFullname" runat="server" />
                    </div>

                    <div class="form-group">
                        <label>PhoneNumber :</label>
                        <input  class="form-control" readonly id="txtPhoneNumber" runat="server" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Gender :</label>
                        <input  class="form-control" readonly id="txtGender" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Email :</label>
                        <input  class="form-control" readonly id="txtEmail" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Addres :</label> 
                        <input  class="form-control" readonly id="txtAddres" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Role :</label>
                        <input class="form-control" readonly id="txtRole" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
