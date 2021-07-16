using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZoologico
{
    abstract class Animal
    {//atributos protected para que las otras clases puedan heredar
        protected string especie;
        protected string nombreAnimal;
        protected double peso;
        protected int jaula;

        //propiedades (inicia con mayuscula)

        protected string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        protected string NombreAnimal
        {
            get { return nombreAnimal; }
            set { nombreAnimal = value; }
        }

        protected double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        protected int Jaula
        {
            get { return jaula; }
            set { jaula = value; }
        }

        //constructores

        public Animal() //constructor por defecto, vacío
        {

        }

        public Animal (string especie, string nombreAnimal, double peso, int jaula)
        {
            this.especie = especie;
            this.nombreAnimal = nombreAnimal;
            this.peso = peso;
            this.jaula = jaula;
        }

        public virtual void queClaseDeAnimalEres()
        {

        }
    }
}
