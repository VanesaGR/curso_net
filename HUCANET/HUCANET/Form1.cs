using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUCANET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClasses1DataContext baseDatos = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        void cargarGrid()
        {
            var cargaGrid = from p in baseDatos.pacientes
                            select p;
            gridDatos.DataSource = cargaGrid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                pacientes mypaciente = new pacientes();
                mypaciente.inscripcion = txtInscripcion.Text;
                mypaciente.nombre = txtNombre.Text;

                if (rbMale.Checked == true)
                {
                    mypaciente.sexo = "H";
                }
                else
                {
                    mypaciente.sexo = "M";
                }
                mypaciente.fecha = dpFecha.Value;
                mypaciente.direccion = txtDireccion.Text;
                mypaciente.ss = txtSS.Text;
                baseDatos.pacientes.InsertOnSubmit(mypaciente);
                baseDatos.SubmitChanges();
                
                txtRegistro.Text = "Inserción de datos realizada";

                var cargarGrid = from pacientes in baseDatos.pacientes select pacientes;
                gridDatos.DataSource = cargarGrid;
            }
            catch
            {
                MessageBox.Show("Fallo en la inserción de datos");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInscripcion.Text != "")
                {
                    pacientes mypaciente = baseDatos.pacientes.Single(p =>
                     p.inscripcion == txtInscripcion.Text);

                    baseDatos.pacientes.DeleteOnSubmit(mypaciente);
                    baseDatos.SubmitChanges();

                    txtRegistro.Text = "Eliminación de datos realizada";
                    
                    cargarGrid();
                }
            }
            catch
            {
                MessageBox.Show("Error en la eliminacion de los datos");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInscripcion.Text != "")
                {
                    pacientes mypaciente = baseDatos.pacientes.Single(p =>
                    p.inscripcion == txtInscripcion.Text);

                    mypaciente.inscripcion = txtInscripcion.Text;
                    mypaciente.nombre = txtNombre.Text;
                    if (rbMale.Checked == true)
                    {
                        mypaciente.sexo = "H";
                    }
                    else
                    {
                        mypaciente.sexo = "M";
                    }
                    mypaciente.fecha = dpFecha.Value;
                    mypaciente.direccion = txtDireccion.Text;
                    mypaciente.ss = txtSS.Text;
                    baseDatos.SubmitChanges();

                    txtRegistro.Text = "Modificación de datos realizada";

                    cargarGrid();
                }
            }
            catch
            {
                MessageBox.Show("Error en la modificación de los datos");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
