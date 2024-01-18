using Inventario_residencias.modelos;
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

        bool buscarPorNumeroFisico(string numeroFisico);

        byte[] ImageToByteArray(Image image);

    }
}
