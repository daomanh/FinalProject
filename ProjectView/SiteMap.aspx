<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="SiteMap.aspx.cs" Inherits="ProjectView.SiteMap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="active"><a href="index.aspx">Home</a></li>
    <li><a href="Location.aspx">Location</a></li>
    <li><a href="ContactPage.aspx">Contact</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Section Background -->
    <section class="section-background">
        <div class="container">
            <h2 class="page-header">our Location
            </h2>
            <ol class="breadcrumb">
                <li><a href="index.aspx">Home</a></li>
                <li class="active">&nbsp;SiteMap</li>
            </ol>
        </div>
        <!-- /.container -->
    </section>
    <!-- /.section-background -->


    <section class="features section-wrapper">


        <div class="container" style="font-size:17px;margin-left:850px">
            <div class="row custom-table">
                <p class="features-details">
                    <h2 style="color:red">Site Map</h2>
                    <asp:TreeView ID="TreeView1" runat="server">
                        <Nodes>
                            <asp:TreeNode Text="Home page">
                                <asp:TreeNode Text="Location page" NavigateUrl="~/Location.aspx"></asp:TreeNode>
                                <asp:TreeNode Text="Contact page" NavigateUrl="~/ContactPage.aspx"></asp:TreeNode>
                                <asp:TreeNode Text="Booking page" NavigateUrl="~/BookingPage.aspx"></asp:TreeNode>
                                <asp:TreeNode Text="Admin page">
                                    <asp:TreeNode Text="Location" NavigateUrl="~/AdminPage/Index.aspx">
                                        <asp:TreeNode Text="Add new Location" NavigateUrl="~/AdminPage/Location/NewLocation.aspx" />
                                        <asp:TreeNode Text="Update Location" NavigateUrl="~/AdminPage/Location/UpdateLocation.aspx" />
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="Booking" NavigateUrl="~/AdminPage/Booking/AllBooking.aspx">
                                        <asp:TreeNode Text="Booking detail" NavigateUrl="~/AdminPage/Booking/BookingDetail.aspx" />
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="Contact" NavigateUrl="~/AdminPage/Contact/AllContact.aspx">
                                        <asp:TreeNode Text="Contact detail" NavigateUrl="~/AdminPage/Contact/ContactDetail.aspx" />
                                    </asp:TreeNode>
                                    <asp:TreeNode Text="Comment" NavigateUrl="~/AdminPage/Index_review.aspx">
                                        <asp:TreeNode Text="Location comment detail" NavigateUrl="~/AdminPage/DetailReview.aspx">
                                            <asp:TreeNode Text="Reply commnet detail" NavigateUrl="~/AdminPage/ReviewRep_detail.aspx" />
                                        </asp:TreeNode>
                                    </asp:TreeNode>
                                </asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </p>
            </div>
        </div>

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
