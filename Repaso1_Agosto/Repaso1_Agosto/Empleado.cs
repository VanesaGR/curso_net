using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1_Agosto
{
    class Empleado:Persona
    {
        private string tipoContrato;
        private double sueldo;
        
        public Empleado() { }

        public string PtipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value; }
        }

        public double Psueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        
        public Empleado(string nombre, string apellidos, string documento, string tipoContrato, double sueldo)
            :base(nombre,apellidos,documento)
        {
            this.tipoContrato = tipoContrato;
            this.sueldo = sueldo;
        }
        /// <summary>
        /// MÉTODO CALCULAR SUELDO
        /// </summary>
        /// 
        public void calcularSueldo()
        {
            if (tipoContrato == "F")
            {
                sueldo = sueldo + 300;
            }
            else
            {
                sueldo = sueldo + 250;
            }
        }

        public override void Mostrar()
        {
            Console.WriteLine("Nombre: " + Pnombre + "\nApellidos: " + Papellidos + "\nDocumento: " + Pdocumento +
                "\nTipo de contrato: " + this.tipoContrato + "\nSueldo: " + this.sueldo);
        }
    }//FIN DE CLASE
}//FIN DE NAMESPACE
