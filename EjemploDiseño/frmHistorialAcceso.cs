using CapaDominio;
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
    public partial class frmHistorialAcceso : Form
    {
        private List<HistorialDominio> listaHistoriales= new List<HistorialDominio>();
        private List<InvitadoDominio> listaInvitados = new List<InvitadoDominio>();
        private List<UsuarioDominio> listaUsuarios = new List<UsuarioDominio>();

        private UsuarioDominio usuarioDominio = new UsuarioDominio();
        private InvitadoDominio invitadoDominio = new InvitadoDominio();
        private HistorialDominio historialDominio = new HistorialDominio();

        private Dictionary<int, int> mapaInvitadoAResidente;

        public frmHistorialAcceso()
        {
            InitializeComponent();
        }


        private void PrepararDiccionarioInvitadores()
        {
            mapaInvitadoAResidente = listaInvitados
                .ToDictionary(i => i.IdInvitado, i => i.IdUsuario);
        }

        

        private void AplicarFiltros()
        {
            if (listaHistoriales == null) return;   

            var filtrados = listaHistoriales.AsEnumerable();

            int idResidente = Convert.ToInt32(cboResidentes.SelectedValue);
            if (idResidente != 0)
            {
                filtrados = filtrados.Where(h =>
                    h.IdUsuario == idResidente ||

                    (h.IdInvitado > 0 &&
                     mapaInvitadoAResidente.TryGetValue(h.IdInvitado, out int invitador) &&
                     invitador == idResidente));
            }


            int idInvitado = Convert.ToInt32(cboInvitados.SelectedValue);
            if (idInvitado != 0)
            {
                filtrados = filtrados.Where(h => h.IdInvitado == idInvitado);
            }

            if (cboTipoAcceso.SelectedIndex > 0)  
            {
                string tipo = cboTipoAcceso.Text;


                if (tipo == "Entrada")
                {
                    filtrados = filtrados.Where(h =>
                        h.FechaEntrada != DateTime.MinValue &&
                        h.FechaSalida == DateTime.MinValue);
                }
                else if (tipo == "Salida")
                {
                    filtrados = filtrados.Where(h =>
                        h.FechaSalida != DateTime.MinValue);
                }
            }

            DateTime desde = dtpFechaInicio.Value.Date;
            DateTime hasta = dtpFechaFin.Value.Date;

            filtrados = filtrados.Where(h =>
                (h.FechaEntrada.Date >= desde && h.FechaEntrada.Date <= hasta) ||
                (h.FechaSalida != DateTime.MinValue && h.FechaSalida.Date >= desde&&
                 h.FechaSalida.Date >= desde &&
                 h.FechaSalida.Date <= hasta));

            pnlContenedor.Controls.Clear();          
            ctlTituloHistorial ctlTituloHistorial = new ctlTituloHistorial
            {
                Dock = DockStyle.Top
            };
            pnlContenedor.Controls.Add(ctlTituloHistorial);
            ctlTituloHistorial.BringToFront();
            CargarControl(filtrados.ToList(),              
                          listaUsuarios,
                          listaInvitados);
        }



        private void CargarControl(List<HistorialDominio> listaHistoriales, List<UsuarioDominio> listaUsuarios, List<InvitadoDominio> listaInvitados)
        {
            pnlContenedor.SuspendLayout();
            

            foreach (HistorialDominio historial in listaHistoriales)
            {
                if (historial.IdInvitado == 0)
                {
                    UsuarioDominio usuario = listaUsuarios.FirstOrDefault(u => u.IdUsuario == historial.IdUsuario);
                    ctlHistorial control = new ctlHistorial
                    {
                        NombreInvitador="[Residente]",
                        Direccion="[No disponible]",
                        IdHistorial = historial.IdHistorial,
                        IdUsuario = historial.IdUsuario,
                        IdInvitado = historial.IdInvitado,
                        ImagenPersonaEntro = usuario.Imagen == null ? Properties.Resources.userdefault : Image.FromStream(new MemoryStream(usuario.Imagen)),
                        NombreCompletoInvitado = $"{usuario.Nombre} {usuario.ApellidoPaterno} {usuario.ApellidoMaterno}",
                        FechaEntrada = historial.FechaEntrada,
                        FechaSalidaTexto = historial.FechaSalida == DateTime.MinValue ? "No ha salido" : historial.FechaSalida.ToString(),
                        FechaSalida = historial.FechaSalida,
                        Dock = DockStyle.Top


                    };
                    pnlContenedor.Controls.Add(control);
                    control.BringToFront();
                }
                else if (historial.IdInvitado >0)
                {
                    InvitadoDominio invitado = listaInvitados.FirstOrDefault(i => i.IdInvitado == historial.IdInvitado);
                    UsuarioDominio usuario = listaUsuarios.FirstOrDefault(u => u.IdUsuario == invitado.IdUsuario);
                    ctlHistorial control = new ctlHistorial
                    {
                        NombreInvitador = $"{usuario.Nombre} {usuario.ApellidoPaterno} {usuario.ApellidoMaterno}",
                        Direccion = $"{usuario.Calle} {usuario.NumeroCasa}",
                        IdHistorial = historial.IdHistorial,
                        ImagenInvitador=usuario.Imagen==null ? Properties.Resources.userdefault : Image.FromStream(new MemoryStream(usuario.Imagen)),
                        IdUsuario = historial.IdUsuario,
                        IdInvitado = historial.IdInvitado,
                        NombreCompletoInvitado = $"{invitado.Nombre} {invitado.ApellidoPaterno} {invitado.ApellidoMaterno}",
                        FechaVigencia = invitado.FechaVigencia,
                        FechaEntrada = historial.FechaEntrada,
                        FechaSalidaTexto = historial.FechaSalida == DateTime.MinValue ? "No ha salido" : historial.FechaSalida.ToString(),
                        FechaSalida = historial.FechaSalida,
                        Dock = DockStyle.Top

                    };
                    pnlContenedor.Controls.Add(control);
                    control.BringToFront();
                }
            }
            pnlContenedor.ResumeLayout();
        }

        private async void LlenarHistoriales()
        {
            try
            {
                var esperarHistorial= Task.Run(() => historialDominio.ObtenerTodos());
                var esperarInvitados = Task.Run(() => invitadoDominio.ObtenerTodos());
                var esperarUsuarios = Task.Run(() => usuarioDominio.ObtenerTodos());

                await Task.WhenAll(esperarHistorial, esperarInvitados, esperarUsuarios);
                listaHistoriales = esperarHistorial.Result;
                listaInvitados = esperarInvitados.Result;
                listaUsuarios = esperarUsuarios.Result;

                
                
                if (listaHistoriales == null || !listaHistoriales.Any())
                {
                    MessageBox.Show("No se encontraron historiales de acceso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                

                CargarControl(listaHistoriales,listaUsuarios,listaInvitados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los historiales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarComboResidentes()
        {
            cboResidentes.ValueMember = "IdUsuario";
            cboResidentes.DisplayMember = "NombreCompleto";
            var listaResidentes = await Task.Run(() => new UsuarioDominio().ObtenerTodos());

            if (listaResidentes != null || listaResidentes.Any())
            {
                listaResidentes.Insert(0, new UsuarioDominio { IdUsuario = 0, NombreCompleto = "[Todos los residentes]" });
                cboResidentes.DataSource = listaResidentes;
            }
        }

        private async void CargarComboInvitados()
        {
            cboInvitados.ValueMember = "IdInvitado";
            cboInvitados.DisplayMember = "NombreCompleto";
            var listaInvitados = await Task.Run(() => invitadoDominio.ObtenerTodos());
            if (listaInvitados != null || listaInvitados.Any())
            {
                listaInvitados.Insert(0, new InvitadoDominio { IdInvitado = 0, NombreCompleto ="Todos" });
                cboInvitados.DataSource = listaInvitados;
            }
        }

        private void frmHistorialAcceso_Load(object sender, EventArgs e)
        {
            CargarComboInvitados();
            cboTipoAcceso.SelectedIndex = 0;
            CargarComboResidentes();

            LlenarHistoriales();

            PrepararDiccionarioInvitadores();
            //AplicarFiltros();
        }

        private void cboResidentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cboInvitados_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cboTipoAcceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
