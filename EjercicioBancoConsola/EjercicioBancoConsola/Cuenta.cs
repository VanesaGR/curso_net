using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBancoConsola
{
    class Cuenta
    {
            private int numCuenta;
            private string nombre;
            private double saldo;

            public Cuenta()
            {
                //constructor por defecto. Accederemos a través de las propiedades.

                //los datos se pedirán por pantalla
            }

            public string Pnombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public int PnumCuenta
            {
                get { return numCuenta; }
                set { numCuenta = value; }
            }

            public double Psaldo
            {
                get { return saldo; }
                set { saldo = value; }
            }

            public void Mostrar()
            {
                Console.WriteLine("El saldo total es: " + saldo);
            }

           
        }
    
}
