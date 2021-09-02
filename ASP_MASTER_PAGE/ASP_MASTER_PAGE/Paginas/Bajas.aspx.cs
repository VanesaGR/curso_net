using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_MASTER_PAGE
{
    public partial class Bajas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroMartesSqlConnectionSTring"].ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("delete from cliente " + "where id='" + this.ddlistIdBaja.Text
                        + "'", conexion);

                GridView2.DataBind();

                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    this.Label7.Text = "Se borró el usuario";
                }
                else
                {
                    this.Label7.Text = "No existe el usuario";
                }
                conexion.Close();
            }
            catch
            {
                Label7.Text = "Fallo en la eliminación de cliente";
            }
        }
    }
}