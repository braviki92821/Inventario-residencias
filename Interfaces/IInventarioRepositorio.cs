using Inventario_residencias.modelos;
using Inventario_residencias.Modelos;
using System.Data;

namespace Inventario_residencias.Interfaces
{
    public interface IInventarioRepositorio
    {
        DataTable obtenerInventario(string numeroFisico, int limite, int offset);

        bool agregarItem(Inventario inventario);

        bool actualizarItem(Inventario inventario);

        Inventario buscarPorNumeroFisico(string numeroFisico);

        byte[] ImageToByteArray(Image image);

        List<Tablero> obtenerTableros();

        int cantidadRegistros();

        bool eliminarExistenciaItem(string numeroFisico, bool existencia);

        Task<bool> numeroFisico(string numeroFisico);

        bool eliminarItem(string numeroFisico);
    }
}
