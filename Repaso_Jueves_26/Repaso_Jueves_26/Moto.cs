using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Jueves_26
{
    class Moto:Vehiculo
    {//ATRIBUTOS
        private bool Sidecar;

        //PROPIEDADES
        public bool PSidecar
        {
            get { return Sidecar; }
            set { Sidecar = value; }
        }

        //CONSTRUCTORES
        public Moto(int p1, string p2, string p3, int p4, double p5, bool p6):base(p1, p2, p3, p4, p5)
        {
            this.Sidecar = p6;
        }

        public Moto() { }

        //METODOS
        public void SetSidecar(bool opt)
        {
            if (opt == true) { PPrecio = PPrecio + 50; }
        }

        public void ImprimirMoto()
        {
            string x;
            if (Sidecar == true) { x = "Si lo tiene"; }
            else { x="No lo tiene"; }

            Console.Clear();
            Console.WriteLine("ID: ");
            Console.WriteLine("Marca: ");
            Console.WriteLine("Modelo: ");
            Console.WriteLine("KM: ");
            Console.WriteLine("Precio: ");
            Console.WriteLine("Sidecar: "+x);
            Console.ReadLine();
        }

    }
}
