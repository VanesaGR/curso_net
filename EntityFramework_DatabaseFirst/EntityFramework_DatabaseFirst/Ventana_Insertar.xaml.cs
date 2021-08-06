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
using System.Windows.Shapes;

namespace EntityFramework_DatabaseFirst
{
    /// <summary>
    /// Lógica de interacción para Ventana_Insertar.xaml
    /// </summary>
    public partial class Ventana_Insertar : Window
    {
        ENTITYEntities DbEntityes = new ENTITYEntities();

        public Ventana_Insertar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int idulti = MyDataGrid.Items.Count + 1;
            Profesores MyProfe = new Profesores()
            {
                Id = int.Parse(TxtID.Text),
                Nombre = TxtNombre.Text,
                Especialidad = cmbEspec.Text
            };

            DbEntityes.Profesores.Add(MyProfe);
            DbEntityes.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
            this.Hide();

        }
    }
}
