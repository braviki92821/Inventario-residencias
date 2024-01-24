
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static iText.IO.Util.IntHashtable;

namespace Inventario_residencias.Exceptions
{
    public class InventarioException : Exception
    {
        public InventarioException() : base() { }
        public InventarioException(string mensaje): base(mensaje) 
        {
            if(mensaje.Equals(" Duplicate entry '10-15' for key 'inventario.PRIMARY'"))
            {
                MessageBox.Show("Este numero fisico ya esta en uso");
                return;
            }
        }

        public InventarioException(string mensaje, Exception inner) : base (mensaje, inner) { }
    }
}
