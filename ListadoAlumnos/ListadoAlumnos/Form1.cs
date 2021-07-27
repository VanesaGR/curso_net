using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ListadoAlumnos
{
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection
            ("Data Source=ASATA406\\SQLEXPRESSVANESA; Initial Catalog= Listado_Alumnos; Persist Security Info=True; User ID=sa; Password=1234;"); //conexion a sql

        DataClasses1DataContext LISTADO_ALUMNOS = new DataClasses1DataContext();

        
        public Form1()
        {
            InitializeComponent();
            this.mostrar_datos();
        }

        void mostrar_datos()//para cargar los datos en el datagrid
        {
            dataGridView1.DataSource = LISTADO_ALUMNOS.mostrar_datos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)//permite la carga de datos al cargar la página
        {
            this.mostrar_datos();
        }

        private void btnCodigo_Click(object sender, EventArgs e)//boton para buscar por codigo de alumno
        {
            dataGridView1.DataSource = LISTADO_ALUMNOS.buscar_codigoAlumno(int.Parse(txtBuscaCodigo.Text));
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LISTADO_ALUMNOS.buscar_DNIAlumno(txtBuscaDNI.Text);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string DNI = txtDNI.Text;
            string nombre = txtNombre.Text;
            string turno = cmbTurno.SelectedItem.ToString();
            string sexo = cmbSexo.SelectedItem.ToString();
            string especialidad = cmbEspecialidades.SelectedItem.ToString();
            string modulos = cmbModulos.SelectedItem.ToString();

            string cadena = "insert into Listado_Alumnos(DNI, nombre, turno, sexo, modulo,especialidad) values('" + DNI + "','" +
                nombre + "','" + turno + "','" + sexo + "','" + modulos + "','"+ especialidad + "')";
            
            SqlCommand comando = new SqlCommand(cadena, conexion);

            if (txtDNI.Text == "")
            {
                MessageBox.Show("Error al insertar datos");
            }
            else
            {
                comando.ExecuteNonQuery();

                MessageBox.Show("Los datos se guardaron correctamente");
                txtDNI.Text = "";
                txtNombre.Text = "";
                cmbTurno.SelectedItem = null;
                cmbSexo.SelectedItem = null;
                cmbEspecialidades.SelectedItem = null;
                cmbModulos.SelectedItem = null;                
            }          
            conexion.Close();
            this.mostrar_datos();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string DNI = txtDNI.Text;
            
            string cadena = "delete from Listado_Alumnos Where dni="+DNI;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();//para que lo ejecute

            if (cant == 1)
            {
                txtDNI.Text = "";
                txtNombre.Text = "";
                cmbTurno.SelectedItem = null;
                cmbSexo.SelectedItem = null;
                cmbEspecialidades.SelectedItem = null;
                cmbModulos.SelectedItem = null;
                MessageBox.Show("Se ha dado de baja el alumno");
                this.mostrar_datos();
            }
            else
            {
                MessageBox.Show("No hay ningún alumno con esos datos");
            }
            conexion.Close();
        }

        private void txtModifica_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string DNI = txtDNI.Text;
            string nombre = txtNombre.Text;
            string turno = cmbTurno.SelectedItem.ToString();
            string sexo = cmbSexo.SelectedItem.ToString();
            string especialidad = cmbEspecialidades.SelectedItem.ToString();
            string modulos = cmbModulos.SelectedItem.ToString();

            string cadena = "update Listado_Alumnos set nombre=" + "'" + nombre + "'" + "," + "DNI=" + "'" + DNI + "'" + "," +
                    "turno=" + "'" + turno + "'" + "," + "sexo=" + "'" + sexo + "'" + ","  +
                    "modulo=" + "'" + modulos + "'" + "," + "especialidad=" + "'" + especialidad + "'" + "where DNI=" + "'" + DNI + "'";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            int cant;
            cant = comando.ExecuteNonQuery();

            if (cant ==1)
            {
                MessageBox.Show("Se modificaron los datos del alumno");
                txtDNI.Text = "";
                txtNombre.Text = "";
                cmbTurno.SelectedItem = null;
                cmbSexo.SelectedItem = null;
                cmbEspecialidades.SelectedItem = null;
                cmbModulos.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("No existe un alumno con esos datos");
            }
            conexion.Close();
        }
    }
}
