using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars1
{
    class SoldadoAsalto:SoldadoSombra
    {
        protected int IntCombates;
        protected string StrClase;
        
        public SoldadoAsalto() : base()
        {
           
        }

        public int PCombates
        {
            get { return IntCombates; }
            set { IntCombates = value; }
        }

        public string PClase
        {
            get { return StrClase; }
            set { StrClase = value; }
        }
        

        public void ImprimeClase()
        {
           
            if (IntCombates >= 100)
            {
                StrClase = "Soldado Sombra";
            }

            base.Imprime();
            Console.WriteLine("HA COMBATIDO " + this.IntCombates.ToString() + " VECES, ES DE TIPO "+StrClase);

        }
    }
}
