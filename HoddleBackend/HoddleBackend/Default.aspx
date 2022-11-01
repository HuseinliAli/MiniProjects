<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HoddleBackend.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="FrontEnd/assets/css/style.css">
    <title>Hoddle</title>
</head>
<body>
    <!-- START HEADER -->
    <header class="header">
        <div class="container flex">
            <div class="logo">
                <a href="./index.html">
                    <img src="FrontEnd/assets/images/logo.svg" alt="alt">
                </a>
            </div>
            <div class="tryItBtn">
                <a href="#" class="tryItem">Try It Free</a>
            </div>
        </div>
    </header>
    <!-- END HEADER -->
    <main>
        <!-- START SLIDE -->
        <section id="slide">
            <asp:Repeater ID="RepeaterHeader" runat="server">
                <ItemTemplate>

                    <div class="container">
                        <div class="slide-container">
                            <div class="slide-left">
                                <div class="slide-title">
                                    <h1>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TitleInHeader") %>'></asp:Label>
                                    </h1>
                                </div>
                                <div class="slide-info">
                                    <p>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DescriptionInHeader") %>'></asp:Label>
                                    </p>
                                </div>
                                <div class="slide-btn">
                                    <a class="slide-btn-link" href="#">
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("ButtonContent") %>'></asp:Label>
                                    </a>
                                </div>
                            </div>
                            <div class="slide-right">
                                <img src='<%# Eval("ImageUrl") %>' alt="">
                            </div>
                        </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </section>
        <!-- START CARDS -->
        <section class="cards">

            <asp:Repeater ID="RepeaterPost" runat="server">
                <ItemTemplate>
                    <div class="card">
                        <div class="card-word">
                            <div class="card-title">
                                <h2>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("TitleInPost") %>'></asp:Label>
                                </h2>
                            </div>
                            <div class="card-info">
                                <p>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Eval("DescriptionInPost") %>'></asp:Label>
                                </p>
                            </div>
                        </div>
                        <div class="card-image">
                            <img src='<%#Eval("ImageUrlInPost") %>' alt="">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </section>
        <!-- END CARDS -->
    </main>
    <!-- START CARD -->
    <footer>
        <div class="logo-container">
            <div class="container">
                <div class="logo">
                    <img src="FrontEnd/assets/images/logo copy.svg" alt="">
                </div>
            </div>
        </div>
        <div class="container flex-gap">
            <div class="footer-left">

                <asp:Repeater ID="RepeaterContact" runat="server">
                    <ItemTemplate>

                        <div class="location-info icon ">
                            <span>
                                <!-- Location ucun repeater baslir-->
                                <img src='<%# Eval("IconInContact")  %>' alt="">
                            </span>
                            <span>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("DescriptionInContact")  %>'></asp:Label></span>
                            <!-- Location ucun repeater bitir -->
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="footer-center">
                <ul class="footer-navigation1">
                    <li>
                        <a href="#">About</a>
                    </li>
                    <li>
                        <a href="#">What We Do</a>
                    </li>
                    <li>
                        <a href="#">Faq</a>
                    </li>
                </ul>
                <ul class="footer-navigation2">
                    <li>
                        <a href="#">Career</a>
                    </li>
                    <li>
                        <a href="#">Blog</a>
                    </li>
                    <li>
                        <a href="#">Contact Us</a>
                    </li>
                </ul>
            </div>
            <div class="footer-right">
                <div class="social">
                    <asp:Repeater ID="RepeaterIcon" runat="server">
                        <ItemTemplate>
                            <a href="#">
                                <i class='<%#Eval("Icon") %>'></i>
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>

        <div class="copyright">
            <p>
                &#169; Copyright  2022 Huddle.All rights reserved.
            </p>
        </div>
    </footer>
    <!-- END CARDS -->
    <script src="https://kit.fontawesome.com/7254eb5e7b.js" crossorigin="anonymous"></script>
</body>
</html>
