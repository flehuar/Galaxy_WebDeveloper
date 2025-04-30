using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Modelos
{
    public class TiposDeDato
    {
        public string Nombre { get; set; } = string.Empty;  
        public short Edad { get; set; } = 0;
        public int Id { get; set; } = 0;
        public long Telefono { get; set; } = 0;
        public float Altura { get; set; } = 0.0f;
        public double Peso { get; set; } = 0.0;
        public decimal Sueldo { get; set; } = 0.0m;
        public bool EsEstudiante { get; set; } = false;
        public char Inicial { get; set; } = ' ';
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Inicial}";
            }
        }
        public Byte[] Imagen { get; set; } = new byte[0];
        public string[] Nombres { get; set; } = new string[0];
        public List<string> ListaNombres { get; set; } = new List<string>();
        public Dictionary<string, string> DiccionarioNombres { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, int> DiccionarioNumeros { get; set; } = new Dictionary<string, int>();
        public List<Persona> ListaPersonas { get; set; } = new List<Persona>();
        public Dictionary<string, Persona> DiccionarioPersonas { get; set; } = new Dictionary<string, Persona>();


    }
}
