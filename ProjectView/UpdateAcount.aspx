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
    <div class="panel panel-default">
        <div class="panel-heading">Table Account</div>
        <div class="panel-body">
            <div class="form-group">
                <div class="col-md-6">
                    <div class="form-group">

                        <label>Username :</label>
                        <input id="txtUsername" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Password :</label>
                        <input id="txtPass" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Fullname :</label>
                        <input id="txtFullname" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>PhoneNumber :</label>
                        <input id="txtPhoneNumber" runat="server" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Gender :</label>
                        <asp:DropDownList ID="Gender" Style="font-size: 20px; color:black" runat="server">
                                <asp:ListItem Value="">Choice</asp:ListItem>
                                <asp:ListItem Value="male">Male</asp:ListItem>
                                <asp:ListItem Value="female">Female</asp:ListItem>
                            </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label>Email :</label>
                        <input id="txtEmail" runat="server" />
                    </div>
                    <div class="form-group">
                        <label>Addres :</label>
                        <input id="txtAddres" runat="server" />
                    </div>
                </div>
            </div>
            <div class="form-group">
                <asp:Button runat="server" type="submit" class="btn btn-primary" ID="btnSubmit" Text="Submit" />
            </div>
        </div>

    </div>
</asp:Content>
