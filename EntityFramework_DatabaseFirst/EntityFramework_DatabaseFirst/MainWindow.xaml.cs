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

namespace EntityFramework_DatabaseFirst
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ENTITYEntities DbEntityes = new ENTITYEntities();
        public static DataGrid ControlDatagrid;

        public MainWindow()
        {//cargamos el datagrid con los datos apuntando a la tabla de Profesores
            InitializeComponent();
            MyDG.ItemsSource = DbEntityes.Profesores.ToList();
            ControlDatagrid = MyDG;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // El primer botón llama al cuadro Insertar
            Ventana_Insertar Vinsertar = new Ventana_Insertar();
            Vinsertar.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // El segundo botón llama al cuadro Modificar int

            int id = (MyDG.SelectedItem as Profesores).Id;

            Ventana_Modificar Vcambiar = new Ventana_Modificar(id);
            Vcambiar.ShowDialog();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = DbEntityes.Profesores.Where(m =>m.Id == id).Single();
            DbEntityes.Profesores.Remove(deleteProfe);
            DbEntityes.SaveChanges();
            ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
            this.Hide();
        }
    }
                   
}
