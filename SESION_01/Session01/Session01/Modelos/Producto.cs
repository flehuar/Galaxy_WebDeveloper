
namespace Session01.Modelos
{
    //TRATAR COMO UNA VERSION DE VS ANTERIOR A LA 2019 / 2017
    public class Producto
    {
        // PROCEDER A DECLARAR LOS ATRIBUTOS DE LA CLASE | PROPIEDADES | CARACTERISTICAS DE LA CLASE

        /// <summary>
        /// Identificador del producto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Código del producto
        /// </summary>
        public string CodigoCategoria { get; set; }

        //VAMOS A HACER USO DE LOS CONSTRUCTORES
        //INYECCIÓN DE DEPENDENCIAS | INICIALIZAR VARIABLES

        public Producto()
        {
            Id = 0;
            Nombre = string.Empty;
            CodigoCategoria = string.Empty;
        }


    }
}
