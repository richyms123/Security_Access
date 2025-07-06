using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ModeloDatos
{
    public class InvitadoDatos
    {
        public int idInvitado { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime fechaVigencia { get; set; }
        public string estatus { get; set; }
        public string tipoInvitacion { get; set; }
        public int idUsuario { get; set; }
    }
}
