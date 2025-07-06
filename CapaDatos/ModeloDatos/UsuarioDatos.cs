using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ModeloDatos
{
    public class UsuarioDatos
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }

        public string nombreCompleto
        {
            get { return $"{nombre} {apellidoPaterno} {apellidoMaterno}"; }
        }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string numeroCasa { get; set; }
        public string calle { get; set; }
        public string telefono { get; set; }
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string usuario { get; set; }
        public DateTime fechaRegistro { get; set; }
        public byte[] imagen { get; set; }
    }
}
