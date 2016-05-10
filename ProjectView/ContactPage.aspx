<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="ProjectView.ContactPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="index.aspx">Home</a></li>
    <li><a href="Location.aspx">Location</a></li>
    <li class="active"><a href="ContactPage.aspx">Contact</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="assets/css/contact.css" />
    <section class="header">

        <nav class="navbar navbar-default">
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="index.html" title="HOME"><i class="ion-paper-airplane"></i>euro <span>travel</span></a>
                </div>
                <!-- /.navbar-header -->

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="index.html">Home</a></li>
                        <li><a href="about.html">about</a></li>
                        <li><a href="services.html">services</a></li>
                        <li class="active"><a href="contact.html">contact</a></li>
                    </ul>
                    <!-- /.nav -->
                </div>
                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container -->
        </nav>
    </section>
    <!-- /#header -->

    <!-- Section Background -->
    <section class="section-background">
        <div class="container">
            <h2 class="page-header">get in touch with us
			</h2>
            <ol class="breadcrumb">
                <li><a href="index.html">Home</a></li>
                <li class="active">&nbsp;contact</li>
            </ol>
        </div>
        <!-- /.container -->
    </section>
    <!-- /.section-background -->


    <section class="section-wrapper contact-and-map">
        <div class="container">
            <div class="row">
                <div class="col-sm-6">

                    <h2 class="section-title">Send Message
					</h2>
                    <div class="form">
                        <div class="input-group">
                            <input id="txtName" runat="server" class="form-control border-radius border-right" type="text" placeholder="Name" required />
                            <span class="input-group-addon  border-radius custom-addon">
                                <i class="ion-person"></i>
                            </span>
                        </div>
                        <div class="input-group">
                            <input id="txtEmail" runat="server" class="form-control border-radius border-right" name="email" type="email" placeholder="Email address" required />
                            <span class="input-group-addon  border-radius custom-addon">
                                <i class="ion-email"></i>
                            </span>
                        </div>
                        <div class="input-group">
                            <input id="txtPhone" runat="server" class="form-control border-radius border-right" type="tel" placeholder="Phone number" />
                            <span class="input-group-addon  border-radius custom-addon">
                                <i class="ion-ios-telephone"></i>
                            </span>
                        </div>
                        <div class="input-group">
                            <textarea id="txtMesage" runat="server" class="form-control border-radius border-right" rows="8" placeholder="Write Message"></textarea>
                            <!-- <input type="text" name="text" rows="8" class="form-control border-radius border-right message" placeholder="Write Message"> -->
                            <span class="input-group-addon border-radius custom-addon">
                                <i class="ion-chatbubbles"></i>
                            </span>
                        </div>
                        
                        <asp:Button runat="server" CssClass="btn btn-default border-radius custom-button" Text="SEND MESSAGE" ID="btnSend" OnClick="btnSend_Click"/>
                    </div>

                </div>
                <!-- /.col-sm-6 -->
                <div class="col-sm-6">
                    <h2 class="section-title">Find Us Via Google Map
					</h2>
                    <div id="googleMap">
                         <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3725.4822139149624!2d105.761156415406!3d20.97329889504411!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x313453213c06f9f7%3A0x146b1b8873a516f3!2zQ1Q1QSBWxINuIEtow6o!5e0!3m2!1svi!2s!4v1461468915626" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
                    </div>
                </div>
                <!-- /.col-sm-6 -->
            </div>
        </div>
    </section>



    <section class="contacts section-wrapper">
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                    <div class="contact">
                        <div class="contact-icon">
                            <i class="ion-android-map"></i>
                        </div>
                        <div class="contact-name">
                            Address
					
                        </div>
                        <div class="contact-detail">
                            Asowld Avenew P.O Box
                            <br>
                            353 Mountain View. United States of America. 
					
                        </div>
                    </div>
                    <!-- /.contact -->
                </div>
                <!-- /.col-sm-4 -->
                <div class="col-sm-4">
                    <div class="contact">
                        <div class="contact-icon">
                            <i class="ion-ios-telephone"></i>
                        </div>
                        <div class="contact-name">
                            Phone
					
                        </div>
                        <div class="contact-detail">
                            Local: 1-800-523-hello
                            <br>
                            Mobile: 1-400-623-hello
					
                        </div>
                    </div>
                    <!-- /.contact -->
                </div>
                <!-- /.col-sm-4 -->
                <div class="col-sm-4">
                    <div class="contact">
                        <div class="contact-icon">
                            <i class="ion-email"></i>
                        </div>
                        <div class="contact-name">
                            Email Address
					
                        </div>
                        <div class="contact-detail">
                            info@themewagon.com
                            <br>
                            <a href="http://www.themewagon.com">www.themewagon.com</a>
                        </div>
                    </div>
                    <!-- /.contact -->
                </div>
                <!-- /.col-sm-4 -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container -->
    </section>
    <!-- /.contacts -->




    
    <div class="subscribe section-wrapper">
        <a class="brand-logo" href="Index.aspx" title="HOME"><i class="ion-paper-airplane"></i>VIETNAM <span>TOURISM</span></a>
        <p class="subscribe-now">
            Subscribe to our Newsletter
	
        </p>
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-sm-6 col-md-offset-4 col-sm-offset-3">
                    <div class="input-group">
                        <input type="email" class="form-control border-radius" placeholder="Email address">
                        <span class="input-group-btn">
                            <button class="btn btn-default border-radius custom-sub-btn" type="button">DONE</button>
                        </span>
                    </div>
                    <!-- /input-group -->
                </div>
            </div>
        </div>



        <ul class="social-icon">
            <li><a href="#"><i class="ion-social-twitter"></i></a></li>
            <li><a href="#"><i class="ion-social-facebook"></i></a></li>
            <li><a href="#"><i class="ion-social-linkedin-outline"></i></a></li>
            <li><a href="#"><i class="ion-social-googleplus"></i></a></li>
        </ul>
    </div>
    <!-- /.subscribe -->


    <footer>
        <div class="container">
            <div class="row">
                <div class="col-xs-4">
                    <div class="text-left">
                        &copy; Copyright 2015
				
                    </div>
                </div>
                <div class="col-xs-4">
                    Theme by MANHDNGC00490
                </div>
                <div class="col-xs-4">
                    <!-- <div class="top">
						<a href="#header">
							<i class="ion-arrow-up-b"></i>
						</a>
					</div> -->
                </div>
            </div>
        </div>
    </footer>


    <script src="assets/js/jquery-1.11.2.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/owl.carousel.min.js"></script>
    <script src="assets/js/contact.js"></script>
    <script src="assets/js/script.js"></script>

</asp:Content>
