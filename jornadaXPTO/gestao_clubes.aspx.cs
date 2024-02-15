using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jornadaXPTO
{
    public partial class gestao_clubes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_data2.Text = lbl_data.Text;
            DateTime date1 = new DateTime(2023, 12, 15, 20, 0, 0);
            if (DateTime.Now > date1) { id_mercado.Text = "Mercado Encerrado Até 18/12 as 23h"; }

            if (!IsPostBack)
            {
                // Configurar para manter a posição de rolagem durante o postback
                Page.MaintainScrollPositionOnPostBack = true;

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

            }
            else { Response.Redirect("index.aspx"); }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Label)e.Item.FindControl("lbl_cod")).Text = dr["id_clube"].ToString();
                ((Image)e.Item.FindControl("img_emblema")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["emblema"]);
                ((Label)e.Item.FindControl("lbl_equipa")).Text = dr["nome_clube"].ToString();
                ((Label)e.Item.FindControl("lbl_cidade")).Text = dr["cidade"].ToString();
                ((DropDownList)e.Item.FindControl("ddl_status")).SelectedValue = dr["ativado"].ToString();
                ((Button)e.Item.FindControl("btn_salvar")).CommandArgument = dr["id_clube"].ToString();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
                if (e.CommandName.Equals("btn_salvar"))
                {

                    SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                    string query = "";

                    query = "update clubes set ";
                    query += "ativado='" + ((DropDownList)e.Item.FindControl("ddl_status")).SelectedValue + "' ";
                    query += "where id_clube=" + ((Label)e.Item.FindControl("lbl_cod")).Text;
                    myCon.Open();
                    SqlCommand myCommand = new SqlCommand(query, myCon);
                    myCommand.ExecuteNonQuery();
                    myCon.Close();

                }
        }

        protected void btn_salvar_todos_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            
            for (int i = 0; i <Repeater1.Items.Count; i++)
            {
                string query = "";
                query = "update clubes set ";
                query += "ativado='" + ((DropDownList)Repeater1.Items[i].FindControl("ddl_status")).SelectedValue + "' ";
                query += "where id_clube=" + ((Label)Repeater1.Items[i].FindControl("lbl_cod")).Text+ ";";
                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();
               
            }

            Response.Redirect("gestao_clubes.aspx");
        } 
    }
}
    