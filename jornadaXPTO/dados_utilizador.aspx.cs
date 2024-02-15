using javax.swing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jornadaXPTO
{
    public partial class dados_utilizador : System.Web.UI.Page
    {   
        int id_utilizador=0;
        string equipa_utilizador="";
        string nome_utilizador = "";
        string equipa_adepto="1";
        string id_escudo = "1";
        string id_filtro = "1";
        // Botão de salvar alteração do utilizador
        // Arrancar com o escudo do utilizador
        // Falta o botão excluir conta

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_data2.Text = lbl_data.Text;

            DateTime date1 = new DateTime(2023, 12, 15, 20, 0, 0);
            if (DateTime.Now > date1) { id_mercado.Text = "Mercado Encerrado Até 18/12 as 23h"; }

            if (!IsPostBack)
            {

                Page.MaintainScrollPositionOnPostBack = true;
                
                equipa_utilizador = tb_equipa.Text;
                nome_utilizador= tb_utilizador.Text;
                equipa_adepto = ddl_adepto.SelectedValue;
                id_escudo = ddl_escudo.SelectedValue;
                

            }   
           
            if(IsPostBack) 
            {

                equipa_utilizador = tb_equipa.Text;
                nome_utilizador = tb_utilizador.Text;
                equipa_adepto = ddl_adepto.SelectedValue;
                id_escudo = ddl_escudo.SelectedValue;
               
            }

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

                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                // Buscar dados utilizador
                string query = "select nome_utilizador, nome_time, id_clube, isnull(utilizadores.id_escudo,1) from utilizadores where email_utilizador='" + lbl_utilizador.Text + "'";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var dados_utilizador = myCommand.ExecuteReader();
                if (dados_utilizador.Equals(null))
                {
                    Response.Write("Utilizador não encontrado!!!!");
                }
                else if (dados_utilizador.Read())
                {
                    tb_utilizador.Text = dados_utilizador.GetString(0);
                    tb_equipa.Text = dados_utilizador.GetString(1);
                    ddl_adepto.SelectedValue = dados_utilizador.GetInt32(2).ToString();
                    ddl_escudo.SelectedValue = dados_utilizador.GetInt32(3).ToString();
                   id_filtro = ddl_escudo.SelectedValue;
                }
                myCon.Close();

                
            }
            else
            {
                Response.Redirect("login.aspx");
            }


        }

        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_escudo")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["emblema"]);
                ((Image)e.Item.FindControl("img_camisa")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["camisola"]);
                ((Button)e.Item.FindControl("btn_salvar")).CommandArgument = dr["id_escudo"].ToString();
            }
        }

        protected void ddl_escudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_mensagem.Text = "";
            if(id_escudo == "1")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 1";
                lbl_mensagem.Text = "";
               ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "2")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 2";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "3")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 3";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "4")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 4";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "5")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 5";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "6")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 6";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "7")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 7";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
            else if (id_escudo == "8")
            {
                SqlDataSource2.SelectCommand = "select * from escudos where id_escudo = 8";
                lbl_mensagem.Text = "";
                ddl_escudo.SelectedValue = id_escudo;
            }
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
            if (e.CommandName.Equals("btn_salvar"))
            {
                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                string query = "";

                query = "update utilizadores set ";
                query += "id_escudo=" + ddl_escudo.SelectedValue;
                query += " where email_utilizador= '"+lbl_utilizador.Text +"'" ;
                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();
                lbl_mensagem.Text = "";
            }
        }

        protected void btn_atualizar_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "atualizar_dados";

            myCommand.Connection = myConn;

            myCommand.Parameters.AddWithValue("@email", lbl_utilizador.Text);
            myCommand.Parameters.AddWithValue("@nome", nome_utilizador);
            myCommand.Parameters.AddWithValue("@equipa", equipa_utilizador);
            myCommand.Parameters.AddWithValue("@adepto", equipa_adepto);


            SqlParameter valor = new SqlParameter();
            valor.ParameterName = "@retorno";
            valor.Direction = ParameterDirection.Output;
            valor.SqlDbType = SqlDbType.Int;

            myCommand.Parameters.Add(valor);


            myConn.Open();
            myCommand.ExecuteNonQuery();
            int respostaSP = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);
            myConn.Close();

            if (respostaSP == 1)
            {
                lbl_mensagem2.Text = "Equipa Existente !!!";
            }
            if (respostaSP == 2)
            {
                lbl_mensagem2.Text = "Dados Inseridos com Sucesso !!!";
                
            }
            else
            {
                lbl_mensagem2.Text = "ERRO!!!";
            }


        }

        protected void btn_salvar_pass_Click(object sender, EventArgs e)
        {
            lbl_mensagem.Text = "";
            if (tb_pass.Text == "")
            {
                lbl_mensagem.Text += "<br/>Palavra-Passe Atual Obrigatorio !!!<br/>";
            }
            if(tb_nova_pass.Text == "")
            {
                lbl_mensagem.Text += "Nova Palavra-Passe Obrigatorio !!!<br/>";
            }
            if (tb_confirm.Text == "")
            {
                lbl_mensagem.Text += "Confirmar Palavra-Passe Obrigatorio !!!<br/>";
            }
            if(tb_pass.Text !="" && tb_nova_pass.Text != "" && tb_confirm.Text != "")
            {

            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "verificar_pass";

            myCommand.Connection = myConn;

            myCommand.Parameters.AddWithValue("@email", lbl_utilizador.Text);
            myCommand.Parameters.AddWithValue("@pass", EncryptString(tb_pass.Text));

            SqlParameter valor = new SqlParameter();
            valor.ParameterName = "@retorno";
            valor.Direction = ParameterDirection.Output;
            valor.SqlDbType = SqlDbType.Int;

            myCommand.Parameters.Add(valor);


            myConn.Open();
            myCommand.ExecuteNonQuery();
            int respostaSP = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);
            myConn.Close();

            if (respostaSP == 1)
            {
                if (tb_nova_pass.Text != tb_confirm.Text)
                {
                    lbl_mensagem.Text = "Confirmação de palavra-passe incorreta !!!";
                }
                else
                {
                    string situacao = "Forte";

                    Regex maiuscula = new Regex("[A-Z]");
                    Regex minuscula = new Regex("[a-z]");
                    Regex digitos = new Regex("[0-9]");
                    Regex especiais = new Regex("[^a-zA-Z0-9]");
                    Regex plica = new Regex("'");

                    if (tb_nova_pass.Text.Length < 6)
                    {
                        situacao = "Fraco";
                    }
                    if (maiuscula.Matches(tb_nova_pass.Text).Count == 0)
                    {
                        situacao = "Fraco";
                    }
                    if (minuscula.Matches(tb_nova_pass.Text).Count == 0)
                    {
                        situacao = "Fraco";
                    }
                    if (digitos.Matches(tb_nova_pass.Text).Count == 0)
                    {
                        situacao = "Fraco";
                    }
                    if (especiais.Matches(tb_nova_pass.Text).Count == 0)
                    {
                        situacao = "Fraco";
                    }
                    if (plica.Matches(tb_nova_pass.Text).Count > 0)
                    {
                        situacao = "Fraco";
                    }

                    string fraco = "A senha tem que conter: " + "<br/>" + "Mais de 6 caracteres" + "<br/>" + "1 Letra Maíscula" + "<br/>" + "1 Letra Minúscula" + "<br/>" + "1 Número" + "<br/>" + "1 Caracter especial";
                    if (situacao == "Fraco")
                    {
                        lbl_mensagem.Text = fraco;

                    }
                    else if (situacao == "Forte")
                    {
                        SqlConnection myConn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                        SqlCommand myCommand2 = new SqlCommand();
                        myCommand2.CommandType = CommandType.StoredProcedure;
                        myCommand2.CommandText = "alterar_passe";

                        myCommand2.Connection = myConn2;

                        myCommand2.Parameters.AddWithValue("@email", lbl_utilizador.Text);
                        myCommand2.Parameters.AddWithValue("@pwNova", EncryptString(tb_nova_pass.Text));

                        SqlParameter valor2 = new SqlParameter();
                        valor2.ParameterName = "@retorno";
                        valor2.Direction = ParameterDirection.Output;
                        valor2.SqlDbType = SqlDbType.Int;

                        myCommand2.Parameters.Add(valor2);


                        myConn2.Open();
                        myCommand2.ExecuteNonQuery();
                        int respostaSP2 = Convert.ToInt32(myCommand2.Parameters["@retorno"].Value);
                        myConn2.Close();
                        if(respostaSP2 == 1)
                        {
                            lbl_mensagem.Text = "Palavra-Passe alterada com sucesso !!!";
                        }
                        else if(respostaSP2 == 0)
                        {
                            lbl_mensagem.Text = "ERRO !!!";
                        }
                    }

                }
            }
            else
            {
                lbl_mensagem.Text = "Senha atual incorreta !!!";
            }

            }
        }

        public static string EncryptString(string Message)
        {
            string Passphrase = "analu";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();



            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below



            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));



            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();



            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;



            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);



            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }



            // Step 6. Return the encrypted string as a base64 encoded string



            string enc = Convert.ToBase64String(Results);
            enc = enc.Replace("+", "KLKLK");
            enc = enc.Replace("/", "JLJLJL");
            enc = enc.Replace("\\", "IOIOIO");
            return enc;
        }
    }

}