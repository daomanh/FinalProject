<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Location/Location_MasterPAge.Master" AutoEventWireup="true" CodeBehind="UpdateLocation.aspx.cs" Inherits="ProjectView.AdminPage.Location.UpdateLocation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Location</a>
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
    <input runat="server" id="test" />

    <div style="margin-left: 20px; margin-right: 20px; min-height: 300px">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Location :
                    <asp:Label ID="NameLocationV" runat="server"></asp:Label>
                </h1>
            </div>
        </div>

        <div class="form-group">           
            <input visible="false" class="form-control" placeholder="Name" id="username" name="User" runat="server" />
        </div>

        <div class="form-group">
            <label>Name of location:</label>
            <asp:TextBox class="form-control" placeholder="Name" ID="nameLocationU2" name="nameLocationU2" runat="server" AutoPostBack="true"></asp:TextBox>
            <asp:Label ID="txtErrorName" Text="Name of location is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Area:</label>
             <asp:DropDownList ID="areaDDL" CssClass="form-control border-radius" runat="server">
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label>Content:</label>
            <textarea class="form-control" rows="3" id="content" name="content" runat="server"> </textarea>
            <asp:Label ID="txtErrorContent" Text="Content is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Image choose:</label>
            <input type="file" />
            <p class="help-block">Example block-level help text here.</p>
        </div>

        <div class="form-group checkbox">
            <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button runat="server" type="reset" class="btn btn-default" ID="btnReset" Text="Reset" OnClick="btnReset_Click" />
        </div>
        <div class="form-group checkbox">
        </div>
    </div>

</asp:Content>
