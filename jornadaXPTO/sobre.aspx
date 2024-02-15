<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sobre.aspx.cs" Inherits="jornadaXPTO.sobre" %>

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
                <a href="#" style="width:300px"> <i><asp:Label style="margin-left:5%;font-size:18px; color:#e10014" ID="Label1" runat="server" Text="Mercado Aberto até 15/12 às 20h"></asp:Label>
                           </i></a>
            </div>
        </div>
        <ul class="main-menu mobile-menu">
            <li ><a href="/index.aspx">Home</a></li>
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
                <li class="active" ><a href="sobre.aspx">Sobre</a></li>
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
                                 <li class="active"><a href="sobre.aspx">Sobre</a></li>
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

 <section class="club-section spad">
        <div class="container">
            <div class="club-content">
                <div class="row">
                    <div class="col-lg-5">
                        <div class="cc-pic">
                            <img src="img/club-logo.png" alt="">
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="cc-text">
                            <div class="ct-title">
                                <h3>ENTENDA MAIS</h3>
                                <p>O que é JonradaXPTO?<br/><br />
                                  O JornadaXTPO é o jogo onde você pode montar seu próprio time 
                                    com os jogadores reais da Primeira Liga do Campeonato de Portugal. 
                                 Você pode acompanhar o campeonato de maneira divertida competindo com os
                                    seus amigos e outros utilizadores para ver quem sabe tudo de futebol e
                                    escolher os melhores atletas.<br /><br />
                                    ► Escale seus jogadores e o técnico usando suas Guitas: a moeda do game (G$).<br />
                                    ► A cada jornada da Primeira Liga, a vossa equipa pontua baseado em suas ações nas partidas.<br />
                                    ► Desafie seus amigos e veja quem é o melhor da malta!
                                </p>
                            </div>
                          </div>
                    </div>
                </div>
            </div>
            <div class="club-tab-list" >
                <div class="row" >
                    <div class="col-lg-8 m-auto" >
                        <ul class="nav nav-tabs" role="tablist" style="width:830px">
                            <li class="nav-item">
                                <a class="nav-link active" data-toggle="tab" href="#tabs-1" role="tab">Como Funciona</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-2" role="tab">Minha Equipa</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-3" role="tab">Pontuação e Patrimônio</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-4" role="tab">Competições</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-5" role="tab">Premiação</a>
                            </li>
                        </ul><!-- Tab panes -->
                        <div class="tab-content">
                            <div class="tab-pane active" id="tabs-1" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                            <h3>Como Funciona</h3><br />
                                    <p> O JornadaXPTO é o jogo onde você pode montar seu próprio time com os jogadores reais da 
                                        Primeira Liga do Campeonato Português! Você pode acompanhar o campeonato de maneira divertida 
                                        competindo com os seus amigos e outros utilizadores para ver quem sabe tudo de futebol 
                                        e escolher os melhores atletas.<br /></p>
                                    <p>Para jogar, é preciso criar um perfil no JornadaXPTO, informando o nome do 
                                        presidente da equipa - você! -, escolhendo um nome para o sua equipa, um escudo e um uniforme.
                                        Depois disso, é só escalar a sua equipa, selecionando 1 técnico e 11 jogadores da Primeira Liga.
                                        Mas lembre-se: a escalação deve ser feita enquanto o mercado estiver aberto 
                                        (o mercado fecha 30 minuto antes do primeiro jogo da jornada).<br /><br />
                                        
                                        A cada jornada, os jogadores recebem pontuações baseadas em suas ações durante as partidas 
                                        (ex: gols feitos, chutes defendidos, desarmes, faltas cometidas ou sofridas, 
                                        cartões tomados, etc.). Ao final da jornada, seu time terá uma pontuação que determinará 
                                        o seu lugar nos rankings e nas ligas (as informações de performance dos atletas, são extraidas do sitio zerozero.pt).
                                        <br />
                                        <br />
                                        ► Mercado: O mercado de jogadores é onde você pode visualizar todos os atletas da
                                        Primeira Liga e escolher quem vai fazer parte do seu time naquela jornada. 
                                        Ele fica aberto até 30 minuto antes do primeiro jogo de cada jornada, e você só poderá escalar 
                                        seu time enquanto o mercado estiver aberto. Durante a jornada, o mercado fica fechado e 
                                        nesse momento não poderá comprar ou vender jogadores. O mercado reabre algumas horas
                                        depois do fim do último jogo da jornada.<br /><br />
                                        ► Rodada: A Primeira Liga tem ao todo 36 jornadas, ao longo das quais as 18 equipas se enfrentam em 
                                        9 jogos de turno e returno, subindo ou descendo sua colocação na classificação. 
                                        As jornadas do JornadaXPTO seguem as da Primeira Liga, e você deve escalar o sua equipa em cada jornada
                                        para pontuar bem no game.
                                       </p>
                                        </div>
                                        </div></div></div>
                           <div class="tab-pane" id="tabs-2" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                            <h3>Minha Equipa</h3><br />
                                    <p>Para participar das jornadas no JornadaXPTO você precisa escalar o sua equipa, 
                                        um Técnico e onze atletas de linha sendo um guarda redes e mais 10 de campo.</p><br />
                                    <p>Para montar o sua equipa, é necessário levar em consideração o seu esquema tático, 
                                       seu preço e suas estatísticas.<br /><br />
                                    ► Escalação: Acompanhar o desempenho da sua equipa e dos atletas escalados é um passo 
                                        importante para se dar bem no JornadaXPTO. Você pode escolher o esquema tático de sua preferência 
                                        e selecionar 11 jogadores e um técnico para compor a sua equipa.  <br /><br />
                                    ► Esquema tático e posições dos jogadores: O esquema tático ou a formação tática que sua equipa joga 
                                        é um ponto crucial para sua estratégia no game. Cada jogador tem uma função em campo, e essa é determinada por sua 
                                        posição dentro do esquema tático escolhido. No JornadaXPTO, a defesa do seu time é formada pelo goleiro, pelos zagueiros 
                                        e os laterais, enquanto o ataque é liderado pelos atacantes e meias. A defesa e o ataque do seu time definem para quais 
                                        scouts você deve olhar na hora de pensar sua escalação, pois cada estratégia tem uma pontuação diferenciada.<br /><br />
                                    Atualmente existem 3 esquemas táticos:<br /><br />
                                        • <b>4-3-3:</b> é a formação mais famosa entre os jogadores. É um esquema com ataque e 
                                        defesa fortes, com menos jogadores de meio de campo - é composto por 2 laterais, 2 centrais, 3 medios e 3 avançados.<br />
                                        • <b>4-4-2:</b> é o esquema tático padrão do jogo. Um esquema mais defensivo, que se apoia em apenas 2 atacantes. 
                                        Possui também 4 médios e 4 jogadores na defesa: 2 laterais e 2 zagueiros.<br />
                                        • <b>3-5-2:</b> é o esquema tátio mais dinâmico, pois é composto por 3 centrais, 2 laterais, 3 médios  2 avançados.
                                    </p>
                                        </div>
                                        </div></div></div>
                            <div class="tab-pane" id="tabs-3" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                            <h3>Pontuações e patrimônio</h3><br />
                                    <p>As ações dos jogadores em campo são chamadas de Performance e são elas que geram a pontuação do seu time no JornadaXPTO. 
                                        O futebol é um jogo complexo e várias dúvidas surgem durante as partidas:
                                        Quanto vale um gol? Assistência dá muito ponto? Como funciona o bônus de jogo sem sofrer gols?<br /><br />
                                        • No momento nossa pontuação é baseada nas performances apresentadas no portal zerozero.pt, 
                                        onde é multiplicado 1,5 sobre o valor apresentado no portal zerozero.pt. <br /><br />

                                        ► Patrimônio: Você começa o game com G$100 (cem guitas) e, com esse dinheiro, 
                                        você pode escalar os atletas do mercado para a sua equipa. O valor total da sua equipa 
                                        - a soma do valor de cada jogador escalado - junto à quantidade de dinheiro que você ainda
                                        tem guardada é o seu patrimônio total. É com esse patrimônio que você compete para ser o 
                                        mais rico do jogo nas suas ligas pessoais e nas outras ligas.<br /><br />

                                         ► Guitas: A moeda oficial do JornadaXPTO é a Guita (G$). As Guitas que você 
                                        junta são utilizadas para escalar os atletas da sua equipa. Todo utilizador começa a 
                                        primeira jornada com 100 Guitas e a cada rodada tem a chance de ganhá-las ou o 
                                        risco de perdê-las através da valorização ou desvalorização dos jogadores escalados 
                                        na sua equipa.<br /><br />
                                       
                                         ► Valorização: A valorização de um jogador leva em consideração a sua pontuação da rodada, a média de pontuação
                                        dele ao longo do campeonato e a média de preços ao longo do campeonato, em relação à performance dos outros 
                                        jogadores no mercado e a quantidade de guitas em circulação. Quando um jogador valoriza, isso significa que o 
                                        seu valor aumentou. O contrário acontece quando ele desvaloriza. É dessa forma que ocorre a variação no preço dos 
                                        jogadores e no patrimônio dos utilizadores.<br /><br />

                                        </p>
                                        </div>
                                        </div></div></div>
                            <div class="tab-pane" id="tabs-4" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                             <h3>Competições</h3><br />
                                    <p>As competições são atráves das ligas: <br /><br />
                                        ► Podes participar de uma liga já existente; <br />
                                        ► Podes criar sua própria liga e convidar amigos para participar<br />
                                        </p>
                                        </div>
                                        </div></div></div>
                            <div class="tab-pane" id="tabs-5" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                             <h3>Premiação</h3><br />
                                    <p>Não há quaquer tipo de premiação financeira, apenas a satisfação de ver entre amigos o quanto sabem de futebol.<br />
                                        </p>
                                        </div>
                                        </div></div></div>
                        </div>
                    </div>
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
