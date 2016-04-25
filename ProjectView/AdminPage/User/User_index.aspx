<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin_masterPage.Master" AutoEventWireup="true" CodeBehind="User_index.aspx.cs" Inherits="ProjectView.AdminPage.User.User_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Tables</h1>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">Advanced Table </div>
                <div class="panel-body">


                    <input id="test" runat="server" />
                    <div class="table-responsive">
                        <asp:gridview id="GridView1" runat="server" autogeneratecolumns="False">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" />
                                <asp:BoundField DataField="Username" HeaderText="Username" />
                                <asp:BoundField DataField="Pass" HeaderText="Pass" />
                                <asp:BoundField DataField="Fullname" HeaderText="Fullname" />
                                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" />
                                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Addres" HeaderText="Addres" />
                                <asp:BoundField DataField="Roll" HeaderText="Roll" />
                            </Columns>
                        </asp:gridview>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
