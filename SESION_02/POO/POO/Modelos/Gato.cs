using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class Gato : Mascota
    {

        public string Bigotes { get; set; }
        public Gato(string nombre, string raza, int edad, string color, string bigotes) :
        //Base indica que el constructor es ejecuctado el constructor de la clase padre (Mascota)
            base(nombre, raza, edad, color)
        {
            this.Bigotes = bigotes;
        }

        
        public void Maullar()
        {
            Console.WriteLine($"{Nombre} está maullando.");
        }

        public override void Dormir()
        {
            Console.WriteLine($"El gato con nombre: {Nombre} está durmiendo en el tejado.");
        }

        //public void Dormir()
        //{
        //    Console.WriteLine($"{Nombre} está durmiendo.");
        //}
    }
}
