using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZoologico
{
    class Mamifero:Animal
    {
        public Mamifero(string especie, string nombreAnimal, double peso, int jaula)
            :base(especie, nombreAnimal, peso, jaula)
        {

        }

        public override void queClaseDeAnimalEres()
        {
            Console.WriteLine("Soy un mamífero llamado: "+nombreAnimal+"\nde la especie: "+especie+"\nPeso en kg: "
                +peso+"\nEstoy en la jaula: "+jaula);
        }
    }
}
