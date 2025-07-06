using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun
{
    public static class UsuarioSesion
    {
        public static int IdUsuario { get; set; }

        public static string NombreCompleto { get; set; }
        public static string Nombre { get; set; } 
        public static string ApellidoMaterno { get; set; } 
        public static string ApellidoPaterno { get; set; } 
        public static string Usuario { get; set; } 
        public static string Contrasena { get; set; } 
        public static string NumeroCasa { get; set; }
        public static string Calle { get; set; }
        public static string CorreoElectronico { get; set; } 
        public static string Telefono { get; set; }
        public static byte[] Imagen { get; set; }
        public static DateTime FechaRegistro { get; set; }
    }
}
