using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public abstract class RepositorioConexion
    {
        private readonly string conexionString;
        public RepositorioConexion()
        {
            /*conexionString = "Server=DESKTOP-KHV44DF\\SQLEXPRESS;" +
                "DataBase=SecureAccess; Trusted_Connection=True;TrustServerCertificate=True";*/
            //conexionString = "Server=chuyserver.database.windows.net;Database=Poyecto_Topicos;User ID=rootchuy@chuyserver;Password=root12345$;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;MultipleActiveResultSets=True;";
            conexionString = "Server=localhost,1433;Database=SecureAccess;User ID=usuarioResidencial;Password=Residencial2025;Trusted_Connection=True;TrustServerCertificate=True;";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(conexionString);
        }
    }
}
