<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Booking/Booking_MasterPage.Master" AutoEventWireup="true" CodeBehind="AllBooking.aspx.cs" Inherits="ProjectView.AdminPage.Booking.AllBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="#"><i class="fa fa-files-o"></i>Location</a>
        <ul>
            <li><a href="../Index.aspx">All Location        </a></li>
            <li><a href="../Location/NewLocation.aspx">Create Location   </a></li>
        </ul>
    </li>
    <li><a href="#"><i class="fa fa-files-o"></i>Banner</a>
        <ul>
            <li class="open"><a href="../PictureBanner/PictureBanner_Index.aspx">All images     </a></li>
            <li><a href="../PictureBanner/NewImageBanner.aspx">New images  </a></li>
        </ul>
    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Booking </a>
        <ul>
            <li class="open"><a href="#">All Booking </a></li>
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
    <h2 class="page-title">Booking...:</h2>

    <!-- Zero Configuration Table -->
    <div class="panel panel-default">
        <div class="panel-heading">Table by DataTables plugin</div>
        <div class="panel-body">
            <table id="zctb" class="display table table-striped table-bordered table-hover" cellspacing="0" width="100%">
                <thead>
                    <tr>                        
                        <th>Customer Name</th>
                        <th>Email</th>
                        <th>PhoneNumber</th>
                        <th>Location Name</th>
                        <th>Date Start</th>
                        <th>Status</th>                        
                        <th>View</th>
                        <th>Remove</th>
                    </tr>
                </thead>

                <tbody>
                    <asp:Repeater ID="theID" runat="server" OnItemCommand="theID_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="Name" Text='<%#Eval("NameOFcustomer") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="Email" Text='<%#Eval("Email") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="Phone" Text='<%#Eval("Phonenumber") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="locationName" Text='<%#Eval("NameLocation") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="Date" Text='<%#Eval("DateStart") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="STT" Text='<%#Eval("Statut") %>'></asp:Label>
                                </td>
                                <td>
                                    <%--phan an--%>
                                    <asp:Label Visible="false" runat="server" ID="ID" Text='<%#Eval("ID") %>'></asp:Label>
                                    <asp:Label Visible="false" runat="server" ID="Address" Text='<%#Eval("Adress") %>'></asp:Label>                                    
                                    <asp:Label Visible="false" runat="server" ID="numberPeople" Text='<%#Eval("NumberPeople") %>'></asp:Label>
                                    <%--  --%>
                                    <asp:LinkButton ID="lbt_sua" CommandName="chinhsua" runat="server">View More</asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton runat="server" Text="Remove" ID="DeleteBTN"></asp:LinkButton>
                                </td>
                                
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>

        </div>
    </div>
</asp:Content>
