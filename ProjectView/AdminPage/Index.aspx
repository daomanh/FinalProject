<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/AdminPage/Admin_masterPage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProjectView.AdminPage.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li class="open"><a href="Index.aspx">All Location        </a></li>
            <li><a href="Location/NewLocation.aspx">Create Location   </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="PictureBanner/PictureBanner_Index.aspx">All images     </a></li>
            <li><a href="PictureBanner/NewImageBanner.aspx">New images  </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Booking </a>
        <ul>
            <li class="open"><a href="Booking/AllBooking.aspx">All Booking </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Contact </a>
        <ul>
            <li class="open"><a href="Contact/AllContact.aspx">All Contact </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Review  </a>
        <ul>
            <li class="open"><a href="Index_review.aspx">All review</a></li>
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
                        <th>NameLocation</th>
                        <th>Area</th>
                        <th>Rate</th>
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
                                    <asp:Label runat="server" ID="locationName" Text='<%#Eval("NameLocation") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="area" Text='<%#Eval("Area") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="rate" Text='<%#Eval("Rate") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label Visible="false" runat="server" ID="idLocation" Text='<%#Eval("ID") %>'></asp:Label>
                                    <asp:Label Visible="false" runat="server" ID="locationContent" Text='<%#Eval("LocationContent") %>'></asp:Label>
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
