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
    public partial class ctlCardInvitado : UserControl
    {
        public ctlCardInvitado()
        {
            InitializeComponent();
        }
        private int idInvitado;
        private int idResidente;
        private string estatus;
        public int IdInvitado
        {
            get { return idInvitado; }
            set { idInvitado = value; }
        }

        public string NombreCompleto
        {
            get { return lblNombreCompleto.Text; }
            set { lblNombreCompleto.Text = value; }
        }
        public string FechaVigencia
        {
            get { return lblFechaVigencia.Text; }
            set { lblFechaVigencia.Text = value; }
        }

        public string Estatus
        {
            get { return lblEstatus.Text; }
            set { lblEstatus.Text = value; }
        }
        public string EstatusInvitado
        {
            get { return estatus; }
            set { estatus = value;  }
        }

        public string NombreResidente
        {
            get { return lblNombreResidente.Text; }
            set { lblNombreResidente.Text = value; }
        }

        public int IdResidente
        {
            get { return idResidente; }
            set { idResidente = value; }
        }

    }
}
