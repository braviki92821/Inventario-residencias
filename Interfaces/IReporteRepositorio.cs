
using Inventario_residencias.Modelos;

namespace Inventario_residencias.Interfaces
{
    public interface IReporteRepositorio
    {
        void GenerarReporteGeneral(string[] colums, float[] tamanios, string campos);

        void GenerarReporteTablero(string[] colums, float[] tamanios, string campos, string tablero, string Letra);

        byte[] imagen();

        bool reportarItem(Reporte reporte);

        void generarExcel();
    }
}
