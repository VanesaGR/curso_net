using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BaseDatosASP
{
    public partial class consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("select nombre, clave, mail from usuarios " + "where nombre='" + this.TextBox1.Text
                    + "'", conexion);

                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    this.Label2.Text = "clave: " + registro["clave"] + "<br/>" + "Mail: " + registro["mail"];
                }
                else
                {
                    this.Label2.Text = "No existe un usuario con ese nombre";
                }
                conexion.Close();
            }
            catch
            {
                Label2.Text = "FALLO EN LA CONSULTA DE DATOS";
            }

        }
    }
}