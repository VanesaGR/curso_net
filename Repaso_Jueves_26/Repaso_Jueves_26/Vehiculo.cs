using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Jueves_26
{
    class Vehiculo
    {   //ATRIBUTOS
        //UNA VARIABLE EMPIEZA CON _ ES PRIVADA (USAR TB CAMEL CASE)
        private int ID;
        private string Marca;
        private string Modelo;
        private int KM;
        private double Precio;
        
        //PROPIEDADES PÚBLICAS
        public int PID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string PMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public string PModelo
        {
            get { return Modelo; }
            set { Modelo = value; }
        }

        public int PKM
        {
            get { return KM; }
            set { KM = value; }
        }

        public double PPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        //CONSTRUCTORES
        //CONSTRUCTOR SOBRECARGADO PARA PASARLE PARÁMETROS
        public Vehiculo(int p1, string p2, string p3, int p4, double p5)
        {
            this.ID = p1;
            this.Marca = p2;
            this.Modelo = p3;
            this.KM = p4;
            this.Precio = p5;
        }

        //PARA PODER GENERAR UNA CLASE POR DEFECTO Y ACCEDER A SUS PROPIEDADES
        public Vehiculo() { }

        

    }
}
