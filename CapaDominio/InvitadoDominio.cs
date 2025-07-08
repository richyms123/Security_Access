using CapaDatos.Contratos;
using CapaDatos.ModeloDatos;
using CapaDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class InvitadoDominio
    {
        private int idInvitado;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private DateTime fechaVigencia;
        private string nombreCompleto;
        private string estatus;
        private string tipoInvitacion;
        private int idUsuario;

        private InvitadoDominio invitadoDomino;
        private List<InvitadoDominio> listaInvitados;
        private IRepositorioInvitado iRepositorioInvitado;

        public int IdInvitado
        {
            get { return idInvitado; }
            set { idInvitado = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
        public string NombreCompleto
        {
            get { return $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}"; }
            set { nombreCompleto = value; }
        }
        public DateTime FechaVigencia
        {
            get { return fechaVigencia; }
            set { fechaVigencia = value; }
        }
        public string Estatus
        {
            get { return estatus; }
            set { estatus = value; }
        }
        public string TipoInvitacion
        {
            get { return tipoInvitacion; }
            set { tipoInvitacion = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public InvitadoDominio()
        {
            iRepositorioInvitado= new RepositorioInvitado();
        }

        public int EliminarInvitadoPorIdUsuario(int idUsuario)
        {
            return iRepositorioInvitado.EliminarInvitadoPorIdUsuario(idUsuario);
        }

        public List<InvitadoDominio> ObtenerTodos()
        {
            listaInvitados = new List<InvitadoDominio>();
            var invitadosDatos = iRepositorioInvitado.ObtenerTodos();
            if(invitadosDatos==null || !invitadosDatos.Any())
            {
                return listaInvitados;
            }
            foreach (var invitadoDatos in invitadosDatos)
            {
                invitadoDomino = new InvitadoDominio
                {
                    IdInvitado = invitadoDatos.idInvitado,
                    Nombre = invitadoDatos.nombre,
                    ApellidoPaterno = invitadoDatos.apellidoPaterno,
                    ApellidoMaterno = invitadoDatos.apellidoMaterno,
                    FechaVigencia = invitadoDatos.fechaVigencia,
                    Estatus = invitadoDatos.estatus,
                    TipoInvitacion = invitadoDatos.tipoInvitacion,
                    IdUsuario = invitadoDatos.idUsuario
                };
                listaInvitados.Add(invitadoDomino);
            }
            return listaInvitados;
        }

        public InvitadoDominio ObtenerDatosInvitadoPorId(int idInvitado)
        {
            InvitadoDominio invitadoDominio = new InvitadoDominio();
            InvitadoDatos invitadoDatos = iRepositorioInvitado.ObtenerDatosInvitadoPorId(idInvitado);
            if (invitadoDatos == null)
            {
                return null;
            }
            invitadoDominio.IdInvitado = invitadoDatos.idInvitado;
            invitadoDominio.Nombre = invitadoDatos.nombre;
            invitadoDominio.ApellidoPaterno = invitadoDatos.apellidoPaterno;
            invitadoDominio.ApellidoMaterno = invitadoDatos.apellidoMaterno;
            invitadoDominio.FechaVigencia = invitadoDatos.fechaVigencia;
            invitadoDominio.TipoInvitacion= invitadoDatos.tipoInvitacion;
            invitadoDominio.Estatus = invitadoDatos.estatus;
            invitadoDominio.IdUsuario = invitadoDatos.idUsuario;
            return invitadoDominio;
        }

        public int EditarEstatusInvitado(int idInvitado, string estatus)
        {
            return iRepositorioInvitado.EditarEstatusInvitado(idInvitado, estatus);
        }
    }
}
