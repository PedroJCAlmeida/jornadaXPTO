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
    public partial class ligas : System.Web.UI.Page
    {
        int id_utilizador = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_data2.Text = lbl_data.Text;
            DateTime date1 = new DateTime(2023, 12, 15, 20, 0, 0);
            if (DateTime.Now > date1) { id_mercado.Text = "Mercado Encerrado Até 18/12 as 23h"; }
            if (!IsPostBack)
            {

                Page.MaintainScrollPositionOnPostBack = true;
                

                SqlDataSource3.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' and u.id_utilizador = " + id_utilizador + " group by f.flamula, l.nome_liga, l.id_liga";

                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga";
               
            }
            if (Session["utilizador"] != null)
            {
                lbl_utilizador.Text = Session["utilizador"].ToString();
                Session["perfil"] = Session["perfil"];
                id_utilizador = int.Parse(Session["id_utilizador"].ToString());
                lbl_logout.Text = "Logout";
            SqlDataSource3.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' and u.id_utilizador = "+id_utilizador +" group by f.flamula, l.nome_liga, l.id_liga";

                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga";

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

            if (IsPostBack)
            {
                SqlDataSource3.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' and u.id_utilizador = " + id_utilizador + " group by f.flamula, l.nome_liga, l.id_liga";

                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga";
                
                Page.MaintainScrollPositionOnPostBack = true;
               
            }

        }

        protected void ddl_flamula_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);
            string query = "";
            if (ddl_flamula.SelectedValue == "6")
            {
                
                query = "select * from flamulas where ativado='true' and id_flamula=6";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var flamula = myCommand.ExecuteReader();
                if (flamula.Read())
                {
                    img_flamula.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])flamula["flamula"]);

                }
                myCon.Close();
            }
            else if (ddl_flamula.SelectedValue == "7")
            {

                query = "select * from flamulas where ativado='true' and id_flamula=7";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var flamula = myCommand.ExecuteReader();
                if (flamula.Read())
                {
                    img_flamula.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])flamula["flamula"]);

                }
                myCon.Close();
            }
            else if (ddl_flamula.SelectedValue == "8")
            {

                query = "select * from flamulas where ativado='true' and id_flamula=8";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var flamula = myCommand.ExecuteReader();
                if (flamula.Read())
                {
                    img_flamula.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])flamula["flamula"]);

                }
                myCon.Close();
            }
            else if (ddl_flamula.SelectedValue == "9")
            {

                query = "select * from flamulas where ativado='true' and id_flamula=9";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var flamula = myCommand.ExecuteReader();
                if (flamula.Read())
                {
                    img_flamula.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])flamula["flamula"]);

                }
                myCon.Close();
            }
            else if (ddl_flamula.SelectedValue == "10")
            {

                query = "select * from flamulas where ativado='true' and id_flamula=10";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var flamula = myCommand.ExecuteReader();
                if (flamula.Read())
                {
                    img_flamula.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])flamula["flamula"]);

                }
                myCon.Close();
            }
            else if (ddl_flamula.SelectedValue == "11")
            {

                query = "select * from flamulas where ativado='true' and id_flamula=11";

                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCon.Open();
                var flamula = myCommand.ExecuteReader();
                if (flamula.Read())
                {
                    img_flamula.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])flamula["flamula"]);

                }
                myCon.Close();
            }
        }

        protected void btn_criar_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "inserir_liga";

            myCommand.Connection = myConn;

            myCommand.Parameters.AddWithValue("@nome", tb_nome.Text);
            myCommand.Parameters.AddWithValue("@flamula", ddl_flamula.SelectedValue);
            myCommand.Parameters.AddWithValue("@id_utilizador", id_utilizador);

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
                lbl_mensagem.Text = "Liga Criada com Sucesso !!!";
            }
            else if (respostaSP == 2)
            {
                lbl_mensagem.Text = "Liga Existente !!!";
            }
            else if(respostaSP == 0)
            {
                lbl_mensagem.Text = "ERRO!!!";
            }

        }

        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_flamula")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["flamula"]);
                ((Label)e.Item.FindControl("lbl_liga")).Text = dr["nome_liga"].ToString();
                ((Label)e.Item.FindControl("lbl_id_liga")).Text = dr["id_liga"].ToString();
                ((Label)e.Item.FindControl("lbl_quantidade")).Text = dr["Qtd"].ToString();
                ((Button)e.Item.FindControl("btn_participar")).CommandArgument = dr["id_liga"].ToString();

            }
        }
        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            if (e.CommandName.Equals("btn_participar"))
            {
                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                string query = "";

                query = "insert into liga_utilizador (id_liga, id_utilizador, ativado) values ('";
                query += ((Label)e.Item.FindControl("lbl_id_liga")).Text + "', '";
                query += id_utilizador + "', 'true');";
                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();

                SqlDataSource3.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' and u.id_utilizador = " + id_utilizador + " group by f.flamula, l.nome_liga, l.id_liga";

                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga";
               
                Page.MaintainScrollPositionOnPostBack = true;
               
            }
        }

        protected void ddl_ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddl_ordenar.SelectedItem.Value == "A-Z")
            {
                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga order by nome_liga asc";                
            }
            else if (ddl_ordenar.SelectedItem.Value == "Z-A")
            {
                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga order by nome_liga desc";
            }
            else if (ddl_ordenar.SelectedItem.Value == "QTD ▲")
            {
                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga order by Qtd asc";
            }
            else if (ddl_ordenar.SelectedItem.Value == "QTD ▼")
            {
                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga order by Qtd desc";
            }
        }

        protected void btn_pesquisar_Click(object sender, EventArgs e)
        {
            SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' and nome_liga like '%"+tb_pesquisar.Text+"%' group by f.flamula, l.nome_liga, l.id_liga";
            
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_flamula")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["flamula"]);
                ((Label)e.Item.FindControl("lbl_liga")).Text = dr["nome_liga"].ToString();
                ((Label)e.Item.FindControl("lbl_id_liga")).Text = dr["id_liga"].ToString();
                ((Label)e.Item.FindControl("lbl_quantidade")).Text = dr["Qtd"].ToString();

                ((Button)e.Item.FindControl("btn_sair")).CommandArgument = dr["id_liga"].ToString();

            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName.Equals("btn_sair"))
            {
                SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["jornadaXptoConnectionString"].ConnectionString);

                string query = "";

                query = "delete from liga_utilizador where id_liga=";
                query += ((Label)e.Item.FindControl("lbl_id_liga")).Text + " and id_utilizador =" + id_utilizador;
                myCon.Open();
                SqlCommand myCommand = new SqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();

                SqlDataSource3.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' and u.id_utilizador = " + id_utilizador + " group by f.flamula, l.nome_liga, l.id_liga";

                SqlDataSource2.SelectCommand = "select f.flamula, l.nome_liga,l.id_liga, count(u.id_utilizador) as Qtd  from ligas as l inner join liga_utilizador as u on u.id_liga=l.id_liga inner join flamulas as f on f.id_flamula = l.id_flamula where u.ativado = 'true' group by f.flamula, l.nome_liga, l.id_liga";

               
                Page.MaintainScrollPositionOnPostBack = true;

            }
        }
    }
}