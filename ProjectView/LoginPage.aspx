﻿<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectView.LoginPage" ValidateRequest="false" EnableEventValidation="false" %>
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
                    <li class="active"><a href="Login.aspx">&nbsp;login</a></li>
                   
                </ol>
            </div>
            <!-- /.container -->
        </section>


    <div class="row" style="margin-top:30px">
		<div class="col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4">
			<div class="login-panel panel panel-default">
				<div class="panel-heading">Log in</div>
				<div class="panel-body">
					<form role="form">
						<fieldset>
							<div class="form-group">
								<input class="form-control" placeholder="Username" name="username" type="text" autofocus="" id="username" runat="server" />
							</div>
							<div class="form-group">
								<input class="form-control" placeholder="Password" name="password" type="password" value="" id="password" runat="server" />
							</div>
							
                            <asp:Button runat="server" OnClick="btnSubmit_Click" ID="btnSubmit" Text="Login" CssClass="btn btn-primary" />
							<asp:Button runat="server" OnClick="btnRegister_Click" ID="btnRegister" Text="Register" CssClass="btn btn-primary" />
						</fieldset>
					</form>
				</div>
			</div>
		</div><!-- /.col-->
	</div>

</asp:Content>
