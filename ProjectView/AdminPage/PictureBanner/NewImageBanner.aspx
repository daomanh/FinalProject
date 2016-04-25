<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/PictureBanner/PictureBanner_MasterPage.Master" AutoEventWireup="true" CodeBehind="NewImageBanner.aspx.cs" Inherits="ProjectView.AdminPage.PictureBanner.NewImageBanner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li class="open"><a href="../Index.aspx">All Location        </a></li>
            <li><a href="NewLocation.aspx">Create Location   </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="PictureBanner_Index.aspx">All images     </a></li>
            <li><a href="#">New images  </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Booking </a>
        <ul>
            <li class="open"><a href="../Booking/AllBooking.aspx">All Booking </a></li>
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
    <div style="margin-left: 20px; margin-right: 20px; min-height: 300px">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">New Image</h1>
            </div>
        </div>

        <div class="form-group">
            <label>Image 1 choose:</label>
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            &nbsp;<p class="help-block">Example block-level help text here.</p>
        </div>

        <div class="form-group">
            <label>Image 2 choose:</label>
            <br />
            <asp:FileUpload ID="FileUpload2" runat="server" />
            &nbsp;<p class="help-block">Example block-level help text here.</p>
        </div>

        <div class="form-group checkbox">
            <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button runat="server" type="reset" class="btn btn-default" ID="btnReset" Text="Reset" OnClick="btnReset_Click" />
        </div>

        <div class="form-group">
            <label>test:</label>
            <input class="form-control" placeholder="Area" id="test11" name="test11" runat="server" />
        </div>

        <div class="form-group checkbox">
        </div>
    </div>
</asp:Content>
