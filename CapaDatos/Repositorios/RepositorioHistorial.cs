using CapaDatos.Contratos;
using CapaDatos.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos.Repositorios
{
    public class RepositorioHistorial : RepositorioMaestro, IRepositorioHistorial
    {
        private readonly string queryAgregar;
        private readonly string queryEditar;
        private readonly string queryEliminar;
        private readonly string queryObtenerTodos;
        private readonly string queryObtenerTodosInvitado;
        private readonly string queryObtenerTodosResidente;
        private readonly string queryVerificarEntradaAbiertaInvitado;
        private readonly string queryVerificarEntradaAbiertaResidente;
        private readonly string queryAgregarFechaEntradaInvitado;
        private readonly string queryAgregarFechaEntradaResidente;
        private readonly string queryAgregarFechaSalidaInvitado;
        private readonly string queryAgregarFechaSalidaResidente;
        private readonly string queryEliminarPorIdUsuario;
        private readonly string queryEliminarPorIdInvitado;


        public RepositorioHistorial()
        {
            queryAgregar = "INSERT INTO Historiales(id_usuario,id_invitado,fecha_entrada,fecha_salida) " +
                "OUTPUT INSERTED.id_historial VALUES(@id_usuario,@id_invitado,@fecha_entrada,@fecha_salida)";
            queryEliminar = "DELETE FROM Historiales WHERE id_historial=@id_historial";
            queryObtenerTodos = "SELECT * FROM Historiales";
            queryObtenerTodosInvitado = "SELECT * FROM Historiales WHERE id_invitado IS NOT NULL";
            queryObtenerTodosResidente = "SELECT * FROM Historiales WHERE id_invitado IS NULL";
            queryVerificarEntradaAbiertaInvitado = "SELECT * FROM Historiales WHERE id_invitado = @id_invitado AND fecha_salida IS NULL";
            queryVerificarEntradaAbiertaResidente = "SELECT * FROM Historiales WHERE id_usuario = @id_usuario AND fecha_salida IS NULL";
            queryAgregarFechaEntradaInvitado="INSERT INTO Historiales(id_invitado,id_usuario, fecha_entrada) " +
                "OUTPUT INSERTED.id_historial VALUES(@id_invitado,@id_usuario, @fecha_entrada)";
            queryAgregarFechaSalidaInvitado = "UPDATE Historiales SET fecha_salida = @fecha_salida WHERE id_invitado = @id_invitado AND fecha_salida IS NULL";
            queryAgregarFechaEntradaResidente = "INSERT INTO Historiales(id_usuario, fecha_entrada) " +
                "OUTPUT INSERTED.id_historial VALUES(@id_usuario, @fecha_entrada)";
            queryAgregarFechaSalidaResidente = "UPDATE Historiales SET fecha_salida = @fecha_salida WHERE id_usuario = @id_usuario AND fecha_salida IS NULL";
            queryEliminarPorIdUsuario = "DELETE FROM Historiales WHERE id_usuario = @id_usuario";
            queryEliminarPorIdInvitado = "DELETE FROM Historiales WHERE id_invitado = @id_invitado";

        }
        public int Agregar(HistorialDatos entidad)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", entidad.id_usuario),
                new SqlParameter("@id_invitado", entidad.id_invitado),
                new SqlParameter("@fecha_entrada", entidad.fecha_entrada),
                new SqlParameter("@fecha_salida", entidad.fecha_salida)
            };
            return Convert.ToInt32(ExecuteScalar(queryAgregar));
        }

        public int AgregarFechaEntradaInvitado(int idInvitado,int idResidente, DateTime fechaEntrada)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_invitado", idInvitado),
                new SqlParameter("@id_usuario", idResidente),
                new SqlParameter("@fecha_entrada", fechaEntrada)
            };
            return Convert.ToInt32(ExecuteScalar(queryAgregarFechaEntradaInvitado));
        }

        public int AgregarFechaEntradaResidente(int idUsuario, DateTime fechaEntrada)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", idUsuario),
                new SqlParameter("@fecha_entrada", fechaEntrada)
            };
            return Convert.ToInt32(ExecuteScalar(queryAgregarFechaEntradaResidente));
        }

        public int AgregarFechaSalidaInvitado(int idInvitado, DateTime fechaSalida)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_invitado", idInvitado),
                new SqlParameter("@fecha_salida", fechaSalida)
            };
            return ExecuteNonQuery(queryAgregarFechaSalidaInvitado);
        }

        public int AgregarFechaSalidaResidente(int idUsuario, DateTime fechaSalida)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", idUsuario),
                new SqlParameter("@fecha_salida", fechaSalida)
            };
            return ExecuteNonQuery(queryAgregarFechaSalidaResidente);
        }

        public int Editar(HistorialDatos entidad)
        {
            throw new NotImplementedException();
        }

        public int Eliminar(int id_usuario)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_historial", id_usuario)
            };
            return ExecuteNonQuery(queryEliminar);
        }

        public int EliminarHistorialPorIdInvitado(int idInvitado)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_invitado", idInvitado)
            };
            return ExecuteNonQuery(queryEliminarPorIdInvitado);
        }

        public int EliminarHistorialPorIdUsuario(int idUsuario)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", idUsuario)
            };
            return ExecuteNonQuery(queryEliminarPorIdUsuario);
        }

        public IEnumerable<HistorialDatos> ObtenerTodos()
        {
            DataTable resultado = ExecuteReader(queryObtenerTodos);
            List<HistorialDatos> listaHistorial = new List<HistorialDatos>();
            if (resultado.Rows.Count == 0)
            {
                return listaHistorial;
            }
            foreach (DataRow fila in resultado.Rows)
            {
                HistorialDatos historial = new HistorialDatos()
                {
                    idHistorial = Convert.ToInt32(fila["id_historial"]),
                    fecha_entrada = Convert.ToDateTime(fila["fecha_entrada"]),
                    fecha_salida =fila["fecha_salida"]!=DBNull.Value? Convert.ToDateTime(fila["fecha_salida"]) : DateTime.MinValue,
                    id_invitado = fila["id_invitado"] != DBNull.Value ? Convert.ToInt32(fila["id_invitado"]) : 0,
                    id_usuario = fila["id_usuario"] != DBNull.Value ? Convert.ToInt32(fila["id_usuario"]) : 0
                };
                listaHistorial.Add(historial);
            }
            return listaHistorial;
        }

        public IEnumerable<HistorialDatos> ObtenerTodosInvitado()
        {
            DataTable resultado = ExecuteReader(queryObtenerTodosInvitado);
            List<HistorialDatos> listaHistorial = new List<HistorialDatos>();
            if (resultado.Rows.Count == 0)
            {
                return listaHistorial;
            }
            foreach (DataRow fila in resultado.Rows)
            {
                HistorialDatos historial = new HistorialDatos()
                {
                    idHistorial = Convert.ToInt32(fila["id_historial"]),
                    fecha_entrada = Convert.ToDateTime(fila["fecha_entrada"]),
                    fecha_salida = Convert.ToDateTime(fila["fecha_salida"]),
                    id_invitado = Convert.ToInt32(fila["id_invitado"]),
                    id_usuario = 0
                };
                listaHistorial.Add(historial);
            }
            return listaHistorial;
        }

        public IEnumerable<HistorialDatos> ObtenerTodosResidente()
        {
            DataTable resultado = ExecuteReader(queryObtenerTodosResidente);
            List<HistorialDatos> listaHistorial = new List<HistorialDatos>();
            if (resultado.Rows.Count == 0)
            {
                return listaHistorial;
            }
            foreach (DataRow fila in resultado.Rows)
            {
                HistorialDatos historial = new HistorialDatos()
                {
                    idHistorial = Convert.ToInt32(fila["id_historial"]),
                    fecha_entrada = Convert.ToDateTime(fila["fecha_entrada"]),
                    fecha_salida = Convert.ToDateTime(fila["fecha_salida"]),
                    id_invitado = 0, // No hay invitado en este caso
                    id_usuario = Convert.ToInt32(fila["id_usuario"])
                };
                listaHistorial.Add(historial);
            }
            return listaHistorial;
        }

        public HistorialDatos VerificarEntradaAbiertaInvitado(int id_invitado)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_invitado", id_invitado)
            };
            DataTable resultado = ExecuteReaderParametros(queryVerificarEntradaAbiertaInvitado);
            if (resultado.Rows.Count == 0)
            {
                return null;
            }
            DataRow fila = resultado.Rows[0];
            return new HistorialDatos()
            {
                idHistorial = Convert.ToInt32(fila["id_historial"]),
                fecha_entrada = Convert.ToDateTime(fila["fecha_entrada"]),
                fecha_salida = fila["fecha_salida"] != DBNull.Value ? Convert.ToDateTime(fila["fecha_salida"]) : DateTime.MinValue,
                id_invitado = Convert.ToInt32(fila["id_invitado"]),
                id_usuario = 0 // No hay usuario en este caso
            };
        }

        public HistorialDatos VerificarEntradaAbiertaResidente(int id_residente)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", id_residente)
            };
            DataTable resultado = ExecuteReaderParametros(queryVerificarEntradaAbiertaResidente);
            if (resultado.Rows.Count == 0)
            {
                return null;
            }
            DataRow fila = resultado.Rows[0];
            return new HistorialDatos()
            {
                idHistorial = Convert.ToInt32(fila["id_historial"]),
                fecha_entrada = Convert.ToDateTime(fila["fecha_entrada"]),
                fecha_salida = fila["fecha_salida"] != DBNull.Value ? Convert.ToDateTime(fila["fecha_salida"]) : DateTime.MinValue,
                id_invitado = 0, // No hay invitado en este caso
                id_usuario = Convert.ToInt32(fila["id_usuario"])
            };

        }
    }
}
