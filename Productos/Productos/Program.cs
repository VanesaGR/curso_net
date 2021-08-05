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

            var almacen = new List<producto>(); //carga de varios productos
           
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

                switch (opcion) //usando p1.Pnombre atacamos a las propiedades, usando c1, c2... también funciona
                {               //declarando el tipo de variable antes.
                    case "1": //para introducir los datos de los productos
                        Console.WriteLine("Introduce el nombre");
                        p1.Pnombre= Console.ReadLine();
                        Console.WriteLine("Introduce el precio");
                        p1.Pprecio= double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la categoria");
                        p1.Pcategoria= Console.ReadLine();
                        almacen.Add(p1);//añade al almacen
                        p1.Mostrar(); //muestra lo que vamos metiendo en el almacen
                        Console.Clear();
                        break;
                    case "2":
                        int num = 0;

                        foreach(var x in almacen)
                        {
                            x.Mostrar();
                            Console.WriteLine();
                            Console.WriteLine("Introduzca la cantidad de producto: ");
                            pedido = int.Parse(Console.ReadLine());
                            acumulador = (x.Pprecio * num) + acumulador;
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("El total es: " + acumulador.ToString());
                        Console.WriteLine("El IVA es: " + (acumulador * 0.21).ToString());
                        Console.WriteLine("El total, IVA incluido es: " + (acumulador * 1.21).ToString());                        
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error en los datos");
                        Console.ReadLine();
                        break;

                }
            } while (opcion != "4");
        }
    }
}
