using Inventario_residencias.Modelos;
using System.ComponentModel;

namespace Inventario_residencias.modelos
{
    public class Inventario
    {
        public string numeroFisicoId { get; set; }
        public string descripcion { get; set; }
        public int tablero { get; set; }
        public string columna { get; set; }
        public string fila { get; set; }
        public string ubicacion { get; set; }
        public byte[]? imagen { get; set; }
        public bool existencia { get; set; }
        public string fecha { get; set; }
    }
}
