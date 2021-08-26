using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Jueves_26
{
    class Coche:Vehiculo
    {//ATRIBUTOS
        private bool Airbag;

        //PROPIEDADES
        public bool PAirbag
        {
            get { return Airbag; }
            set { Airbag = value; }
        }

        //CONSTRUCTORES

        public Coche(int p1, string p2, string p3, int p4, double p5, bool p6):base(p1, p2, p3, p4, p5)
        {
            this.Airbag = p6;
        }

        public Coche() { }

        //METODOS

        public void SetAirbag(bool opt)
        {
            if (opt == true) { PPrecio = PPrecio + 200; }
        }
        public void ImprimirCoche()
        {
            string x;
            if (Airbag == true) { x = "Si lo tiene"; }
            else { x = "No lo tiene"; }

            Console.Clear();
            Console.WriteLine("ID: ");
            Console.WriteLine("Marca: ");
            Console.WriteLine("Modelo: ");
            Console.WriteLine("KM: ");
            Console.WriteLine("Precio: ");
            Console.WriteLine("Airbag: "+x);
            Console.ReadLine();
        }
    }
}
