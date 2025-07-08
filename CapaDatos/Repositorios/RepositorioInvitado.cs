using CapaDatos.Contratos;
using CapaDatos.ModeloDatos;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioInvitado : RepositorioMaestro, IRepositorioInvitado
    {
        private readonly string queryObtenerTodos;
        private readonly string queryObtenerDatosInvitadoPorId;
        private readonly string queryEliminarInvitadoPorIdUsuario;
        private readonly string queryEditarEstatusInvitado;

        public RepositorioInvitado()
        {
            queryObtenerTodos = "SELECT * FROM Invitados";
            queryObtenerDatosInvitadoPorId = "SELECT * FROM Invitados WHERE id_invitado=@id_invitado";
            queryEliminarInvitadoPorIdUsuario = "DELETE FROM Invitados WHERE id_usuario=@id_usuario";
            queryEditarEstatusInvitado = "UPDATE Invitados SET estatus=@estatus WHERE id_invitado=@id_invitado";
        }
        public int Agregar(InvitadoDatos entidad)
        {
            throw new NotImplementedException();
        }

        public int Editar(InvitadoDatos entidad)
        {
            throw new NotImplementedException();
        }

        public int EditarEstatusInvitado(int idInvitado, string estatus)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@estatus",estatus),
                new SqlParameter("@id_invitado",idInvitado)
            };
            return Convert.ToInt32(ExecuteScalar(queryEditarEstatusInvitado));
        }

        public int Eliminar(int id_usuario)
        {
            throw new NotImplementedException();
        }

        public int EliminarInvitadoPorIdUsuario(int idUsuario)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", idUsuario)
            };
            return ExecuteNonQuery(queryEliminarInvitadoPorIdUsuario);
        }

        public InvitadoDatos ObtenerDatosInvitadoPorId(int idInvitado)
        {
            parametrosSql= new List<SqlParameter>
            {
                new SqlParameter("@id_invitado", idInvitado)
            };
            DataTable resultado = ExecuteReaderParametros(queryObtenerDatosInvitadoPorId);
            if (resultado.Rows.Count == 0)
            {
                return null;
            }
            DataRow fila = resultado.Rows[0];
            InvitadoDatos invitado = new InvitadoDatos
            {
                idInvitado = Convert.ToInt32(fila["id_invitado"]),
                nombre = fila["nombre"].ToString(),
                apellidoPaterno = fila["apellido_paterno"].ToString(),
                apellidoMaterno = fila["apellido_materno"].ToString(),
                fechaVigencia = Convert.ToDateTime(fila["fecha_vigencia"]),
                estatus = fila["estatus"].ToString(),
                tipoInvitacion = fila["tipo_invitacion"].ToString(),
                idUsuario = Convert.ToInt32(fila["id_usuario"])
            };
            return invitado;
        }

        public IEnumerable<InvitadoDatos> ObtenerTodos()
        {
            DataTable resultado =ExecuteReader(queryObtenerTodos);
            List<InvitadoDatos> listaInvitados = new List<InvitadoDatos>();
            if(resultado.Rows.Count==0)
                {
                return listaInvitados;
            }
            foreach (DataRow fila in resultado.Rows)
            {
                InvitadoDatos invitado = new InvitadoDatos
                {
                    idInvitado = Convert.ToInt32(fila["id_invitado"]),
                    nombre = fila["nombre"].ToString(),
                    apellidoPaterno = fila["apellido_paterno"].ToString(),
                    apellidoMaterno = fila["apellido_materno"].ToString(),
                    fechaVigencia = Convert.ToDateTime(fila["fecha_vigencia"]),
                    estatus = fila["estatus"].ToString(),
                    tipoInvitacion = fila["tipo_invitacion"].ToString(),
                    idUsuario = Convert.ToInt32(fila["id_usuario"])
                };
                listaInvitados.Add(invitado);
            }
            return listaInvitados;

        
        }
    }
}
