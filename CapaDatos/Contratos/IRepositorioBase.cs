using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    public interface IRepositorioBase<Entity> where Entity : class
    {
        int Agregar(Entity entidad);
        int Editar(Entity entidad);
        int Eliminar(int id_usuario);
        IEnumerable<Entity> ObtenerTodos();
    }
}
