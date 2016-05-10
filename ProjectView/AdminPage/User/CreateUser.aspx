<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/User/User_MasterPage.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="ProjectView.AdminPage.User.CreateUser" %>

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
    <div style="margin-left: 20px; margin-right: 20px; min-height: 300px">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Add Account</h1>
            </div>
        </div>

        <div class="form-group">
            <label>Username:</label>
            <input class="form-control" placeholder="Username" id="username" runat="server" />
            <asp:Label ID="txtErrorUName" Text="Username is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
            <asp:Label ID="txtErrorUName2" Text="Username is ready!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Fullname:</label>
            <input class="form-control" placeholder="Full name" id="fullname" runat="server" />
            <asp:Label ID="txtErrorFname" Text="Full name is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Gender:</label>
            <asp:DropDownList ID="Gender" Style="font-size: 20px; color: black" runat="server">
                <asp:ListItem Value="null" Selected="True">Choice</asp:ListItem>
                <asp:ListItem Value="male">Male</asp:ListItem>
                <asp:ListItem Value="female">Female</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="txtErrorGender" Text="Please Choice one!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Email:</label>
            <input class="form-control" placeholder="Email" id="email" runat="server" />
            <asp:Label ID="txtErrorEmail" Text="Email is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Phonenumber:</label>
            <input class="form-control" placeholder="Phonenumber" id="phone" runat="server" />
            <asp:Label ID="txtErrorPhone" Text="Phonenumber is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Address:</label>
            <input class="form-control" placeholder="Address" id="address" runat="server" />
            <asp:Label ID="txtErrorAdr" Text="Address is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label>Role:</label>
            <asp:DropDownList ID="RoleChoice" Style="font-size: 20px; color: black" runat="server">
                <asp:ListItem Value="null" Selected="True">Choice</asp:ListItem>
                <asp:ListItem Value="admin">Admin</asp:ListItem>
                <asp:ListItem Value="user">User</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="txtErrorRole" Text="Please Choice Role fro account!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group checkbox">
            <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button runat="server" type="reset" class="btn btn-default" ID="btnReset" Text="Reset" OnClick="btnReset_Click" />
        </div>


    </div>
</asp:Content>
