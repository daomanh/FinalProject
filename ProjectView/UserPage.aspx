<%@ Page Title="" Language="C#" MasterPageFile="~/UserLayout.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="ProjectView.UserPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="Index.aspx"><i class="fa fa-files-o"></i>Home</a>

    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Booking</a>
        <ul>
            <li class="open"><a href="#">All Booking </a></li>            
        </ul>
    </li>
    <li class="open"><a href="#"><i class="fa fa-files-o"></i>Account</a>
        <ul>
            <li class="open"><a href="UpdateAcount.aspx">Update Account </a></li>            
        </ul>
    </li>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="page-title">All Booking:</h2>

    <!-- Zero Configuration Table -->
    <div class="panel panel-default">
        <div class="panel-heading">Table by DataTables plugin</div>
        <div class="panel-body">
            <table id="zctb" class="display table table-striped table-bordered table-hover" cellspacing="0" width="100%">
                <thead>
                    <tr>                      
                            <th>NameOFcustomer</th>
                            <th>Email</th>
                            <th>NameLocation</th>
                            <th>NumberPeople</th>
                            <th>DateStart</th>
                            <th>Statut</th>
                            <th></th>
                    </tr>
                </thead>

                <tbody>
                    <asp:Repeater ID="theID" runat="server" >
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:Label runat="server" ID="lblIdReview" Text='<%#Eval("NameOFcustomer") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="USername" Text='<%#Eval("Email") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="area" Text='<%#Eval("NameLocation") %>'></asp:Label>
                                </td>

                                <td>
                                    <asp:Label runat="server" ID="Label1" Text='<%#Eval("NumberPeople") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="Label2" Text='<%#Eval("DateStart") %>'></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" ID="Label3" Text='<%#Eval("Statut") %>'></asp:Label>
                                </td>
                                <td>                   
                                   
                                </td>

                                
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
