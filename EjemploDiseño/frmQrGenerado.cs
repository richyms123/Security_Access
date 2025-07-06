using CapaComun;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDiseño
{
    public partial class frmQrGenerado : Form
    {
        public frmQrGenerado()
        {
            InitializeComponent();
        }

        private void frmQrGenerado_Load(object sender, EventArgs e)
        {
            if (UsuarioSesion.IdUsuario!=0)
            {
                try
                {
                    string contenidQr = $"RES/{UsuarioSesion.IdUsuario}";
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();

                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(contenidQr, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    using (Bitmap bitmap = qrCode.GetGraphic(20))
                    {
                        pictureBoxQr.Image = new Bitmap(bitmap);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el código QR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
