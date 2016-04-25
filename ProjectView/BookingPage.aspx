<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="ProjectView.BookingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="index.aspx">Home</a></li>
    <li><a href="Location.aspx">Location</a></li>
    <li><a href="ContactPage.aspx">Contact</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Section Background -->
    <section class="section-background">
        <div class="container">
            <h2 class="page-header">Booking
            </h2>
            <ol class="breadcrumb">
                <li><a href="index.aspx">Home</a></li>
                <li class="active">&nbsp;Booking</li>
            </ol>
        </div>
        <!-- /.container -->
    </section>
    <!-- /.section-background -->


    <section class="features section-wrapper">

        <div class="container">
            <h2 class="section-title">
                Booking                           
            </h2>
            <p class="section-subtitle">
                Thank you for your interest in  <asp:Label ID="locationName" runat="server" Font-Size="Large"> </asp:Label>
                . Please fill in your details below and we will contact you by phone or email within 24 to 48 hours with a tailor-made price & itinerary proposal.		
            </p>

            <div class="form">
                <div class="input-group">
                    <input class="form-control border-radius border-right" type="text" placeholder="Name" id="name" runat="server" required />
                    <span class="input-group-addon  border-radius custom-addon">
                        <i class="ion-person"></i>
                    </span>
                </div>
                <div class="input-group">
                    <input class="form-control border-radius border-right" name="email" type="email" placeholder="Email" id="Email" runat="server" required />
                    <span class="input-group-addon  border-radius custom-addon">
                        <i class="ion-email"></i>
                    </span>
                </div>
                <div class="input-group">
                    <input class="form-control border-radius border-right" name="phonenumber" type="number" placeholder="Phone number" id="phonenumber" runat="server" required />
                    <span class="input-group-addon  border-radius custom-addon">
                        <i class="ion-ios-telephone"></i>
                    </span>
                </div>
                <div class="input-group">
                    <input class="form-control border-radius border-right" name="address" type="text" placeholder="Address" id="address" runat="server" required />
                    <span class="input-group-addon  border-radius custom-addon">
                        
                    </span>
                </div>
                <div class="input-group">
                    <input readonly class="form-control border-radius border-right" type="text" placeholder="tour" id="tour" runat="server" required>
                    <span class="input-group-addon  border-radius custom-addon">                        
                    </span>
                </div>
                <div class="input-group">
                    <input class="form-control border-radius border-right" type="date" placeholder="Date you go" id="DateStart" runat="server" required>
                    <span class="input-group-addon  border-radius custom-addon">                        
                    </span>                   
                </div>
                 <asp:Label ID="txtErrorDate" Text="Date start Error!!!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                <div class="input-group">
                    <input class="form-control border-radius border-right" type="number" placeholder="Number people" id="numbeRpeople" runat="server" required>
                    <span class="input-group-addon  border-radius custom-addon">                        
                    </span>
                </div>
                <asp:Label ID="txtNumberError" Text="Number people > 0!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                <asp:Button runat="server" CssClass="btn btn-default border-radius custom-button" Text="Send" ID="btnSend" OnClick="btnSend_Click" />
                 <asp:Label ID="txtDONE" Text="Thank For Booking!" Visible="false" runat="server" ForeColor="Red"></asp:Label>
            </div>

        </div>
        <!-- /.row -->
        <!-- /.container -->
    </section>
    <!-- /.features -->

    

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
</asp:Content>
