using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SqlConnection conexion=new SqlConnection("server=ASATA406\\SQLEXPRESSVANESA; Initial Catalog=Inyeccion_SQL; Persist Security Info=true;User ID=sa; PassWord=1234;");

        public MainWindow()
        {
            InitializeComponent();
        }

  
        private void Insertar(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIdInsertar.Text;
            string nombre = txtNombreInsertar.Text;
            string edad = txtEdadInsertar.Text;
            string cadena = "insert into Personas (id, nombre, edad) values(" + iden + ",'" + nombre + "'," + edad + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            if (txtIdInsertar.Text == "" || txtNombreInsertar.Text == "" || txtEdadInsertar.Text == "")
            {
                MessageBox.Show("Error al insertar los datos");
            }
            else
            {
                comando.ExecuteNonQuery();

                MessageBox.Show("Los datos se guardaron correctamente");
                txtIdInsertar.Text = "";
                txtNombreInsertar.Text = "";
                txtEdadInsertar.Text = "";
            }

            conexion.Close();

        }

        private void Consult(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = txtIdEliminar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                LabelNombre.Content = registro["nombre"].ToString();
                LabelEdad.Content = registro["edad"].ToString();
                btnConsultar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
            conexion.Close();
        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtIdEliminar.Text;
            string cadena = "delete from Personas where id=" + iden;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            if (cant == 1)
            {
                LabelNombre.Content = "";
                LabelEdad.Content = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
            conexion.Close();
            btnBorrar.IsEnabled = false;
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = txtIdModificar.Text;
            string nombre = txtNombreModificar.Text;
            string edad = txtEdadModificar.Text;
            string cadena = "update Personas set nombre='" + nombre + "', edad=" + edad + " where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            if (cant == 2)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                txtIdModificar.Text = "";
                txtNombreModificar.Text = "";
                txtEdadModificar.Text = "";
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
            conexion.Close();
            btnModificar.IsEnabled = false;
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string cod = txtIdModificar.Text;
            string cadena = "select id, nombre, edad from Personas where id=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombreModificar.Text = registro["nombre"].ToString();
                txtEdadModificar.Text = registro["edad"].ToString();
                btnBuscar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");

            }
            conexion.Close();
        }
    }
}
