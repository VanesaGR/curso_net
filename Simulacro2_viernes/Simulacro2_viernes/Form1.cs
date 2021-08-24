using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacro2_viernes //CON LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext baseDatos = new DataClasses1DataContext();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarGrid(); //CARGA EL GRID AL INICIAR EL FORMULARIO
        }
        void cargarGrid()
        {
            var cargaGrid = from p in baseDatos.empleados
                            select p;
            gridDatos.DataSource = cargaGrid;

            var cargarGrid = from empleados in baseDatos.empleados select empleados;
            gridDatos.DataSource = cargarGrid;

            int numero = cargarGrid.Count();
            textBox1.Text = "SE HAN ENCONTRADO " + numero + " REGISTROS";
        }
                
        private void btnAlta_Click(object sender, EventArgs e)
        {//BOTON PARA DAR DE ALTA UN REGISTRO NUEVO
            try
            {//CONTROLA QUE ESTÉN TODOS LOS DATOS INTRODUCIDOS
                empleados myempleado = new empleados();

                myempleado.ID = int.Parse(txtId.Text);
                myempleado.Nombre = txtName.Text;
                myempleado.Apellido = txtSurname.Text;
                myempleado.Edad = int.Parse(txtAge.Text);
                myempleado.Casado = cbMarried.Checked;

                baseDatos.empleados.InsertOnSubmit(myempleado); //AÑADE EL REGISTRO EN LA DATABASE
                baseDatos.SubmitChanges(); //SE HACE EL COMMIT, LA CONFIRMACION

                var cargarGrid = from empleados in baseDatos.empleados select empleados;
                gridDatos.DataSource = cargarGrid;

                int numero = cargarGrid.Count();
                textBox1.Text = "SE HAN ENCONTRADO " +numero+ " REGISTROS";

                
            }
            catch
            {
                MessageBox.Show("Ha habido un error en la insercion de datos");
            }
        
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    empleados myempleado = baseDatos.empleados.Single(p =>
                     p.ID == int.Parse(txtId.Text));

                    baseDatos.empleados.DeleteOnSubmit(myempleado);
                    baseDatos.SubmitChanges();
                    cargarGrid();
                }
            }
            catch
            {
                MessageBox.Show("Error en la eliminacion de los datos");
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    empleados myempleado = baseDatos.empleados.Single(p =>
                    p.ID == int.Parse(txtId.Text));

                    myempleado.ID = int.Parse(txtId.Text);
                    myempleado.Nombre = txtName.Text;
                    myempleado.Apellido = txtSurname.Text;
                    myempleado.Edad = int.Parse(txtAge.Text);
                    myempleado.Casado = cbMarried.Checked;

                    baseDatos.SubmitChanges();
                    cargarGrid();
                }
            }
            catch
            {
                MessageBox.Show("Error en la modificación de los datos");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e){}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") //COMPRUEBA QUE EL CUADRO DE BUSQUEDA NO ESTA EN BLANCO
            {
                empleados myempleado = baseDatos.empleados.Single(p =>
                p.Nombre.Contains(txtBuscar.Text));
                           
                string busca = txtBuscar.Text; //SE PUEDE PONER TODOS LOS CAMPOS PARA QUE CARGUE EN LOS TXT                           

                var cargaGrid = from empleados in baseDatos.empleados
                                where empleados.Nombre.Contains(busca)
                                select empleados;
                gridDatos.DataSource = cargaGrid;
            }
            else
            { //CARGA TODO EL GRID
                var cargaGrid = from empleados in baseDatos.empleados
                                select empleados;
                gridDatos.DataSource = cargaGrid;
            }
                        
        }

        private void gridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtAge.Text = "";
            cbMarried.Checked = false;
        }
    }

    
}
