using CapaDatos.Contratos;
using CapaDatos.ModeloDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioUsuario : RepositorioMaestro, IRepositorioUsuario
    {
        private readonly string queryAgregar;
        private readonly string queryEditar;
        private readonly string queryEliminar;
        private readonly string queryObtenerTodos;
        private readonly string queryIniciarSesion;
        private readonly string queryObtenerDatosUsuarioPorId;

        public RepositorioUsuario()
        {
            queryAgregar = "INSERT INTO Usuarios(nombre,apellido_materno,apellido_paterno,usuario,password,numero_casa,calle,correo,telefono,imagen) " +
                "OUTPUT INSERTED.id_usuario VALUES(@nombre,@apellido_materno,@apellido_paterno,@usuario,@password,@numero_casa,@calle,@correo,@telefono,@imagen) ";
            queryEditar = "UPDATE Usuarios SET nombre=@nombre,apellido_materno=@apellido_materno,apellido_paterno=@apellido_paterno, " +
                "usuario=@usuario,numero_casa=@numero_casa,calle=@calle,correo=@correo,telefono=@telefono, imagen=@imagen " +
                "WHERE id_usuario=@id_usuario";
            queryEliminar = "DELETE FROM Usuarios WHERE id_usuario=@id_usuario";
            queryObtenerTodos = "SELECT * FROM Usuarios";
            queryIniciarSesion = "SELECT * FROM Usuarios WHERE (usuario=@usuario OR correo = @usuario)";
            queryObtenerDatosUsuarioPorId="SELECT * FROM Usuarios WHERE id_usuario=@id_usuario";
        }

        public int Agregar(UsuarioDatos entidad)
        {
            parametrosSql= new List<SqlParameter>
            {
                new SqlParameter("@nombre", entidad.nombre),
                new SqlParameter("@apellido_materno", entidad.apellidoMaterno),
                new SqlParameter("@apellido_paterno", entidad.apellidoPaterno),
                new SqlParameter("@usuario", entidad.usuario),
                new SqlParameter("@password", entidad.contrasena),
                new SqlParameter("@numero_casa", entidad.numeroCasa),
                new SqlParameter("@calle", entidad.calle),
                new SqlParameter("@correo", entidad.correoElectronico),
                new SqlParameter("@telefono", entidad.telefono),
                new SqlParameter("@imagen", entidad.imagen ?? (object)DBNull.Value)
            };
            return Convert.ToInt32(ExecuteScalar(queryAgregar));


        }

        public int Editar(UsuarioDatos entidad)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", entidad.idUsuario),
                new SqlParameter("@nombre", entidad.nombre),
                new SqlParameter("@apellido_materno", entidad.apellidoMaterno),
                new SqlParameter("@apellido_paterno", entidad.apellidoPaterno),
                new SqlParameter("@usuario", entidad.usuario),
                new SqlParameter("@numero_casa", entidad.numeroCasa),
                new SqlParameter("@calle", entidad.calle),
                new SqlParameter("@correo", entidad.correoElectronico),
                new SqlParameter("@telefono", entidad.telefono),
                new SqlParameter("@imagen", entidad.imagen ?? (object)DBNull.Value)
            };
            return ExecuteNonQuery(queryEditar);
        }

        public int Eliminar(int id_usuario)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", id_usuario)
            };
            return ExecuteNonQuery(queryEliminar);
        }

        public UsuarioDatos IniciarSesion(string usuario)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@usuario", usuario)
            };
            DataTable resultado = ExecuteReaderParametros(queryIniciarSesion);
            UsuarioDatos usuarioDatos = new UsuarioDatos();
            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                usuarioDatos.idUsuario = Convert.ToInt32(fila["id_usuario"]);
                usuarioDatos.nombre = fila["nombre"].ToString();
                usuarioDatos.apellidoMaterno = fila["apellido_materno"].ToString();
                usuarioDatos.apellidoPaterno = fila["apellido_paterno"].ToString();
                usuarioDatos.usuario = fila["usuario"].ToString();
                usuarioDatos.contrasena = fila["password"].ToString();
                usuarioDatos.numeroCasa = fila["numero_casa"].ToString();
                usuarioDatos.calle = fila["calle"].ToString();
                usuarioDatos.correoElectronico = fila["correo"].ToString();
                usuarioDatos.telefono = fila["telefono"].ToString();
                usuarioDatos.fechaRegistro = Convert.ToDateTime(fila["fecha_registro"]);
                if(fila["imagen"] != DBNull.Value)
                {
                    usuarioDatos.imagen = (byte[])fila["imagen"];
                }
            }
            return usuarioDatos;
        }

        public UsuarioDatos ObtenerDatosUsuarioPorId(int idUsuario)
        {
            parametrosSql = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", idUsuario)
            };
            DataTable resultado = ExecuteReaderParametros(queryObtenerDatosUsuarioPorId);
            UsuarioDatos usuarioDatos = new UsuarioDatos();
            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                usuarioDatos.idUsuario = Convert.ToInt32(fila["id_usuario"]);
                usuarioDatos.nombre = fila["nombre"].ToString();
                usuarioDatos.apellidoMaterno = fila["apellido_materno"].ToString();
                usuarioDatos.apellidoPaterno = fila["apellido_paterno"].ToString();
                usuarioDatos.usuario = fila["usuario"].ToString();
                usuarioDatos.contrasena = fila["password"].ToString();
                usuarioDatos.numeroCasa = fila["numero_casa"].ToString();
                usuarioDatos.calle = fila["calle"].ToString();
                usuarioDatos.correoElectronico = fila["correo"].ToString();
                usuarioDatos.telefono = fila["telefono"].ToString();
                usuarioDatos.fechaRegistro = Convert.ToDateTime(fila["fecha_registro"]);
                if (fila["imagen"] != DBNull.Value)
                {
                    usuarioDatos.imagen = (byte[])fila["imagen"];
                }
            }
            return usuarioDatos;
        }

        public IEnumerable<UsuarioDatos> ObtenerTodos()
        {
            DataTable resultado = ExecuteReader(queryObtenerTodos);
            List<UsuarioDatos> listaUsuarios = new List<UsuarioDatos>();
            if(resultado.Rows.Count==0)
            {
                return listaUsuarios;
            }
            foreach (DataRow fila in resultado.Rows)
            {
                UsuarioDatos usuarioDatos = new UsuarioDatos
                {
                    idUsuario = Convert.ToInt32(fila["id_usuario"]),
                    nombre = fila["nombre"].ToString(),
                    apellidoMaterno = fila["apellido_materno"].ToString(),
                    apellidoPaterno = fila["apellido_paterno"].ToString(),
                    usuario = fila["usuario"].ToString(),
                    contrasena = fila["password"].ToString(),
                    numeroCasa = fila["numero_casa"].ToString(),
                    calle = fila["calle"].ToString(),
                    correoElectronico = fila["correo"].ToString(),
                    telefono = fila["telefono"].ToString(),
                    fechaRegistro = Convert.ToDateTime(fila["fecha_registro"]),
                };
                if (fila["imagen"] != DBNull.Value)
                {
                    usuarioDatos.imagen = (byte[])fila["imagen"];
                }
                listaUsuarios.Add(usuarioDatos);
            }
            return listaUsuarios;
        }
    }
}
