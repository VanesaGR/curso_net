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

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //inicializamos la clase de contexto GLOBAL
        //siempre es
        datosjuevesDataContext filtros = new datosjuevesDataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();

        }

        void cargarGrid()
        {//codigo linq para alimentar el datagrid (método)
            var listagrid = from f in filtros.datosjueves 
                            select f;
            DGV1.ItemsSource = listagrid;
        }
        /// <summary>
        /// MÉTODO PARA MOSTRAR LOS REGISTROS DE UN CURSO DETERMINADO
        /// </summary>
        void cargarGridCurso() //la f es un objeto de coleccion, se puede poner lo que se quiera
        {//AQUI FILTRAMOS LOS REGISTROS DEL CURSO SELECCIONADO EN EL COMBO
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosjueves where f.Curso == curso select f;
            DGV1.ItemsSource = listagrid;
        }
        /// <summary>
        /// MÉTODO CON LINQ PARA FILTRAR POR EL NOMBRE
        /// OJO CONTAINS ES LO MISMO QUE LIKE EN SQL
        /// FILTRA EN FUNCIÓN DEL NOMBRE Y DEL CURSO QUE ESTÉ ACTIVADO
        /// </summary>
        /// <param name="cadena">la cadena seria el nombre a filtrar</param>
        void cargarGridNombre(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosjueves where f.Curso == curso && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }
        /// <summary>
        /// MÉTODO CON LINQ PARA FILTRAR POR EL APELLIDO
        /// OJO CONTAINS ES LO MISMO QUE LIKE EN SQL
        /// FILTRA EN FUNCION DEL APELLIDO Y DEL CURSO QUE ESTÉ ACTIVADO
        /// FILTRA EN FUNCION DEL APELLIDO Y DEL CURSO QUE ESTÉ ACTIVADO
        /// </summary>
        /// <param name="cadena"></param>
        void cargarGridApellido(String cadena)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosjueves where f.Curso == curso && f.Apellidos.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }

        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            string curso = ComboBox1.Text;
            var listagrid = from f in filtros.datosjueves where f.Curso==curso&&
                            f.Nombre.Contains(cadena) && f.Apellidos.Contains(cadena2)
                            select f;
            DGV1.ItemsSource = listagrid;
        }


        /// <summary>
        /// Habilitar y deshabilit Checkbox de las fechas
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = true;
        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = false;
        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = false;

        }
        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = false;
        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = false;
        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>
        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = true;
            CheckBox5.IsEnabled = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = false;
            CheckBox5.IsEnabled = false;
        }

        /// <summary>
        /// FUNCIONALIDAD DEL BOTÓN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
            }
            else if (TextBox1.Text != "" && TextBox2.Text == "")
            {
                cargarGridNombre(TextBox1.Text);
            }
            else if (TextBox1.Text == "" && TextBox2.Text != "")
            {
                cargarGridApellido(TextBox2.Text);
            }
            else cargarGridCurso();
        }
        void cargarGridFechasUnoDos(DateTime f1, DateTime f2)
        {
            string curso = ComboBox1.Text;
            string fecha = (DatePicker1.SelectedDate).ToString();

            var listagrid = from f in filtros.datosjueves
                            where f.Fecha_Insc > f1 && f.Fecha_Insc < f2 && f.Curso == curso
                            select f;
            DGV1.ItemsSource = listagrid;
        }
        private void btnFechas_Click(object sender, RoutedEventArgs e)
        {
           if(CheckBox1.IsChecked==true && CheckBox2.IsChecked == true)
            {
                cargarGridFechasUnoDos(DatePicker1.DisplayDate, DatePicker2.DisplayDate);
            }
            else
            {
                cargarGridCurso();
            }
        }

       
    }
}
