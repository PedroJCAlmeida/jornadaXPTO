<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="escalacao.aspx.cs" Inherits="jornadaXPTO.escalacao" %>

<html lang="pt-pt" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8"/>
    <meta name="description" content="Jornada XPTO"/>
    <meta name="keywords" content="Jornada XPTO, a liga mais popular de Portugal"/>
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
            <li class="active" runat="server" id="escalacao1" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
            <li runat="server" id="gestao" style="display:none"><a href="#">Gestão</a>
                <ul class="dropdown">
                   <li><a href="registar_club.aspx">Registar Clube</a></li>
                    <li><a href="registar_jogador.aspx">Registar Jogador</a></li>
                    <li><a href="inserir_escudo_camisa.aspx">Registar Emblemas e Flâmulas</a></li>
                    <li><a href="gestao_utilizadores.aspx">Gestão de Utilizador</a></li>
                    <li><a href="gestao_clubes.aspx">Gestão de Clubes</a></li>
                    <li><a href="gestao_jogadores.aspx">Gestão de Jogadores</a></li>
                     <li><a href="web_scraping.aspx">Automação</a></li>
                </ul>
            </li>
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
                                <li class="active" runat="server" id="escalacao2" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
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

    <!-- Breadcrumb Section Begin -->
    <section class="breadcrumb-section set-bg" data-setbg="img/breadcrumb-bg.jpg">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="bs-text">
                        <h2>Selecionar Jogadores</h2>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->

    <!-- Schedule Section Begin -->
    <section class="schedule-section spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 left-blog-pad">
                    <div class="schedule-text">
                        <h4 class="st-title">Escalação da Equipa</h4>
                        <div class="st-table">
                            <h5>&nbsp; Escolha o esquema tático:&nbsp; <asp:DropDownList ID="ddl_esquema" runat="server" DataSourceID="SqlDataSource1" DataTextField="esquema_tatico" DataValueField="id_esquema" Width="190px" AutoPostBack="True" OnSelectedIndexChanged="ddl_esquema_SelectedIndexChanged"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [esquema_tatico]"></asp:SqlDataSource>
                            </h5>&nbsp; 
                             <!-- Inicio Esquema 4-3-3 -->
                            <asp:Panel ID="Panel1" runat="server">
                            <div style="background-image:url(/img/campo2.png); background-repeat: no-repeat; width:800px; height:1050px" >
                            
                            <div>
                            <a href="javascript:rolarParaParteDeBaixo()"><asp:ImageButton style="margin-top:15%; margin-left:7%; width:70px; height:80px; border-radius:100%" ID="ibtn_av1_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_av1_p1_Click" /></a>
                            <asp:ImageButton style="margin-top:15%; margin-left:10%; width:70px;height:80px; border-radius:100%" ID="ibtn_av2_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_av2_p1_Click"/>
                            <asp:ImageButton style="margin-top:15%; margin-left:10%; width:70px; height:80px;border-radius:100%" ID="ibtn_av3_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_av3_p1_Click"/>
                            </div>

                            <div>
                            <asp:ImageButton style="margin-top:5%; margin-left:6%; width:70px;height:80px; border-radius:100%" ID="ibtn_md1_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_md1_p1_Click"/>
                            <asp:ImageButton style="margin-top:5%; margin-left:32%; width:70px;height:80px; border-radius:100%" ID="ibtn_md2_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_md2_p1_Click"/>
                            </div>

                            <div>
                                <asp:ImageButton style="margin-left:26%; width:70px; height:80px;border-radius:100%" ID="ibtn_md3_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_md3_p1_Click" />
                            </div>

                            <div>
                            <asp:ImageButton style="margin-top:5%; margin-left:5%; width:70px; border-radius:100%" ID="ibtn_df1_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_df1_p1_Click"/>
                            <asp:ImageButton style="margin-top:5%; margin-left:32%; width:70px; border-radius:100%" ID="ibtn_df2_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_df2_p1_Click"/>
                            </div>

                            <div>
                                <asp:ImageButton style="margin-left:14%; width:70px;height:80px; border-radius:100%" ID="ibtn_df3_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_df3_p1_Click"/>
                                <asp:ImageButton style="margin-left:14%; width:70px;height:80px; border-radius:100%" ID="ibtn_df4_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_df4_p1_Click"/>
                            </div>

                            <div>
                                <asp:ImageButton style="margin-left:26%; width:70px; height:80px;border-radius:100%" ID="ibtn_rd_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_rd_p1_Click"/>
                            </div>

                                <asp:ImageButton style="margin-left:5%; width:70px; height:80px;border-radius:100%" ID="ibtn_tr_p1" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_tr_p1_Click"/>
                            </div>
                            </asp:Panel>
                             <!-- Fim Esquema 4-3-3 -->

                             <!-- Inicio Esquema 4-4-2 -->
                             <asp:Panel ID="Panel2" runat="server" Visible="False">
                            <div style="background-image:url(/img/campo2.png); background-repeat: no-repeat; width:800px; height:1050px" >
                            
                            <div>
                            <asp:ImageButton style="margin-top:15%; margin-left:10%; width:70px; height:80px;border-radius:100%" ID="ibtn_av1_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_av1_p2_Click"/>
                            <asp:ImageButton style="margin-top:15%; margin-left:20%; width:70px; height:80px;border-radius:100%" ID="ibtn_av2_p2" runat="server" ImageUrl="/img/add.png" OnClick="ibtn_av2_p2_Click" />
                            </div>

                            <div>
                            <asp:ImageButton style="margin-top:5%; margin-left:6%; width:70px;height:80px; border-radius:100%" ID="ibtn_md1_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md1_p2_Click"/>
                            <asp:ImageButton style="margin-top:5%; margin-left:32%; width:70px;height:80px; border-radius:100%" ID="ibtn_md2_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md2_p2_Click"/>
                            </div>

                            <div>
                            <asp:ImageButton style="margin-left:13%; width:70px;height:80px; border-radius:100%" ID="ibtn_md3_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md3_p2_Click"/>
                            <asp:ImageButton style="margin-left:15%; width:70px;height:80px; border-radius:100%" ID="ibtn_md4_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md4_p2_Click"/>
                            </div>
                           
                            <div>
                            <asp:ImageButton style="margin-top:5%; margin-left:6%; width:70px; height:80px;border-radius:100%" ID="ibtn_df1_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df1_p2_Click"/>
                            <asp:ImageButton style="margin-top:5%; margin-left:32%; width:70px;height:80px; border-radius:100%" ID="ibtn_df2_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df2_p2_Click" />
                            </div>
                            
                            <div>
                            <asp:ImageButton style="margin-left:14%; width:70px;height:80px; border-radius:100%" ID="ibtn_df3_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df3_p2_Click"/>
                            <asp:ImageButton style="margin-left:15%; width:70px;height:80px; border-radius:100%" ID="ibtn_df4_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df4_p2_Click"/>
                            </div>

                            <div>
                                <asp:ImageButton style="margin-left:26%; width:70px;height:80px; border-radius:100%" ID="ibtn_rd_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_rd_p2_Click"/>
                            </div>

                                <asp:ImageButton style="margin-left:5%; width:70px;height:80px; border-radius:100%" ID="ibtn_tr_p2" runat="server" ImageUrl="/img/add.png" onclick="ibtn_tr_p2_Click"/>
                            </div>
                                 </a>
                            </asp:Panel>
                            <!-- Fim Esquema 4-4-2 -->

                            <!-- Inicio Esquema 3-5-2 -->
                            <asp:Panel ID="Panel3" runat="server" Visible="False">
                            <div style="background-image:url(/img/campo2.png); background-repeat: no-repeat; width:800px; height:1050px" >
                            
                            <div>
                            <asp:ImageButton style="margin-top:15%; margin-left:10%; width:70px; height:80px; border-radius:100%" ID="ibtn_av1_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_av1_p3_Click"/>
                            <asp:ImageButton style="margin-top:15%; margin-left:22%; width:70px; height:80px;border-radius:100%" ID="ibtn_av2_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_av2_p3_Click" />
                            </div>

                            <div>
                            <asp:ImageButton style="margin-top:5%; margin-left:6%; width:70px; height:80px;border-radius:100%" ID="ibtn_md1_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md1_p3_Click"/>
                            <asp:ImageButton style="margin-top:5%; margin-left:32%; width:70px;height:80px; border-radius:100%" ID="ibtn_md2_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md2_p3_Click"/>
                            </div>

                            <div>
                            <asp:ImageButton style="margin-left:13%; width:70px;height:80px;border-radius:100%" ID="ibtn_md3_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md3_p3_Click"/>
                            <asp:ImageButton style="margin-left:15%; width:70px;height:80px;border-radius:100%" ID="ibtn_md4_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md4_p3_Click" />
                            </div>
                            
                            <div>
                            <asp:ImageButton style="margin-left:25%; width:70px;height:80px; border-radius:100%" ID="ibtn_md5_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_md5_p3_Click" />
                            </div>
                            
                            <div>
                            <asp:ImageButton style="margin-top:5%; margin-left:6%; width:70px;height:80px;border-radius:100%" ID="ibtn_df1_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df1_p3_Click" />
                            <asp:ImageButton style="margin-top:5%; margin-left:10%; width:70px;height:80px; border-radius:100%" ID="ibtn_df2_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df2_p3_Click"/>
                            <asp:ImageButton style="margin-top:5%; margin-left:10%; width:70px; height:80px;border-radius:100%" ID="ibtn_df3_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_df3_p3_Click"/>
                            </div>
                            
                            <div>
                            <asp:ImageButton style="margin-top:2%; margin-left:26%; width:70px;height:80px; border-radius:100% " ID="ibtn_rd_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_rd_p3_Click"/>
                            </div>

                            <asp:ImageButton style="margin-left:5%; width:70px;height:80px; border-radius:100%" ID="ibtn_tr_p3" runat="server" ImageUrl="/img/add.png" onclick="ibtn_tr_p3_Click"/>
                            </div>
                            </asp:Panel>
                            <!-- Fim Esquema 3-5-2 -->
                        </div>
                       </div>
                </div>
                <!-- Inicio Vossa equipa-->
                <div style="background: #00235a; padding: 12px 0 14px; height:50px; width:350px">
                <h4 style="font-size: 22px; color: #ffffff; font-weight: 500; text-align:center;">Vossa Equipa</h4>
                
                <div style="margin:10%"><h5>Jogadores Selecionados</h5></div>
                    <div id="selecionados">
                        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource4" OnItemDataBound="Repeater2_ItemDataBound" OnItemCommand="Repeater2_ItemCommand">
                            <HeaderTemplate>
                               <table class="table">
						            <thead class="thead-primary">
						             <tr class="text-center">
						        <th>Posição</th>
						        <th>Jogador</th>
                                <th>Valor (G$)</th>
                                <th><asp:Button  class="btn-primary" ID="btn_vender_todos" runat="server" Text="Vender Todos" onClick="btn_vender_todos_Click"/>
                                            </th>
                                </tr>
						    </thead>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tbody>
                                        <tr class="text-center">
                                            <td>
                                            <asp:Label ID="lbl_posicao" runat="server" Text=""></asp:Label>
                                            </td> 
                                            <td>
                                            <asp:Label ID="lbl_jogador_convocado" runat="server" Text=""></asp:Label>
                                            <asp:Label ID="lbl_id_jogador" runat="server" Text="" Visible="false"></asp:Label>
                                            </td>    
                                            <td>
                                            <asp:Label ID="lbl_valor_convocado" runat="server" Text=""></asp:Label>
                                            </td>   
                                            <td>
                                            <asp:Button class="btn-primary" ID="btn_vender" runat="server" Text="Vender" CommandName="btn_vender"  />
                                            </td>
                                        </tr>
                                    </tbody>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                 <tbody>
                                        <tr class="text-center">
                                            <td>
                                            <asp:Label ID="lbl_posicao" runat="server" Text=""></asp:Label>
                                            </td> 
                                            <td>
                                            <asp:Label ID="lbl_jogador_convocado" runat="server" Text=""></asp:Label>
                                            <asp:Label ID="lbl_id_jogador" runat="server" Text="" Visible="false" ></asp:Label>
                                            </td>    
                                            <td>
                                            <asp:Label ID="lbl_valor_convocado" runat="server" Text=""></asp:Label>
                                            </td>   
                                            <td>
                                            <asp:Button  class="btn-primary" ID="btn_vender" runat="server" Text="Vender" CommandName="btn_vender" />
                                            </td>
                                        </tr>
                                    </tbody>
                            </AlternatingItemTemplate>
                            <FooterTemplate>
                                
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                        <table>
                            <tr>
                            <td style="width:150px">
                                    <asp:Label Font-Bold="true" Font-Size="Large" ID="lbl_guita" runat="server" Text=""></asp:Label>
                                </td>
                                <td></td>
                                 <td style="width:160px">
                                    <asp:Label Font-Bold="true" Font-Size="Large"  ID="lbl_valor_time" runat="server" Text=""></asp:Label>
                                </td>
                                </tr>
                            </table>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="select p.posicao, j.nome_jogador, e.valor_atual, j.id_jogador  from jogadores as j inner join posicoes as p on j.id_posicao = p.id_posicao inner join escalacao as e on e.id_jogador = j.id_jogador order by j.id_posicao"></asp:SqlDataSource>
                    </div>
                </div>
                <!-- Fim Vossa equipa-->    
                </div> 
                </div>
         </section>

        <!--Selecionar jogadores-->
       
        <section class="schedule-section spad" style="margin-top:-25%; margin-left:15%;">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 left-blog-pad">
                    <div id="mercado" class="schedule-text" style="width:950px;">
                        <h4  class="st-title">Mercado da Bola</h4>
                        <div class="st-table">
                            <h5>&nbsp; Escolha a posição do jogador:&nbsp; <asp:DropDownList ID="ddl_escolher_posicao" runat="server" DataSourceID="SqlDataSource3" DataTextField="posicao" DataValueField="id_posicao" Width="190px" OnSelectedIndexChanged="ddl_escolher_posicao_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [posicoes]"></asp:SqlDataSource>
                            &nbsp;&nbsp;&nbsp; Ordenar:&nbsp; <asp:DropDownList ID="ddl_ordenar" runat="server"  Width="190px" AutoPostBack="True" OnSelectedIndexChanged="ddl_ordenar_SelectedIndexChanged">
                                 <asp:ListItem>A-Z</asp:ListItem>
                                 <asp:ListItem>Z-A</asp:ListItem>
                                 <asp:ListItem>Valor ▲</asp:ListItem>
                                 <asp:ListItem>Valor ▼</asp:ListItem>
                                 <asp:ListItem>Pontos ▲</asp:ListItem>
                                 <asp:ListItem>Pontos ▼</asp:ListItem>
                                 </asp:DropDownList>
                               </h5>&nbsp;
                            <h5>&nbsp; Pesquisar:&nbsp; <asp:TextBox ID="tb_pesquisar" runat="server"></asp:TextBox>&nbsp<asp:Button class="btn-primary" ID="btn_pesquisar" runat="server" Text="Pesquisar" onclick="btn_pesquisar_Click"/></h5>&nbsp;
                             <table class="table" >
						            <thead class="thead-primary">
						             <tr class="text-center">
						        <th style="width:10%;">Equipa</th>
						        <th style="width:11%;">Foto</th>
						        <th style="width:10%;">Jogador</th>
						        <th style="width:10%;">Valor (G$)</th>
						        <th style="width:10%;">Pontos</th>
						        <th style="width:12%;"></th>                               
						      </tr>
						    </thead>
                                 </table>
                            <div class="scrollable-div">
                            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource2" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                                <HeaderTemplate>
                                   <table class="table">
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tbody>
                                        <tr class="text-center">
                                            <td>
                                            <asp:Image ID="img_clube" runat="server" class="img" Height="60px" Width="60px"/><br />
                                            <asp:Label ID="lbl_clube" runat="server" Text=""></asp:Label>   
                                            <asp:Label ID="lbl_id_clube" runat="server" Text="" Visible="false"></asp:Label>
                                            </td>
                                            <td>    
                                            <asp:Image ID="img_jogador" runat="server" class="img" Height="60px" Width="60px"/>
                                            </td>
                                            <td>
                                            <asp:Label ID="lbl_jogador" runat="server" Text=""></asp:Label>
                                            <asp:Label ID="lbl_id_jogador" runat="server" Text="" Visible="false"></asp:Label>
                                            </td>    
                                            <td>
                                            <asp:Label ID="lbl_preco" runat="server" Text=""></asp:Label>
                                            </td>
                                            <td>
                                            <asp:Label ID="lbl_pontuacao" runat="server" Text=""></asp:Label>
                                            </td>
                                            <td>
                                            <asp:Button  class="btn-primary" ID="btn_comprar" runat="server" Text="Comprar" CommandName="btn_comprar" />
                                            </td>
                                        </tr>
                                    </tbody>
                                </ItemTemplate>
                                <AlternatingItemTemplate>
                                    <tbody>
                                        <tr class="text-center">
                                           <td>
                                            <asp:Image ID="img_clube" runat="server" class="img" Height="60px" Width="60px"/><br />
                                            <asp:Label ID="lbl_clube" runat="server" Text=""></asp:Label>   
                                            <asp:Label ID="lbl_id_clube" runat="server" Text="" Visible="false"></asp:Label>
                                            </td>
                                            <td>    
                                            <asp:Image ID="img_jogador" runat="server" class="img" Height="60px" Width="60px"/>
                                            </td>
                                            <td>
                                            <asp:Label ID="lbl_jogador" runat="server" Text=""></asp:Label>
                                            <asp:Label ID="lbl_id_jogador" runat="server" Text="" Visible="false"></asp:Label>
                                            </td>    
                                            <td>
                                            <asp:Label ID="lbl_preco" runat="server" Text=""></asp:Label>
                                            </td>
                                            <td>
                                            <asp:Label ID="lbl_pontuacao" runat="server" Text=""></asp:Label>
                                            </td>
                                            <td>
                                            <asp:Button  class="btn-primary" ID="btn_comprar" runat="server" Text="Comprar" CommandName="btn_comprar" />
                                            </td>
                                        </tr>
                                    </tbody>
                                </AlternatingItemTemplate>
                                <FooterTemplate>
                                </table>
                                </FooterTemplate>
                                </asp:Repeater>
                                </div>                                
                              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j
inner join clubes as c on j.id_clube = c.id_clube
inner join historico_jogadores as h on h.id_jogador = j.id_jogador
where j.id_posicao = 1
group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador"></asp:SqlDataSource>
                              </div>
                        </div>
                    </div>
                  </div>
            </div>
         </section>
             
    <!-- Schedule Section End -->

    
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
    <script>
        function rolarParaParteDeBaixo() {
            var parteDeBaixo = document.getElementById('mercado');
            parteDeBaixo.scrollIntoView({ behavior: 'instant'});
        }
    </script>

    <script src="js/jquery-3.3.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.magnific-popup.min.js"></script>
    <script src="js/jquery.slicknav.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/main.js"></script>
          
    </form>
</body>
</html>
