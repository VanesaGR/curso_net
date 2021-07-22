using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQToSp
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.ListarClientes();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.ListarClientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(TxtNombre.Text);
            this.ListarClientes();
        }

        void ListarClientes()
        {
            GridDatos.DataSource = ClienteLinq.ListarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtTelefono.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridDatos.DataSource = ClienteLinq.buscarcliente(TxtBuscar.Text);
        }
    }
}
