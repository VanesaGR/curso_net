using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoldadoSombra Soldado1 = new SoldadoSombra("FLIN", "FN-2199", "BLASTER", 0);
            Console.WriteLine();
            SoldadoAsaltoEstandar SoldadoE = new SoldadoAsaltoEstandar("REY", "RY-2540", "SABLE", 150);
            Console.WriteLine();
            Console.WriteLine();

            SoldadoAsalto SoldadoA = new SoldadoAsalto();
            Console.WriteLine("Introduce el nombre del soldado");
            SoldadoA.NombreSoldado = Console.ReadLine();
            Console.WriteLine("Introduce el codigo");
            SoldadoA.PCodigo = Console.ReadLine();
            Console.WriteLine("Introduce el arma");
            SoldadoA.Rifle = Console.ReadLine();
            Console.WriteLine("Introduce el número de combates");
            SoldadoA.PCombates = int.Parse(Console.ReadLine());
            


            Soldado1.ImprimeRebeldes();
            SoldadoE.ImprimeRebeldes1();
            SoldadoA.ImprimeClase();


            Console.ReadLine();
            
        }
    }
}
