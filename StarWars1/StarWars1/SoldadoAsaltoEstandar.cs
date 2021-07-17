using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars1
{
    class SoldadoAsaltoEstandar:SoldadoImperial
    {
        protected int NumRebeldes1;
        public SoldadoAsaltoEstandar() : base()
        {
            NumRebeldes1 = 0;
        }

        //Una segunda manera invocando a la clase padre //Constructor
        public SoldadoAsaltoEstandar(string nombre, string codigo, string TipoRifle, int RebeldesMuertos)
       : base(nombre, codigo, TipoRifle)
        {
            NumRebeldes1= RebeldesMuertos;
        }
        public void ImprimeRebeldes1()
        {
            base.Imprime();
            Console.WriteLine("HA FINIQUITADO " + this.NumRebeldes1.ToString() + " SUCIOS REBELDES..");
        }
    }
}
