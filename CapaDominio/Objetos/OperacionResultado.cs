using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Objetos
{
    public class OperacionResultado
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public int idGenerado { get; set; }
    }
}
