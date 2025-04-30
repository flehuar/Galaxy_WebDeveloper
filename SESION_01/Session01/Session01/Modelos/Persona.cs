using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Modelos
{
    public  class Persona
    {

        /// <summary>
        /// Identificador de la persona
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        public string Nombre { get; set; } = string.Empty;
        /// <summary>
        /// Apellido de la persona
        /// </summary>
        public string Apellido { get; set; } = string.Empty;

        /// <summary>
        /// Direccion de la persona
        /// </summary>
        public string Direccion { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; } = DateTime.Now;

        public List<TelefonoPersona> ListaTelefonos { get; set; } = new List<TelefonoPersona>();

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
                //return Nombre + "" + Apellido;
                //return string.Concat(Nombre, " ", Apellido);
            }
        }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }


        //HACER USO DE MULTIPLES CONSTRUCTORES

        public Persona(int Id, string Nombre, string Apellido)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }


        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        /// <summary>
        /// Calcula la distancia recorrida en kilometros
        /// </summary>
        /// <param name="edad">Edad de la persona</param>
        /// <param name="tiempo">Tiempo que caminara</param>
        public void CaminarEnKilometros(int edad, int tiempo)
        {

            double distancia = edad * tiempo;

        }

    }
}
