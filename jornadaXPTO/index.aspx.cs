using java.lang;
using javax.security.auth;
using org.apache.pdfbox.pdmodel.common.function;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Services.Discovery;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace jornadaXPTO
{
    public partial class index : System.Web.UI.Page
    {
       
            protected void Page_Load(object sender, EventArgs e)
            {
            lbl_data.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lbl_data2.Text = lbl_data.Text;

            DateTime date1 = new DateTime(2023, 12, 15, 20, 0, 0);
            if (DateTime.Now > date1) { id_mercado.Text= "Mercado Encerrado Até 18/12 as 23h"; }

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
                else if(Session["perfil"].ToString() == "1")
                {
                    liga.Style["display"] = "visible";
                    liga2.Style["display"] = "visible";
                    escalacao.Style["display"] = "visible";
                    escalacao2.Style["display"] = "visible";
                    gestao.Style["display"] = "visible";
                    gestao2.Style["display"] = "visible";

                }
            }

            XmlDocument url = new XmlDocument();
            url.Load("https://www.noticiasaominuto.com/rss/desporto");

            Xml1.Document = url;


            }

        int n = 1;
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
           
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
               
                DataRowView dr = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_emblema")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr["emblema"]);
                ((Label)e.Item.FindControl("lbl_clube")).Text = dr["nome_clube"].ToString();
                ((Label)e.Item.FindControl("lbl_jogos")).Text = dr["num_jogos"].ToString();
                ((Label)e.Item.FindControl("lbl_pontos")).Text = dr["pontos"].ToString();
                ((Label)e.Item.FindControl("lbl_ordem")).Text = n.ToString();
               n=n+1;
               
            }

        }
        int n2 = 1;
        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr2 = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_flamula")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr2["flamula"]);
                ((Label)e.Item.FindControl("lbl_liga")).Text = dr2["nome_liga"].ToString();
                ((Label)e.Item.FindControl("lbl_id_liga")).Text = dr2["id_liga"].ToString();
                ((Label)e.Item.FindControl("lbl_qtd")).Text = dr2["Qtd"].ToString();
                ((Label)e.Item.FindControl("lbl_ordem")).Text = n2.ToString();
                n2 = n2 + 1;
            }
        }
        int n3 = 1;
        protected void Repeater3_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView dr2 = (DataRowView)e.Item.DataItem;
                ((Image)e.Item.FindControl("img_escudo")).ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])dr2["emblema"]);
                ((Label)e.Item.FindControl("lbl_equipa")).Text = dr2["nome_time"].ToString();
                ((Label)e.Item.FindControl("lbl_id_equipa")).Text = dr2["id_utilizador"].ToString();
                ((Label)e.Item.FindControl("lbl_pontos")).Text = dr2["pontos"].ToString();
                ((Label)e.Item.FindControl("lbl_ordem")).Text = n3.ToString();
                n3 = n3 + 1;
            }
        }
    }
}