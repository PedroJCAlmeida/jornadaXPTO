using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jornadaXPTO
{
    public partial class sobre : System.Web.UI.Page
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
    }
}