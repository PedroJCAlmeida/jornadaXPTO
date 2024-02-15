<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="politica.aspx.cs" Inherits="jornadaXPTO.politica" %>

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
              <li class="active"><a href="politica.aspx">Privacidade</a></li>
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
                                <li class="active"><a href="politica.aspx">Privacidade</a></li>
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
                                <h3>Política de Privacidade</h3>
                                <p>A presente Política de Privacidade explicita os termos em que a JornadaXPTO, com sede em 
                                    Portugal continental, proprietária e administradora do sítio jornadaxpto.pt, 
                                    utiliza e procede ao tratamento dos dados e informações dos seus 
                                    Utilizadores. As regras de recolha, utilização e tratamento de 
                                    dados e informações encontram-se em conformidade com a legislação nacional e o 
                                    Regulamento da Proteção de dados Pessoais 2016/679 do Parlamento Europeu e do 
                                    Conselho de 27 de Abril de 2016. A nova Política de Privacidade entra em vigor a 
                                    partir de 12.12.2023.</p>
                            </div>
                          </div>
                    </div>
                </div>
            </div>
            <div class="club-tab-list">
                <div class="row">
                    <div class="col-lg-8 m-auto">
                        <ul class="nav nav-tabs" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" data-toggle="tab" href="#tabs-1" role="tab">Responsáveis</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-2" role="tab">Recolhimento</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-3" role="tab">Profiling</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-4" role="tab">Finalidade</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-toggle="tab" href="#tabs-5" role="tab">Segurança</a>
                            </li>
                        </ul><!-- Tab panes -->
                        <div class="tab-content">
                            <div class="tab-pane active" id="tabs-1" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                            <h3>Identificação do Responsável pelo tratamento de dados</h3><br />
                                    <p> JornadaXPTO zela pela privacidade e pela proteção dos dados pessoais dos seus Utilizadores
                                        (doravante designados por “Utilizadores”) sendo responsável pelo 
                                        sítio www.jornadaxpto.pt (doravante designado por “Sítio”).</p>
                                    <p>Poderá obter mais informações sobre os seus direitos e/ou exercê-los através dos 
                                        seguintes contactos: <br /><br />
                                        E-mail: pedro.almeida.22122@formandos.cinel.pt<br />   <br />
                                        Website: www.jornadaxpto.pt</p>
                                        </div>
                                        </div></div></div>
                           <div class="tab-pane" id="tabs-2" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                            <h3>Que dados pessoais tratamos</h3><br />
                                    <p>Recolhemos, registamos e armazenamos apenas os dados pessoais que permitam a criação de um perfil dos 
                                        Utilizadores que optem por se inscrever como tal no Sítio.</p>
                                    <p>Os dados pessoais recolhidos aquando da criação do perfil são os seguintes: <br /><br />
                                        ► Nome do Utilizador<br />
                                        ► Nome da Equipa<br />
                                        ► Equipa Adepto<br />
                                        ► Palavra-Passe<br /></p>
                                        </div>
                                        </div></div></div>
                            <div class="tab-pane" id="tabs-3" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                            <h3>Dados recolhidos para fins de profiling</h3><br />
                                    <p>Recolhemos, registamos e armazenamos ainda dados que nos permitem padronizar os Utilizadores em 
                                        função das suas preferências com a finalidade, única e exclusiva, de podermos disponibilizar 
                                        conteúdos personalizados aos nossos Utilizadores, em função dos seus interesses, a saber: <br /><br />
                                        ► Emblema <br />
                                        ► Nome da Equipa<br />
                                        ► Equipa Adepto<br />
                                        </p>
                                        </div>
                                        </div></div></div>
                            <div class="tab-pane" id="tabs-4" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                             <h3>Para que finalidades podem ser utilizados os seus dados pessoais</h3><br />
                                    <p>Os dados pessoais dos Utilizadores são apenas recolhidos e armazenados, única e exclusivamente para: <br /><br />
                                        ► Permitir aos Utilizadores a participação no Sítio e nas suas funcionalidades; <br />
                                        ► Garantir que os Utilizadores respeitam o Código de Conduta do Utilizador do Sítio;<br />
                                        ► Manter a comunicação entre o jornadaxpto.pt e os seus utilizadores;<br />
                                        ► Fornecer um ambiente de jogo interativo aos seus utilizadores;<br />
                                        ► Melhorar o funcionamento do Sítio incluindo a gestão e priorização de conteúdos.<br /><br />
                                        
                                       <bold>♦ IMPORTANTE: </bold> Não cedemos a Terceiros os dados pessoais que nos são fornecidos pelos nossos Utilizadores, 
                                        seja para que finalidade for.
                                        <br />
                                        </p>
                                        </div>
                                        </div></div></div>
                            <div class="tab-pane" id="tabs-5" role="tabpanel">
                                <div class="club-tab-content">
                                    <div class="ct-item">
                                        <div class="ci-text">
                                             <h3>Como é que mantemos os seus dados pessoais seguros</h3><br />
                                    <p>Os nossos sistemas dispõem de uma diversidade de medidas de segurança, incluindo encriptação 
                                        avançada e ferramentas de autenticação, para ajudar a proteger e manter a segurança, 
                                        integridade e disponibilidade dos seus dados pessoais. <br />
                                        O único dado dos Utilizadores divulgado, ou tornado público no 
                                        Sítio é o Nome de Utilizador, criado pelo próprio Utilizador no momento do registo, 
                                        sendo que o jornadaxpto.pt recomenda que os Utilizadores escolham um pseudónimo por 
                                        forma a evitar que os Utilizadores se identifiquem pelos seus Nomes Próprios e Apelidos.<br />
                                        Do ponto de vista da nossa organização interna, apenas 1 (um) colaborador do jornadaxpto.pt 
                                        têm acesso à base de dados dos Utilizadores, limitando-se o acesso à mesma ao mínimo indispensável 
                                        para a gestão e manutenção da base de dados.<br />
                                        Esta norma interna visa minimizar o número de acessos à base de dados pessoais dos Utilizadores, 
                                        diminuindo a probabilidade de acesso não autorizado aos dados armazenados.<br />
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
