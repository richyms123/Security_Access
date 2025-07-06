using CapaComun;
using CapaDominio;
using CapaDominio.Objetos;
using EjemploDiseño.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDiseño
{
    public partial class frmGestionResidentes : Form
    {
        private List<UsuarioDominio> listaUsuarios;
        private UsuarioDominio usuarioDominio= new UsuarioDominio();
        private HistorialDominio historialDominio = new HistorialDominio();
        private InvitadoDominio invitadoDominio = new InvitadoDominio();
        private Timer timerRetraso;
        public frmGestionResidentes()
        {
            InitializeComponent();
        }

        private void CargarControl(List<UsuarioDominio> listaUsuarios)
        {
            
            foreach (UsuarioDominio usuario in listaUsuarios)
            {
                Image imagenUsuario;
                if (usuario.Imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(usuario.Imagen))
                    {
                        imagenUsuario = Image.FromStream(ms);
                    }
                }
                else
                {
                    imagenUsuario = Properties.Resources.userdefault;
                }
                ctlUsuario ctl = new ctlUsuario
                {
                    IdUsuario = usuario.IdUsuario,
                    Nombre = usuario.Nombre,
                    ApellidoMaterno = usuario.ApellidoMaterno,
                    ApellidoPaterno = usuario.ApellidoPaterno,
                    NombreCompleto = $"{usuario.Nombre} {usuario.ApellidoPaterno} {usuario.ApellidoMaterno}",
                    DomicilioCompleto = $"{usuario.Calle} {usuario.NumeroCasa}",
                    Usuario = usuario.Usuario,
                    Contrasena = usuario.Contrasena,
                    NumeroCasa = usuario.NumeroCasa,
                    Calle = usuario.Calle,
                    CorreoElectronico = usuario.CorreoElectronico,
                    Telefono = usuario.Telefono,
                    FechaRegistro = usuario.FechaRegistro,
                    ImagenUsuario = imagenUsuario,
                    Dock = DockStyle.Top,
                };
                ctl.btnEditar.Click += btnEditar_Click;
                ctl.btnVerQR.Click += btnVerQR_Click;
                ctl.btnEliminar.Click += btnEliminar_Click;
                pnlContenedor.Controls.Add(ctl);
                ctl.BringToFront();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                usuarioDominio.IdUsuario = UsuarioSesion.IdUsuario;
                usuarioDominio.estadoEntidad = EstadoEntidad.Eliminado;
                int resultado2=historialDominio.EliminarHistorialPorIdUsuario(UsuarioSesion.IdUsuario);
                int resltado3 = invitadoDominio.EliminarInvitadoPorIdUsuario(UsuarioSesion.IdUsuario);
                int resultado = usuarioDominio.Eliminar(UsuarioSesion.IdUsuario);
                if (resultado>0)
                {
                    
                    var control = pnlContenedor.Controls.OfType<ctlUsuario>().FirstOrDefault(c => c.IdUsuario == UsuarioSesion.IdUsuario);
                    if (control != null)
                    {
                        listaUsuarios.RemoveAt(listaUsuarios.FindIndex(u => u.IdUsuario == UsuarioSesion.IdUsuario));
                        pnlContenedor.Controls.Remove(control);
                        control.Dispose();
                        pnlContenedor.Refresh();
                    }
                }
                MessageBox.Show("Usuario eliminado exitosamente");
                    
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error hermanito");
            }
        }

        private void btnVerQR_Click(object sender, EventArgs e)
        {
            frmQrGenerado frm = new frmQrGenerado();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (frmRegistraroEditarUsuario frm = new frmRegistraroEditarUsuario())
            {
                frm.EsModoEdicion = true;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ActualizarControlUsuario();
                    
                }
            }
        }

        private void ActualizarControlUsuario()
        {
            var control=pnlContenedor.Controls.OfType<ctlUsuario>().FirstOrDefault(c => c.IdUsuario == UsuarioSesion.IdUsuario);
            if (control != null)
            {
                control.Nombre = UsuarioSesion.Nombre;
                control.ApellidoMaterno = UsuarioSesion.ApellidoMaterno;
                control.ApellidoPaterno = UsuarioSesion.ApellidoPaterno;
                control.NombreCompleto = $"{UsuarioSesion.Nombre} {UsuarioSesion.ApellidoPaterno} {UsuarioSesion.ApellidoMaterno}";
                control.DomicilioCompleto = $"{UsuarioSesion.Calle} {UsuarioSesion.NumeroCasa}";
                control.Usuario = UsuarioSesion.Usuario;
                control.Contrasena = UsuarioSesion.Contrasena;
                control.NumeroCasa = UsuarioSesion.NumeroCasa;
                control.Calle = UsuarioSesion.Calle;
                control.CorreoElectronico = UsuarioSesion.CorreoElectronico;
                control.Telefono = UsuarioSesion.Telefono;
                control.FechaRegistro = DateTime.Now;
                control.ImagenUsuario = ByteAImagen();
                control.Refresh();
            }
        }

        private void RegistrarControlUsuario()
        {
            var usuarioAgregado = usuarioDominio.ObtenerDatosUsuarioPorId(UsuarioSesion.IdUsuario);
            if(usuarioAgregado == null)
            {
                MessageBox.Show("No se pudo agregar la interfaz.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            listaUsuarios.Add(usuarioAgregado);
              
            ctlUsuario control = new ctlUsuario
            {
                IdUsuario = usuarioAgregado.IdUsuario,
                Nombre = usuarioAgregado.Nombre,
                ApellidoMaterno = usuarioAgregado.ApellidoMaterno,
                ApellidoPaterno = usuarioAgregado.ApellidoPaterno,
                NombreCompleto = $"{usuarioAgregado.Nombre} {usuarioAgregado.ApellidoPaterno} {usuarioAgregado.ApellidoMaterno}",
                DomicilioCompleto = $"{usuarioAgregado.Calle} {usuarioAgregado.NumeroCasa}",
                Usuario = usuarioAgregado.Usuario,
                Contrasena = usuarioAgregado.Contrasena,
                NumeroCasa = usuarioAgregado.NumeroCasa,
                Calle = usuarioAgregado.Calle,
                CorreoElectronico = usuarioAgregado.CorreoElectronico,
                Telefono = usuarioAgregado.Telefono,
                FechaRegistro = usuarioAgregado.FechaRegistro,
                ImagenUsuario = ByteAImagen(),
                Dock = DockStyle.Top
            };
            control.btnEditar.Click += btnEditar_Click;
            control.btnVerQR.Click += btnVerQR_Click;
            pnlContenedor.Controls.Add(control);
            control.BringToFront();
        }

        private async void LlenarUsuarios()
        {
            try
            {
                listaUsuarios = await Task.Run(() => usuarioDominio.ObtenerTodos());
                if (listaUsuarios != null && listaUsuarios.Count > 0)
                {
                    CargarControl(listaUsuarios);
                }
                else
                {
                    MessageBox.Show("No se encontraron residentes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los residentes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BuscarUsuario()
        {
            var lista= await Task.Run(() =>usuarioDominio.BuscarPorFiltro(txtBuscar.Text.Trim()));
            List<UsuarioDominio> listaUsuariosFiltrada = lista.ToList();
            if(listaUsuariosFiltrada != null && listaUsuariosFiltrada.Count > 0)
            {
                pnlContenedor.Controls.Clear();
                CargarControl(listaUsuariosFiltrada);
            }
            
        }
        private Image ByteAImagen()
        {
            MemoryStream ms = new MemoryStream(UsuarioSesion.Imagen);
            Bitmap bm = null;
            bm = new Bitmap(ms);
            return bm;

        }

        private void frmGestionResidentes_Load(object sender, EventArgs e)
        {
             LlenarUsuarios();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            using(frmRegistraroEditarUsuario frm = new frmRegistraroEditarUsuario())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    RegistrarControlUsuario();
                    
                }
            }
        }

        private  void txtBuscar_TextChange(object sender, EventArgs e)
        {
            if (timerRetraso != null)
            {
                timerRetraso.Stop();
                timerRetraso.Dispose();
            }


            timerRetraso = new Timer();
            timerRetraso.Interval = 300;
            timerRetraso.Tick += (s, args) =>
            {
                timerRetraso.Stop();
                timerRetraso.Dispose();

                if (string.IsNullOrEmpty(txtBuscar.Text))
                {
                    pnlContenedor.Controls.Clear();
                    LlenarUsuarios();
                   
                }
                else
                {
                    BuscarUsuario();
                }
            };

            timerRetraso.Start();
        }
    }
}
