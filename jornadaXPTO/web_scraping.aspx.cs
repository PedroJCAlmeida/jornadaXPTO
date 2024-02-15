using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services.Protocols;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using System.Net.Http;

using OpenQA.Selenium;
using sun.net.www.http;
using System.Configuration;
using System.Data.SqlClient;
using javax.management;

namespace jornadaXPTO
{
    public partial class web_scraping : System.Web.UI.Page
    {
        string url = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_data2.Text = lbl_data.Text;
            DateTime date1 = new DateTime(2023, 12, 15, 20, 0, 0);
            if (DateTime.Now > date1) { id_mercado.Text = "Mercado Encerrado Até 18/12 as 23h"; }

            if (Session["utilizador"] != null)
            {
                lbl_utilizador.Text = Session["utilizador"].ToString();
                Session["perfil"] = Session["perfil"];
                lbl_logout.Text = "Logout";

                if (Session["perfil"].ToString() == "3")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao.Style["display"] = "visible";
                    escalacao2.Style["display"] = "visible";

                }
                if (Session["perfil"].ToString() == "2")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao.Style["display"] = "visible";
                    escalacao2.Style["display"] = "visible";

                }
                else if (Session["perfil"].ToString() == "1")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao.Style["display"] = "visible";
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

       


        protected void ddl_jornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "select * from links where id_jornada=" + ddl_jornada.SelectedValue;
        }
        protected void ddl_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            url = ddl_jogo.SelectedValue;
            RPA();
        }
        

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            string valor = "1.7";
            string ponto = "1.2";
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);


            // Inserir dados jogador 1
            string query = "insert into historico_jogadores (id_jornada, id_jogador, id_clube, id_posicao, valor, pontos) values ";
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador.Text + "," + lbl_id_clube.Text + "," + lbl_id_posicao.Text + "," + "(" + valor + "* parse('" + lbl_pontos.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos.Text + "' as numeric(5,2) using 'PT-pt'))), ";
            // Inserir dados jogador 2
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador2.Text + "," + lbl_id_clube2.Text + "," + lbl_id_posicao2.Text + "," + "(" + valor + "* parse('" + lbl_pontos2.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos2.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 3
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador3.Text + "," + lbl_id_clube3.Text + "," + lbl_id_posicao3.Text + "," + "(" + valor + "* parse('" + lbl_pontos3.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos3.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 4
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador4.Text + "," + lbl_id_clube4.Text + "," + lbl_id_posicao4.Text + "," + "(" + valor + "* parse('" + lbl_pontos4.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos4.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 5
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador5.Text + "," + lbl_id_clube5.Text + "," + lbl_id_posicao5.Text + "," + "(" + valor + "* parse('" + lbl_pontos5.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos5.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 6
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador6.Text + "," + lbl_id_clube6.Text + "," + lbl_id_posicao6.Text + "," + "(" + valor + "* parse('" + lbl_pontos6.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos6.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 7
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador7.Text + "," + lbl_id_clube7.Text + "," + lbl_id_posicao7.Text + "," + "(" + valor + "* parse('" + lbl_pontos7.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos7.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 8
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador8.Text + "," + lbl_id_clube8.Text + "," + lbl_id_posicao8.Text + "," + "(" + valor + "* parse('" + lbl_pontos8.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos8.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 9
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador9.Text + "," + lbl_id_clube9.Text + "," + lbl_id_posicao9.Text + "," + "(" + valor + "* parse('" + lbl_pontos9.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos9.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 10
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador10.Text + "," + lbl_id_clube10.Text + "," + lbl_id_posicao10.Text + "," + "(" + valor + "* parse('" + lbl_pontos10.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos10.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 11
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador11.Text + "," + lbl_id_clube11.Text + "," + lbl_id_posicao11.Text + "," + "(" + valor + "* parse('" + lbl_pontos11.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos11.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 23
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador23.Text + "," + lbl_id_clube23.Text + "," + lbl_id_posicao23.Text + "," + "(" + valor + "* parse('" + lbl_pontos23.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos23.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 24
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador24.Text + "," + lbl_id_clube24.Text + "," + lbl_id_posicao24.Text + "," + "(" + valor + "* parse('" + lbl_pontos24.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos24.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 25
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador25.Text + "," + lbl_id_clube25.Text + "," + lbl_id_posicao25.Text + "," + "(" + valor + "* parse('" + lbl_pontos25.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos25.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 26
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador26.Text + "," + lbl_id_clube26.Text + "," + lbl_id_posicao26.Text + "," + "(" + valor + "* parse('" + lbl_pontos26.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos26.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 27
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador27.Text + "," + lbl_id_clube27.Text + "," + lbl_id_posicao27.Text + "," + "(" + valor + "* parse('" + lbl_pontos27.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos27.Text + "' as numeric(5,2) using 'PT-pt'))),";

            // Inserir dados jogador 12
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador12.Text + "," + lbl_id_clube12.Text + "," + lbl_id_posicao12.Text + "," + "(" + valor + "* parse('" + lbl_pontos12.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos12.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 13
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador13.Text + "," + lbl_id_clube13.Text + "," + lbl_id_posicao13.Text + "," + "(" + valor + "* parse('" + lbl_pontos13.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos13.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 14
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador14.Text + "," + lbl_id_clube14.Text + "," + lbl_id_posicao14.Text + "," + "(" + valor + "* parse('" + lbl_pontos14.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos14.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 15
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador15.Text + "," + lbl_id_clube15.Text + "," + lbl_id_posicao15.Text + "," + "(" + valor + "* parse('" + lbl_pontos15.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos15.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 16
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador16.Text + "," + lbl_id_clube16.Text + "," + lbl_id_posicao16.Text + "," + "(" + valor + "* parse('" + lbl_pontos16.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos16.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 17
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador17.Text + "," + lbl_id_clube17.Text + "," + lbl_id_posicao17.Text + "," + "(" + valor + "* parse('" + lbl_pontos17.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos17.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 18
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador18.Text + "," + lbl_id_clube18.Text + "," + lbl_id_posicao18.Text + "," + "(" + valor + "* parse('" + lbl_pontos18.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos18.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 19
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador19.Text + "," + lbl_id_clube19.Text + "," + lbl_id_posicao19.Text + "," + "(" + valor + "* parse('" + lbl_pontos19.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos19.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 20
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador20.Text + "," + lbl_id_clube20.Text + "," + lbl_id_posicao20.Text + "," + "(" + valor + "* parse('" + lbl_pontos20.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos20.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 21
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador21.Text + "," + lbl_id_clube21.Text + "," + lbl_id_posicao21.Text + "," + "(" + valor + "* parse('" + lbl_pontos21.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos21.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 22
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador22.Text + "," + lbl_id_clube22.Text + "," + lbl_id_posicao22.Text + "," + "(" + valor + "* parse('" + lbl_pontos22.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos22.Text + "' as numeric(5,2) using 'PT-pt'))),";
            // Inserir dados jogador 28
            query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador28.Text + "," + lbl_id_clube28.Text + "," + lbl_id_posicao28.Text + "," + "(" + valor + "* parse('" + lbl_pontos28.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos28.Text + "' as numeric(5,2) using 'PT-pt'))),";
            if (lbl_jogador30.Text == "-")
            {
                // Inserir dados jogador 29
                query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador29.Text + "," + lbl_id_clube29.Text + "," + lbl_id_posicao29.Text + "," + "(" + valor + "* parse('" + lbl_pontos29.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos29.Text + "' as numeric(5,2) using 'PT-pt')));";
            }
            else if (lbl_jogador30.Text != "-")
            {
                // Inserir dados jogador 29
                query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador29.Text + "," + lbl_id_clube29.Text + "," + lbl_id_posicao29.Text + "," + "(" + valor + "* parse('" + lbl_pontos29.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos29.Text + "' as numeric(5,2) using 'PT-pt'))),";
                if (lbl_jogador31.Text == "-")
                {
                    // Inserir dados jogador 30
                    query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador30.Text + "," + lbl_id_clube30.Text + "," + lbl_id_posicao30.Text + "," + "(" + valor + "* parse('" + lbl_pontos30.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos30.Text + "' as numeric(5,2) using 'PT-pt')));";

                }
                else if (lbl_jogador31.Text != "-")
                {
                    // Inserir dados jogador 30
                    query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador30.Text + "," + lbl_id_clube30.Text + "," + lbl_id_posicao30.Text + "," + "(" + valor + "* parse('" + lbl_pontos30.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos30.Text + "' as numeric(5,2) using 'PT-pt'))),";

                    if (lbl_jogador32.Text == "-")
                    {
                        // Inserir dados jogador 31
                        query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador31.Text + "," + lbl_id_clube31.Text + "," + lbl_id_posicao31.Text + "," + "(" + valor + "* parse('" + lbl_pontos31.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos31.Text + "' as numeric(5,2) using 'PT-pt')));";
                    }
                    else if (lbl_jogador32.Text != "-")
                    {
                        // Inserir dados jogador 31
                        query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador31.Text + "," + lbl_id_clube31.Text + "," + lbl_id_posicao31.Text + "," + "(" + valor + "* parse('" + lbl_pontos31.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos31.Text + "' as numeric(5,2) using 'PT-pt'))),";

                        // Inserir dados jogador 32
                        query += "(" + ddl_jornada.SelectedValue + "," + lbl_id_jogador32.Text + "," + lbl_id_clube32.Text + "," + lbl_id_posicao32.Text + "," + "(" + valor + "* parse('" + lbl_pontos32.Text + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + lbl_pontos32.Text + "' as numeric(5,2) using 'PT-pt')));";
                    }

                }
            }

            myCon.Open();
            SqlCommand myCommand = new SqlCommand(query, myCon);
            myCommand.ExecuteNonQuery();
            myCon.Close();

            // calcular dados treinadores
            string query2 = "select avg(pontos) from historico_jogadores where id_clube= " + lbl_clube.Text + " and " + "id_jornada=" + ddl_jornada.SelectedValue;

            string ponto_treinador = "";
            SqlCommand myCommand2 = new SqlCommand(query2, myCon);
            myCon.Open();
            var id_jogador2 = myCommand2.ExecuteReader();
            if (id_jogador2.Equals(null))
            {
                Response.Write("Treinador não encontrado!!!!");
            }
            else if (id_jogador2.Read())
            {
                ponto_treinador = id_jogador2.GetDecimal(0).ToString();
            }
            myCon.Close();

            string query4 = "select avg(pontos) from historico_jogadores where id_clube= " + lbl_clube2.Text + " and " + "id_jornada=" + ddl_jornada.SelectedValue;

            string ponto_treinador2 = "";
            SqlCommand myCommand4 = new SqlCommand(query4, myCon);
            myCon.Open();
            var id_jogador4 = myCommand4.ExecuteReader();
            if (id_jogador4.Equals(null))
            {
                Response.Write("Treinador não encontrado!!!!");
            }
            else if (id_jogador4.Read())
            {
                ponto_treinador2 = id_jogador4.GetDecimal(0).ToString();
            }
            myCon.Close();

            // inserir dados treinadores

            string query3 = "insert into historico_jogadores (id_jornada, id_jogador, id_clube, id_posicao, valor, pontos) values ";
            query3 += "(" + ddl_jornada.SelectedValue + "," + lbl_treinador.Text + "," + lbl_clube.Text + ", 1002," + "(" + valor + "* parse('" + ponto_treinador + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + ponto_treinador + "' as numeric(5,2) using 'PT-pt'))); ";

            myCon.Open();
            SqlCommand myCommand3 = new SqlCommand(query3, myCon);
            myCommand3.ExecuteNonQuery();
            myCon.Close();

            string query5 = "insert into historico_jogadores (id_jornada, id_jogador, id_clube, id_posicao, valor, pontos) values ";
            query5 += "(" + ddl_jornada.SelectedValue + "," + lbl_treinador2.Text + "," + lbl_clube2.Text + ", 1002," + "(" + valor + "* parse('" + ponto_treinador2 + "' as numeric(5,2) using 'PT-pt'))," + "(" + ponto + "* parse('" + ponto_treinador2 + "' as numeric(5,2) using 'PT-pt'))); ";

            myCon.Open();
            SqlCommand myCommand5 = new SqlCommand(query5, myCon);
            myCommand5.ExecuteNonQuery();
            myCon.Close();

            lbl_mensagem.Text = "Jogo Registado com Sucesso !!!";
        }

        public void RPA()
        {
            
            var wc = new WebClient();
            string pagina = wc.DownloadString(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(pagina);

            var divs = htmlDocument.DocumentNode.Descendants("div").Where(node => node.GetAttributeValue("class", "").Contains("player")).ToList();

            string jogador = "";
            string equipa = "";
            string nota = "";
            int nt = 0;
            int n = 0;
            int num = 0;

            if(url != "") { 
            foreach (HtmlNode node in htmlDocument.GetElementbyId("game_report").ChildNodes)
            {
                if (node.Attributes.Count > 0)
                {

                    var node4 = node.Descendants("div").Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("title")).ToList();
                    foreach (var nodes in node4)
                    {
                        equipa = nodes.InnerText;
                        if (num == 0)
                        {
                            lbl_casa.Text = equipa;
                        }
                        else if (num == 1)
                        {
                            lbl_visitante.Text = equipa;
                        }
                        num = num + 1;
                    }
                    var node2 = node.Descendants("div").Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("text")).ToList();
                    foreach (var nodes in node2)
                    {
                        jogador = nodes.InnerText;
                        if (n == 0)
                        {
                            lbl_jogador.Text = jogador;
                        }
                        else if (n == 1)
                        {
                            lbl_jogador2.Text = jogador;
                        }
                        else if (n == 2)
                        {
                            lbl_jogador3.Text = jogador;
                        }
                        else if (n == 3)
                        {
                            lbl_jogador4.Text = jogador;
                        }
                        else if (n == 4)
                        {
                            lbl_jogador5.Text = jogador;
                        }
                        else if (n == 5)
                        {
                            lbl_jogador6.Text = jogador;
                        }
                        else if (n == 6)
                        {
                            lbl_jogador7.Text = jogador;
                        }
                        else if (n == 7)
                        {
                            lbl_jogador8.Text = jogador;
                        }
                        else if (n == 8)
                        {
                            lbl_jogador9.Text = jogador;
                        }
                        else if (n == 9)
                        {
                            lbl_jogador10.Text = jogador;
                        }
                        else if (n == 10)
                        {
                            lbl_jogador11.Text = jogador;
                        }
                        else if (n == 11)
                        {
                            lbl_jogador12.Text = jogador;
                        }
                        else if (n == 12)
                        {
                            lbl_jogador13.Text = jogador;
                        }
                        else if (n == 13)
                        {
                            lbl_jogador14.Text = jogador;
                        }
                        else if (n == 14)
                        {
                            lbl_jogador15.Text = jogador;
                        }
                        else if (n == 15)
                        {
                            lbl_jogador16.Text = jogador;
                        }
                        else if (n == 16)
                        {
                            lbl_jogador17.Text = jogador;
                        }
                        else if (n == 17)
                        {
                            lbl_jogador18.Text = jogador;
                        }
                        else if (n == 18)
                        {
                            lbl_jogador19.Text = jogador;
                        }
                        else if (n == 19)
                        {
                            lbl_jogador20.Text = jogador;
                        }
                        else if (n == 20)
                        {
                            lbl_jogador21.Text = jogador;
                        }
                        else if (n == 21)
                        {
                            lbl_jogador22.Text = jogador;
                        }
                        else if (n == 22)
                        {
                            lbl_jogador23.Text = jogador;
                        }
                        else if (n == 23)
                        {
                            lbl_jogador24.Text = jogador;
                        }
                        else if (n == 24)
                        {
                            lbl_jogador25.Text = jogador;
                        }
                        else if (n == 25)
                        {
                            lbl_jogador26.Text = jogador;
                        }
                        else if (n == 26)
                        {
                            lbl_jogador27.Text = jogador;
                        }
                        else if (n == 27)
                        {
                            lbl_jogador28.Text = jogador;
                        }
                        else if (n == 28)
                        {
                            lbl_jogador29.Text = jogador;
                        }
                        else if (n == 29)
                        {
                            lbl_jogador30.Text = jogador;
                        }
                        else if (n == 30)
                        {
                            lbl_jogador31.Text = jogador;
                        }
                        else if (n == 31)
                        {
                            lbl_jogador32.Text = jogador;
                        }
                        n = n + 1;
                    }

                    var node3 = node.Descendants("div").Where(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("number round")).ToList();
                    foreach (var nodes in node3)
                    {
                        string ponto = "0";
                        nota = nodes.InnerText;
                        if (nt == 0)
                        {
                            lbl_pontos.Text = nota;
                            if (lbl_pontos.Text == " -")
                            {
                                lbl_pontos.Text = ponto;
                            }
                        }
                        else if (nt == 1)
                        {
                            lbl_pontos2.Text = nota;
                            if (lbl_pontos2.Text == " -")
                            {
                                lbl_pontos2.Text = ponto;
                            }
                        }
                        else if (nt == 2)
                        {
                            lbl_pontos3.Text = nota;
                            if (lbl_pontos3.Text == " -")
                            {
                                lbl_pontos3.Text = ponto;
                            }
                        }
                        else if (nt == 3)
                        {
                            lbl_pontos4.Text = nota;
                            if (lbl_pontos4.Text == " -")
                            {
                                lbl_pontos4.Text = ponto;
                            }
                        }
                        else if (nt == 4)
                        {
                            lbl_pontos5.Text = nota;
                            if (lbl_pontos5.Text == " -")
                            {
                                lbl_pontos5.Text = ponto;
                            }
                        }
                        else if (nt == 5)
                        {
                            lbl_pontos6.Text = nota;
                            if (lbl_pontos6.Text == " -")
                            {
                                lbl_pontos6.Text = ponto;
                            }
                        }
                        else if (nt == 6)
                        {
                            lbl_pontos7.Text = nota;
                            if (lbl_pontos7.Text == " -")
                            {
                                lbl_pontos7.Text = ponto;
                            }
                        }
                        else if (nt == 7)
                        {
                            lbl_pontos8.Text = nota;
                            if (lbl_pontos8.Text == " -")
                            {
                                lbl_pontos8.Text = ponto;
                            }
                        }
                        else if (nt == 8)
                        {
                            lbl_pontos9.Text = nota;
                            if (lbl_pontos9.Text == " -")
                            {
                                lbl_pontos9.Text = ponto;
                            }
                        }
                        else if (nt == 9)
                        {
                            lbl_pontos10.Text = nota;
                            if (lbl_pontos10.Text == " -")
                            {
                                lbl_pontos10.Text = ponto;
                            }
                        }
                        else if (nt == 10)
                        {
                            lbl_pontos11.Text = nota;
                            if (lbl_pontos11.Text == " -")
                            {
                                lbl_pontos11.Text = ponto;
                            }
                        }
                        else if (nt == 11)
                        {
                            lbl_pontos12.Text = nota;
                            if (lbl_pontos12.Text == " -")
                            {
                                lbl_pontos12.Text = ponto;
                            }
                        }
                        else if (nt == 12)
                        {
                            lbl_pontos13.Text = nota;
                            if (lbl_pontos13.Text == " -")
                            {
                                lbl_pontos13.Text = ponto;
                            }
                        }
                        else if (nt == 13)
                        {
                            lbl_pontos14.Text = nota;
                            if (lbl_pontos14.Text == " -")
                            {
                                lbl_pontos14.Text = ponto;
                            }
                        }
                        else if (nt == 14)
                        {
                            lbl_pontos15.Text = nota;
                            if (lbl_pontos15.Text == " -")
                            {
                                lbl_pontos15.Text = ponto;
                            }
                        }
                        else if (nt == 15)
                        {
                            lbl_pontos16.Text = nota;
                            if (lbl_pontos16.Text == " -")
                            {
                                lbl_pontos16.Text = ponto;
                            }
                        }
                        else if (nt == 16)
                        {
                            lbl_pontos17.Text = nota;
                            if (lbl_pontos17.Text == " -")
                            {
                                lbl_pontos17.Text = ponto;
                            }
                        }
                        else if (nt == 17)
                        {
                            lbl_pontos18.Text = nota;
                            if (lbl_pontos18.Text == " -")
                            {
                                lbl_pontos18.Text = ponto;
                            }
                        }
                        else if (nt == 18)
                        {
                            lbl_pontos19.Text = nota;
                            if (lbl_pontos19.Text == " -")
                            {
                                lbl_pontos19.Text = ponto;
                            }
                        }
                        else if (nt == 19)
                        {
                            lbl_pontos20.Text = nota;
                            if (lbl_pontos20.Text == " -")
                            {
                                lbl_pontos20.Text = ponto;
                            }
                        }
                        else if (nt == 20)
                        {
                            lbl_pontos21.Text = nota;
                            if (lbl_pontos21.Text == " -")
                            {
                                lbl_pontos21.Text = ponto;
                            }
                        }
                        else if (nt == 21)
                        {
                            lbl_pontos22.Text = nota;
                            if (lbl_pontos22.Text == " -")
                            {
                                lbl_pontos22.Text = ponto;
                            }
                        }
                        else if (nt == 22)
                        {
                            lbl_pontos23.Text = nota;
                            if (lbl_pontos23.Text == " -")
                            {
                                lbl_pontos23.Text = ponto;
                            }
                        }
                        else if (nt == 23)
                        {
                            lbl_pontos24.Text = nota;
                            if (lbl_pontos24.Text == " -")
                            {
                                lbl_pontos24.Text = ponto;
                            }
                        }
                        else if (nt == 24)
                        {
                            lbl_pontos25.Text = nota;
                            if (lbl_pontos25.Text == " -")
                            {
                                lbl_pontos25.Text = ponto;
                            }
                        }
                        else if (nt == 25)
                        {
                            lbl_pontos26.Text = nota;
                            if (lbl_pontos26.Text == " -")
                            {
                                lbl_pontos26.Text = ponto;
                                if (lbl_pontos26.Text == " -")
                                {
                                    lbl_pontos26.Text = ponto;
                                }
                            }
                        }
                        else if (nt == 26)
                        {
                            lbl_pontos27.Text = nota;
                            if (lbl_pontos27.Text == " -")
                            {
                                lbl_pontos27.Text = ponto;
                                if (lbl_pontos27.Text == " -")
                                {
                                    lbl_pontos27.Text = ponto;
                                }
                            }
                        }
                        else if (nt == 27)
                        {
                            lbl_pontos28.Text = nota;
                            if (lbl_pontos28.Text == " -")
                            {
                                lbl_pontos28.Text = ponto;
                            }
                        }
                        else if (nt == 28)
                        {
                            lbl_pontos29.Text = nota;
                            if (lbl_pontos29.Text == " -")
                            {
                                lbl_pontos29.Text = ponto;
                            }
                        }
                        else if (nt == 29)
                        {
                            lbl_pontos30.Text = nota;
                            if (lbl_pontos30.Text == " -")
                            {
                                lbl_pontos30.Text = ponto;
                            }
                        }
                        else if (nt == 30)
                        {
                            lbl_pontos31.Text = nota;
                            if (lbl_pontos31.Text == " -")
                            {
                                lbl_pontos31.Text = ponto;
                            }
                        }
                        else if (nt == 31)
                        {
                            lbl_pontos32.Text = nota;
                            if (lbl_pontos32.Text == " -")
                            {
                                lbl_pontos32.Text = ponto;
                            }
                        }
                        nt = nt + 1;
                    }
                }


                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                // Buscar dados jogador 1
                string query = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador.Text + "'";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var id_jogador = myCommand.ExecuteReader();
                if (id_jogador.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador.Read())
                {
                    lbl_id_jogador.Text = id_jogador.GetInt32(0).ToString();
                    lbl_id_clube.Text = id_jogador.GetInt32(1).ToString();
                    lbl_id_posicao.Text = id_jogador.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 2
                string query2 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador2.Text + "'";

                SqlCommand myCommand2 = new SqlCommand(query2, myCon);
                myCon.Open();
                var id_jogador2 = myCommand2.ExecuteReader();
                if (id_jogador2.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador2.Read())
                {
                    lbl_id_jogador2.Text = id_jogador2.GetInt32(0).ToString();
                    lbl_id_clube2.Text = id_jogador2.GetInt32(1).ToString();
                    lbl_id_posicao2.Text = id_jogador2.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 3
                string query3 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador3.Text + "'";

                SqlCommand myCommand3 = new SqlCommand(query3, myCon);
                myCon.Open();
                var id_jogador3 = myCommand3.ExecuteReader();
                if (id_jogador3.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador3.Read())
                {
                    lbl_id_jogador3.Text = id_jogador3.GetInt32(0).ToString();
                    lbl_id_clube3.Text = id_jogador3.GetInt32(1).ToString();
                    lbl_id_posicao3.Text = id_jogador3.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 4
                string query4 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador4.Text + "'";

                SqlCommand myCommand4 = new SqlCommand(query4, myCon);
                myCon.Open();
                var id_jogador4 = myCommand4.ExecuteReader();
                if (id_jogador4.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador4.Read())
                {
                    lbl_id_jogador4.Text = id_jogador4.GetInt32(0).ToString();
                    lbl_id_clube4.Text = id_jogador4.GetInt32(1).ToString();
                    lbl_id_posicao4.Text = id_jogador4.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 5
                string query5 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador5.Text + "'";

                SqlCommand myCommand5 = new SqlCommand(query5, myCon);
                myCon.Open();
                var id_jogador5 = myCommand5.ExecuteReader();
                if (id_jogador5.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador5.Read())
                {
                    lbl_id_jogador5.Text = id_jogador5.GetInt32(0).ToString();
                    lbl_id_clube5.Text = id_jogador5.GetInt32(1).ToString();
                    lbl_id_posicao5.Text = id_jogador5.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 6
                string query6 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador6.Text + "'";

                SqlCommand myCommand6 = new SqlCommand(query6, myCon);
                myCon.Open();
                var id_jogador6 = myCommand6.ExecuteReader();
                if (id_jogador6.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador6.Read())
                {
                    lbl_id_jogador6.Text = id_jogador6.GetInt32(0).ToString();
                    lbl_id_clube6.Text = id_jogador6.GetInt32(1).ToString();
                    lbl_id_posicao6.Text = id_jogador6.GetInt32(2).ToString();
                }
                myCon.Close();


                // Buscar dados jogador 7
                string query7 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador7.Text + "'";

                SqlCommand myCommand7 = new SqlCommand(query7, myCon);
                myCon.Open();
                var id_jogador7 = myCommand7.ExecuteReader();
                if (id_jogador7.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador7.Read())
                {
                    lbl_id_jogador7.Text = id_jogador7.GetInt32(0).ToString();
                    lbl_id_clube7.Text = id_jogador7.GetInt32(1).ToString();
                    lbl_id_posicao7.Text = id_jogador7.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 8
                string query8 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador8.Text + "'";

                SqlCommand myCommand8 = new SqlCommand(query8, myCon);
                myCon.Open();
                var id_jogador8 = myCommand8.ExecuteReader();
                if (id_jogador8.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador8.Read())
                {
                    lbl_id_jogador8.Text = id_jogador8.GetInt32(0).ToString();
                    lbl_id_clube8.Text = id_jogador8.GetInt32(1).ToString();
                    lbl_id_posicao8.Text = id_jogador8.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 9
                string query9 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador9.Text + "'";

                SqlCommand myCommand9 = new SqlCommand(query9, myCon);
                myCon.Open();
                var id_jogador9 = myCommand9.ExecuteReader();
                if (id_jogador9.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador9.Read())
                {
                    lbl_id_jogador9.Text = id_jogador9.GetInt32(0).ToString();
                    lbl_id_clube9.Text = id_jogador9.GetInt32(1).ToString();
                    lbl_id_posicao9.Text = id_jogador9.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 10
                string query10 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador10.Text + "'";

                SqlCommand myCommand10 = new SqlCommand(query10, myCon);
                myCon.Open();
                var id_jogador10 = myCommand10.ExecuteReader();
                if (id_jogador10.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador10.Read())
                {
                    lbl_id_jogador10.Text = id_jogador10.GetInt32(0).ToString();
                    lbl_id_clube10.Text = id_jogador10.GetInt32(1).ToString();
                    lbl_id_posicao10.Text = id_jogador10.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 11
                string query11 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador11.Text + "'";

                SqlCommand myCommand11 = new SqlCommand(query11, myCon);
                myCon.Open();
                var id_jogador11 = myCommand11.ExecuteReader();
                if (id_jogador11.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador11.Read())
                {
                    lbl_id_jogador11.Text = id_jogador11.GetInt32(0).ToString();
                    lbl_id_clube11.Text = id_jogador11.GetInt32(1).ToString();
                    lbl_id_posicao11.Text = id_jogador11.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 23
                string query23 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador23.Text + "'";

                SqlCommand myCommand23 = new SqlCommand(query23, myCon);
                myCon.Open();
                var id_jogador23 = myCommand23.ExecuteReader();
                if (id_jogador23.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador23.Read())
                {
                    lbl_id_jogador23.Text = id_jogador23.GetInt32(0).ToString();
                    lbl_id_clube23.Text = id_jogador23.GetInt32(1).ToString();
                    lbl_id_posicao23.Text = id_jogador23.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 24
                string query24 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador24.Text + "'";

                SqlCommand myCommand24 = new SqlCommand(query24, myCon);
                myCon.Open();
                var id_jogador24 = myCommand24.ExecuteReader();
                if (id_jogador24.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador24.Read())
                {
                    lbl_id_jogador24.Text = id_jogador24.GetInt32(0).ToString();
                    lbl_id_clube24.Text = id_jogador24.GetInt32(1).ToString();
                    lbl_id_posicao24.Text = id_jogador24.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 25
                string query25 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador25.Text + "'";

                SqlCommand myCommand25 = new SqlCommand(query25, myCon);
                myCon.Open();
                var id_jogador25 = myCommand25.ExecuteReader();
                if (id_jogador25.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador25.Read())
                {
                    lbl_id_jogador25.Text = id_jogador25.GetInt32(0).ToString();
                    lbl_id_clube25.Text = id_jogador25.GetInt32(1).ToString();
                    lbl_id_posicao25.Text = id_jogador25.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 26
                string query26 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador26.Text + "'";

                SqlCommand myCommand26 = new SqlCommand(query26, myCon);
                myCon.Open();
                var id_jogador26 = myCommand26.ExecuteReader();
                if (id_jogador26.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador26.Read())
                {
                    lbl_id_jogador26.Text = id_jogador26.GetInt32(0).ToString();
                    lbl_id_clube26.Text = id_jogador26.GetInt32(1).ToString();
                    lbl_id_posicao26.Text = id_jogador26.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 27
                string query27 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador27.Text + "'";

                SqlCommand myCommand27 = new SqlCommand(query27, myCon);
                myCon.Open();
                var id_jogador27 = myCommand27.ExecuteReader();
                if (id_jogador27.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador27.Read())
                {
                    lbl_id_jogador27.Text = id_jogador27.GetInt32(0).ToString();
                    lbl_id_clube27.Text = id_jogador27.GetInt32(1).ToString();
                    lbl_id_posicao27.Text = id_jogador27.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 12
                string query12 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador12.Text + "'";

                SqlCommand myCommand12 = new SqlCommand(query12, myCon);
                myCon.Open();
                var id_jogador12 = myCommand12.ExecuteReader();
                if (id_jogador12.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador12.Read())
                {
                    lbl_id_jogador12.Text = id_jogador12.GetInt32(0).ToString();
                    lbl_id_clube12.Text = id_jogador12.GetInt32(1).ToString();
                    lbl_id_posicao12.Text = id_jogador12.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 13
                string query13 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador13.Text + "'";

                SqlCommand myCommand13 = new SqlCommand(query13, myCon);
                myCon.Open();
                var id_jogador13 = myCommand13.ExecuteReader();
                if (id_jogador13.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador13.Read())
                {
                    lbl_id_jogador13.Text = id_jogador13.GetInt32(0).ToString();
                    lbl_id_clube13.Text = id_jogador13.GetInt32(1).ToString();
                    lbl_id_posicao13.Text = id_jogador13.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 14
                string query14 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador14.Text + "'";

                SqlCommand myCommand14 = new SqlCommand(query14, myCon);
                myCon.Open();
                var id_jogador14 = myCommand14.ExecuteReader();
                if (id_jogador14.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador14.Read())
                {
                    lbl_id_jogador14.Text = id_jogador14.GetInt32(0).ToString();
                    lbl_id_clube14.Text = id_jogador14.GetInt32(1).ToString();
                    lbl_id_posicao14.Text = id_jogador14.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 15
                string query15 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador15.Text + "'";

                SqlCommand myCommand15 = new SqlCommand(query15, myCon);
                myCon.Open();
                var id_jogador15 = myCommand15.ExecuteReader();
                if (id_jogador15.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador15.Read())
                {
                    lbl_id_jogador15.Text = id_jogador15.GetInt32(0).ToString();
                    lbl_id_clube15.Text = id_jogador15.GetInt32(1).ToString();
                    lbl_id_posicao15.Text = id_jogador15.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 16
                string query16 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador16.Text + "'";

                SqlCommand myCommand16 = new SqlCommand(query16, myCon);
                myCon.Open();
                var id_jogador16 = myCommand16.ExecuteReader();
                if (id_jogador16.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador16.Read())
                {
                    lbl_id_jogador16.Text = id_jogador16.GetInt32(0).ToString();
                    lbl_id_clube16.Text = id_jogador16.GetInt32(1).ToString();
                    lbl_id_posicao16.Text = id_jogador16.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 17
                string query17 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador17.Text + "'";

                SqlCommand myCommand17 = new SqlCommand(query17, myCon);
                myCon.Open();
                var id_jogador17 = myCommand17.ExecuteReader();
                if (id_jogador17.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador17.Read())
                {
                    lbl_id_jogador17.Text = id_jogador17.GetInt32(0).ToString();
                    lbl_id_clube17.Text = id_jogador17.GetInt32(1).ToString();
                    lbl_id_posicao17.Text = id_jogador17.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 18
                string query18 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador18.Text + "'";

                SqlCommand myCommand18 = new SqlCommand(query18, myCon);
                myCon.Open();
                var id_jogador18 = myCommand18.ExecuteReader();
                if (id_jogador18.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador18.Read())
                {
                    lbl_id_jogador18.Text = id_jogador18.GetInt32(0).ToString();
                    lbl_id_clube18.Text = id_jogador18.GetInt32(1).ToString();
                    lbl_id_posicao18.Text = id_jogador18.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 19
                string query19 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador19.Text + "'";

                SqlCommand myCommand19 = new SqlCommand(query19, myCon);
                myCon.Open();
                var id_jogador19 = myCommand19.ExecuteReader();
                if (id_jogador19.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador19.Read())
                {
                    lbl_id_jogador19.Text = id_jogador19.GetInt32(0).ToString();
                    lbl_id_clube19.Text = id_jogador19.GetInt32(1).ToString();
                    lbl_id_posicao19.Text = id_jogador19.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 20
                string query20 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador20.Text + "'";

                SqlCommand myCommand20 = new SqlCommand(query20, myCon);
                myCon.Open();
                var id_jogador20 = myCommand20.ExecuteReader();
                if (id_jogador20.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador20.Read())
                {
                    lbl_id_jogador20.Text = id_jogador20.GetInt32(0).ToString();
                    lbl_id_clube20.Text = id_jogador20.GetInt32(1).ToString();
                    lbl_id_posicao20.Text = id_jogador20.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 21
                string query21 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador21.Text + "'";

                SqlCommand myCommand21 = new SqlCommand(query21, myCon);
                myCon.Open();
                var id_jogador21 = myCommand21.ExecuteReader();
                if (id_jogador21.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador21.Read())
                {
                    lbl_id_jogador21.Text = id_jogador21.GetInt32(0).ToString();
                    lbl_id_clube21.Text = id_jogador21.GetInt32(1).ToString();
                    lbl_id_posicao21.Text = id_jogador21.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 22
                string query22 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador22.Text + "'";

                SqlCommand myCommand22 = new SqlCommand(query22, myCon);
                myCon.Open();
                var id_jogador22 = myCommand22.ExecuteReader();
                if (id_jogador22.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador22.Read())
                {
                    lbl_id_jogador22.Text = id_jogador22.GetInt32(0).ToString();
                    lbl_id_clube22.Text = id_jogador22.GetInt32(1).ToString();
                    lbl_id_posicao22.Text = id_jogador22.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 28
                string query28 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador28.Text + "'";

                SqlCommand myCommand28 = new SqlCommand(query28, myCon);
                myCon.Open();
                var id_jogador28 = myCommand28.ExecuteReader();
                if (id_jogador28.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador28.Read())
                {
                    lbl_id_jogador28.Text = id_jogador28.GetInt32(0).ToString();
                    lbl_id_clube28.Text = id_jogador28.GetInt32(1).ToString();
                    lbl_id_posicao28.Text = id_jogador28.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 29
                string query29 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador29.Text + "'";

                SqlCommand myCommand29 = new SqlCommand(query29, myCon);
                myCon.Open();
                var id_jogador29 = myCommand29.ExecuteReader();
                if (id_jogador29.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador29.Read())
                {
                    lbl_id_jogador29.Text = id_jogador29.GetInt32(0).ToString();
                    lbl_id_clube29.Text = id_jogador29.GetInt32(1).ToString();
                    lbl_id_posicao29.Text = id_jogador29.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 30
                string query30 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador30.Text + "'";

                SqlCommand myCommand30 = new SqlCommand(query30, myCon);
                myCon.Open();
                var id_jogador30 = myCommand30.ExecuteReader();
                if (id_jogador30.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador30.Read())
                {
                    lbl_id_jogador30.Text = id_jogador30.GetInt32(0).ToString();
                    lbl_id_clube30.Text = id_jogador30.GetInt32(1).ToString();
                    lbl_id_posicao30.Text = id_jogador30.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 31
                string query31 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador31.Text + "'";

                SqlCommand myCommand31 = new SqlCommand(query31, myCon);
                myCon.Open();
                var id_jogador31 = myCommand31.ExecuteReader();
                if (id_jogador31.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador31.Read())
                {
                    lbl_id_jogador31.Text = id_jogador31.GetInt32(0).ToString();
                    lbl_id_clube31.Text = id_jogador31.GetInt32(1).ToString();
                    lbl_id_posicao31.Text = id_jogador31.GetInt32(2).ToString();
                }
                myCon.Close();

                // Buscar dados jogador 32
                if (lbl_jogador32.Text != "-")
                {
                    string query32 = "select id_jogador, id_clube, id_posicao from jogadores where nome_jogador= '" + lbl_jogador32.Text + "'";

                    SqlCommand myCommand32 = new SqlCommand(query32, myCon);
                    myCon.Open();
                    var id_jogador32 = myCommand32.ExecuteReader();
                    if (id_jogador32.Equals(null))
                    {
                        Response.Write("Jogador não encontrado!!!!");
                    }
                    else if (id_jogador32.Read())
                    {
                        lbl_id_jogador32.Text = id_jogador32.GetInt32(0).ToString();
                        lbl_id_clube32.Text = id_jogador32.GetInt32(1).ToString();
                        lbl_id_posicao32.Text = id_jogador32.GetInt32(2).ToString();
                    }
                    myCon.Close();

                }

                // Buscar dados clube mandante
                string query33 = "select id_clube from jogadores where id_jogador= " + lbl_id_jogador.Text;

                SqlCommand myCommand33 = new SqlCommand(query33, myCon);
                myCon.Open();
                var id_jogador33 = myCommand33.ExecuteReader();
                if (id_jogador33.Equals(null))
                {
                    Response.Write("Clube não encontrado!!!!");
                }
                else if (id_jogador33.Read())
                {
                    lbl_clube.Text = id_jogador33.GetInt32(0).ToString();

                }
                myCon.Close();

                // Buscar dados jogador 32
                string query34 = "select id_jogador from jogadores where id_posicao=1002 and id_clube= '" + lbl_clube.Text + "'";

                SqlCommand myCommand34 = new SqlCommand(query34, myCon);
                myCon.Open();
                var id_jogador34 = myCommand34.ExecuteReader();
                if (id_jogador34.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador34.Read())
                {
                    lbl_treinador.Text = id_jogador34.GetInt32(0).ToString();

                }
                myCon.Close();

                // Buscar dados clube visitante
                string query35 = "select id_clube from jogadores where id_jogador= " + lbl_id_jogador12.Text;

                SqlCommand myCommand35 = new SqlCommand(query35, myCon);
                myCon.Open();
                var id_jogador35 = myCommand35.ExecuteReader();
                if (id_jogador35.Equals(null))
                {
                    Response.Write("Clube não encontrado!!!!");
                }
                else if (id_jogador35.Read())
                {
                    lbl_clube2.Text = id_jogador35.GetInt32(0).ToString();

                }
                myCon.Close();

                // Buscar dados jogador 32
                string query36 = "select id_jogador from jogadores where id_posicao=1002 and id_clube= '" + lbl_clube2.Text + "'";

                SqlCommand myCommand36 = new SqlCommand(query36, myCon);
                myCon.Open();
                var id_jogador36 = myCommand36.ExecuteReader();
                if (id_jogador36.Equals(null))
                {
                    Response.Write("Jogador não encontrado!!!!");
                }
                else if (id_jogador36.Read())
                {
                    lbl_treinador2.Text = id_jogador36.GetInt32(0).ToString();

                }
                myCon.Close();
                }


            }
        }

        protected void btn_jogadores_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            for(int i=0; i<9999; i++)
            {
                string query = "";
                query = "update j set j.valor = consulta.valor_atualizado,  j.pontuacao = consulta.ponto_atualizado  from jogadores as j inner join(select id_jogador, avg(valor) as valor_atualizado , avg(pontos) as ponto_atualizado from historico_jogadores where id_jogador = " + i + "group by id_jogador) as consulta on j.id_jogador = consulta.id_jogador ";
                query += " where j.id_jogador = " + i;
                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();
            }

            lbl_mensagem.Text = "Valores jogadores atualizado com Sucesso !!!";
            
        }

        protected void btn_mercado_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            for (int i = 0; i < 9999; i++)
            {
                int id_escalacao = 0;
                int id_utilizador2 = 0;
                int id_jornada = 0;
                int id_clube = 0;
                int id_jogador = 0;
                string valor = "0";
                string pontos = "0";
                int id_esquema = 0;
                string query = "";
                

                query = "select * from escalacao where id_escalacao="+i;
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var escalacao = myCommand.ExecuteReader();
                if (escalacao.Equals(null))
                {
                    Response.Write("Dados não encontrado!!!!");
                }
                else if (escalacao.Read())
                {
                    id_escalacao = escalacao.GetInt32(0);
                    id_utilizador2 = escalacao.GetInt32(1);
                    id_jornada = escalacao.GetInt32(2);
                    id_clube = escalacao.GetInt32(3);
                    id_jogador = escalacao.GetInt32(4);
                    valor = escalacao.GetDecimal(5).ToString();
                    pontos = escalacao.GetDecimal(6).ToString();
                    id_esquema = escalacao.GetInt32(7);
                    
                }
                myCon.Close();
                if(id_escalacao != 0)
                {
                    string query2 = "insert into historico_escalacao (id_escalacao, id_jornada, id_clube, id_jogador, valor, pontos, id_esquema, id_utilizador) values (" + id_escalacao + "," + id_jornada + "," + id_clube + "," + id_jogador + "," + "convert(numeric(5,2),"+valor + "), convert(numeric(5,2)," + pontos + ")," + id_esquema + "," + id_utilizador2 + ");";

                    myCon.Open();
                    SqlCommand myCommand2 = new SqlCommand(query2, myCon);
                    myCommand2.ExecuteNonQuery();
                    myCon.Close();

                }
                            }
            lbl_mensagem.Text = "Mercado atualizado com Sucesso !!!";

        }
        int id_jonanada2=14;
        protected void btn_utilizador_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            for(int i = 0; i < 99999; i++)
            {

            double valor_equipaA = 0;
            double valor_equipa = 0;
            double pontos = 0;
            double guita_utilizador = 0;
            double pontos_utilizador = 0;
            double saldo = 0;
            double pontos_atuais = 0;
            string queryUp = "";
            string queryVtime = "";
            string queryGuita = "";
            string querypontos = "";


            string queryVAntigo = "select sum(h.valor) as soma from historico_escalacao as h where id_utilizador= "+ i + "and id_jornada=" + id_jonanada2 ;
            SqlCommand myCommandVA = new SqlCommand(queryVAntigo, myCon);
            myCon.Open();
            var valor_timeA = myCommandVA.ExecuteReader();
            if (valor_timeA.Read())
            {
                if (valor_timeA["soma"] != DBNull.Value)
                {
                    valor_equipaA = double.Parse(valor_timeA["soma"].ToString());
                }
                else
                {
                    valor_equipaA = 0;
                }
            }
            myCon.Close();

            queryVtime = "select sum(j.valor) as soma, sum(j.pontuacao) as pontos from escalacao as e inner join jogadores as j on j.id_jogador = e.id_jogador where id_utilizador=" + i;
            SqlCommand myCommandVtime = new SqlCommand(queryVtime, myCon);
            myCon.Open();
            var valor_time = myCommandVtime.ExecuteReader();
            if (valor_time.Read())
            {
                if (valor_time["soma"] != DBNull.Value)
                {
                    valor_equipa = double.Parse(valor_time["soma"].ToString());
                    pontos = double.Parse(valor_time["pontos"].ToString());
                }
                else
                {
                    valor_equipa = 0;
                }
            }
            myCon.Close();


            queryGuita = "select guita from utilizadores where id_utilizador=" + i;
            SqlCommand myCommandGuita = new SqlCommand(queryGuita, myCon);
            myCon.Open();
            var guita = myCommandGuita.ExecuteReader();
            if (guita.Read())
            {
                guita_utilizador = double.Parse(guita["guita"].ToString());
            }
            myCon.Close();

            saldo = (valor_equipa - valor_equipaA) + guita_utilizador;


            querypontos = "select pontos from utilizadores where id_utilizador=" + i;
            SqlCommand myCommandPontos = new SqlCommand(querypontos, myCon);
            myCon.Open();
            var pontosUtilizador= myCommandPontos.ExecuteReader();
            if (pontosUtilizador.Read())
            {
                pontos_utilizador = double.Parse(pontosUtilizador["pontos"].ToString());
            }
            myCon.Close();

            pontos_atuais = pontos_utilizador + pontos;

            // Atualiza os valores e pontos do utilizador
            queryUp = "update utilizadores set guita =" + "convert(numeric(5,2),"+ saldo + "),";
            queryUp += "pontos = "+ "convert(numeric(5,2),"+pontos_atuais+")" + "where id_utilizador="+i;

            myCon.Open();
            SqlCommand myCommandUp = new SqlCommand(queryUp, myCon);
            myCommandUp.ExecuteNonQuery();
            myCon.Close();

            }
        }
    }
}