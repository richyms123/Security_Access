using CapaComun;
using CapaDominio;
using CapaDominio.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDiseño
{
    public partial class frmRegistraroEditarUsuario : Form
    {
        public event EventHandler UsuarioEditado;
        public bool EsModoEdicion { get; set; }
        public int idUsuario { get; set; }
        public int idClinica { get; set; }
        private OpenFileDialog abrir;
        private UsuarioDominio usuarioDominio = new UsuarioDominio();
        public frmRegistraroEditarUsuario()
        {
            InitializeComponent();
        }

        private void btnElegirImagen_Click(object sender, EventArgs e)
        {
            abrir = new OpenFileDialog();
            abrir.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|JPEG|*.jpeg";
            System.IO.Stream mystream = null;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = abrir.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            pictureUsuario.Image = Image.FromStream(mystream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen. " + ex.Message);

                }
            }
        }

        private void frmRegistraroEditarUsuario_Load(object sender, EventArgs e)
        {
            if (EsModoEdicion)
            {
                lblTipo.Text= "Editar Usuario";
                txtNombre.Text = UsuarioSesion.Nombre;
                txtApellidoPaterno.Text = UsuarioSesion.ApellidoPaterno;
                txtApellidoMaterno.Text = UsuarioSesion.ApellidoMaterno;
                txtUsuario.Text = UsuarioSesion.Usuario;
                txtCorreo.Text = UsuarioSesion.CorreoElectronico;
                txtTelefono.Text = UsuarioSesion.Telefono;
                txtNumeroCasa.Text = UsuarioSesion.NumeroCasa;
                txtCalle.Text = UsuarioSesion.Calle;
                pictureUsuario.Image = ByteAImagen();


            }
            else
            {
                lblTipo.Text = "Registrar Usuario";
                pictureUsuario.Image = SecurityAccess.Properties.Resources.userdefault;
                
            }
        }

        private void GuardarEdicionUsuario()
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    mensaje.Show(this, "El nombre no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                else if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
                    mensaje.Show(this, "El apellido paterno no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                else if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
                    mensaje.Show(this, "El apellido materno no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                else if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                    mensaje.Show(this, "El usuario no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                else if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !EsCorreoValido(txtCorreo.Text))
                    mensaje.Show(this, "El correo electronico no es valido",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                else if (string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length < 10)
                    mensaje.Show(this, "El telefono debe tener al menos 10 digitos",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
               
                else
                {
                    usuarioDominio.IdUsuario= UsuarioSesion.IdUsuario;
                    usuarioDominio.Nombre = txtNombre.Text.Trim();
                    usuarioDominio.ApellidoPaterno = txtApellidoPaterno.Text.Trim();
                    usuarioDominio.ApellidoMaterno = txtApellidoMaterno.Text.Trim();
                    usuarioDominio.Usuario = txtUsuario.Text.Trim();
                    usuarioDominio.Contrasena = txtContrasena.Text.Trim();
                    usuarioDominio.CorreoElectronico = txtCorreo.Text.Trim();
                    usuarioDominio.Telefono = txtTelefono.Text.Trim();
                    usuarioDominio.NumeroCasa = txtNumeroCasa.Text.Trim();
                    usuarioDominio.Calle = txtCalle.Text.Trim();
                    usuarioDominio.Imagen = ConvertirImg();
                    usuarioDominio.estadoEntidad = EstadoEntidad.Modificado;
                    var resultado = usuarioDominio.GuardarCambios();
                    if (resultado.Exito)
                    {
                        mensaje.Show(this, resultado.Mensaje,
                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        mensaje.Show(this, resultado.Mensaje,
                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }

        private void GuardarRegistroUsuario()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    mensaje.Show(this, "El nombre no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }
                 if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
                {
                    mensaje.Show(this, "El apellido paterno no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }

                 if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
                {
                    mensaje.Show(this, "El apellido materno no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }
                 if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    mensaje.Show(this, "El usuario no puede estar vacio",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }
                 if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !EsCorreoValido(txtCorreo.Text))
                {
                    mensaje.Show(this, "El correo electronico no es valido",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }
                 if (string.IsNullOrWhiteSpace(txtTelefono.Text) || txtTelefono.Text.Length < 10)
                {
                    mensaje.Show(this, "El telefono debe tener al menos 10 digitos",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }
                 if (string.IsNullOrWhiteSpace(txtContrasena.Text) || txtContrasena.Text.Length < 6)
                {
                    mensaje.Show(this, "La contraseña debe tener al menos 6 caracteres",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }
                 if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    mensaje.Show(this, "Las contraseñas no coinciden",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    return;
                }

                usuarioDominio.Nombre = txtNombre.Text.Trim();
                usuarioDominio.ApellidoPaterno = txtApellidoPaterno.Text.Trim();
                usuarioDominio.ApellidoMaterno = txtApellidoMaterno.Text.Trim();
                usuarioDominio.Usuario = txtUsuario.Text.Trim();
                usuarioDominio.Contrasena= txtContrasena.Text.Trim();
                usuarioDominio.CorreoElectronico = txtCorreo.Text.Trim();
                usuarioDominio.Telefono = txtTelefono.Text.Trim();
                usuarioDominio.NumeroCasa = txtNumeroCasa.Text.Trim();
                usuarioDominio.Calle = txtCalle.Text.Trim();
                usuarioDominio.Imagen = ConvertirImg();
                usuarioDominio.estadoEntidad = EstadoEntidad.Agregado;
                var resultado = usuarioDominio.GuardarCambios();
                if (resultado.Exito)
                {
                    
                    mensaje.Show(this, resultado.Mensaje,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    mensaje.Show(this, resultado.Mensaje,
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 4000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
        }

        private byte[] ConvertirImg()
        {
            ImageConverter img = new ImageConverter();
            byte[] bytes = (byte[])img.ConvertTo(new Bitmap(pictureUsuario.Image), typeof(byte[]));
            return bytes;
        }

        private Image ByteAImagen()
        {
            MemoryStream ms = new MemoryStream(UsuarioSesion.Imagen);
            Bitmap bm = null;
            bm = new Bitmap(ms);
            return bm;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if(EsModoEdicion)
            {
                GuardarEdicionUsuario();
            }
            else
            {
                GuardarRegistroUsuario();
            }
        }

        public bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            TextBox txt = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && txt.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
