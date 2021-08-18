using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1_Agosto
{
    public class Persona
    {
        //atributos de la clase. Protected para que las otras clases puedan utilizar sus propiedades
        protected string nombre;
        protected string apellidos;
        protected string documento;

        public Persona() { } //constructor por defecto

        public string Pnombre //propiedades
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Papellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Pdocumento
        {
            get { return documento; }
            set { documento = value; }
        }

        public Persona(string nombre, string apellidos, string documento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.documento = documento;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombre + "\nApellidos: " + apellidos + "\nDocumento: " + documento);
        }

    }
}
