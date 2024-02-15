using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace jornadaXPTO
{
    public partial class registar_utilizador : System.Web.UI.Page
    {
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
        }

        protected void btn_registar_Click(object sender, EventArgs e)
        {
            if(tb_pass.Text != tb_confirm_pass.Text)
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

                if (tb_pass.Text.Length < 6)
                {
                    situacao = "Fraco";
                }
                if (maiuscula.Matches(tb_pass.Text).Count == 0)
                {
                    situacao = "Fraco";
                }
                if (minuscula.Matches(tb_pass.Text).Count == 0)
                {
                    situacao = "Fraco";
                }
                if (digitos.Matches(tb_pass.Text).Count == 0)
                {
                    situacao = "Fraco";
                }
                if (especiais.Matches(tb_pass.Text).Count == 0)
                {
                    situacao = "Fraco";
                }
                if (plica.Matches(tb_pass.Text).Count > 0)
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

                    SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                    SqlCommand myCommand = new SqlCommand();
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "registar_utilizador";

                    myCommand.Connection = myConn;

                    myCommand.Parameters.AddWithValue("@nome", tb_utilizador.Text);
                    myCommand.Parameters.AddWithValue("@email", tb_email.Text);
                    myCommand.Parameters.AddWithValue("@adepto", ddl_adepto.SelectedItem.Value);
                    myCommand.Parameters.AddWithValue("@time_utilizador", tb_equipa_utilizador.Text);
                    myCommand.Parameters.AddWithValue("@palavra_passe", EncryptString(tb_pass.Text));

                    SqlParameter valor = new SqlParameter();
                    valor.ParameterName = "@retorno";
                    valor.Direction = ParameterDirection.Output;
                    valor.SqlDbType = SqlDbType.Int;

                    myCommand.Parameters.Add(valor);


                    myConn.Open();
                    myCommand.ExecuteNonQuery();
                    int respostaSP = Convert.ToInt32(myCommand.Parameters["@retorno"].Value);
                    myConn.Close();

                    if (respostaSP == 1) { 

                        lbl_mensagem.Text = "Verifique a sua conta de email para ativar a conta de registo !!!";

                    SmtpClient servidor = new SmtpClient();
                    MailMessage email = new MailMessage();

                    email.From = new MailAddress("pedro.almeida.22122@formandos.cinel.pt");
                    email.To.Add(new MailAddress(tb_email.Text));

                    email.Subject = "Ativação de conta !!!";

                    email.IsBodyHtml = true;
                    email.Body = "<b>Obrigado pelo registo na nossa aplicação. <br> Para ativar sua conta e começar a jogar, clique <a href='https://localhost:44328/ativacao.aspx?user=" + EncryptString(tb_email.Text) + "'>AQUI<a></b>";

                    servidor.Host = ConfigurationManager.AppSettings["SMTP_URL"];
                    servidor.Port = int.Parse(ConfigurationManager.AppSettings["SMTP_PORT"]);

                    string utilizador = ConfigurationManager.AppSettings["SMTP_USER"];
                    string pw = ConfigurationManager.AppSettings["SMTP_PASSWORD"];

                    servidor.Credentials = new NetworkCredential(utilizador, pw);
                    servidor.EnableSsl = true;

                    servidor.Send(email);
                    }
                    else if(respostaSP == 2)
                    {
                        lbl_mensagem.Text = "Nome de Equipa já existe, insira outro nome para vossa equipa !!!";
                    }
                    else if (respostaSP == 3)
                    {
                        lbl_mensagem.Text = "E-mail já cadastrado";
                    }
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