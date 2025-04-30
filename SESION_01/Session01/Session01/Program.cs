using Session01.Modelos;

namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO!");


            Ejemplo ejemplo = new Ejemplo();
            ejemplo.Nombre = "Ejemplo de clase";

            Persona persona = new Persona(1, "Juan", "Pérez");


            persona.CaminarEnKilometros(20, 30);

        }
    }
}
