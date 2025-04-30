using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Color { get; set; }
        private string _sonido; 
        public Mascota(string nombre, string raza, int edad, string color)
        {
            Nombre = nombre;
            Raza = raza;
            Edad = edad;
            Color = color;
            _sonido = "Sonido de mascota";
        }
        public virtual void Dormir()
        {
            Console.WriteLine($"{Nombre} está durmiendo.");
        }
        public void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo.");
            HacerSonido();
        }
        private void HacerSonido()
        {
            Console.WriteLine($"{Nombre} hace un sonido: {_sonido}");
        }
    }
}
