<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/PictureBanner/PictureBanner_MasterPage.Master" AutoEventWireup="true" CodeBehind="PictureBanner_Index.aspx.cs" Inherits="ProjectView.AdminPage.PictureBanner.PictureBanner_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li class="open"><a href="../Index.aspx">All Location        </a></li>
            <li><a href="NewLocation.aspx">Create Location   </a></li>
        </ul>
    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="#">All images     </a></li>
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
   <h2 class="page-title">Location</h2>

    <!-- Zero Configuration Table -->
    <div class="panel panel-default">
        <div class="panel-heading">Table by DataTables plugin</div>
        <div class="panel-body">
            <table id="zctb" class="display table table-striped table-bordered table-hover" cellspacing="0" width="100%">
                <thead>
                    <tr>
                        <th>Picture name</th>                        
                        <th>View</th>
                        <th>Remove</th>
                        <th></th>
                    </tr>
                </thead>

                <tbody>
                    <asp:Repeater ID="theID" runat="server" OnItemCommand="theID_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="name" Text='<%#Eval("PicName") %>'></asp:Label>
                                </td>
                               
                                <td>
                                    <asp:Label Visible="false" runat="server" ID="id" Text='<%#Eval("ID") %>'></asp:Label>
                                    <asp:Label Visible="false" runat="server" ID="url" Text='<%#Eval("PicUrl") %>'></asp:Label>
                                    <asp:LinkButton ID="lbt_sua" CommandName="chinhsua" runat="server">View More</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton runat="server"  CommandName="delete" ID="DeleteBTN"  OnClientClick="return confirm('Are you sure you want to submit ?')"> Remove</asp:LinkButton>
                                </td>
                                <td></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>

        </div>
    </div>
</asp:Content>
