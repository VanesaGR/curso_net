using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Jueves_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto m1 = new Moto();
            Coche c1 = new Coche();

            string opcion = "";
            string n2, n3, n6;
            int n1, n4;
            double n5;
            bool abg;

            do
            {
                Console.WriteLine("1. Crear coche");
                Console.WriteLine("2. Crear moto");
                Console.WriteLine("3. Listar datos del coche");
                Console.WriteLine("4. Listar datos de la moto");
                Console.WriteLine("5. Salir");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Escribe el ID del coche: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Marca del coche: ");
                        n2 = Console.ReadLine();
                        Console.WriteLine("Modelo del coche: ");
                        n3 = Console.ReadLine();
                        Console.WriteLine("Km: ");
                        n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Precio del coche: ");
                        n5 = double.Parse(Console.ReadLine());

                        Console.WriteLine("¿Tiene airbag? (S/N): ");
                        n6 = Console.ReadLine();
                        if (n6 == "s" || n6 == "S") abg=true;
                        else abg=false;

                        c1 = new Coche(n1, n2, n3, n4, n5, abg);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Escribe el ID de la moto: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Marca de la moto: ");
                        n2 = Console.ReadLine();
                        Console.WriteLine("Modelo de la moto: ");
                        n3 = Console.ReadLine();
                        Console.WriteLine("Km: ");
                        n4= int.Parse(Console.ReadLine());
                        Console.WriteLine("Precio de la moto: ");
                        n5 = double.Parse(Console.ReadLine());

                        Console.WriteLine("¿Tiene sidecar? (S/N): ");
                        n6 = Console.ReadLine();
                        if (n6 == "s" || n6 == "S") abg=true;
                        else abg=false;

                        m1 = new Moto(n1, n2, n3, n4, n5, abg);
                        Console.Clear();
                        break;
                    case "3":
                        c1.ImprimirCoche();
                        Console.ReadLine();
                        break;
                    case "4":
                        m1.ImprimirMoto();
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                }
            } while (opcion != "5");
        }
    }
}
