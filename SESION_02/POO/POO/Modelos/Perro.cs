using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class Perro:Mascota
    {
        public Perro(string nombre, string raza, int edad, string color)
            :base(nombre, raza, edad, color)
        {
            
        }

        public override void Dormir()
        {
            Console.WriteLine($" El perro con nombre {Nombre} está durmiendo en la sala.");
        }

        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} está ladrando.");
        }
        public void Jugar()
        {
            try
            {
                Console.WriteLine($"{Nombre} está jugando.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Ocurrio un error.");
                throw;
            }
            
        }
        public void Jugar(string nombreJuego)
        {
            Console.WriteLine($"{Nombre} está jugando el juego {nombreJuego}.");
        }

        public void Jugar(string nombreJuego, string objeto)
        {
            Console.WriteLine($"{Nombre} está jugando el juego {nombreJuego}, con {objeto}.");
        }
    }
}