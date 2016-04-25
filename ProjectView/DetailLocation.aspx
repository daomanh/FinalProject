<%@ Page Language="C#" MasterPageFile="~/HomeUser_Masterpage.Master" AutoEventWireup="true" CodeBehind="DetailLocation.aspx.cs" Inherits="ProjectView.DetailLocation" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <li><a href="index.aspx">Home</a></li>
    <li class="active"><a href="Location.aspx">Location</a></li>
    <li><a href="ContactPage.aspx">Contact</a></li>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="RatingCSS/stylesheet.css" rel="stylesheet" />

    <section class="section-background">
        <div class="container">
            <h2 class="page-header">
                <asp:Label runat="server" ID="LocationName2"></asp:Label>
            </h2>
            <ol class="breadcrumb">
                <li><a href="Index.aspx">Home</a></li>
                <li><a href="Location.aspx">&nbsp;Locations</a></li>
                <li class="active">&nbsp;<asp:Label runat="server" ID="LocationName1"></asp:Label></li>
            </ol>
        </div>
        <!-- /.container -->
    </section>

    <!--single-->
    <div class="single">
        <div class="container">
            <asp:Repeater ID="picture1" runat="server">
                <ItemTemplate>
                    <div class="single-top">
                        <img src='<%#Eval("PicUrl") %>' alt="" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <asp:Repeater ID="theLocation" runat="server">
                <ItemTemplate>

                    <div class="top-single">
                        <h4>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</h4>
                        <div class="grid-single">
                            <div class="single-one">
                                <span><i class="glyphicon glyphicon-calendar"></i>
                                    <asp:Label runat="server" Text='<%#Eval("DateCreate") %>'></asp:Label>
                                </span>
                            </div>
                            <div class="single-one">
                                <span>
                                    <a href="#">
                                        <i class="glyphicon glyphicon-comment">Viewer</i>
                                        <asp:Label runat="server" Text='<%#Eval("Viewer") %>'></asp:Label>
                                    </a>
                                </span>
                            </div>
                            <div class="single-one">
                                <span><i class="glyphicon glyphicon-heart">Rate: </i>
                                    <asp:Label ID="lblCountBooking" runat="server" Text='<%#Eval("Rate") %>'></asp:Label>
                                </span>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <p class="eget">
                            <asp:Label runat="server" Text='<%#Eval("LocationContent") %>'></asp:Label>
                        </p>
                </ItemTemplate>
            </asp:Repeater>

            <li class="single-middle">
                <ul class="social-share">
                    <li><span>SHARE</span></li>
                    <li><a href="#"><i></i></a></li>
                    <li><a href="#"><i class="tin"></i></a></li>
                    <li><a href="#"><i class="message"></i></a></li>

                </ul>

                <ul style="float: right; font-size: 18px">
                    <li>
                        <span>
                            <asp:LinkButton runat="server" Text="Booking now.." ID="btnBooking" OnClick="btnBooking_Click"></asp:LinkButton>
                        </span>
                    </li>
                </ul>
                <a href="#">
                    <i class="arrow"></i>
                </a>
            </li>

            <div class="clearfix"></div>
        </div>
        <%--comment--%>
        <div class="top-comments">
            <h3>10 Comments</h3>

            <asp:Repeater ID="Reviewtbl" runat="server">
                <ItemTemplate>
                    <div class="met">
                        <div class="code-in">
                            <p class="smith">
                                <a href="#">
                                    <asp:Label runat="server" Text='<%#Eval("Username") %>'> </asp:Label></a> <span>
                                        <asp:Label runat="server" Text='<%#Eval("DateReview") %>'></asp:Label>
                                    </span>
                            </p>
                            <p class="reply"><a href="#"><i></i>REPLY</a></p>
                            <div class="clearfix"></div>
                        </div>
                        <div class="comments-top-top">
                            <div class="men">
                                <i class=" glyphicon glyphicon-user"></i>
                            </div>
                            <p class="men-it">
                                <asp:Label runat="server" Text='<%#Eval("ReviewContent") %>'></asp:Label>
                            </p>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>


            <asp:Repeater ID="Comment2" runat="server">
                <ItemTemplate>
                    <div class="met">
                        <div class="code-in">
                            <p class="smith">
                                <a href="#">
                                    <asp:Label runat="server" Text='<%#Eval("Username") %>'> </asp:Label></a> <span>
                                        <asp:Label runat="server" Text='<%#Eval("DateReview") %>'></asp:Label>
                                    </span>
                            </p>              
                            <div class="clearfix"></div>
                        </div>
                        <div class="comments-top-top">
                            <div class="men">
                                <i class=" glyphicon glyphicon-user"></i>
                            </div>
                            <p class="men-it">
                                <asp:Label runat="server" Text='<%#Eval("ReviewContent") %>'></asp:Label>
                            </p>
                            <div class="clearfix"></div>

                            <div class="met met-in">
                                <div class="code-in">
                                    <p class="smith"><a href="#">Robert Smith</a> <span><asp:Label runat="server" Text='<%#Eval("DateReply") %>'></asp:Label></span></p>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="comments-top-top top-in">
                                    <div class="men">
                                        <i class=" glyphicon glyphicon-user"></i>
                                    </div>
                                    <p class="men-it two"><asp:Label runat="server" Text='<%#Eval("Content") %>'></asp:Label></p>
                                    <div class="clearfix"></div>
                                </div>
                            </div>

                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>



        </div>
        <div class="leave">
            <h3>Leave a comment</h3>
            <div class="single-grid">
                <form>
                    <div class="single-us">

                        <textarea id="textContent" runat="server" placeholder="Comment"></textarea>
                        <asp:Button ID="btnSubmit" OnClick="submit_Click" runat="server" Text="Submit" CssClass="submit" />
                        <asp:Label ID="txtError" Text="You need login" Visible="false" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                </form>
            </div>
        </div>
    </div>


    </div>
    </div>
        <!--//single-->
    <!--contact-->
    <section class="section-wrapper services-owl">
        <div class="container">
            <div class="owl-carousel services-owl-carousel row">
                <div class="item col-sm-8 col-sm-offset-2">
                    <div class="item-name">
                        David Martin
				
                    </div>
                    <p class="item-detail">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eos omnis, architecto ipsam laudantium corporis eveniet blanditiis eaque ab ex eum, provident culpa tenetur adipisci libero aliquid quia dolores deleniti illo.
				
                    </p>
                </div>
                <!-- /.item -->

                <div class="item col-sm-8 col-sm-offset-2">
                    <div class="item-name">
                        David Martin
				
                    </div>
                    <p class="item-detail">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eos omnis, architecto ipsam laudantium corporis eveniet blanditiis eaque ab ex eum, provident culpa tenetur adipisci libero aliquid quia dolores deleniti illo.
				
                    </p>
                </div>
                <!-- /.item -->

                <div class="item col-sm-8 col-sm-offset-2">
                    <div class="item-name">
                        David Martin
				
                    </div>
                    <p class="item-detail">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eos omnis, architecto ipsam laudantium corporis eveniet blanditiis eaque ab ex eum, provident culpa tenetur adipisci libero aliquid quia dolores deleniti illo.
				
                    </p>
                </div>
                <!-- /.item -->
            </div>
            <!-- /.services-owl-carousel -->
        </div>
        <!-- /.container -->
    </section>
    <!-- /.services-owl -->


    <div class="section-wrapper sponsor">
        <div class="container">
            <div class="owl-carousel sponsor-carousel">
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-1.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-2.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-3.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-4.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-5.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-6.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-1.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-2.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-3.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-4.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-5.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-6.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-1.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-2.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-3.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-4.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-5.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
                <div class="item">
                    <a href="#">
                        <img src="assets/images/sp-6.png" alt="sponsor-brand" class="img-responsive sponsor-item">
                    </a>
                </div>
            </div>
            <!-- /.owl-carousel -->
        </div>
        <!-- /.container -->
    </div>
    <!-- /.sponsor -->

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






