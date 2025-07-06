using CapaDatos.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    public interface IRepositorioHistorial :IRepositorioBase<HistorialDatos>
    {
        IEnumerable<HistorialDatos> ObtenerTodosInvitado();
        IEnumerable<HistorialDatos> ObtenerTodosResidente();

        HistorialDatos VerificarEntradaAbiertaInvitado(int id_invitado);
        HistorialDatos VerificarEntradaAbiertaResidente(int id_residente);

        int EliminarHistorialPorIdUsuario(int idUsuario);
        int EliminarHistorialPorIdInvitado(int idInvitado);

        int AgregarFechaEntradaResidente(int idUsuario, DateTime fechaEntrada);
        int AgregarFechaSalidaResidente(int idUsuario, DateTime fechaSalida);
        int AgregarFechaEntradaInvitado(int idInvitado, int idUsuario, DateTime fechaEntrada);
        int AgregarFechaSalidaInvitado(int idInvitado, DateTime fechaSalida);
    }
}
