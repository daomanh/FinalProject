<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="UpdateAcount.aspx.cs" Inherits="ProjectView.UpdateAcount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="Index.aspx"><i class="fa fa-files-o"></i>Home</a>

    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Booking</a>
        <ul>
            <li class="open"><a href="UserPage.aspx">All Booking </a></li>
        </ul>
    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Account</a>
        <ul>
            <li class="open"><a href="#">Update Account </a></li>
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
                </div>
            </div>
            <div class="form-group">
                <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </div>


</asp:Content>
