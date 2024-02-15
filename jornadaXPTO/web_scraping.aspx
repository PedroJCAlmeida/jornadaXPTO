<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web_scraping.aspx.cs" Inherits="jornadaXPTO.web_scraping" %>

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
                </ul>
            </div>
            <div class="ht-links">
                
            </div>
        </div>
        <ul class="main-menu mobile-menu">
            <li ><a href="/index.aspx">Home</a></li>
            <li runat="server" id="liga" style="display:none"><a href="ligas.aspx">Ligas</a></li>
            <li runat="server" id="escalacao" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
            <li class="active" runat="server" id="gestao" style="display:none"><a href="#">Gestão</a>
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
        <section class="schedule-section spad">
        <h4><asp:Label style="margin-left:40%" ID="lbl_mensagem" runat="server" Text=""></asp:Label></h4>
            <div class="container" >
              <div class="row">
                <div class="col-lg-8 left-blog-pad" >
                    <div class="schedule-text" style="width:500px;">
                        <h4 class="st-title">Automação Jogadores</h4>
                    <div class="st-table">
                        <h5>Selecionar Jornada :<asp:DropDownList ID="ddl_jornada" runat="server" DataSourceID="SqlDataSource2" DataTextField="id_jornada" DataValueField="id_jornada" Width="104px" AutoPostBack="True" OnSelectedIndexChanged="ddl_jornada_SelectedIndexChanged"></asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [jornadas]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [links]"></asp:SqlDataSource>
        </h5>
        <br />
        <h5>Selecionar Jogo:
        <asp:DropDownList ID="ddl_jogo" runat="server" DataSourceID="SqlDataSource1" DataTextField="num_jogo" DataValueField="link" Width="105px" AutoPostBack="True" OnSelectedIndexChanged="ddl_jogo_SelectedIndexChanged"></asp:DropDownList>
        </h5>
        <br />
        <br />
       
          <asp:Button class="primary-btn" ID="btn_salvar" runat="server" Text="Salvar na BD" onclick="btn_salvar_Click"/>
        <br />
        <br />

      
        <table>
            <thead>
                <tr>
                     <td><asp:Label ID="lbl_casa" runat="server" Text="Casa"></asp:Label></td>
                     <td><asp:Label ID="lbl_clube" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_treinador" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>Jogador</td>
                    <td>Pontos</td>
                    <td>Id Jogador</td>
                    <td>Id Clube</td>
                    <td>Id Posição</td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><asp:Label ID="lbl_jogador" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador2" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos2" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador2" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube2" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao2" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador3" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos3" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador3" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube3" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao3" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador4" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos4" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador4" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube4" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao4" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador5" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos5" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador5" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube5" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao5" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador6" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos6" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador6" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube6" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao6" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador7" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos7" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador7" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube7" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao7" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador8" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos8" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador8" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube8" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao8" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador9" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos9" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador9" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube9" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao9" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador10" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos10" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador10" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube10" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao10" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador11" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos11" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador11" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube11" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao11" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador23" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos23" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador23" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube23" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao23" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador24" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos24" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador24" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube24" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao24" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador25" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos25" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador25" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube25" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao25" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador26" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos26" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador26" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube26" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao26" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador27" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos27" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador27" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube27" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao27" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td></td>
                    <td></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_visitante" runat="server" Text="Visitante"></asp:Label></td>
                    <td><asp:Label ID="lbl_clube2" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_treinador2" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador12" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos12" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador12" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube12" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao12" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador13" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos13" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador13" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube13" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao13" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador14" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos14" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador14" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube14" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao14" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador15" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos15" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador15" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube15" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao15" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador16" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos16" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador16" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube16" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao16" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador17" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos17" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador17" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube17" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao17" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador18" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos18" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador18" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube18" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao18" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador19" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos19" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador19" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube19" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao19" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador20" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos20" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador20" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube20" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao20" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador21" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos21" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador21" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube21" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao21" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador22" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos22" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador22" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube22" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao22" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador28" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos28" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador28" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube28" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao28" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador29" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos29" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador29" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube29" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao29" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lbl_jogador30" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos30" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_jogador30" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube30" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao30" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador31" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos31" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador31" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube31" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao31" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="lbl_jogador32" runat="server" Text="-"></asp:Label></td>
                    <td><asp:Label ID="lbl_pontos32" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="lbl_id_jogador32" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_clube32" runat="server" Text=""></asp:Label></td>
                    <td><asp:Label ID="lbl_id_posicao32" runat="server" Text=""></asp:Label></td>
                </tr>
                </tbody>
            </table>                       
                            </div>
                    </div>
                    </div>
                 <div style="background: #00235a; padding: 12px 0 14px; height:55px; width:400px">
                <h4 style="font-size: 22px; color: #ffffff; font-weight: 500; text-align:center;">Atualizar BD</h4>

                     <asp:Button style="margin-top:10%; margin-left:25%" class="btn-primary" ID="btn_jogadores" runat="server" Text="Valores e Pontos Jogadores" onclick="btn_jogadores_Click"/>
                     <asp:Button style="margin-top:10%; margin-left:35%" class="btn-primary" ID="btn_mercado" runat="server" Text="Fechar Mercado" onclick="btn_mercado_Click"/>
                     <asp:Button style="margin-top:10%; margin-left:25%" class="btn-primary" ID="btn_utilizador" runat="server" Text="Atualizar Valores Utilizadores" OnClick="btn_utilizador_Click"/>
                    
                     </div>
                </div>
            </div>
            </section>

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
   <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/jquery.slicknav.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/main.js"></script>
        
    </form>
</body>
</html>