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
    public partial class ctlCardUsuario : UserControl
    {
        public ctlCardUsuario()
        {
            InitializeComponent();
        }

        public string NombreCompleto
        {
            get { return lblNombreCompleto.Text; }
            set { lblNombreCompleto.Text = value; }
        }

        public string Correo 
        {
            get { return lblCorreo.Text; }
            set { lblCorreo.Text = value; }
        }
        public string Domicilio
        {
            get { return lblDomicilio.Text; }
            set { lblDomicilio.Text = value; }
        }
        public string Telefono
        {
            get { return lblTelefono.Text; }
            set { lblTelefono.Text = value; }
        }
        public Image FotoUsuario
        {
            get { return pictureUsuario.Image; }
            set { pictureUsuario.Image = value; }
        }
    }
}
