using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Modelos
{
    

    public class EjemploVariables
    {
        #region declaracion de variables y constructores
        //VARIABLES QUE SE MANTENDRAN EN TODA LA CLASE
        Persona persona;
        string nombre;
        public static string nombreProyecto = "Ejemplo02";
        public EjemploVariables()
        {
            //INICIALIZAR VARIABLES
            persona = new Persona(1, "Juan", "Pérez");
            nombre = "Juan";
        }
        #endregion

        #region metodos

        public void CaminarEnKilometros(int distancia, int tiempo)
        {
            //VARIABLES LOCALES
            double velocidad = 0;
            double distanciaRecorrida = 0;
            //CALCULAR VELOCIDAD
            velocidad = (double)distancia / tiempo;
            //CALCULAR DISTANCIA RECORRIDA
            distanciaRecorrida = velocidad * tiempo;
            Console.WriteLine($"La velocidad de juan {nombre} es: {velocidad} km/h");
            Console.WriteLine($"La distancia recorrida de {persona.Nombre} es de: {distanciaRecorrida} km");

            string nombreProyecto = "HOLAMUNDO";
            if (nombreProyecto == Constantes.NombreProyecto)
            {
                Console.WriteLine($"El proyecto es el mismo");
                nombreProyecto = "NuevoProyecto";
            }
            else
            {
                Console.WriteLine($"El proyecto es incorrecto");
            }


        }
        #endregion
    }
}
