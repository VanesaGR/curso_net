using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZoologico
{
    class Insecto:Animal
    {

        protected bool vuela;

        public Insecto(string especie, string nombreAnimal, double peso, int jaula, bool vuela)
            : base(especie, nombreAnimal, peso, jaula)
        {
            this.vuela=vuela;
        }

        public override void queClaseDeAnimalEres()
        {
            if (vuela == true)
            {
                Console.WriteLine("Soy un ave llamado: " + nombreAnimal + "\nde la especie: " + especie + "\nPeso en kg: "
                + peso + "\nEstoy en la jaula: " + jaula + "\nY vuelo");
            }
            else
            {
                Console.WriteLine("Soy un ave llamado: " + nombreAnimal + "\nde la especie: " + especie + "\nPeso en kg: "
                + peso + "\nEstoy en la jaula: " + jaula + "\nY no vuelo");
            }
        }
    }
}
