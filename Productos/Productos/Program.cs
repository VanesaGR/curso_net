using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    class Program
    {
        static void Main(string[] args)
        {
            producto p1 = new producto(); //creacion del producto
           
            string opcion = ""; //opcion del menu
            double cuenta=0, acumulador=0;
            int pedido = 0;

            do
            {
                Console.WriteLine("MENÚ:");
                Console.WriteLine("1. Crear objeto");
                Console.WriteLine("2. Hacer pedido");
                Console.WriteLine("3. Mostrar el total + IVA");
                Console.WriteLine("4. Salir");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": //para introducir los datos de los productos
                        Console.WriteLine("Introduce el nombre");
                        p1.Pnombre= Console.ReadLine();
                        Console.WriteLine("Introduce el precio");
                        p1.Pprecio= double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la categoria");
                        p1.Pcategoria= Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Cantidad a comprar");
                        pedido = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case "3": 
                        cuenta = p1.Pprecio * pedido-((p1.Pprecio * pedido)*0.21);                        
                        acumulador = acumulador + cuenta;                        
                        p1.Mostrar();                   
                        Console.WriteLine("El coste total del pedido es: " + acumulador);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error en los datos");
                        break;

                }
            } while (opcion != "4");
        }
    }
}
