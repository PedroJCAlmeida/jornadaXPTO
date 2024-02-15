<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dados_utilizador.aspx.cs" Inherits="jornadaXPTO.dados_utilizador" %>

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
            <li ><a href="index.aspx">Home</a></li>
            <li runat="server" id="liga" style="display:none"><a href="ligas.aspx">Ligas</a></li>
            <li runat="server" id="escalacao" style="display:none"><a href="escalacao.aspx">Escalação</a></li>
            <li runat="server" id="gestao" style="display:none"><a href="#">Gestão</a></li>
            <li><a href="#">Gestão</a>
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
                                <li><a href="index.aspx">Home</a></li>
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
           

    <!-- Contact Section Begin -->
    <section class="schedule-section spad">
        <div class="container" >
            <div class="row">
                <div class="col-lg-8 left-blog-pad" >
                    <div class="schedule-text" style="width:1150px;">
                        <h4 class="st-title">Dados Utilizador</h4>
                        <div class="st-table">
                              <table class="table">
                                    <tr style="background: #00235a; padding: 12px 0 14px; font-size: 15px; color: #ffffff; font-weight: 500; text-align:center;">
                                    <td>Utilizador</td>
                                    <td>Nome Equipa</td>
                                    <td>Equipa Adepto</td>
                                    <td></td>
                                </tr>
                            <tr class="text-center">
                                    <td><asp:TextBox ID="tb_utilizador" runat="server"></asp:TextBox></td>
                                    <td><asp:TextBox ID="tb_equipa" runat="server"></asp:TextBox></td>
                                    <td><asp:DropDownList ID="ddl_adepto" runat="server" DataSourceID="SqlDataSource1" DataTextField="clube" DataValueField="id_clube" ></asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [clube_adeptos]"></asp:SqlDataSource>
                                    </td>
                                <br />
                                <asp:Label ID="lbl_mensagem2" runat="server" Text=""></asp:Label>
                                <td><asp:Button class="btn-primary" ID="btn_atualizar" runat="server" Text="Salvar" onclick="btn_atualizar_Click"/></td>
                            
                            </tr>
                            </table>
                                </div>
                 </div>

                </div>
                 </div>
        </div>
        
    </section>
         <section class="schedule-section spad">
        <div class="container" >
            <div class="row">
                <div class="col-lg-8 left-blog-pad" >
                    <div class="schedule-text" style="width:600px; height:600px">
                <div class="col-lg-8 left-blog-pad" >
                   
                    <div class="schedule-text" style="width:500px;">
                        <h4 class="st-title">Escudo Utilizador</h4>
                        <div class="st-table">
                          <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [escudos]" DeleteCommand="DELETE FROM [escudos] WHERE [id_escudo] = @id_escudo" InsertCommand="INSERT INTO [escudos] ([nome], [emblema], [ct_emblema], [camisola], [ct_camisola], [ativado]) VALUES (@nome, @emblema, @ct_emblema, @camisola, @ct_camisola, @ativado)" UpdateCommand="UPDATE [escudos] SET [nome] = @nome, [emblema] = @emblema, [ct_emblema] = @ct_emblema, [camisola] = @camisola, [ct_camisola] = @ct_camisola, [ativado] = @ativado WHERE [id_escudo] = @id_escudo">
                              <DeleteParameters>
                                  <asp:Parameter Name="id_escudo" Type="Int32" />
                              </DeleteParameters>
                              <InsertParameters>
                                  <asp:Parameter Name="nome" Type="String" />
                                  <asp:Parameter Name="emblema" Type="Object" />
                                  <asp:Parameter Name="ct_emblema" Type="String" />
                                  <asp:Parameter Name="camisola" Type="Object" />
                                  <asp:Parameter Name="ct_camisola" Type="String" />
                                  <asp:Parameter Name="ativado" Type="Boolean" />
                              </InsertParameters>
                              <UpdateParameters>
                                  <asp:Parameter Name="nome" Type="String" />
                                  <asp:Parameter Name="emblema" Type="Object" />
                                  <asp:Parameter Name="ct_emblema" Type="String" />
                                  <asp:Parameter Name="camisola" Type="Object" />
                                  <asp:Parameter Name="ct_camisola" Type="String" />
                                  <asp:Parameter Name="ativado" Type="Boolean" />
                                  <asp:Parameter Name="id_escudo" Type="Int32" />
                              </UpdateParameters>
                            </asp:SqlDataSource>
                            <div>
                               <h4>Escolher Emblema:
                              <asp:DropDownList class="st-table" ID="ddl_escudo" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="nome" DataValueField="id_escudo" OnSelectedIndexChanged="ddl_escudo_SelectedIndexChanged"></asp:DropDownList>
                               </h4>  <br />
                                <br />
                            </div>
                        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource2" OnItemDataBound="Repeater2_ItemDataBound" OnItemCommand="Repeater2_ItemCommand">
                        <HeaderTemplate>
                            <div style="margin-left:15%">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Image ID="img_escudo" runat="server" Width="200px" Height="200px"/>
                            <asp:Image ID="img_camisa" runat="server" Width="200px" Height="200px"/>
                            <br />
                            <asp:Button style="margin-left:15%; margin-top:10%" class="primary-btn" ID="btn_salvar" runat="server" Text="Salvar Emblema" CommandName="btn_salvar" />
                        </ItemTemplate>
                        <FooterTemplate>
                          </div>
                        </FooterTemplate>
                    </asp:Repeater>
                                </div>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:jornadaXptoConnectionString %>" SelectCommand="SELECT * FROM [escudos] where id_escudo=1" ></asp:SqlDataSource>
                   </div>
                    </div>
                </div>
                 </div>

                 <div style="background: #00235a; padding: 12px 0 14px; height:55px; width:350px">
                <h4 style="font-size: 22px; color: #ffffff; font-weight: 500; text-align:center;">Alterar Palavra Passe </h4>
                
                     <br />
                     <br />
                     Palavra-Passe:<asp:TextBox style="margin-left:15%; margin-top:5%;" ID="tb_pass" textmode="Password" runat="server" Width="247px" />
                     <br />
                     <br />
                    Nova Palavra-Passe:<asp:TextBox  style="margin-left:15%; margin-top:5%;" ID="tb_nova_pass"  textmode="Password" runat="server"  Width="247px"/>
                    
                     <br />
                     <br />
                    Confirmar Nova Passe: <asp:TextBox style="margin-left:15%; margin-top:5%;" ID="tb_confirm" textmode="Password" runat="server"  Width="247px"/>
                    <br />
                    <asp:Label style="color:red" ID="lbl_mensagem" runat="server" Text=""></asp:Label>
                    <asp:Button style="margin-left:25%; margin-top:10%" class="primary-btn" ID="btn_salvar_pass" runat="server" Text="Salvar Passe" OnClick="btn_salvar_pass_Click"/>
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

