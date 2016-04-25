<%@ Page Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProjectView.Index" ValidateRequest="false" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li class="active"><a href="index.aspx">Home</a></li>
    <li><a href="Location.aspx">Location</a></li>
    <li><a href="ContactPage.aspx">Contact</a></li>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Home -->


    <div class="camera-wrapper">
        <div id="jssor_1" style="position: relative; margin: 0 auto; top: 0px; left: 0px; width: 1300px; height: 400px; overflow: hidden; visibility: hidden;">
            <!-- Loading Screen -->
            <div data-u="loading" style="position: absolute; top: 0px; left: 0px;">
                <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
                <div style="position: absolute; display: block; background: url('img/loading.gif') no-repeat center center; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
            </div>
            <div data-u="slides" style="cursor: default; position: relative; top: 0px; left: 0px; width: 1300px; height: 500px; overflow: hidden;">
                <asp:Repeater ID="theID" runat="server">
                    <ItemTemplate>
                        <div data-p="225.00" style="display: none;">
                            <img src='<%# Eval("PicUrl") %>' />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <!-- Bullet Navigator -->
            <div data-u="navigator" class="jssorb05" style="bottom: 16px; right: 16px;" data-autocenter="1">
                <!-- bullet navigator item prototype -->
                <div data-u="prototype" style="width: 16px; height: 16px;"></div>
            </div>
            <!-- Arrow Navigator -->
            <span data-u="arrowleft" class="jssora22l" style="top: 0px; left: 12px; width: 40px; height: 58px;" data-autocenter="2"></span>
            <span data-u="arrowright" class="jssora22r" style="top: 0px; right: 12px; width: 40px; height: 58px;" data-autocenter="2"></span>
        </div>
    </div>
    <!-- /#header -->
    <!-- Find a Tour -->
    <section class="tour section-wrapper container">
        <h2 class="section-title">Find a Tour
        </h2>
        <p class="section-subtitle">
            Where would you like to go?
	
        </p>
        <div class="row">
            <div class="col-md-3 col-sm-6">
                <form role="form" class="form-dropdown">
                    <div class="form-group">
                        <asp:DropDownList ID="area" CssClass="form-control border-radius" runat="server">

                        </asp:DropDownList>
                        
                    </div>
                </form>
            </div>            

            <div class="col-md-6 col-sm-6">
                <div class="input-group">
                    <input type="text" class="form-control border-radius border-right" placeholder="Arrival" runat="server" id="txtArrival" />
                    <span class="input-group-addon border-radius custom-addon">
                        <i class="ion-ios-calendar"></i>
                    </span>
                </div>
            </div>
           
            <div class="col-md-3 col-sm-6">
                <asp:Button ID="search" Text="Search" CssClass="btn btn-default border-radius custom-button" runat="server" OnClick="search_Click" />                
            </div>
        </div>
    </section>
    <!-- /.tour -->


    <!-- Our Blazzing offers -->
    <section class="offer section-wrapper">
        <div class="container">
            <h2 class="section-title">Top 4 New Post
            </h2>
            <p class="section-subtitle">
                Lorem Ipsum is simply dummy text of the industry.		
            </p>

            <div class="row">
                <asp:Repeater ID="TheNewestCreate" runat="server" OnItemCommand="TheNewestCreate_ItemCommand">
                    <ItemTemplate>
                        <div class="col-sm-3 col-xs-6">
                            <div class="offer-item" style="height: 450px">

                                <div class="icon">
                                    <i class="ion-social-euro"></i>
                                </div>
                                <h3>
                                    <asp:Label runat="server" ID="namelocation" Text='<%#Eval("NameLocation") %>'></asp:Label>
                                </h3>
                                <p>
                                    <asp:Label runat="server" Text='<%#Eval("LocationContent").ToString().Substring(0,Math.Min(200,Eval("LocationContent").ToString().Length)) %>'></asp:Label>
                                </p>
                                <asp:Label hidden="true" runat="server" ID="Label1" Text='<%#Eval("ID") %>'></asp:Label>
                                <asp:Label hidden="true" runat="server" ID="lblViewer" Text='<%#Eval("Viewer") %>'></asp:Label>
                                <asp:Label hidden="true" runat="server" ID="Label2" Text='<%#Eval("Rate") %>'></asp:Label>
                                <asp:LinkButton ID="lbt_sua" CommandName="chinhsua" runat="server">Read more</asp:LinkButton>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>

                <!-- /.col-md-3 -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container -->
    </section>
    <!-- /.offer -->

    <!-- Top place to visit -->
    <section class="visit section-wrapper">
        <div class="container">
            <h2 class="section-title">Top 4 place to Booking
            </h2>
            <p class="section-subtitle">
                Lorem Ipsum is simply dummy text of the industry.
		
            </p>

            <div class="row">
                <asp:Repeater ID="TopRate" runat="server" OnItemCommand="TopRate_ItemCommand">
                    <ItemTemplate>
                        <div class="item">
                            <div class="col-sm-3 col-xs-6">
                                <div class="offer-item">
                                    <div class="icon">
                                        <i class="ion-social-euro"></i>
                                    </div>
                                    <h3>
                                        <asp:Label runat="server" ID="lblNameRate" Text='<%#Eval("NameLocation") %>' ForeColor="#993333"></asp:Label>
                                    </h3>
                                    <p>
                                        <asp:Label runat="server" ID="lblLOcationRate" Text='<%#Eval("LocationContent").ToString().Substring(0,Math.Min(200,Eval("LocationContent").ToString().Length)) %>'></asp:Label>
                                    </p>
                                    <asp:Label hidden="true" runat="server" ID="lblIDTopRate" Text='<%#Eval("ID") %>'></asp:Label>
                                    <asp:Label hidden="true" runat="server" ID="lblViewer" Text='<%#Eval("Viewer") %>'></asp:Label>
                                    <asp:Label hidden="true" runat="server" ID="Label2" Text='<%#Eval("Rate") %>'></asp:Label>
                                    <asp:LinkButton ID="lbt_sua_rate" CommandName="chinhsua" runat="server">Read more</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
        <!-- /.container -->
    </section>
    <!-- /.visit -->

    <section class="offer section-wrapper">
        <div class="container">
            <h2 class="section-title">Top 4 View
            </h2>
            <p class="section-subtitle">
                Lorem Ipsum is simply dummy text of the industry.		
            </p>

            <div class="row">
                <asp:Repeater ID="TopView" runat="server" OnItemCommand="TopView_ItemCommand">
                    <ItemTemplate>
                        <div class="col-sm-3 col-xs-6">
                            <div class="offer-item">

                                <div class="icon">
                                    <i class="ion-social-euro"></i>
                                </div>
                                <h3>
                                    <asp:Label runat="server" ID="NAMELOCATION" Text='<%#Eval("NameLocation") %>'></asp:Label>
                                </h3>
                                <p>
                                    <asp:Label runat="server" ID="coNTENTLOCATION" Text='<%#Eval("LocationContent").ToString().Substring(0,Math.Min(200,Eval("LocationContent").ToString().Length)) %>'></asp:Label>
                                </p>
                                <asp:Label hidden="true" runat="server" ID="Label1" Text='<%#Eval("ID") %>'></asp:Label>
                                <asp:Label hidden="true" runat="server" ID="lblViewer" Text='<%#Eval("Viewer") %>'></asp:Label>
                                <asp:Label hidden="true" runat="server" ID="Label2" Text='<%#Eval("Rate") %>'></asp:Label>
                                <asp:LinkButton ID="lbt_sua" CommandName="chinhsua" runat="server">Read more</asp:LinkButton>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

                <!-- /.col-md-3 -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container -->
    </section>
    <!-- /.Additional-services -->


    <div class="section-wrapper sponsor">
        <div class="container">
            <div class="owl-carousel sponsor-carousel">
                <div class="item">
                    <a href="#">
                        <img src="images/sp-1.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-2.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-3.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-4.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-5.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-6.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-1.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-2.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-3.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-4.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-5.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-6.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-1.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-2.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-3.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-4.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-5.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="images/sp-6.png" alt="sponsor-brand" class="img-responsive sponsor-item" />
                    </a>
                </div>
            </div>
            <!-- /.owl-carousel -->
        </div>
        <!-- /.container -->
    </div>
    <!-- /.sponsor -->

    <div class="subscribe section-wrapper">
        <a class="brand-logo" href="Index.aspx" title="HOME"><i class="ion-paper-airplane"></i>Vietnam <span>TOURISM</span></a>
        <p class="subscribe-now">
            Subscribe to our Newsletter
	
        </p>
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-sm-6 col-md-offset-4 col-sm-offset-3">
                    <div class="input-group">
                        <input type="email" class="form-control border-radius" placeholder="Email address" />
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
                    <div class="top">
                        <a href="#header">
                            <i class="ion-arrow-up-b"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </footer>

</asp:Content>




