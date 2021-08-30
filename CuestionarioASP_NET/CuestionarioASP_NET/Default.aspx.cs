using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuestionarioASP_NET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (correcta1.Checked || correcta2.Checked)
            {
                Label1.Text = "Has acertado una pregunta";
            }
            else if (correcta1.Checked && correcta2.Checked)
            {
                Label1.Text = "Has acertado las dos preguntas!";
            }
            else
            {
                Label1.Text = "Serás zote... Ni una siquiera...";
            }

            if (IsValid)
                Response.Redirect("AccesoPermitido.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            respuesta1.Checked = false;
            respuesta2.Checked = false;
            correcta1.Checked = false;
            respuesta4.Checked = false;
            respuesta5.Checked = false;
            respuesta6.Checked = false;
            correcta2.Checked = false;
            respuesta8.Checked = false;
            Label1.Text = "¿Acertarás o no?";
        }
    }
}