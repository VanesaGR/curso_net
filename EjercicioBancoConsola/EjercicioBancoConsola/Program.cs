using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBancoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta();

            string opcion = "";
            int n1 = 0, n2 = 0;

            do
            {
                Console.WriteLine("1. Crear cuenta");
                Console.WriteLine("2. Depositar una cantidad");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Consultar saldo");
                Console.WriteLine("5. Salir de la aplicación");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Escriba el nombre");
                        miCuenta.Pnombre = Console.ReadLine();
                        Console.WriteLine("Escriba el número de cuenta");
                        miCuenta.PnumCuenta = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el saldo");
                        miCuenta.Psaldo = double.Parse(Console.ReadLine());

                        Console.WriteLine("CUENTA CREADA");
                        break;

                    case "2":
                        Console.WriteLine("Escriba cantidad a ingresar");
                        n1 = int.Parse(Console.ReadLine());
                        miCuenta.Psaldo = (miCuenta.Psaldo) + n1;
                        break;

                    case "3":
                        Console.WriteLine("Escriba la cantidad a retirar");
                        n2 = int.Parse(Console.ReadLine());
                        miCuenta.Psaldo = (miCuenta.Psaldo) - n2;
                        miCuenta.Retirar();
                        Console.ReadLine();
                        break;

                    case "4":
                        miCuenta.Mostrar();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "5":
                        Console.WriteLine("Saliendo de la App");
                        break;

                }
            } while (opcion != "5");
        }
    }
}
