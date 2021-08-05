using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    class producto
    {
        private string nombre; //atributos
        private double precio;
        private string categoria;
        
        public string Pnombre //propiedades
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Pprecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Pcategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public producto() { } //constructor por defecto

        public producto(string nombre, double precio, string categoria)//constructor con los tres parametros
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
        }

        public producto(string nombre, double precio) //constructor con dos parametros
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public void Mostrar() //método
        {
            Console.WriteLine("Has comprado " +nombre+ " a "+precio+ " con categoria "+categoria);
        }


    }
}
