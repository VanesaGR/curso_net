using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioZoologico
{
    class Ave:Animal
    {
        protected string colorPlumaje;
        double alturaMaximaVuelo;

        protected string ColorPlumaje
        {
            get { return colorPlumaje; }
            set { colorPlumaje = value; }
        }

        protected double AlturaMaximaVuelo
        {
            get { return alturaMaximaVuelo; }
            set { alturaMaximaVuelo = value; }
        }

        public Ave(string especie, string nombreAnimal, double peso, int jaula, string colorPlumaje, double alturaMaximaVuelo) 
            : base(especie, nombreAnimal, peso, jaula)
        {
            this.colorPlumaje = colorPlumaje;
            this.alturaMaximaVuelo = alturaMaximaVuelo;

        }

        public override void queClaseDeAnimalEres()
        {
            Console.WriteLine("Soy un ave llamado: " + nombreAnimal + "\nde la especie: " + especie + "\nPeso en kg: "
                + peso + "\nEstoy en la jaula: " + jaula+"\nMi plumaje es de color: "+colorPlumaje+"\nVuelo máximo a: "
                +alturaMaximaVuelo);
        }
    }
}
