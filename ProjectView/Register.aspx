<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectView.Register" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="Index.aspx">Home</a></li>
    <li><a href="Location.aspx">Location</a></li>   
    <li><a href="ContactPage.aspx">Contact</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500" />
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css" />
    <link rel="stylesheet" href="assets/css/form-elements.css" />
    <link rel="stylesheet" href="assets/css/style.css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
            <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
            <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->

    <!-- Favicon and touch icons -->
    <link rel="shortcut icon" href="assets/ico/favicon.png" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="assets/ico/apple-touch-icon-57-precomposed.png" />

    <section class="section-background">
        <div class="container">
            <h2 class="page-header">
                <asp:Label runat="server" ID="LocationName2"></asp:Label>
            </h2>
            <ol class="breadcrumb">
                <li><a href="Index.aspx">Home</a></li>
                <li class="active"><a href="Register.aspx">&nbsp;Register</a></li>
            </ol>
        </div>
        <!-- /.container -->
    </section>


    <div class="row" style="margin-top: 30px; font-size: 25px">
        <div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
            <div class="login-panel panel panel-default">
                <div class="panel-heading">Register</div>
                <div class="panel-body">
                    <form role="form">

                        <div class="form-group">
                            <label for="firstname" runat="server" style="color: #000000">User Name</label>
                            <input class="form-control" style="font-size: 20px" type="text" id="username" name="username" placeholder="enter your username..." runat="server" />
                        </div>
                        <div class="form-group">
                            <label for="lastname" style="color: #000000">Password</label>
                            <input class="form-control" style="font-size: 20px" type="password" id="password" name="password" placeholder="choose a password..." runat="server" />
                        </div>
                        <div class="form-group">
                            <label for="username" style="color: #000000">Full name</label>
                            <input class="form-control" style="font-size: 20px" type="text" id="fullname" name="fullname" placeholder="enter your full name..." runat="server" />
                        </div>

                        <div class="form-group">
                            <label for="phonenumber" style="color: #000000">Phone number</label>
                            <input class="form-control" style="font-size: 20px" type="text" id="phonenumber" name="phonenumber" placeholder="enter your phone number..." runat="server" />
                        </div>

                        <div class="form-group">
                            <label for="Gender" style="color: #000000">Gender</label>

                            <asp:DropDownList ID="Gender" Style="font-size: 20px; color:black" runat="server">
                                <asp:ListItem Value="male" Selected="True">Choice</asp:ListItem>
                                <asp:ListItem Value="male">Male</asp:ListItem>
                                <asp:ListItem Value="female">Female</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <label for="email" style="color: #000000">Email</label>
                            <input class="form-control" type="text" style="font-size: 20px" id="email" name="email" placeholder="enter your email..." runat="server" />
                        </div>
                        <div class="form-group">
                            <label for="address" style="color: #000000">Address</label>
                            <input class="form-control" style="font-size: 20px" type="text" id="address" name="address" placeholder="enter your address..." runat="server" />
                        </div>
                        <asp:Button runat="server" OnClick="Button1_Click" ID="Button1" Text="Register" CssClass="btn btn-primary" />

                    </form>
                </div>
            </div>
        </div>
        <!-- /.col-->
    </div>
</asp:Content>
