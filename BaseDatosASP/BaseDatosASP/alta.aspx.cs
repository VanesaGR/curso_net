using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BaseDatosASP
{
    public partial class alta : System.Web.UI.Page
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

                SqlCommand comando = new SqlCommand("insert into usuarios(nombre, clave, mail) values ('" + this.TextBox1.Text + "','"
                    + this.TextBox2.Text + "','" + this.TextBox3.Text + "')", conexion);
                comando.ExecuteNonQuery();
                Label4.Text = "Se registró el usuario";
                conexion.Close();
            }
            catch
            {
                Label4.Text = "FALLO EN LA INSERCIÓN DE USUARIO";
            }
        }
    }
}