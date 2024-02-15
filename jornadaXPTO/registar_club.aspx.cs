using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace jornadaXPTO
{
    public partial class registar_club : System.Web.UI.Page
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
            else { Response.Redirect("index.aspx"); }
        }

        protected void btn_registar_Click(object sender, EventArgs e)
        {

            //Apanhar o ficheiro que foi selecionado
            Stream imgStream = FileUpload1.PostedFile.InputStream;

            //Identificar o tamanho do ficheiro
            int tamanhoFich = FileUpload1.PostedFile.ContentLength;

            //Identificar o contentType (tipo de ficheiro)
            string contentType = FileUpload1.PostedFile.ContentType;

            //Arrey para armazernar dados binarios
            byte[] imgBinaryData = new byte[tamanhoFich];

            //Preencher o arrey 
            imgStream.Read(imgBinaryData, 0, tamanhoFich);

            //Conexão a base de dados
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            // Seleccionar a SP
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "inserir_club";

            myCommand.Connection = myConn;
            //Passar os parametros para a SP
            myCommand.Parameters.AddWithValue("@nome_clube", tb_clube.Text);
            myCommand.Parameters.AddWithValue("@cidade", tb_cidade.Text);
            myCommand.Parameters.AddWithValue("@ct_emblema", contentType);
            myCommand.Parameters.AddWithValue("@emblema", imgBinaryData);
            


            myConn.Open();
            myCommand.ExecuteNonQuery();
            myConn.Close();

            Response.Write("<script language=javascript>alert('ERROR');</script>");


            Response.Redirect("registar_club.aspx");
        }
    }
}