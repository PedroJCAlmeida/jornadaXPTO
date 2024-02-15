using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace jornadaXPTO
{
    public partial class recuperar_pass : System.Web.UI.Page
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

        protected void btn_recuperar_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "verificar_conta";

            myCommand.Connection = myConn;

            myCommand.Parameters.AddWithValue("@email", tb_email.Text);

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
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var CharSar = new char[10];
                Random aleatorio = new Random();

                for (int i = 0; i < CharSar.Length; i++)
                {
                    CharSar[i] = chars[aleatorio.Next(chars.Length)];
                }

                var nova_passe = new String(CharSar);
               
                SqlConnection myConn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                SqlCommand myCommand2 = new SqlCommand();
                myCommand2.CommandType = CommandType.StoredProcedure;
                myCommand2.CommandText = "recuperar_passe";

                myCommand2.Connection = myConn2;

                myCommand2.Parameters.AddWithValue("@email", tb_email.Text);
                myCommand2.Parameters.AddWithValue("@pwNova", EncryptString(nova_passe));

                SqlParameter valor2 = new SqlParameter();
                valor2.ParameterName = "@retorno";
                valor2.Direction = ParameterDirection.Output;
                valor2.SqlDbType = SqlDbType.Int;

                myCommand2.Parameters.Add(valor2);


                myConn2.Open();
                myCommand2.ExecuteNonQuery();
                int respostaSP2 = Convert.ToInt32(myCommand2.Parameters["@retorno"].Value);
                myConn2.Close();

                if (respostaSP2 == 1)
                {
                    SmtpClient servidor = new SmtpClient();
                    MailMessage email = new MailMessage();

                    email.From = new MailAddress("pedro.almeida.22122@formandos.cinel.pt");
                    email.To.Add(new MailAddress(tb_email.Text));

                    email.Subject = "Recuperação de Palavra-Passe !!!";

                    email.IsBodyHtml = true;
                    email.Body = $"<b>Palavra-Passe recuperada com sucesso !!!. <br> Palavra-Passe: {nova_passe} </b>";

                    servidor.Host = ConfigurationManager.AppSettings["SMTP_URL"];
                    servidor.Port = int.Parse(ConfigurationManager.AppSettings["SMTP_PORT"]);

                    string utilizador = ConfigurationManager.AppSettings["SMTP_USER"];
                    string pw = ConfigurationManager.AppSettings["SMTP_PASSWORD"];

                    servidor.Credentials = new NetworkCredential(utilizador, pw);
                    servidor.EnableSsl = true;

                    servidor.Send(email);

                    lbl_mensagem.Text = "Foi enviado a nova Palavra-Passe para vosso email !!!";
                }

            }
            else if (respostaSP == 0)
            {
                lbl_mensagem.Text = "Utilizador não cadastrado !!!";
            }
            else if (respostaSP == 2)
            {
                lbl_mensagem.Text = "Utilizador inativo !!!";
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