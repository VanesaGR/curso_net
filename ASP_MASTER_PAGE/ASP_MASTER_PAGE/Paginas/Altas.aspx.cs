using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_MASTER_PAGE
{
    public partial class WebForm1 : System.Web.UI.Page
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

                SqlCommand comando = new SqlCommand("insert into cliente(id, nombre, apellido1, apellido2, ciudad, categoria) " +
                    "values ('" + int.Parse(this.txtId.Text) + "','" + this.txtNombre.Text + "','" 
                    + this.txtApellido1.Text + "','"+ this.txtApellido2.Text + "','"+ this.txtCiudad.Text
                    + "','"+int.Parse(txtCategoria.Text)+ "')", conexion);
                comando.ExecuteNonQuery();
                Label7.Text = "Se registró el usuario";
                conexion.Close();
            }
            catch
            {
                Label7.Text = "FALLO EN LA INSERCIÓN DE USUARIO";
            }
        }
    }
}