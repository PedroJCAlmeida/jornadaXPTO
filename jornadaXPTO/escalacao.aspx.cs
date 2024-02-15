using com.sun.corba.se.impl.oa.poa;
using javax.security.auth;
using org.apache.pdfbox.pdmodel.common.function;
using sun.security.x509;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Caching;
using System.Web.Services.Discovery;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jornadaXPTO
{
    public partial class escalacao : System.Web.UI.Page
    {
        int id_utilizador = 0;
        int jordada = 14;
        int redes = 0;
        int defesa = 0;
        int treinador = 0;
        int avancado = 0;
        int meia = 0;
        double valor_equipa = 0;
        double guita_utilizador = 0;
        double saldo = 0;
        DateTime date1 = new DateTime(2023, 12, 15, 20, 0, 0);
        protected void Page_Load(object sender, EventArgs e)
        {
           
            lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_data2.Text = lbl_data.Text;
          
            if (DateTime.Now > date1) { id_mercado.Text = "Mercado Encerrado Até 18/12 as 23h"; }
           

            // Mostrar lista de jogadores escolhido ao carrregar a pagina. 
            JogadoresSelecionados();
            MostrarEmCampo();
            if (!IsPostBack)
            {
                // Configurar para manter a posição de rolagem durante o postback
                Page.MaintainScrollPositionOnPostBack = true;
                MostrarEmCampo();
                JogadoresSelecionados();
                // Verifica se há utilizador logado, e guarda os dados de email, perfil e id em caso de logado
                if (Session["utilizador"] != null)
                {
                    lbl_utilizador.Text = Session["utilizador"].ToString();
                    Session["perfil"] = Session["perfil"];
                    id_utilizador = int.Parse(Session["id_utilizador"].ToString());
                   


                    if (Session["perfil"].ToString() == "3")
                    {
                        liga.Style["display"] = "visible";
                        liga2.Style["display"] = "visible";
                        escalacao1.Style["display"] = "visible";
                        escalacao2.Style["display"] = "visible";

                    }
                    if (Session["perfil"].ToString() == "2")
                    {
                        liga.Style["display"] = "visible";
                        liga2.Style["display"] = "visible";
                        escalacao1.Style["display"] = "visible";
                        escalacao2.Style["display"] = "visible";

                    }
                    else if (Session["perfil"].ToString() == "1")
                    {
                        liga.Style["display"] = "visible";
                        liga2.Style["display"] = "visible";
                        escalacao1.Style["display"] = "visible";
                        escalacao2.Style["display"] = "visible";
                        gestao.Style["display"] = "visible";
                        gestao2.Style["display"] = "visible";

                    }
                } else { Response.Redirect("index.aspx"); }

            }
            if (IsPostBack)
            {
                JogadoresSelecionados();
                MostrarEmCampo();
                if (Session["utilizador"] != null)
                {
                    lbl_utilizador.Text = Session["utilizador"].ToString();
                    Session["perfil"] = Session["perfil"];
                    id_utilizador = int.Parse(Session["id_utilizador"].ToString());
                   

                    if (Session["perfil"].ToString() == "3")
                    {
                        liga.Style["display"] = "visible";
                        liga2.Style["display"] = "visible";
                        escalacao1.Style["display"] = "visible";
                        escalacao2.Style["display"] = "visible";

                    }
                    if (Session["perfil"].ToString() == "2")
                    {
                        liga.Style["display"] = "visible";
                        liga2.Style["display"] = "visible";
                        escalacao1.Style["display"] = "visible";
                        escalacao2.Style["display"] = "visible";

                    }
                    else if (Session["perfil"].ToString() == "1")
                    {
                        liga.Style["display"] = "visible";
                        liga2.Style["display"] = "visible";
                        escalacao1.Style["display"] = "visible";
                        escalacao2.Style["display"] = "visible";
                        gestao.Style["display"] = "visible";
                        gestao2.Style["display"] = "visible";

                    }
                }
                else { Response.Redirect("index.aspx"); }
                
            }
            if (Session["utilizador"] != null)
            {
                JogadoresSelecionados();
                MostrarEmCampo();
                lbl_utilizador.Text = Session["utilizador"].ToString();
                Session["perfil"] = Session["perfil"];
                lbl_logout.Text = "Logout";
                id_utilizador = int.Parse(Session["id_utilizador"].ToString());
               

                if (Session["perfil"].ToString() == "3")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao1.Style["display"] = "visible";
                    escalacao2.Style["display"] = "visible";

                }
                if (Session["perfil"].ToString() == "2")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao1.Style["display"] = "visible";
                    escalacao2.Style["display"] = "visible";

                }
                else if (Session["perfil"].ToString() == "1")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao1.Style["display"] = "visible";
                    escalacao2.Style["display"] = "visible";
                    gestao.Style["display"] = "visible";
                    gestao2.Style["display"] = "visible";

                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }

        }
       
        // Mostra a lista de jogadores disponíveis para compra.
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_clube")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["emblema"]);
                ((Label)e.Item.FindControl("lbl_clube")).Text = dr["nome_clube"].ToString();
                ((Label)e.Item.FindControl("lbl_id_clube")).Text = dr["id_clube"].ToString();
                ((Image)e.Item.FindControl("img_jogador")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["foto_jogador"]);
                ((Label)e.Item.FindControl("lbl_jogador")).Text = dr["nome_jogador"].ToString();
                ((Label)e.Item.FindControl("lbl_id_jogador")).Text = dr["id_jogador"].ToString();
                ((Label)e.Item.FindControl("lbl_preco")).Text = dr["valor"].ToString();
                ((Label)e.Item.FindControl("lbl_pontuacao")).Text = dr["pontuacao"].ToString();
                ((Button)e.Item.FindControl("btn_comprar")).CommandArgument = dr["id_jogador"].ToString();

                // Desativar botão quando o mercado estiver encerrado
                if (DateTime.Now > date1) { ((Button)e.Item.FindControl("btn_comprar")).Enabled = false; }


                // Desativar botão de compra quando atinge a quantidade de jogador selecionado.

                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);
                
                string query = "select count(e.id_jogador) as cont from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where j.id_posicao = 1 and id_utilizador="+id_utilizador;
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var jogador = myCommand.ExecuteReader();
                if (jogador.Read())
                {
                    redes = int.Parse(jogador["cont"].ToString());
                }
                myCon.Close();

                string query2 = "select count(e.id_jogador) as cont from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where j.id_posicao = 2 and id_utilizador=" + id_utilizador;
                SqlCommand myCommand2 = new SqlCommand(query2, myCon);
                myCon.Open();
                var jogador2 = myCommand2.ExecuteReader();
                if (jogador2.Read())
                {
                    defesa = int.Parse(jogador2["cont"].ToString());
                }
                myCon.Close();

                string query3 = "select count(e.id_jogador) as cont from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where j.id_posicao = 3 and id_utilizador="+id_utilizador;
                SqlCommand myCommand3 = new SqlCommand(query3, myCon);
                myCon.Open();
                var jogador3 = myCommand3.ExecuteReader();
                if (jogador3.Read())
                {
                    meia = int.Parse(jogador3["cont"].ToString());
                }
                myCon.Close();

                string query4 = "select count(e.id_jogador) as cont from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where j.id_posicao = 4 and id_utilizador="+id_utilizador;
                SqlCommand myCommand4 = new SqlCommand(query4, myCon);
                myCon.Open();
                var jogador4 = myCommand4.ExecuteReader();
                if (jogador4.Read())
                {
                    avancado = int.Parse(jogador4["cont"].ToString());
                }
                myCon.Close();

                string query5 = "select count(e.id_jogador) as cont from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where j.id_posicao = 1002 and id_utilizador="+id_utilizador;
                SqlCommand myCommand5 = new SqlCommand(query5, myCon);
                myCon.Open();
                var jogador5 = myCommand5.ExecuteReader();
                if (jogador5.Read())
                {
                    treinador = int.Parse(jogador5["cont"].ToString());
                }
                myCon.Close();

                //----------------------------------
                double valor_equipa2 = 0;
                double guita_utilizador2 = 0;
                double saldo2 = 0;
                string queryVtime = "select sum(j.valor) as soma from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where id_utilizador=" + id_utilizador;
                SqlCommand myCommandVtime = new SqlCommand(queryVtime, myCon);
                myCon.Open();
                var valor_time2 = myCommandVtime.ExecuteReader();
                if (valor_time2.Read())
                {
                    if (valor_time2["soma"] != DBNull.Value)
                    {
                        valor_equipa2 = double.Parse(valor_time2["soma"].ToString());
                    }
                    else
                    {
                        valor_equipa2 = 0;
                    }
                }
                myCon.Close();


                string queryGuita = "select guita from utilizadores where id_utilizador=" + id_utilizador;
                SqlCommand myCommandGuita = new SqlCommand(queryGuita, myCon);
                myCon.Open();
                var guita2 = myCommandGuita.ExecuteReader();
                if (guita2.Read())
                {
                    guita_utilizador2 = double.Parse(guita2["guita"].ToString());
                }
                myCon.Close();

                saldo2 = guita_utilizador2 - valor_equipa2;
                if (double.Parse(((Label)e.Item.FindControl("lbl_preco")).Text) > saldo2)
                {
                    ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                }
                //---------------------------------

                // Comparar quantidade de jogares selecionados com o perfil e desabilitar se já estiver a quantidade máxima em cada posição.

                //Verificar Redes e Treinador
                if (redes > 0 && ddl_escolher_posicao.SelectedValue.ToString() == "1")
                {
                    ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                }
                if (treinador > 0 && ddl_escolher_posicao.SelectedValue.ToString() == "1002")
                {
                    ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                }
                //Verificar Defesa, Meio e Avançado Esquema tático 1
                if (ddl_esquema.SelectedValue.ToString() == "1")
                {
                    if (defesa > 3 && ddl_escolher_posicao.SelectedValue.ToString() == "2")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    if (meia > 2 && ddl_escolher_posicao.SelectedValue.ToString() == "3")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    if (avancado > 2 && ddl_escolher_posicao.SelectedValue.ToString() == "4")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    JogadoresSelecionados();
                }
                //Verificar Defesa, Meio e Avançado Esquema tático 2
                if (ddl_esquema.SelectedValue.ToString() == "2")
                {
                    if (defesa > 3 && ddl_escolher_posicao.SelectedValue.ToString() == "2")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    if (meia > 3 && ddl_escolher_posicao.SelectedValue.ToString() == "3")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    if (avancado > 1 && ddl_escolher_posicao.SelectedValue.ToString() == "4")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                }
                //Verificar Defesa, Meio e Avançado Esquema tático 3
                if (ddl_esquema.SelectedValue.ToString() == "3")
                {
                    if (defesa > 2 && ddl_escolher_posicao.SelectedValue.ToString() == "2")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    if (meia > 4 && ddl_escolher_posicao.SelectedValue.ToString() == "3")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                    if (avancado > 1 && ddl_escolher_posicao.SelectedValue.ToString() == "4")
                    {
                        ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;
                    }
                }
                
                MostrarEmCampo();
            }
           
            MostrarEmCampo();
        }

        // Comprar jogador selecionado
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName.Equals("btn_comprar"))
            {
                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);
                string query = "";
                query = "insert into escalacao (id_utilizador, id_jornada, id_clube, id_jogador, valor_atual, ponto_atual, id_esquema) values ('";
                query += id_utilizador + "', '" + jordada + "', '";
                query += ((Label)e.Item.FindControl("lbl_id_clube")).Text + "', '";
                query += ((Label)e.Item.FindControl("lbl_id_jogador")).Text + "', ";
                query += "convert(numeric(5,2),"+ ((Label)e.Item.FindControl("lbl_preco")).Text + "),";
                query += "convert(numeric(5,2)," + ((Label)e.Item.FindControl("lbl_pontuacao")).Text + "), '";
                query += ddl_esquema.SelectedValue + "');";
                
                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();

                ((Button)e.Item.FindControl("btn_comprar")).Enabled = false;


                MostrarEmCampo();
                RedirecionarParaParteDeBaixo();
               
            }
        }

        // Filtro de poisção de jogadores na lista de jogadores disponíveis para compra
        protected void ddl_escolher_posicao_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // Selecionar a posição do jogador no filtro
            if (ddl_escolher_posicao.SelectedValue.ToString() == "1")
            {
                SqlDataSource2.SelectCommand = "select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";

            }
            else if (ddl_escolher_posicao.SelectedValue.ToString() == "2")
            {
                SqlDataSource2.SelectCommand = "select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao  from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
            }
            else if (ddl_escolher_posicao.SelectedValue.ToString() == "3")
            {
                SqlDataSource2.SelectCommand = "select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
            }
            else if (ddl_escolher_posicao.SelectedValue.ToString() == "4")
            {
                SqlDataSource2.SelectCommand = "select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
            }
            else if (ddl_escolher_posicao.SelectedValue.ToString() == "1002")
            {
                SqlDataSource2.SelectCommand = "select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
            }
            JogadoresSelecionados();
            MostrarEmCampo();
        }

        // Seleciona o esquema tático
        protected void ddl_esquema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_esquema.SelectedValue.ToString() == "1")
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                Panel3.Visible = false;
            }
            else if (ddl_esquema.SelectedValue.ToString() == "2")
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                Panel3.Visible = false;
            }
            else if (ddl_esquema.SelectedValue.ToString() == "3")
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = true;
            }
            JogadoresSelecionados();
            MostrarEmCampo();
        }

        // Mostra a lista de jogadores selecionados
        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Label)e.Item.FindControl("lbl_posicao")).Text = dr["posicao"].ToString();
                ((Label)e.Item.FindControl("lbl_jogador_convocado")).Text = dr["nome_jogador"].ToString();
                ((Label)e.Item.FindControl("lbl_id_jogador")).Text = dr["id_jogador"].ToString();
                ((Label)e.Item.FindControl("lbl_valor_convocado")).Text = dr["valor_atual"].ToString();
                ((Button)e.Item.FindControl("btn_vender")).CommandArgument = dr["id_jogador"].ToString();

                if (DateTime.Now > date1) { ((Button)e.Item.FindControl("btn_vender")).Enabled = false; }

                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            string query = "select sum(j.valor) as soma from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where e.id_utilizador=" + id_utilizador;
            SqlCommand myCommand = new SqlCommand(query, myCon);
            myCon.Open();
            var valor_time = myCommand.ExecuteReader();
            if (valor_time.Read())
            {
                if (valor_time["soma"] != DBNull.Value)
                {
                    valor_equipa = double.Parse(valor_time["soma"].ToString());
                }
                else
                {
                    valor_equipa = 0;
                }
            }
            myCon.Close();


            string query2 = "select guita from utilizadores where id_utilizador=" + id_utilizador;
            SqlCommand myCommand2 = new SqlCommand(query2, myCon);
            myCon.Open();
            var guita = myCommand2.ExecuteReader();
            if (guita.Read())
            {
                guita_utilizador = double.Parse(guita["guita"].ToString());
            }
            myCon.Close();

            saldo = guita_utilizador - valor_equipa;
            lbl_valor_time.Text = "Equipa (G$): " + valor_equipa.ToString("f");
            lbl_guita.Text = "Saldo (G$): " + saldo.ToString("f");

            JogadoresSelecionados();
            MostrarEmCampo();
            }
        }

        // Vende o jogador selecionado
        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName.Equals("btn_vender"))
            {
                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                string query = "delete from escalacao where id_jogador = " + ((Label)e.Item.FindControl("lbl_id_jogador")).Text + "and id_utilizador="+id_utilizador;

                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();

                MostrarEmCampo();
                JogadoresSelecionados();
                RedirecionarLista();
            }
        }

        // Vende todos os jogadores selecionados. 
        protected void btn_vender_todos_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            string query = "";
            query = "delete from escalacao ";
            query += "where id_utilizador=" + id_utilizador;
            myCon.Open();
            SqlCommand myCommand = new SqlCommand(query, myCon);
            myCommand.ExecuteNonQuery();
            myCon.Close();

            Response.Redirect("escalacao.aspx");
        }
        //Botões do tabuleiro de jogo. Onde aparece os jogadores selecionados. 
        protected void ibtn_av1_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();
        }
        protected void ibtn_av2_p1_Click(object sender, ImageClickEventArgs e)
        {

            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();

        }
        protected void ibtn_av3_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();

        }
        protected void ibtn_md1_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md2_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md3_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_df1_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df2_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df3_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df4_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_rd_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "1";
            FiltroRedes();
        }
        protected void ibtn_tr_p1_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "1002";
            FiltroTreinador();
        }
        protected void ibtn_av1_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();
        }
        protected void ibtn_av2_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();
        }
        protected void ibtn_md1_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md2_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md3_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md4_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_df1_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df2_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df3_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df4_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_rd_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "1";
            FiltroRedes();
        }
        protected void ibtn_tr_p2_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "1002";
            FiltroTreinador();
        }
        protected void ibtn_av1_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();
        }
        protected void ibtn_av2_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "4";
            FiltroAvancado();
        }
        protected void ibtn_md1_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md2_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md3_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md4_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_md5_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "3";
            FiltroMedio();
        }
        protected void ibtn_df1_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df2_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_df3_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "2";
            FiltroDefesa();
        }
        protected void ibtn_rd_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "1";
            FiltroRedes();
        }
        protected void ibtn_tr_p3_Click(object sender, ImageClickEventArgs e)
        {
            ddl_escolher_posicao.SelectedValue = "1002";
            FiltroTreinador();
        }

        //Funções ----------------------------
        public void MostrarEmCampo()
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);
            string query = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 1002 and id_utilizador="+id_utilizador;

            SqlCommand myCommand = new SqlCommand(query, myCon);
            myCon.Open();
            var jogador = myCommand.ExecuteReader();
            if (jogador.Read())
            {
                ibtn_tr_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador["foto_jogador"]);

                ibtn_tr_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador["foto_jogador"]);

                ibtn_tr_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar goleiro e mostrar no campo
            string query2 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 1 and id_utilizador=" + id_utilizador;

            SqlCommand myCommand2 = new SqlCommand(query2, myCon);
            myCon.Open();
            var jogador2 = myCommand2.ExecuteReader();
            if (jogador2.Read())
            {
                ibtn_rd_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador2["foto_jogador"]);

                ibtn_rd_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador2["foto_jogador"]);

                ibtn_rd_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador2["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar defesa 1 e mostrar no campo
            string query3 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 2 and id_utilizador="+id_utilizador+" order by foto_jogador offset 0 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand3 = new SqlCommand(query3, myCon);
            myCon.Open();
            var jogador3 = myCommand3.ExecuteReader();
            if (jogador3.Read())
            {
                ibtn_df1_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador3["foto_jogador"]);
                ibtn_df1_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador3["foto_jogador"]);
                ibtn_df1_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador3["foto_jogador"]);

            }
            myCon.Close();

            //Selecionar defesa 2 e mostrar no campo
            string query4 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 2 and id_utilizador="+id_utilizador+"  order by foto_jogador offset 1 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand4 = new SqlCommand(query4, myCon);
            myCon.Open();
            var jogador4 = myCommand4.ExecuteReader();
            if (jogador4.Read())
            {
                ibtn_df2_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador4["foto_jogador"]);
                ibtn_df2_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador4["foto_jogador"]);
                ibtn_df2_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador4["foto_jogador"]);

            }
            myCon.Close();

            //Selecionar defesa 3 e mostrar no campo
            string query5 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 2  and id_utilizador="+id_utilizador+" order by foto_jogador offset 2 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand5 = new SqlCommand(query5, myCon);
            myCon.Open();
            var jogador5 = myCommand5.ExecuteReader();
            if (jogador5.Read())
            {
                ibtn_df3_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador5["foto_jogador"]);
                ibtn_df3_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador5["foto_jogador"]);
                ibtn_df3_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador5["foto_jogador"]);

            }
            myCon.Close();

            //Selecionar defesa 4 e mostrar no campo
            string query6 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 2  and id_utilizador="+id_utilizador+" order by foto_jogador offset 3 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand6 = new SqlCommand(query6, myCon);
            myCon.Open();
            var jogador6 = myCommand6.ExecuteReader();
            if (jogador6.Read())
            {
                ibtn_df4_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador6["foto_jogador"]);
                ibtn_df4_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador6["foto_jogador"]);

            }
            myCon.Close();

            //Selecionar meia 1 e mostrar no campo
            string query7 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 3  and id_utilizador="+id_utilizador+" order by foto_jogador offset 0 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand7 = new SqlCommand(query7, myCon);
            myCon.Open();
            var jogador7 = myCommand7.ExecuteReader();
            if (jogador7.Read())
            {
                ibtn_md1_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador7["foto_jogador"]);
                ibtn_md1_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador7["foto_jogador"]);
                ibtn_md1_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador7["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar meia 2 e mostrar no campo
            string query8 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 3 and id_utilizador="+id_utilizador+" order by foto_jogador offset 1 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand8 = new SqlCommand(query8, myCon);
            myCon.Open();
            var jogador8 = myCommand8.ExecuteReader();
            if (jogador8.Read())
            {
                ibtn_md2_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador8["foto_jogador"]);
                ibtn_md2_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador8["foto_jogador"]);
                ibtn_md2_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador8["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar meia 3 e mostrar no campo
            string query9 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 3  and id_utilizador="+id_utilizador+" order by foto_jogador offset 2 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand9 = new SqlCommand(query9, myCon);
            myCon.Open();
            var jogador9 = myCommand9.ExecuteReader();
            if (jogador9.Read())
            {
                ibtn_md3_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador9["foto_jogador"]);
                ibtn_md3_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador9["foto_jogador"]);
                ibtn_md3_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador9["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar meia 4 e mostrar no campo
            string query10 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 3 and id_utilizador="+id_utilizador+"  order by foto_jogador offset 3 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand10 = new SqlCommand(query10, myCon);
            myCon.Open();
            var jogador10 = myCommand10.ExecuteReader();
            if (jogador10.Read())
            {
                ibtn_md4_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador10["foto_jogador"]);
                ibtn_md4_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador10["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar meia 5 e mostrar no campo
            string query11 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 3 and id_utilizador="+id_utilizador+"  order by foto_jogador offset 4 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand11 = new SqlCommand(query11, myCon);
            myCon.Open();
            var jogador11 = myCommand11.ExecuteReader();
            if (jogador11.Read())
            {
                ibtn_md5_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador11["foto_jogador"]);
            }
            myCon.Close();

            //Selecionar avançado 1 e mostrar no campo
            string query12 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 4 and id_utilizador="+id_utilizador+" order by foto_jogador offset 0 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand12 = new SqlCommand(query12, myCon);
            myCon.Open();
            var jogador12 = myCommand12.ExecuteReader();
            if (jogador12.Read())
            {
                ibtn_av1_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador12["foto_jogador"]);
                ibtn_av1_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador12["foto_jogador"]);
                ibtn_av1_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador12["foto_jogador"]);

            }
            myCon.Close();

            //Selecionar avançado 2 e mostrar no campo
            string query13 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 4 and id_utilizador="+id_utilizador+" order by foto_jogador offset 1 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand13 = new SqlCommand(query13, myCon);
            myCon.Open();
            var jogador13 = myCommand13.ExecuteReader();
            if (jogador13.Read())
            {
                ibtn_av2_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador13["foto_jogador"]);
                ibtn_av2_p2.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador13["foto_jogador"]);
                ibtn_av2_p3.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador13["foto_jogador"]);

            }
            myCon.Close();

            //Selecionar avançado 3 e mostrar no campo
            string query14 = "select j.foto_jogador from jogadores as j inner join escalacao as e on e.id_jogador = j.id_jogador where j.id_posicao = 4 and id_utilizador="+id_utilizador+" order by foto_jogador offset 2 row FETCH NEXT 1 ROW ONLY";

            SqlCommand myCommand14 = new SqlCommand(query14, myCon);
            myCon.Open();
            var jogador14 = myCommand14.ExecuteReader();
            if (jogador14.Read())
            {
                ibtn_av3_p1.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])jogador14["foto_jogador"]);
            }
            myCon.Close();
        }
        public void FiltroAvancado()
        {
            ddl_escolher_posicao.SelectedValue = "4";
            SqlDataSource2.SelectCommand = "select top 25 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador,  convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
        }
        public void FiltroMedio()
        {
            ddl_escolher_posicao.SelectedValue = "3";
            SqlDataSource2.SelectCommand = "select top 25 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
        }
        public void FiltroDefesa()
        {
            ddl_escolher_posicao.SelectedValue = "2";
            SqlDataSource2.SelectCommand = "select top 25 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador,  convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
        }
        public void FiltroRedes()
        {
            ddl_escolher_posicao.SelectedValue = "1";
            SqlDataSource2.SelectCommand = "select top 25 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
        }
        public void FiltroTreinador()
        {
            ddl_escolher_posicao.SelectedValue = "1002";
            SqlDataSource2.SelectCommand = "select top 25 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador";
        }

        public void JogadoresSelecionados()
        {
            SqlDataSource4.SelectCommand = "select p.posicao, j.nome_jogador, convert(numeric(5,2),(avg(h.valor))) as valor_atual, j.id_jogador  from jogadores as j inner join posicoes as p on j.id_posicao = p.id_posicao inner join escalacao as e on e.id_jogador = j.id_jogador inner join historico_jogadores as h on h.id_jogador = j.id_jogador where id_utilizador =" + id_utilizador+" group by p.posicao, j.nome_jogador, j.id_jogador, j.id_posicao order by j.id_posicao";
        }
        // Ainda não funciona como eu gostria. Ao executar, ignora a função de filtro na lista de jogadores, acredito que seja por conta da nova url. Ainda preciso rever. 
        public void RedirecionarParaParteDeBaixo()
        {
            HttpResponse response = HttpContext.Current.Response;

            // Define o caminho com o id da div
            string url = "escalacao.aspx#mercado";
            Page.MaintainScrollPositionOnPostBack = true;

            // Redirecionamento
            response.Redirect(url, true);

        }
        public void RedirecionarLista()
        {
            HttpResponse response = HttpContext.Current.Response;

            // Define o caminho com o id da div
            string url = "escalacao.aspx#selecionados";
            Page.MaintainScrollPositionOnPostBack = true;

            if(ddl_escolher_posicao.SelectedValue == "4")
            {
                FiltroAvancado();
            }
            // Redirecionamento
            response.Redirect(url, true);

        }

        protected void ddl_ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_ordenar.SelectedValue == "A-Z" )
            {
                if (ddl_escolher_posicao.SelectedValue == "1002")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "1")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador,  convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "2")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador,  convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "3")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador,  convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "4")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador asc";
                }
            }
            else if (ddl_ordenar.SelectedValue == "Z-A")
            {
                if (ddl_escolher_posicao.SelectedValue == "1002")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador,  convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "1")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "2")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "3")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "4")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by j.nome_jogador desc";
                }
            }
            else if (ddl_ordenar.SelectedValue == "Valor ▲")
            {
                if (ddl_escolher_posicao.SelectedValue == "1002")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "1")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "2")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "3")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "4")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor asc";
                }
            }
            else if (ddl_ordenar.SelectedValue == "Valor ▼")
            {
                if (ddl_escolher_posicao.SelectedValue == "1002")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "1")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "2")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "3")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "4")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by valor desc";
                }
            }
            else if (ddl_ordenar.SelectedValue == "Pontos ▲")
            {
                if (ddl_escolher_posicao.SelectedValue == "1002")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "1")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "2")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "3")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao asc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "4")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao asc";
                }
            }
            else if (ddl_ordenar.SelectedValue == "Pontos ▼")
            {
                if (ddl_escolher_posicao.SelectedValue == "1002")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1002 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "1")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 1 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "2")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 2 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "3")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 3 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao desc";
                }
                else if (ddl_escolher_posicao.SelectedValue == "4")
                {
                    SqlDataSource2.SelectCommand = "select top 100 j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, convert(numeric(5,2),avg(h.valor)) as valor, convert(numeric(5,2),avg(h.pontos)) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.id_posicao =" + 4 + " group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador order by pontuacao desc";
                }
            }
        }

        protected void btn_pesquisar_Click(object sender, EventArgs e)
        {
            SqlDataSource2.SelectCommand = "select j.id_jogador, c.emblema,c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador, avg(h.valor) as valor, avg(h.pontos) as pontuacao from jogadores as j inner join clubes as c on j.id_clube = c.id_clube inner join historico_jogadores as h on h.id_jogador = j.id_jogador where j.nome_jogador like '%"+ tb_pesquisar.Text + "%' group by j.id_jogador, c.emblema, c.id_clube, c.nome_clube, j.nome_jogador, j.foto_jogador ";
        }
    }
        
}
    
        