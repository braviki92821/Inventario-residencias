using Inventario_residencias.modelos;
using Inventario_residencias.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_residencias.Interfaces
{
    public interface IInventarioRepositorio
    {
        List<Inventario> obtenerInventario(string numeroFisico, int limite, int offset);

        bool agregarItem(Inventario inventario);

        bool actualizarItem(Inventario inventario);

        Inventario buscarPorNumeroFisico(string numeroFisico);

        byte[] ImageToByteArray(Image image);

        List<Tablero> obtenerTableros();

        int cantidadRegistros();

        bool eliminarExistenciaItem(string numeroFisico);
    }
}
