using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoJueves
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext ClienteJueves = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }
        void MostrarClientes()
        {
            dataGridView1.DataSource = ClienteJueves.MostrarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MostrarClientes();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteJueves.Insertarcliente(txtIdCliente.Text, txtApellidos.Text, txtNombre.Text);
            this.MostrarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteJueves.EliminarCliente_JUEVES(txtIdCliente.Text);
            this.MostrarClientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClienteJueves.modificarcliente(txtIdCliente.Text, txtNombre.Text, txtApellidos.Text);
            this.MostrarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "IDCLIENTE")
            {
               dataGridView1.DataSource = ClienteJueves.buscarCliente(txtBuscar.Text);
            }
            else if (comboBox1.Text == "APELLIDOS")
            {
                dataGridView1.DataSource = ClienteJueves.BUSCAR_APELLIDOS(txtBuscar.Text);
            }
            else if(comboBox1.Text=="NOMBRE")
            {
                dataGridView1.DataSource=ClienteJueves.BUSCAR_NOMBRE(txtBuscar.Text);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.MostrarClientes();
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
