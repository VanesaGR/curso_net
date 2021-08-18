using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1_Agosto
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
           
            Cliente cliente1 = new Cliente();
            
            string opcion = "";

            do
            {
                Console.WriteLine("1. Crear nuevo empleado");
                Console.WriteLine("2. Crear nuevo cliente");
                Console.WriteLine("3. Salir de la aplicación");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Introduce el nombre");
                        empleado1.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce los apellidos");
                        empleado1.Papellidos = Console.ReadLine();
                        Console.WriteLine("Introduce el documento");
                        empleado1.Pdocumento = Console.ReadLine();
                        Console.WriteLine("Introduce el tipo de contrato (F o T)");
                        empleado1.PtipoContrato = Console.ReadLine();
                        Console.WriteLine("Introduce el sueldo");
                        empleado1.Psueldo = double.Parse(Console.ReadLine());
                        empleado1.calcularSueldo(); //invoca la funcion que calcula el sueldo
                        empleado1.Mostrar();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Introduce el nombre");
                        cliente1.Pnombre = Console.ReadLine();
                        Console.WriteLine("Introduce los apellidos");
                        cliente1.Papellidos = Console.ReadLine();
                        Console.WriteLine("Introduce el documento");
                        cliente1.Pdocumento = Console.ReadLine();
                        Console.WriteLine("Introduce la categoría");
                        cliente1.Pcategoria = Console.ReadLine();
                        cliente1.generarCodigo();//invoca la funcion para generar el codigo de cliente
                        cliente1.Mostrar();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != "3");

            

            
           
        }
    }
}
