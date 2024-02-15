    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="jornadaXPTO.index" %>

<!DOCTYPE html>

<html lang="pt-pt" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8"/>
    <meta name="description" content="Jornada XPTO"/>
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
                         <li><a href="logout.aspx"><asp:Label ID="lbl_logout2" runat="server" Text="Logout"></asp:Label></a></li>
                 
                </ul>
            </div>
            <div class="ht-links">
                
            </div>
        </div>
        <ul class="main-menu mobile-menu">
            <li class="active"><a href="/index.aspx">Home</a></li>
            <li runat="server" id="liga" style="display:none"><a href="ligas.aspx">Ligas</a></li>
            <li runat="server" id="escalacao" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
            <li runat="server" id="gestao" style="display:none"><a href="#">Gestão</a>
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
                                <li class="active"><a href="index.aspx">Home</a></li>
                                <li runat="server" id="liga2" style="display:none"><a href="ligas.aspx">Ligas</a></li>
                                <li runat="server" id="escalacao2" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
                                <li runat="server" id="gestao2" style="display:none"><a href="#">Gestão</a>
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

    <!-- Hero Section Begin -->
    <section class="hero-section set-bg" data-setbg="img/hero/hero-1.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="hs-item">
                        <div class="container">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="hs-text">
                                        <h4></h4>
                                        <h2>Faça Parte da Nossa Liga</h2>
                                        <a href="registar_utilizador.aspx" class="primary-btn">Registra-se AQUI</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Hero Section End -->

    <!-- Soccer Section Begin -->
    <section class="soccer-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 p-0">
                    <div class="section-title">
                        <h3>Sport <span>Feed</span></h3>
                    </div>
                </div>
            </div>
            <div class="row">
                 <asp:Xml ID="Xml1" runat="server" TransformSource="formata_desporto.xslt"></asp:Xml>
              
            </div>
        </div>
    </section>
    <!-- Soccer Section End -->

    <!-- Latest Section Begin -->
    <section class="latest-section">
        <div class="container">
            <div class="row">
                <!--Primeira Liga-->
                <div class="col-lg-4">
                    <div class="section-title">
                        <h3>Ranking <span>Primeira Liga</span></h3>
                    </div>
                    <div class="points-table">
                        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1" OnItemDataBound="Repeater1_ItemDataBound" >
                            <HeaderTemplate>
                                <table>
                            <thead>
                                <tr>
                                    <th class="th-o">Pos</th>
                                    <th class="th-o">Emblema</th>
                                    <th>CLUBE</th>
                                    <th class="th-o">J</th>
                                    <th class="th-o">PTS</th>
                                </tr>
                            </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                <tr>
                                    <td><asp:Label ID="lbl_ordem" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Image ID="img_emblema" runat="server"  Height="40px" Width="40px"/></td>
                                    <td class="team-name">
                                       <span><asp:Label ID="lbl_clube" runat="server" Text=""></asp:Label></span>
                                    </td>
                                    <td><asp:Label ID="lbl_jogos" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_pontos" runat="server" Text=""></asp:Label></td>                                    
                                </tr>
                                </tbody>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                 <tbody>
                                <tr>
                                    <td><asp:Label ID="lbl_ordem" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Image ID="img_emblema" runat="server"  Height="40px" Width="40px"/></td>
                                    <td class="team-name">
                                       <span><asp:Label ID="lbl_clube" runat="server" Text=""></asp:Label></span>
                                    </td>
                                    <td><asp:Label ID="lbl_jogos" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Label ID="lbl_pontos" runat="server" Text=""></asp:Label></td>                                  
                                </tr>
                                </tbody>
                            </AlternatingItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="select c.emblema, c.nome_clube, p.num_jogos, p.pontos from primeira_liga as p
inner join clubes as c on c.id_clube = p.id_clube
order by p.pontos desc
"></asp:SqlDataSource>
                </div>
                    </div>
               
             <div class="col-lg-4" style="width:350px">
                    <div class="section-title">
                        <h3>Ligas <span>Com Mais Adeptos</span></h3>
                    </div>
                    <div class="points-table">
                        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource2" OnItemDataBound="Repeater2_ItemDataBound" >
                            <HeaderTemplate>
                                <table>
                            <thead>
                                <tr>
                                    <th class="th-o">Pos</th>
                                    <th class="th-o">Flamula</th>
                                    <th>Liga</th>
                                    <th class="th-o">Qtd</th>
                                    </tr>
                            </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                <tr>
                                    <td><asp:Label ID="lbl_ordem" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Image ID="img_flamula" runat="server"  Height="40px" Width="40px"/></td>
                                    <td class="team-name">
                                       <span><asp:Label ID="lbl_liga" runat="server" Text=""></asp:Label></span>
                                   <asp:Label ID="lbl_id_liga" runat="server" Text="" Visible="false"></asp:Label>
                                        
                                        </td>
                                    <td><asp:Label ID="lbl_qtd" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                </tbody>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                 <tbody>
                                <tr>
                                    <td><asp:Label ID="lbl_ordem" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Image ID="img_flamula" runat="server"  Height="40px" Width="40px"/></td>
                                    <td class="team-name">
                                       <span><asp:Label ID="lbl_liga" runat="server" Text=""></asp:Label></span>
                                    <asp:Label ID="lbl_id_liga" runat="server" Text="" Visible="false"></asp:Label>
                                        
                                    </td>
                                    <td><asp:Label ID="lbl_qtd" runat="server" Text=""></asp:Label></td>                               
                                </tr>
                                </tbody>
                            </AlternatingItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l  
inner join liga_utilizador as u on u.id_liga=l.id_liga
inner join flamulas as f on f.id_flamula = l.id_flamula
where u.ativado = 'true'
group by f.flamula, l.nome_liga, l.id_liga
order by  Qtd desc"></asp:SqlDataSource>
                
                    </div>
                </div>
              
                  <div class="col-lg-4" style="width:350px">
                    <div class="section-title">
                        <h3>Equipas <span>Com Mais Pontos</span></h3>
                    </div>
                    <div class="points-table">
                        <asp:Repeater ID="Repeater3" runat="server" DataSourceID="SqlDataSource3" OnItemDataBound="Repeater3_ItemDataBound" >
                            <HeaderTemplate>
                                <table>
                            <thead>
                                <tr>
                                    <th class="th-o">Pos</th>
                                    <th class="th-o">Escudo</th>
                                    <th>EQUIPA</th>
                                    <th class="th-o">Pontos</th>
                                </tr>
                            </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                <tr>
                                   <td><asp:Label ID="lbl_ordem" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Image ID="img_escudo" runat="server"  Height="40px" Width="40px"/></td>
                                    <td class="team-name">
                                       <span><asp:Label ID="lbl_equipa" runat="server" Text=""></asp:Label></span>
                                    <asp:Label ID="lbl_id_equipa" runat="server" Text="" Visible="false"></asp:Label>
                                        
                                    </td>
                                    <td><asp:Label ID="lbl_pontos" runat="server" Text=""></asp:Label></td>                               
                                 </tr>
                                </tbody>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                 <tbody>
                                <tr>
                                    <td><asp:Label ID="lbl_ordem" runat="server" Text=""></asp:Label></td>
                                    <td><asp:Image ID="img_escudo" runat="server"  Height="40px" Width="40px"/></td>
                                    <td class="team-name">
                                       <span><asp:Label ID="lbl_equipa" runat="server" Text=""></asp:Label></span>
                                    <asp:Label ID="lbl_id_equipa" runat="server" Text="" Visible="false"></asp:Label>
                                        
                                    </td>
                                    <td><asp:Label ID="lbl_pontos" runat="server" Text=""></asp:Label></td>                               
                                </tr>
                                </tbody>
                            </AlternatingItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="select top 18 e.emblema, u.nome_time, u.pontos, u.id_utilizador from utilizadores as u
inner join escudos as e on e.id_escudo =u.id_escudo
order by u.pontos desc
"></asp:SqlDataSource>
                
                    </div>
                </div>
                   </div>
             </div>
    </section>
    <!-- Latest Section End -->


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
