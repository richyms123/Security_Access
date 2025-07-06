using AForge.Video;
using AForge.Video.DirectShow;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using TheArtOfDev.HtmlRenderer.Adapters;
using ZXing;

namespace EjemploDiseño
{
    public partial class frmInicio : Form
    {
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice camara;
        private Timer temporizador;
        bool esInvitado = false;

        private UsuarioDominio usuarioActual = new UsuarioDominio();
        private UsuarioDominio usuarioConInvitado = new UsuarioDominio();
        private InvitadoDominio invitadoActual = new InvitadoDominio();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIniciarScanner_Click(object sender, EventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                MessageBox.Show("La cámara ya está en uso.");
                return;
            }
            try
            {
                dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (dispositivosDeVideo.Count > 0)
                {
                    camara = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                    camara.NewFrame += new NewFrameEventHandler(Capturar);
                    camara.Start();

                    temporizador = new Timer();
                    temporizador.Interval = 500;
                    temporizador.Tick += ProcesarQR;
                    temporizador.Start();
                }
                else
                {
                    MessageBox.Show("No se detectó ninguna cámara.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar la cámara: " + ex.Message);
            }

        }
        private void Capturar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBoxCamara.Image = bitmap;
        }

        private void ProcesarQR(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxCamara.Image != null)
                {
                    using (Bitmap img = new Bitmap(pictureBoxCamara.Image))
                    {
                        BarcodeReader lector = new BarcodeReader();
                        var resultado = lector.Decode(img);
                        if (resultado != null)
                        {
                            string textoQR = resultado.Text;
                            txtIdUsuario.Text = textoQR;
                            temporizador.Stop();
                            camara.SignalToStop();

                            ProcesarCodigoQR(textoQR);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el código QR: " + ex.Message);
            }
        }

        private void ProcesarCodigoQR(string codigo)
        {
            if (codigo.StartsWith("RES/"))
            {
                int id = int.Parse(codigo.Split('/')[1]);
                txtIdUsuario.Text = id.ToString();
                btnConsultar.Enabled = true;
            }
            else if (codigo.StartsWith("INV/"))
            {
                int idInvitado = int.Parse(codigo.Split('/')[1]);
                txtIdUsuario.Text = idInvitado.ToString();
                btnConsultar.Enabled = true;
                esInvitado = true;
            }
            else
            {
                MessageBox.Show("QR no válido.");
                

            }
        }

        private void btnDetenerScanner_Click(object sender, EventArgs e)
        {
            try
            {
                if (camara != null)
                {
                    if (camara.IsRunning)
                    {
                        camara.SignalToStop();
                        camara.WaitForStop();
                    }
                    camara = null;
                }

                if (temporizador != null)
                {
                    temporizador.Stop();
                    temporizador = null;
                }

                if (pictureBoxCamara.Image != null)
                {
                    pictureBoxCamara.Image.Dispose();
                    pictureBoxCamara.Image = null;
                }

                txtIdUsuario.Text = string.Empty;
                LimpiarCardUsuario();
                esInvitado = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detener el escáner: " + ex.Message);
            }
        }

        private void LimpiarCardUsuario()
        {
            pnlContenedor.Controls.Clear();
            btnRegistrarEntrada.Visible = false;
            btnRegistrarSalida.Visible = false;

        }

        private void ConsultarInvitado(int idUsuario)
        {
            if (idUsuario > 0)
            {
                invitadoActual = new InvitadoDominio().ObtenerDatosInvitadoPorId(idUsuario);

                if (invitadoActual != null && invitadoActual.IdInvitado>0)
                {
                    if (invitadoActual.FechaVigencia < DateTime.Now)
                    {
                        MessageBox.Show("El invitado ha expirado su vigencia.");
                        return;
                    }



                    usuarioConInvitado = new UsuarioDominio().ObtenerDatosUsuarioPorId(invitadoActual.IdUsuario);
                    AgregarControlInvitado(invitadoActual, usuarioConInvitado);
                    btnRegistrarEntrada.Visible = true;
                    btnRegistrarSalida.Visible = true;



                }
                else
                {
                    MessageBox.Show("No se encontró un invitado con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("ID de invitado no válido.");
            }
        }

        private void AgregarControlResidente(UsuarioDominio usuarioResidente)
        {
            pnlContenedor.Controls.Clear();
            ctlCardUsuario cardUsuario = new ctlCardUsuario
            {
                NombreCompleto = $"{usuarioResidente.Nombre} {usuarioResidente.ApellidoPaterno} {usuarioResidente.ApellidoMaterno}",
                Domicilio = $"{usuarioResidente.Calle} {usuarioResidente.NumeroCasa}",
                Telefono = usuarioResidente.Telefono,
                FotoUsuario = usuarioResidente.Imagen != null ? Image.FromStream(new MemoryStream(usuarioResidente.Imagen)) : Properties.Resources.userdefault,
                Correo = usuarioResidente.CorreoElectronico,
               Dock = DockStyle.Fill
            };
            pnlContenedor.Controls.Add(cardUsuario);

        }

        private void AgregarControlInvitado(InvitadoDominio invitado, UsuarioDominio usuarioResidente)
        {
            pnlContenedor.Controls.Clear();
            ctlCardInvitado cardInvitado = new ctlCardInvitado
            {
                NombreCompleto = $"{invitado.Nombre} {invitado.ApellidoPaterno} {invitado.ApellidoMaterno}",
                NombreResidente= $"{usuarioResidente.Nombre} {usuarioResidente.ApellidoPaterno} {usuarioResidente.ApellidoMaterno}",
                FechaVigencia = invitado.FechaVigencia.ToString("dd/MM/yyyy"),
                EstatusInvitado = invitado.Estatus,
                IdInvitado = invitado.IdInvitado,
                IdResidente = usuarioResidente.IdUsuario,
                Estatus = invitado.Estatus ? "Activo" : "Inactivo",
                Dock = DockStyle.Fill
            };
            pnlContenedor.Controls.Add(cardInvitado);
        }



        private void ConsultarResidente(int idUsuario)
        {
            if (idUsuario > 0)
            {
                 usuarioActual = new UsuarioDominio().ObtenerDatosUsuarioPorId(idUsuario);
                if (usuarioActual != null && usuarioActual.IdUsuario>0)
                {
                    AgregarControlResidente(usuarioActual);
                    btnRegistrarEntrada.Visible = true;
                    btnRegistrarSalida.Visible = true;

                }
                else
                {
                    MessageBox.Show("No se encontró un residente con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("ID de usuario no válido.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idUsuario=Convert.ToInt32(txtIdUsuario.Text);
            if(esInvitado)
            {
                ConsultarInvitado(idUsuario);
            }
            else
            {
                ConsultarResidente(idUsuario);
            }

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            LimpiarCardUsuario();
            btnRegistrarEntrada.Visible = false;
            btnRegistrarSalida.Visible = false;
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if(usuarioActual != null && usuarioActual.IdUsuario > 0)
            {
                HistorialDominio historial = new HistorialDominio();
                if (historial.VerificarEntradaAbiertaResidente(usuarioActual.IdUsuario)!=null)
                {
                    MessageBox.Show("El residente ya tiene una entrada abierta.");
                    return;
                }

                
                int resultado=historial.AgregarFechaEntradaResidente(usuarioActual.IdUsuario,DateTime.Now);
                if(resultado > 0)
                {
                    MessageBox.Show("Entrada de residente registrada correctamente.");
                    
                }
                else
                {
                    MessageBox.Show("Error al registrar la entrada del residente.");
                }
                LimpiarCardUsuario();

            }
            else if (invitadoActual != null && invitadoActual.IdInvitado > 0)
            {
                HistorialDominio historial = new HistorialDominio();
                if (historial.VerificarEntradaAbiertaInvitado(invitadoActual.IdInvitado) != null)
                {
                    MessageBox.Show("El invitado ya tiene una entrada abierta.");
                    return;
                }


                int resultado = historial.AgregarFechaEntradaInvitado(invitadoActual.IdInvitado,usuarioConInvitado.IdUsuario, DateTime.Now);
                if (resultado > 0)
                {
                    MessageBox.Show("Entrada de invitado registrada correctamente.");
                    
                }
                else
                {
                    MessageBox.Show("Error al registrar la entrada del invitado.");
                }
                LimpiarCardUsuario();
            }
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (usuarioActual != null && usuarioActual.IdUsuario > 0)
            {
                HistorialDominio historial = new HistorialDominio();
                if (historial.VerificarEntradaAbiertaResidente(usuarioActual.IdUsuario) == null)
                {
                    MessageBox.Show("No se encuentra una entrada abierta para registrar la salida.");
                    return;
                }

                int resultado = historial.AgregarFechaSalidaResidente(usuarioActual.IdUsuario, DateTime.Now);
                if (resultado > 0)
                {
                    MessageBox.Show("Salida de residente registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar la salida del residente.");
                }
            }
            else if (invitadoActual != null && invitadoActual.IdInvitado > 0)
            {
                HistorialDominio historial = new HistorialDominio();
                if (historial.VerificarEntradaAbiertaInvitado(invitadoActual.IdInvitado) == null)
                {
                    MessageBox.Show("No se encuentra una entrada abierta para registrar la salida.");
                    return;
                }

                int resultado = historial.AgregarFechaSalidaInvitado(invitadoActual.IdInvitado, DateTime.Now);
                if (resultado > 0)
                {
                    MessageBox.Show("Salida de invitado registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar la salida del invitado.");
                }
            }
            LimpiarCardUsuario();
        }
    }
}
