using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars1
{
    public class SoldadoImperial
    {
        private string StrNombre;
        private string StrCodigo;
        private string TipoRifle;

        // Método constructor por defecto
        // Se define pero puede que no se use
        public SoldadoImperial()
        {
            StrNombre = "";
            StrCodigo = "";
        }
        // Sobrecarga del método constructor
        public SoldadoImperial(string nombre, string codigo, string rifle)
        {
            StrNombre = nombre;
            StrCodigo = codigo;
            TipoRifle = rifle;
        }
        public string NombreSoldado
        { 
            get { return StrNombre; } 
            set { StrNombre = value; }
        }

        public string PCodigo
        {
            get { return StrCodigo; }
            set { StrCodigo = value; }
        }

        public string Rifle
        {
            get { return TipoRifle; }
            set { TipoRifle = value; }
        }
        public void Imprime()
        {
            Console.WriteLine("SOLDADO REGISTRADO: " + this.StrNombre + " CON CÓDIGO " +
           this.StrCodigo + " CON ARMAMENTO->" + this.TipoRifle);
        }
    }
}
