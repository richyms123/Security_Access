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
    public partial class frmMenu : Form
    {
        Form ActiveForm;
        public frmMenu()
        {
            InitializeComponent();
        }

        public void AbrirFormHijo(Form ChildForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(ChildForm);
            pnlContenedor.Tag = ChildForm;
            ChildForm.BringToFront();

            ChildForm.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmInicio());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmGestionResidentes());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmHistorialAcceso());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmInicio());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
