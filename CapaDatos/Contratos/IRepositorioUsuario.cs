
using CapaDatos.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    public interface IRepositorioUsuario : IRepositorioBase<UsuarioDatos>
    {
        UsuarioDatos IniciarSesion(string usuario);
        UsuarioDatos ObtenerDatosUsuarioPorId(int idUsuario);
    }
}
