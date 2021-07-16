using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero mamifero1 = new Mamifero("Elefante", "Koko", 1500, 23);
            mamifero1.queClaseDeAnimalEres();
            Console.WriteLine();

            Ave ave1 = new Ave("Guacamayo", "Sombra", 3, 11, "Rojo", 500);
            ave1.queClaseDeAnimalEres();
            Console.WriteLine();

            Insecto insecto1 = new Insecto("Mariquita", "Topo", 0.02, 2, true);
            insecto1.queClaseDeAnimalEres();

            Console.ReadLine();


        }
    }
}
