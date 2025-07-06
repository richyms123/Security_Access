using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ModeloDatos
{
    public class HistorialDatos
    {
        public int idHistorial { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public int id_invitado { get; set; }
        public int id_usuario { get; set; }

    }
}
