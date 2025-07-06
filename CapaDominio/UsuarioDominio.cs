using CapaComun;
using CapaDatos.Contratos;
using CapaDatos.ModeloDatos;
using CapaDatos.Repositorios;
using CapaDominio.Objetos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio
{
    public class UsuarioDominio
    {
        private int idUsuario;
        private string nombre;
        private string apellidoMaterno;
        private string apellidoPaterno;
        private string usuario;
        private string contrasena;
        private string numeroCasa;
        private string calle;
        private string correoElectronico;
        private string nombreCompleto;
        private string telefono;
        private byte[] imagen;
        private DateTime fechaRegistro;

        private List<UsuarioDominio> listaUsuarios;
        private UsuarioDominio usuarioDominio;
        private IRepositorioUsuario iRepositorioUsuario;
        public EstadoEntidad estadoEntidad;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public string Calle { get => calle; set => calle = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {ApellidoPaterno} {ApellidoMaterno}";
            }
            set
            {
                nombreCompleto = value;
            }
        }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }

        public UsuarioDominio()
        {
            iRepositorioUsuario = new RepositorioUsuario();
        }

        public OperacionResultado GuardarCambios()
        {
            var operacionResultado = new OperacionResultado();
            try
            {
                int resultado = 0;
                UsuarioDatos usuarioDatos = new UsuarioDatos
                {
                    idUsuario = this.IdUsuario,
                    nombre = this.Nombre,
                    apellidoMaterno = this.ApellidoMaterno,
                    apellidoPaterno = this.ApellidoPaterno,
                    usuario = this.Usuario,
                    contrasena = EncriptarContrasena(this.contrasena),
                    numeroCasa = this.NumeroCasa,
                    calle = this.Calle,
                    correoElectronico = this.CorreoElectronico,
                    telefono = this.Telefono,
                    imagen = this.Imagen,
                    fechaRegistro = this.FechaRegistro
                };
                switch(estadoEntidad){
                    case EstadoEntidad.Agregado:
                        resultado = operacionResultado.idGenerado = iRepositorioUsuario.Agregar(usuarioDatos);
                        if (resultado > 0)
                        {
                            UsuarioSesion.IdUsuario = resultado;
                            UsuarioSesion.Nombre = this.Nombre;
                            UsuarioSesion.ApellidoMaterno = this.ApellidoMaterno;
                            UsuarioSesion.ApellidoPaterno = this.ApellidoPaterno;
                            UsuarioSesion.Usuario = this.Usuario;
                            UsuarioSesion.Contrasena = this.Contrasena;
                            UsuarioSesion.NumeroCasa = this.NumeroCasa;
                            UsuarioSesion.Calle = this.Calle;
                            UsuarioSesion.CorreoElectronico = this.CorreoElectronico;
                            UsuarioSesion.Telefono = this.Telefono;
                            UsuarioSesion.Imagen = this.Imagen;
                            UsuarioSesion.FechaRegistro = this.FechaRegistro;
                            
                            operacionResultado.Exito = true;
                            operacionResultado.Mensaje = "Usuario agregado correctamente.";
                        }
                        else
                        {
                            operacionResultado.Exito = false;
                            operacionResultado.Mensaje = "Error al agregar el usuario.";
                        }
                        break;
                    case EstadoEntidad.Modificado:
                        resultado = iRepositorioUsuario.Editar(usuarioDatos);
                        if (resultado > 0)
                        {
                            UsuarioSesion.IdUsuario = this.IdUsuario;
                            UsuarioSesion.Nombre = this.Nombre;
                            UsuarioSesion.ApellidoMaterno = this.ApellidoMaterno;
                            UsuarioSesion.ApellidoPaterno = this.ApellidoPaterno;
                            UsuarioSesion.Usuario = this.Usuario;
                            UsuarioSesion.Contrasena = this.Contrasena;
                            UsuarioSesion.NumeroCasa = this.NumeroCasa;
                            UsuarioSesion.Calle = this.Calle;
                            UsuarioSesion.CorreoElectronico = this.CorreoElectronico;
                            UsuarioSesion.Telefono = this.Telefono;
                            UsuarioSesion.Imagen = this.Imagen;
                            UsuarioSesion.FechaRegistro = this.FechaRegistro;
                            operacionResultado.Exito = true;
                            operacionResultado.Mensaje = "Usuario modificado correctamente.";
                        }
                        else
                        {
                            operacionResultado.Exito = false;
                            operacionResultado.Mensaje = "Error al modificar el usuario.";
                        }
                        break;
                    case EstadoEntidad.Eliminado:
                        resultado = iRepositorioUsuario.Eliminar(this.IdUsuario);
                        if (resultado > 0)
                        {
                            operacionResultado.Exito = true;
                            operacionResultado.Mensaje = "Usuario eliminado correctamente.";
                        }
                        else
                        {
                            operacionResultado.Exito = false;
                            operacionResultado.Mensaje = "Error al eliminar el usuario.";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                operacionResultado.Exito = false;
                operacionResultado.Mensaje = ex.Message;
            }
            return operacionResultado;

        }

        public int Eliminar(int idUsuario)
        {
            int resultado = iRepositorioUsuario.Eliminar(idUsuario);
            if (resultado > 0)
            {
                return resultado;
            }
            return 0;
        }



        public List<UsuarioDominio> ObtenerTodos()
        {
            listaUsuarios = new List<UsuarioDominio>();
            IEnumerable<UsuarioDatos> usuariosDatos = iRepositorioUsuario.ObtenerTodos();
            if (usuariosDatos==null)
            {
                return null;
            }
            foreach (var usuario in usuariosDatos)
            {
                UsuarioDominio usuarioDominio = new UsuarioDominio
                {
                    IdUsuario = usuario.idUsuario,
                    Nombre = usuario.nombre,
                    ApellidoMaterno = usuario.apellidoMaterno,
                    ApellidoPaterno = usuario.apellidoPaterno,
                    Usuario = usuario.usuario,
                    Contrasena = usuario.contrasena,
                    NumeroCasa = usuario.numeroCasa,
                    Calle = usuario.calle,
                    CorreoElectronico = usuario.correoElectronico,
                    Telefono = usuario.telefono,
                    Imagen = usuario.imagen,
                    FechaRegistro = usuario.fechaRegistro
                };
                listaUsuarios.Add(usuarioDominio);
            }
            return listaUsuarios;
        }

        public int EliminarHistorialPorIdUsuario(int idUsuario)
        {
            int resultado = iRepositorioUsuario.Eliminar(idUsuario);
            if (resultado > 0)
            {
                return resultado;
            }
            return 0;
        }

        public UsuarioDominio ObtenerDatosUsuarioPorId(int idUsuario)
        {
            UsuarioDatos usuarioDatos = iRepositorioUsuario.ObtenerDatosUsuarioPorId(idUsuario);
            if (usuarioDatos == null)
            {
                return null;
            }
            usuarioDominio = new UsuarioDominio
            {
                IdUsuario = usuarioDatos.idUsuario,
                Nombre = usuarioDatos.nombre,
                ApellidoMaterno = usuarioDatos.apellidoMaterno,
                ApellidoPaterno = usuarioDatos.apellidoPaterno,
                Usuario = usuarioDatos.usuario,
                Contrasena = usuarioDatos.contrasena,
                NumeroCasa = usuarioDatos.numeroCasa,
                Calle = usuarioDatos.calle,
                CorreoElectronico = usuarioDatos.correoElectronico,
                Telefono = usuarioDatos.telefono,
                Imagen = usuarioDatos.imagen,
                FechaRegistro = usuarioDatos.fechaRegistro
            };
            return usuarioDominio;
        }

        public string EncriptarContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(contrasena);

                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }

                return hashString.ToString();
            }
        }

        public bool VerificarContrasena(string contrasenaUsuario, string contrasenaEncriptada)
        {
            string inputHash = EncriptarContrasena(contrasenaUsuario);

            return inputHash.Equals(contrasenaEncriptada, StringComparison.OrdinalIgnoreCase);
        }

        public IEnumerable<UsuarioDominio> BuscarPorFiltro(string filtro)
        {
            string filtroLower = filtro.ToLower();
            var usuariosFiltrados = listaUsuarios.Where(u => u.Nombre.ToLower().Contains(filtroLower) ||
                                                           u.calle.ToLower().Contains(filtroLower));
            return usuariosFiltrados;
        }

    }
}
