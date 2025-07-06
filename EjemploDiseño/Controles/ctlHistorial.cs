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
    public partial class ctlHistorial : UserControl
    {
        private int idHistorial;
        private int idUsuario;
        private int idInvitado;
        private DateTime fechaSalida;
        public ctlHistorial()
        {
            InitializeComponent();
        }
        public int IdHistorial
        {
            get { return idHistorial; }
            set { idHistorial = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public int IdInvitado
        {
            get { return idInvitado; }
            set { idInvitado = value; }
        }
        public string NombreCompletoInvitado
        {
            get { return lblNombreInvitado.Text; }
            set { lblNombreInvitado.Text = value; }
        }
        public DateTime FechaEntrada
        {
            get { return Convert.ToDateTime( lblFechaEntrada.Text); }
            set { lblFechaEntrada.Text = value.ToString(); }
        }

        public string FechaSalidaTexto
        {
            get { return lblFechaSalida.Text; }
            set { lblFechaSalida.Text = value; }
        }

        public DateTime FechaSalida
        {
            get { return fechaSalida; }
            set { fechaSalida = value;}
        }

        public string NombreInvitador
        {
            get { return lblNombreInvitador.Text; }
            set { lblNombreInvitador.Text = value; }
        }
        public string Direccion
        {
            get { return lblDireccionInvitador.Text; }
            set { lblDireccionInvitador.Text = value; }
        }

        public DateTime FechaVigencia
        {
            get { return Convert.ToDateTime(lblFechaVigencia.Text); }
            set { lblFechaVigencia.Text = value.ToString(); }
        }

        public System.Drawing.Image ImagenInvitador { get => pictureInvitador.Image; set => pictureInvitador.Image = value; }

        public Image ImagenPersonaEntro { get => pictureEntro.Image; set => pictureEntro.Image = value; }



        private byte[] ConvertirImg()
        {
            ImageConverter img = new ImageConverter();
            byte[] bytes = (byte[])img.ConvertTo(new Bitmap(this.ImagenInvitador), typeof(byte[]));
            return bytes;
        }

        private void lblNombreInvitador_Click(object sender, EventArgs e)
        {

        }
    }
}
