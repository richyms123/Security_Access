using CapaComun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDiseño.Controles
{
    public partial class ctlUsuario : UserControl
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
        private string telefono;
        private byte[] imagen;
        private DateTime fechaRegistro;

        public ctlUsuario()
        {
            InitializeComponent();
            ttMensaje.SetToolTip(btnEditar, "Editar Usuario");
            ttMensaje.SetToolTip(btnEliminar, "Eliminar Usuario");
            ttMensaje.SetToolTip(btnVerQR, "Ver QR del Usuario");
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreCompleto { get=>lblNombreCompleto.Text; set => lblNombreCompleto.Text = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public string Calle { get => calle; set => calle = value; }
        public string CorreoElectronico { get => lblCorreo.Text; set => lblCorreo.Text = value; }
        public string Telefono { get => lblTelefono.Text; set => lblTelefono.Text = value; }

        public string DomicilioCompleto { get =>lblDomicilio.Text; set => lblDomicilio.Text = value; }
        public DateTime FechaRegistro
        {
            get => Convert.ToDateTime(lblFechaRegistro.Text);
            set => lblFechaRegistro.Text = value.ToString("yyyy-MM-dd");
        }
        public System.Drawing.Image ImagenUsuario { get => pictureUsuario.Image; set => pictureUsuario.Image = value; }



        private byte[] ConvertirImg()
        {
            ImageConverter img = new ImageConverter();
            byte[] bytes = (byte[])img.ConvertTo(new Bitmap(this.ImagenUsuario), typeof(byte[]));
            return bytes;
        }

        public void LlenarUsuarios()
        {
            UsuarioSesion.Usuario = this.Usuario;
            UsuarioSesion.IdUsuario = this.IdUsuario;
            UsuarioSesion.Nombre = this.Nombre;
            UsuarioSesion.ApellidoMaterno = this.ApellidoMaterno;
            UsuarioSesion.ApellidoPaterno = this.ApellidoPaterno;
            UsuarioSesion.NumeroCasa = this.NumeroCasa;
            UsuarioSesion.Calle = this.Calle;
            UsuarioSesion.CorreoElectronico = this.CorreoElectronico;
            UsuarioSesion.Telefono = this.Telefono;
            UsuarioSesion.Imagen = this.ConvertirImg();
            UsuarioSesion.FechaRegistro = this.FechaRegistro;
            UsuarioSesion.Contrasena = this.Contrasena;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LlenarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LlenarUsuarios();
        }

        private void btnVerQR_Click(object sender, EventArgs e)
        {
            LlenarUsuarios();
        }
    }
}
