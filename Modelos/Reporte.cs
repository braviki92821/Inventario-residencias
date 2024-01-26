
namespace Inventario_residencias.Modelos
{
    public class Reporte
    {
        public int? reporteId { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public string? Item { get; set; }
        public int? usuario { get; set; }
        public DateTime? fecha { get; set; }
        public bool leido { get; set; }
    }
}
