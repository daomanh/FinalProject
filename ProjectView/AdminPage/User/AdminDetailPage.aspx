<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/User/User_MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminDetailPage.aspx.cs" Inherits="ProjectView.AdminPage.User.AdminDetailPage" %>

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

    <div class="panel panel-default">
        <div class="panel-heading">Information User</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">

                        <label>Username :</label>
                        <input class="form-control" id="txtUsername" runat="server" />
                        <asp:Label ID="txtErrorUName" Text="Username is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                        <asp:Label ID="txtErrorUName2" Text="Username is ready!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="form-group">
                        <label>Password :</label>
                        <input class="form-control" id="txtPass" runat="server" />
                        <asp:Label ID="txtErrorpass" Text="Password is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="form-group">
                        <label>Fullname :</label>
                        <input class="form-control" id="txtFullname" runat="server" />
                        <asp:Label ID="txtErrorFname" Text="Full name is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="form-group">
                        <label>PhoneNumber :</label>
                        <input class="form-control" id="txtPhoneNumber" runat="server" />
                        <asp:Label ID="txtErrorPhone" Text="Phonenumber is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Gender :</label>
                        <asp:DropDownList class="form-control" ID="Gender" Style="font-size: 20px; color: black" runat="server">
                            <asp:ListItem Value="male">Male</asp:ListItem>
                            <asp:ListItem Value="female">Female</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Email :</label>
                        <input class="form-control" id="txtEmail" runat="server" />
                        <asp:Label ID="txtErrorEmail" Text="Email is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="form-group">
                        <label>Addres :</label>
                        <input class="form-control" id="txtAddres" runat="server" />
                        <asp:Label ID="txtErrorAdr" Text="Address is not null!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                    <div class="form-group">
                        <label>Role :</label>
                        <asp:DropDownList class="form-control" ID="Role" runat="server">
                            <asp:ListItem Value="admin">Admin</asp:ListItem>
                            <asp:ListItem Value="user">User</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>


</asp:Content>
