using CapaDatos.Contratos;
using CapaDatos.ModeloDatos;
using CapaDatos.Repositorios;
using CapaDominio.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class HistorialDominio
    {
        private int idHistorial;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private int idInvitado;
        private int idUsuario;

        private List<HistorialDominio> listaHistoriales;
        private HistorialDominio historialDominio;
        private IRepositorioHistorial iRepositorioHistorial;
        public EstadoEntidad estadoEntidad { get; set; }


        public int IdHistorial
        {
            get { return idHistorial; }
            set { idHistorial = value; }
        }
        public DateTime FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }
        public DateTime FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value; }
        }
        public int IdInvitado
        {
            get { return idInvitado; }
            set { idInvitado = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public HistorialDominio()
        {
            iRepositorioHistorial=new RepositorioHistorial();
        }

        public OperacionResultado GuardarCambios()
        {
            var operacionResultado = new OperacionResultado();
            try
            {
                int resultado = 0;
                HistorialDatos historialDatos = new HistorialDatos
                {
                    idHistorial = this.idHistorial,
                    fecha_entrada = this.fechaEntrada,
                    fecha_salida = this.fechaSalida,
                    id_invitado = this.idInvitado,
                    id_usuario = this.idUsuario
                };
                switch (estadoEntidad)
                {
                    case EstadoEntidad.Agregado:
                        resultado=operacionResultado.idGenerado = iRepositorioHistorial.Agregar(historialDatos);
                        if (resultado > 0)
                        {
                            operacionResultado.Mensaje = "Historial agregado correctamente.";
                            operacionResultado.Exito = true;
                        }
                        else
                        {
                            operacionResultado.Mensaje = "No se pudo agregar el historial.";
                            operacionResultado.Exito = false;
                        }
                        break;
                    case EstadoEntidad.Modificado:
                        resultado = iRepositorioHistorial.Editar(historialDatos);
                        if (resultado > 0)
                        {
                            operacionResultado.Mensaje = "Historial modificado correctamente.";
                            operacionResultado.Exito = true;
                        }
                        else
                        {
                            operacionResultado.Mensaje = "No se pudo modificar el historial.";
                            operacionResultado.Exito = false;
                        }
                        break;
                    case EstadoEntidad.Eliminado:
                        resultado = iRepositorioHistorial.Eliminar(this.idHistorial);
                        if (resultado > 0)
                        {
                            operacionResultado.Mensaje = "Historial eliminado correctamente.";
                            operacionResultado.Exito = true;
                        }
                        else
                        {
                            operacionResultado.Mensaje = "No se pudo eliminar el historial.";
                            operacionResultado.Exito = false;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                operacionResultado.Mensaje = "Error al guardar cambios en el historial.";
                operacionResultado.Exito = false;
            }
            return operacionResultado;
        }

        public int EliminarHistorialPorIdUsuario(int idUsuario)
        {
            return iRepositorioHistorial.EliminarHistorialPorIdUsuario(idUsuario);
        }

        public int EliminarHistorialPorIdInvitado(int idInvitado)
        {
            return iRepositorioHistorial.EliminarHistorialPorIdInvitado(idInvitado);
        }

        public int AgregarFechaEntradaResidente(int idUsuario, DateTime fechaEntrada)
        {
            return iRepositorioHistorial.AgregarFechaEntradaResidente(idUsuario, fechaEntrada);
        }
        public int AgregarFechaSalidaResidente(int idUsuario, DateTime fechaSalida)
        {
            return iRepositorioHistorial.AgregarFechaSalidaResidente(idUsuario, fechaSalida);
        }

        public int AgregarFechaEntradaInvitado(int idInvitado,int idResidente, DateTime fechaEntrada)
        {
            return iRepositorioHistorial.AgregarFechaEntradaInvitado(idInvitado,idResidente, fechaEntrada);
        }

        public int AgregarFechaSalidaInvitado(int idInvitado, DateTime fechaSalida)
        {
            return iRepositorioHistorial.AgregarFechaSalidaInvitado(idInvitado, fechaSalida);
        }

        public List<HistorialDominio> ObtenerTodos()
        {
            listaHistoriales = new List<HistorialDominio>();
            IEnumerable<HistorialDatos> listaHistorialDatos = iRepositorioHistorial.ObtenerTodos();
            if (listaHistorialDatos == null)
            {
                return listaHistoriales;
            }
            foreach (var item in listaHistorialDatos)
            {
                historialDominio = new HistorialDominio
                {
                    idHistorial = item.idHistorial,
                    fechaEntrada = item.fecha_entrada,
                    fechaSalida = item.fecha_salida,
                    idInvitado = item.id_invitado,
                    idUsuario = item.id_usuario
                };
                listaHistoriales.Add(historialDominio);
            }
            return listaHistoriales;


        }

        public List<HistorialDominio> ObtenerTodosInvitado()
        {
            listaHistoriales = new List<HistorialDominio>();
            IEnumerable<HistorialDatos> listaHistorialDatos = iRepositorioHistorial.ObtenerTodosInvitado();
            if (listaHistorialDatos == null)
            {
                return listaHistoriales;
            }
            foreach (var item in listaHistorialDatos)
            {
                historialDominio = new HistorialDominio
                {
                    idHistorial = item.idHistorial,
                    fechaEntrada = item.fecha_entrada,
                    fechaSalida = item.fecha_salida,
                    idInvitado = item.id_invitado,
                    idUsuario = item.id_usuario
                };
                listaHistoriales.Add(historialDominio);
            }
            return listaHistoriales;
        }

        public List<HistorialDominio> ObtenerTodosResidente()
        {
            listaHistoriales = new List<HistorialDominio>();
            IEnumerable<HistorialDatos> listaHistorialDatos = iRepositorioHistorial.ObtenerTodosResidente();
            if (listaHistorialDatos == null)
            {
                return listaHistoriales;
            }
            foreach (var item in listaHistorialDatos)
            {
                historialDominio = new HistorialDominio
                {
                    idHistorial = item.idHistorial,
                    fechaEntrada = item.fecha_entrada,
                    fechaSalida = item.fecha_salida,
                    idInvitado = item.id_invitado,
                    idUsuario = item.id_usuario
                };
                listaHistoriales.Add(historialDominio);
            }
            return listaHistoriales;
        }

       public HistorialDominio VerificarEntradaAbiertaInvitado(int idInvitado)
        {
            var historialDatos = iRepositorioHistorial.VerificarEntradaAbiertaInvitado(idInvitado);
            if (historialDatos == null)
            {
                return null;
            }
            historialDominio = new HistorialDominio
            {
                idHistorial = historialDatos.idHistorial,
                fechaEntrada = historialDatos.fecha_entrada,
                fechaSalida = historialDatos.fecha_salida,
                idInvitado = historialDatos.id_invitado,
                idUsuario = historialDatos.id_usuario
            };
            return historialDominio;
        }
        public HistorialDominio VerificarEntradaAbiertaResidente(int idUsuario)
        {
            var historialDatos = iRepositorioHistorial.VerificarEntradaAbiertaResidente(idUsuario);
            if (historialDatos == null)
            {
                return null;
            }
            historialDominio = new HistorialDominio
            {
                idHistorial = historialDatos.idHistorial,
                fechaEntrada = historialDatos.fecha_entrada,
                fechaSalida = historialDatos.fecha_salida,
                idInvitado = historialDatos.id_invitado,
                idUsuario = historialDatos.id_usuario
            };
            return historialDominio;
        }

    }
}
