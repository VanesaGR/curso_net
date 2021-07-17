using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars1
{
    class SoldadoSombra:SoldadoImperial
    {
        protected int NumRebeldes;
        public SoldadoSombra() : base()
        {
            NumRebeldes = 0;
        }


        //Una segunda manera invocando a la clase padre
        public SoldadoSombra(string nombre, string codigo, string TipoRifle, int Rebeldesmuertos)
       : base(nombre, codigo, TipoRifle)
        {
            NumRebeldes = Rebeldesmuertos;
        }
        public void ImprimeRebeldes()
        {
            base.Imprime();
            Console.WriteLine("HA FINIQUITADO " + this.NumRebeldes.ToString() + " SUCIOS REBELDES..");
        }
    }
}
