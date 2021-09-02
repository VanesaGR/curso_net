using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_MASTER_PAGE
{
    public partial class Modificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroMartesSqlConnectionSTring"].ToString();
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();

                SqlCommand comando = new SqlCommand("select id, nombre, apellido1, apellido2, ciudad, categoria from cliente "
                    + "where id='" + int.Parse(this.ddlistIdMod.Text) + "'", conexion);

                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    this.ddlistIdMod.SelectedValue = registro["id"].ToString();
                    this.txtNombre.Text = registro["nombre"].ToString();
                    this.txtApellido1.Text = registro["apellido1"].ToString();
                    this.txtApellido2.Text = registro["apellido2"].ToString();
                    this.txtCiudad.Text = registro["ciudad"].ToString();
                    this.txtCategoria.Text = registro["categoria"].ToString();
                }
                else
                {
                    this.Label7.Text = "No existe el usuario";
                }
                conexion.Close();
            }
            catch
            {
                this.Label7.Text = "Fallo en la modificación de usuario";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["simulacroMartesSqlConnectionSTring"].ToString();
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            SqlCommand comando = new SqlCommand("update cliente set " + "nombre='" + this.txtNombre.Text + "',apellido1='" +
                this.txtApellido1.Text + "' ,apellido2='" + this.txtApellido2.Text + "' ,ciudad='" + this.txtCiudad.Text +
                "' ,categoria='" + this.txtCategoria.Text +
                "' where id='" + this.ddlistIdMod.Text + "'", conexion);

            int cantidad = comando.ExecuteNonQuery();
            if (cantidad == 1)
            {
                this.Label7.Text = "Datos Modificados";
            }
            else
            {
                this.Label7.Text = "No existe el usuario";
            }
            conexion.Close();
        }
    }
}