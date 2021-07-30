using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulari_LinQ_Lambda
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
            cargarcombo();
            cargarGrid();
        }

        void cargarcombo()
        {
            var cargaCombo = from p in baseDatos.Products
                             select p.ProductName;
            combo.DataSource = cargaCombo;
        }

        void cargarGrid()
        {
            var cargaGrid = from p in baseDatos.Products
                            select p;
            GridDatos.DataSource = cargaGrid;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Products myproduct = new Products();
            myproduct.ProductName = TxtProd.Text;
            myproduct.UnitPrice = int.Parse(TxtPrec.Text);
            myproduct.UnitsInStock = short.Parse(TxtStock.Text);
            myproduct.CategoryID = int.Parse(TxtCate.Text);
            baseDatos.Products.InsertOnSubmit(myproduct);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarcombo();
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(combo.SelectedItem.ToString());
            Products myproducto = baseDatos.Products.Single(p =>
              p.ProductName == combo.SelectedItem.ToString());
            myproducto.ProductName = combo.SelectedItem.ToString();
            myproducto.UnitPrice = int.Parse(TxtPrec.Text);
            myproducto.UnitsInStock = short.Parse(TxtStock.Text);
            myproducto.CategoryID = int.Parse(TxtCate.Text);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarcombo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Products Myproduct = baseDatos.Products.Single(p =>
                 p.ProductName == combo.SelectedItem.ToString());
            baseDatos.Products.DeleteOnSubmit(Myproduct);
            baseDatos.SubmitChanges();
            cargarGrid();
            cargarcombo();
        }
    }
}
