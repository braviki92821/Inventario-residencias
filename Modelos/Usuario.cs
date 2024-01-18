using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_residencias.modelos
{
    public class Usuario
    {
        public int? usuarioId { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public string tipo { get; set; }
        public bool status { get; set; }
        public byte[]? imagen { get; set; }

    }
}
