<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestao_utilizadores.aspx.cs" Inherits="jornadaXPTO.gestao_utilizadores" %>

<!DOCTYPE html>

<html lang="pt-pt" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="UTF-8"/>
    <meta name="description" content="Specer Template"/>
    <meta name="keywords" content="Specer, unica, creative, html"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <title>Jornada XPTO</title>

    <!-- Google Font -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700,900&display=swap" rel="stylesheet"/>

    <!-- Css Styles -->
    <link rel="stylesheet" href="css/bootstrap.min.css" type="text/css"/>
    <link rel="stylesheet" href="css/font-awesome.min.css" type="text/css"/>
    <link rel="stylesheet" href="css/owl.carousel.min.css" type="text/css"/>
    <link rel="stylesheet" href="css/magnific-popup.css" type="text/css"/>
    <link rel="stylesheet" href="css/slicknav.min.css" type="text/css"/>
    <link rel="stylesheet" href="css/style.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Page Preloder -->
    <div id="preloder">
        <div class="loader"></div>
    </div>

    <!-- Offcanvas Menu Section Begin -->
    <div class="offcanvas-menu-overlay"></div>
    <div class="offcanvas-menu-wrapper">
        <div class="canvas-close">
            <i class="fa fa-close"></i>
        </div>
        <div class="search-btn search-switch">
            <i class="fa fa-search"></i>
        </div>
        <div class="header__top--canvas">
            <div class="ht-info">
                <ul>
                    <li><asp:Label ID="lbl_data" runat="server" Text=""></asp:Label></li>
                     <li><a href="dados_utilizador.aspx"><asp:Label ID="lbl_utilizador2" runat="server" Text="Login"></asp:Label></a></li>
                    </ul>
            </div>
            <div class="ht-links">
                
            </div>
        </div>
        <ul class="main-menu mobile-menu">
             <li><a href="/index.aspx">Home</a></li>
            <li runat="server" id="liga" style="display:none"><a href="ligas.aspx">Ligas</a></li>
            <li runat="server" id="escalacao" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
            <li  class="active" runat="server" id="gestao" style="display:none"><a href="#">Gestão</a>
                <ul class="dropdown">
                    <li><a href="registar_club.aspx">Registar Clube</a></li>
                    <li><a href="registar_jogador.aspx">Registar Jogador</a></li>
                    <li><a href="inserir_escudo_camisa.aspx">Registar Emblemas e Flâmulas</a></li>
                    <li><a href="gestao_utilizadores.aspx">Gestão de Utilizador</a></li>
                    <li><a href="gestao_clubes.aspx">Gestão de Clubes</a></li>
                    <li><a href="gestao_jogadores.aspx">Gestão de Jogadores</a></li>
                     <li><a href="web_scraping.aspx">Automação</a></li>
                </ul></li>
            <li ><a href="politica.aspx">Privacidade</a></li>
                                 <li ><a href="sobre.aspx">Sobre</a></li>
        </ul>        
        <div id="mobile-menu-wrap"></div>
    </div>
    <!-- Offcanvas Menu Section End -->

    <!-- Header Section Begin -->
    <header class="header-section">
        <div class="header__top">
            <div class="container">
                <div class="row">
                    <div class="col-lg-6">
                        <div class="ht-info">
                            <ul>
                                <li><asp:Label ID="lbl_data2" runat="server" Text=""></asp:Label></li>
                                 <li><a href="dados_utilizador.aspx"><asp:Label ID="lbl_utilizador" runat="server" Text="Login"></asp:Label></a></li>
                                 </ul>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="ht-links">
                            <a href="#" style="width:300px"> <i><asp:Label style="margin-left:5%;font-size:18px; color:#e10014" ID="id_mercado" runat="server" Text="Mercado Aberto até 15/12 às 20h"></asp:Label>
                           </i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="header__nav">
            <div class="container">
                <div class="row">
                    <div class="col-lg-2">
                        <div class="logo">
                             <a href="index.aspx" style="color:white; font-size:25px" ><span>Jornada XPTO</span></a> 
                        </div>
                    </div>
                    <div class="col-lg-10">
                        <div class="nav-menu">
                            <ul class="main-menu">
                               <li ><a href="index.aspx">Home</a></li>
                                <li runat="server" id="liga2" style="display:none"><a href="ligas.aspx">Ligas</a></li>
                                <li runat="server" id="escalacao2" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
                                <li class="active" runat="server" id="gestao2" style="display:none"><a href="#">Gestão</a>
                                 <ul class="dropdown">
                                       <li><a href="registar_club.aspx">Registar Clube</a></li>
                                       <li><a href="registar_jogador.aspx">Registar Jogador</a></li>
                                       <li><a href="inserir_escudo_camisa.aspx">Registar Emblemas e Flâmulas</a></li>
                                       <li><a href="gestao_utilizadores.aspx">Gestão de Utilizador</a></li>
                                       <li><a href="gestao_clubes.aspx">Gestão de Clubes</a></li>
                                       <li><a href="gestao_jogadores.aspx">Gestão de Jogadores</a></li>
                                       <li><a href="web_scraping.aspx">Automação</a></li>
                            </ul></li>
                                <li ><a href="politica.aspx">Privacidade</a></li>
                                 <li ><a href="sobre.aspx">Sobre</a></li>
                                 <li><a href="logout.aspx"><asp:Label ID="lbl_logout" runat="server" Text=""></asp:Label></a></li>
               
                            </ul>
                            
                        </div>
                    </div>
                </div>
                <div class="canvas-open">
                    <i class="fa fa-bars"></i>
                </div>
            </div>
        </div>
    </header>
    <!-- Header End -->
           

    <!-- Contact Section Begin -->
    <section class="schedule-section spad">
        <div class="container" >
            <div class="row">
                <div class="col-lg-8 left-blog-pad" >
                    <div class="schedule-text" style="width:1150px;">
                        <h4 class="st-title">Gestão de Utilizadores</h4>
                        <div class="st-table">
                           <div class="scrollable-div">
                    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1"  OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                        <HeaderTemplate>
                              <table class="table">
                                    <tr style="background: #00235a; padding: 12px 0 14px; font-size: 15px; color: #ffffff; font-weight: 500; text-align:center;">
                                    <td>Cód</td>
                                    <td>Utilizador</td>
                                    <td>Equipa</td>
                                    <td>Adepto</td>
                                    <td>E-mail</td>
                                    <td>Perfil Utilizador</td>
                                    <td>Ativo</td>
                                    <td><asp:Button class="btn-primary" ID="btn_salvar_todos" runat="server" Text="Salvar Todos" CommandName="btn_salvar_todos" OnClick="btn_salvar_todos_Click"/></td>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            
                            <tr class="text-center">
                                    <td><asp:Label ID="lbl_cod" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_utilizador" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_equipa" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_adepto" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_email" runat="server" Text=""></asp:Label></td>
                                    <td><asp:DropDownList ID="ddl_perfil_utilizador" runat="server" DataSourceID="SqlDataSource2" DataTextField="perfil_utilizador" DataValueField="id_perfil_utilizador"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT [perfil_utilizador], [id_perfil_utilizador] FROM [perfil_utilizador]"></asp:SqlDataSource></td>
                                     <td><asp:DropDownList ID="ddl_status" runat="server">
                        <asp:ListItem Value="False">Não</asp:ListItem>
                        <asp:ListItem Value="True">Sim</asp:ListItem>
                    </asp:DropDownList></td>
                                <td>
                                    <asp:Button class="btn-primary" ID="btn_salvar" runat="server" Text="Salvar" CommandName="btn_salvar" /></td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="text-center" style="background-color:lightgray;">
                                    <td><asp:Label ID="lbl_cod" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_utilizador" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_equipa" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_adepto" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_email" runat="server" Text=""></asp:Label></td>
                                    <td><asp:DropDownList ID="ddl_perfil_utilizador" runat="server" DataSourceID="SqlDataSource2" DataTextField="perfil_utilizador" DataValueField="id_perfil_utilizador"></asp:DropDownList>
                                </td>
                                    <td><asp:DropDownList ID="ddl_status" runat="server">
                        <asp:ListItem Value="False">Não</asp:ListItem>
                        <asp:ListItem Value="True">Sim</asp:ListItem>
                    </asp:DropDownList></td>
                                <td>
                                    <asp:Button class="btn-primary" ID="btn_salvar" runat="server" Text="Salvar" CommandName="btn_salvar" /></td>
                                </tr>
                           
                        </AlternatingItemTemplate>
                        <FooterTemplate>
                            </table>
                            
                        </FooterTemplate>
                    </asp:Repeater>
                                </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="select u.id_utilizador, u.nome_utilizador, u.nome_time, c.clube, u.email_utilizador, u.palavra_passe, p.perfil_utilizador, u.ativado from utilizadores as u
inner join perfil_utilizador as p on p.id_perfil_utilizador = u.id_perfil
inner join clube_adeptos as c on c.id_clube = u.id_clube"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT [perfil_utilizador], [id_perfil_utilizador] FROM [perfil_utilizador]"></asp:SqlDataSource>

                    </div>
                          
                </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Contact Section End -->

   <!-- Footer Section Begin -->
    <footer class="footer-section set-bg" data-setbg="img/footer-bg.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-6">
                    <div class="fs-logo">
                        <div class="logo">
                             <a href="index.aspx" style="color:white; font-size:25px" ><span>Jornada XPTO</span></a> 
                        </div>
                        <ul>
                            <li><i class="fa fa-envelope"></i> pedro.almeida.22122@formandos.cinel.pt</li>
                            <li><i class="fa fa-copy"></i> +351 911 837 861</li>
                            <li><i class="fa fa-thumb-tack"></i> Vila Nova de Gaia, Porto</li>
                        </ul>
                        <div class="fs-social">
                            <a href="https://www.facebook.com/pedro.almeida.7140497"><i class="fa fa-facebook"></i></a>
                            <a href="https://www.linkedin.com/in/pedro-j-c-almeida/"><i class="fa fa-linkedin"></i></a>
                            <a href="https://www.instagram.com/pjcalmeida/"><i class="fa fa-instagram"></i></a>
                        </div>
                    </div>
                </div>
              
              
            </div>
        </div>
        <div class="container">
            <div class="copyright-option">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="co-text"><p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
  Copyright &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class="fa fa-heart" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Colorlib</a>
  <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. --></p></div>
                        <div class="co-widget">
                            <ul>
                                <li><a href="#">Copyright notification</a></li>
                                <li><a href="politica.aspx">Terms of Use</a></li>
                                <li><a href="politica.aspx">Privacy Policy</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer> -->
    <!-- Footer Section End -->


    <!-- Js Plugins -->
    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/jquery.slicknav.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/main.js"></script>
    </form>
</body>
</html>
