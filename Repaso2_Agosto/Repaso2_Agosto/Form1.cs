using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2_Agosto
{
    public partial class Form1 : Form
    {
        //AÑADIMOS EL CONTEXTO DE ENITDADES DE CLIENTES
        REPASO_AGOSTOEntities1 ClientesEntity = new REPASO_AGOSTOEntities1();
        public Form1()
        {
            InitializeComponent();
            //INVOCAMOS AL ENVENTO DE CARGAR GRID AL CARGAR EL FORMULARIO
            Cargargrid();
        }

        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void Cargargrid()
        {
            gridDatos.DataSource = ClientesEntity.cliente.ToList();

            //TAMBIÉN PODEMOS SEGUIR UTILIZANDO LINQ
            //GRIDDATOS.DATASOURCE=FROM CLIENTE IN CLIENTEENTITY.CLIENTES SELECT CLIENTE;
        }//cliente es la base de datos

        private void btnRegistrar_Click(object sender, EventArgs e)//boton para agregar registro
        {
            try
            {                
                    cliente Misclientes = new cliente() //CREAMOS UN NUEVO CLIENTE CON LOS CONTENIDOS DE LOS TEXTBOX
                    {
                        DNI = txtDNI.Text,
                        NOMBRES = txtNombre.Text,
                        APELLIDOS = txtApellidos.Text,
                        ESTADO_CIVIL = cbEstadoCivil.Text,
                        TELEFONO = txtTelefono.Text,
                        EMAIL = txtEmail.Text,
                        FECHA_NACIMIENTO = dateTimePicker1.Value
                    };

                    //CONTEXTO DE ENTIDADES Y AÑADIMOS AL CLIENTE
                    ClientesEntity.cliente.Add(Misclientes);
                //GUARDAR EL NUEVO REGISTRO EN LA BASE DE DATOS. ES GLOBAL TANTO PARA CLASES TIPO LINQ COMO PARA
                //ENTIDADES
                    ClientesEntity.SaveChanges();
                //REFRESCAMOS EL DATA GRID
                    Cargargrid(); 
                
            }
            //MOSTRAR MENSAJE MÁS CONCRETO DE QUÉ DATO FALTA
            catch
            {
                if (txtDNI.Text == "" || txtNombre.Text != "" || txtApellidos.Text != "" || cbEstadoCivil.Text != "" ||
                    txtTelefono.Text != "" || txtEmail.Text != "")
                {
                    MessageBox.Show("Error. Faltan datos");
                }
                else
                {
                    MessageBox.Show("Error, registro duplicado");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoDNI = txtDNI.Text;
            //METODO LAMBDA QUE CONSIGUE A UN CLIENTE POR SU DNI Y LO VUELCA A UNA LISTA DE REGISTROS
            //SI FILTRAMOS X NOMBRE, POR EJEMPLO, USAMOS CONTAINS
            //(SE PUEDE PONER UN METODO LINQ, A ESCOGER)
            //CON LINQ HABRIA QUE CREAR UN CLIENTE: CLIENTES MYCLIENTE... TRABAJARÍA CON UN CLIENTE DE FORMA
            //INDIVIDUAL
            var BuscaCliente = ClientesEntity.cliente.Where(c => c.DNI == textoDNI).Single();

            txtNombre.Text=BuscaCliente.NOMBRES;
            txtApellidos.Text=BuscaCliente.APELLIDOS;
            cbEstadoCivil.Text=BuscaCliente.ESTADO_CIVIL;
            txtTelefono.Text=BuscaCliente.TELEFONO;
            txtEmail.Text=BuscaCliente.EMAIL;
            dateTimePicker1.Text=BuscaCliente.FECHA_NACIMIENTO.ToString();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string textoDNI = txtDNI.Text; //DEFINIMOS UNA VARIABLE QUE GUARDA EL DNI
            //MÉTODO LAMBDA QUE CONSIGUE A UN CLIENTE POR SU DNI

            //AQUEL DNI QUE COINCIDE CON TEXTO DNI
            var deleteCliente = ClientesEntity.cliente.Where(c => c.DNI == textoDNI).Single();

            ClientesEntity.cliente.Remove(deleteCliente); //BORRAMOS AL CLIENTE BUSCADO
            ClientesEntity.SaveChanges(); //CONFIRMA LOS CAMBIOS
            Cargargrid();//REFRESCO DE GRID
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {//DEBERIA ESTAR CONTROLADO
         //DEFINE LA VARIABLE PARA EL DNI
         //TODO: 
            if (txtDNI.Text == "") MessageBox.Show("Tienes que introducir un DNI");

            else
            {
                string textoDNI = txtDNI.Text;

                //MEDIANTE LINQ OBTENEMOS EL CLIENTE POR EL DNI
                cliente Misclientes = (from c in ClientesEntity.cliente where c.DNI == textoDNI select c).Single();

                //DEFINIMOS LOS ATRIBUTOS DEL OBJETO Misclientes
                //EL DNI NO SE MODIFICA
                //Misclientes.DNI = txtDNI.Text;
                Misclientes.NOMBRES = txtNombre.Text;
                Misclientes.APELLIDOS = txtApellidos.Text;
                Misclientes.ESTADO_CIVIL = cbEstadoCivil.Text;
                Misclientes.TELEFONO = txtTelefono.Text;
                Misclientes.EMAIL = txtEmail.Text;
                Misclientes.FECHA_NACIMIENTO = dateTimePicker1.Value;

                //HACEMOS SALVADO EN LA BASE DE DATOS
                ClientesEntity.SaveChanges();
                //REFRESCAR EL DATAGRID
                Cargargrid();
            }
        }

        private void btn1_Click(object sender, EventArgs e) //PARA BUSCAR EL PRIMER REGISTRO DEL DATAGRID
        {
            string textoDNI = txtDNI.Text;
            var BuscaCliente = ClientesEntity.cliente.First();

            txtDNI.Text = BuscaCliente.DNI;
            txtNombre.Text = BuscaCliente.NOMBRES;
            txtApellidos.Text = BuscaCliente.APELLIDOS;
            cbEstadoCivil.Text = BuscaCliente.ESTADO_CIVIL;
            txtTelefono.Text = BuscaCliente.TELEFONO;
            txtEmail.Text = BuscaCliente.EMAIL;
            dateTimePicker1.Text = BuscaCliente.FECHA_NACIMIENTO.ToString();
        }

        private void btn4_Click(object sender, EventArgs e) //PARA BUSCAR EL ULTIMO REGISTRO DEL DATAGRID
        {
            string textoDNI = txtDNI.Text;
            var BuscaCliente = ClientesEntity.cliente.ToList().Last();

            txtDNI.Text = BuscaCliente.DNI;
            txtNombre.Text = BuscaCliente.NOMBRES;
            txtApellidos.Text = BuscaCliente.APELLIDOS;
            cbEstadoCivil.Text = BuscaCliente.ESTADO_CIVIL;
            txtTelefono.Text = BuscaCliente.TELEFONO;
            txtEmail.Text = BuscaCliente.EMAIL;
            dateTimePicker1.Text = BuscaCliente.FECHA_NACIMIENTO.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = gridDatos.CurrentRow.Index - 1;

                //NOS DESPLAZAMOS A LA FILA ANTERIOR
                gridDatos.CurrentCell = gridDatos.Rows[anterior].Cells
                    [gridDatos.CurrentCell.ColumnIndex];

                //AQUI CARGAMOS EN EL TEXTBOX DEL DNI
                txtDNI.Text = gridDatos.Rows[anterior].Cells[0].Value.ToString();
                txtNombre.Text = gridDatos.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = gridDatos.Rows[anterior].Cells[2].Value.ToString();
                cbEstadoCivil.Text = gridDatos.Rows[anterior].Cells[3].Value.ToString();
                txtTelefono.Text = gridDatos.Rows[anterior].Cells[4].Value.ToString();
                txtEmail.Text = gridDatos.Rows[anterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = gridDatos.Rows[anterior].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Estás en la primera fila");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA SIGUIENTE
                int siguiente = gridDatos.CurrentRow.Index + 1;

                //NOS DESPLAZAMOS A LA FILA SIGUIENTE
                gridDatos.CurrentCell = gridDatos.Rows[siguiente].Cells[gridDatos.CurrentCell.ColumnIndex];

                //AQUÍ CARGAMOS EN EL TEXTBOX DEL DNI
                txtDNI.Text = gridDatos.Rows[siguiente].Cells[0].Value.ToString();
                txtNombre.Text = gridDatos.Rows[siguiente].Cells[1].Value.ToString();
                txtApellidos.Text = gridDatos.Rows[siguiente].Cells[2].Value.ToString();
                cbEstadoCivil.Text = gridDatos.Rows[siguiente].Cells[3].Value.ToString();
                txtTelefono.Text = gridDatos.Rows[siguiente].Cells[4].Value.ToString();
                txtEmail.Text = gridDatos.Rows[siguiente].Cells[5].Value.ToString();
                dateTimePicker1.Text = gridDatos.Rows[siguiente].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Estás en la última fila");
            }
        }
    }
}
