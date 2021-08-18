using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1_Agosto
{
    class Cliente:Persona //hereda de clase persona
    {   //ATRIBUTOS O CAMPOS DE CLIENTE
        private string categoria;
        private string codigo;

        public Cliente() { }//constructor. si no se usa, no hace falta definirlo

        public string Pcategoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Pcodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public void generarCodigo()
        {
            codigo = "C"+ nombre.Substring(0,3) + documento.Substring(0, 2);
        }
        public override void Mostrar()
        {
            Console.WriteLine("Nombre: " + Pnombre + "\nApellidos: " + Papellidos + "\nDocumento: " + Pdocumento +
                "\nCategoria: " + this.categoria + "\nCódigo: " + this.codigo);
        }
    }
}
