using CapaDatos.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    public interface IRepositorioInvitado : IRepositorioBase<InvitadoDatos>
    {
        InvitadoDatos ObtenerDatosInvitadoPorId(int idInvitado);

        int EliminarInvitadoPorIdUsuario(int idUsuario);
        int EditarEstatusInvitado(int idInvitado,string estatus);

    }
}
