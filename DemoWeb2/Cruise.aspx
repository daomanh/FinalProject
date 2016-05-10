<%@ Page Title="" Language="C#" MasterPageFile="~/NguoiDunglayout.Master" AutoEventWireup="true" CodeBehind="Cruise.aspx.cs" Inherits="DemoWeb2.Cruise" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
            <div class="box">
                <div class="col-lg-12">
                    <hr />
                    <h2 class="intro-text text-center">
                        The all of cruise
                    </h2>
                    <hr />
                    
                     <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" RepeatColumns="4" >
            <ItemTemplate>
                <table class="auto-style2">
                    <tr>
                        <td>
                            
                            <asp:Image ID="Image2" runat="server" Height="165px" ImageUrl='<%#Eval("img") %>' Width="165px" />
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("NameCruise") %>'></asp:Label>
                        </td>
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Detail" Width="82px" CommandName="Detail" />
                            <asp:Button ID="Button2" runat="server" Text="Add To Cart" Width="82px" CommandName="Add"/>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

                </div>
            </div>
        </div>
</asp:Content>
