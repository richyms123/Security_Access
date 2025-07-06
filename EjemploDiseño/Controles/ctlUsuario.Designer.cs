namespace EjemploDiseño.Controles
{
    partial class ctlUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlUsuario));
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureUsuario = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVerQR = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnEliminar = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnEditar = new FontAwesome.Sharp.Material.MaterialButton();
            this.ttMensaje = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoEllipsis = true;
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(72, 16);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(228, 23);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Luis Enrique Fonseca Sosa";
            this.ttMensaje.SetToolTip(this.lblNombreCompleto, "");
            this.ttMensaje.SetToolTipIcon(this.lblNombreCompleto, null);
            this.ttMensaje.SetToolTipTitle(this.lblNombreCompleto, "");
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Location = new System.Drawing.Point(73, 41);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(155, 23);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "luis123@gmail.com";
            this.ttMensaje.SetToolTip(this.lblCorreo, "");
            this.ttMensaje.SetToolTipIcon(this.lblCorreo, null);
            this.ttMensaje.SetToolTipTitle(this.lblCorreo, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureUsuario);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.lblNombreCompleto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 81);
            this.panel1.TabIndex = 3;
            this.ttMensaje.SetToolTip(this.panel1, "");
            this.ttMensaje.SetToolTipIcon(this.panel1, null);
            this.ttMensaje.SetToolTipTitle(this.panel1, "");
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.AllowFocused = false;
            this.pictureUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUsuario.AutoSizeHeight = true;
            this.pictureUsuario.BorderRadius = 25;
            this.pictureUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.Image")));
            this.pictureUsuario.IsCircle = true;
            this.pictureUsuario.Location = new System.Drawing.Point(13, 15);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(50, 50);
            this.pictureUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario.TabIndex = 0;
            this.pictureUsuario.TabStop = false;
            this.ttMensaje.SetToolTip(this.pictureUsuario, "");
            this.ttMensaje.SetToolTipIcon(this.pictureUsuario, null);
            this.ttMensaje.SetToolTipTitle(this.pictureUsuario, "");
            this.pictureUsuario.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(354, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 81);
            this.panel2.TabIndex = 4;
            this.ttMensaje.SetToolTip(this.panel2, "");
            this.ttMensaje.SetToolTipIcon(this.panel2, null);
            this.ttMensaje.SetToolTipTitle(this.panel2, "");
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(26, 31);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(110, 23);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "4451220067";
            this.ttMensaje.SetToolTip(this.lblTelefono, "");
            this.ttMensaje.SetToolTipIcon(this.lblTelefono, null);
            this.ttMensaje.SetToolTipTitle(this.lblTelefono, "");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDomicilio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(516, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 81);
            this.panel3.TabIndex = 5;
            this.ttMensaje.SetToolTip(this.panel3, "");
            this.ttMensaje.SetToolTipIcon(this.panel3, null);
            this.ttMensaje.SetToolTipTitle(this.panel3, "");
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(31, 31);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(179, 23);
            this.lblDomicilio.TabIndex = 1;
            this.lblDomicilio.Text = "Plan de ayala No.45";
            this.ttMensaje.SetToolTip(this.lblDomicilio, "");
            this.ttMensaje.SetToolTipIcon(this.lblDomicilio, null);
            this.ttMensaje.SetToolTipTitle(this.lblDomicilio, "");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFechaRegistro);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(769, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 81);
            this.panel4.TabIndex = 6;
            this.ttMensaje.SetToolTip(this.panel4, "");
            this.ttMensaje.SetToolTipIcon(this.panel4, null);
            this.ttMensaje.SetToolTipTitle(this.panel4, "");
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(26, 31);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(106, 23);
            this.lblFechaRegistro.TabIndex = 1;
            this.lblFechaRegistro.Text = "23/03/2005";
            this.ttMensaje.SetToolTip(this.lblFechaRegistro, "");
            this.ttMensaje.SetToolTipIcon(this.lblFechaRegistro, null);
            this.ttMensaje.SetToolTipTitle(this.lblFechaRegistro, "");
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnVerQR);
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnEditar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(931, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(107, 81);
            this.panel5.TabIndex = 7;
            this.ttMensaje.SetToolTip(this.panel5, "");
            this.ttMensaje.SetToolTipIcon(this.panel5, null);
            this.ttMensaje.SetToolTipTitle(this.panel5, "");
            // 
            // btnVerQR
            // 
            this.btnVerQR.FlatAppearance.BorderSize = 0;
            this.btnVerQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerQR.IconChar = FontAwesome.Sharp.MaterialIcons.Eye;
            this.btnVerQR.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnVerQR.IconSize = 38;
            this.btnVerQR.Location = new System.Drawing.Point(42, 27);
            this.btnVerQR.Name = "btnVerQR";
            this.btnVerQR.Size = new System.Drawing.Size(30, 30);
            this.btnVerQR.TabIndex = 2;
            this.ttMensaje.SetToolTip(this.btnVerQR, "");
            this.ttMensaje.SetToolTipIcon(this.btnVerQR, null);
            this.ttMensaje.SetToolTipTitle(this.btnVerQR, "");
            this.btnVerQR.UseVisualStyleBackColor = true;
            this.btnVerQR.Click += new System.EventHandler(this.btnVerQR_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.MaterialIcons.TrashCan;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.IconSize = 38;
            this.btnEliminar.Location = new System.Drawing.Point(74, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(30, 30);
            this.btnEliminar.TabIndex = 1;
            this.ttMensaje.SetToolTip(this.btnEliminar, "");
            this.ttMensaje.SetToolTipIcon(this.btnEliminar, null);
            this.ttMensaje.SetToolTipTitle(this.btnEliminar, "");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.IconChar = FontAwesome.Sharp.MaterialIcons.PencilBoxMultiple;
            this.btnEditar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(107)))), ((int)(((byte)(198)))));
            this.btnEditar.IconSize = 38;
            this.btnEditar.Location = new System.Drawing.Point(6, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(30, 30);
            this.btnEditar.TabIndex = 0;
            this.ttMensaje.SetToolTip(this.btnEditar, "");
            this.ttMensaje.SetToolTipIcon(this.btnEditar, null);
            this.ttMensaje.SetToolTipTitle(this.btnEditar, "");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ttMensaje
            // 
            this.ttMensaje.Active = true;
            this.ttMensaje.AlignTextWithTitle = false;
            this.ttMensaje.AllowAutoClose = false;
            this.ttMensaje.AllowFading = true;
            this.ttMensaje.AutoCloseDuration = 5000;
            this.ttMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.ttMensaje.BorderColor = System.Drawing.Color.Gainsboro;
            this.ttMensaje.ClickToShowDisplayControl = false;
            this.ttMensaje.ConvertNewlinesToBreakTags = true;
            this.ttMensaje.DisplayControl = null;
            this.ttMensaje.EntryAnimationSpeed = 350;
            this.ttMensaje.ExitAnimationSpeed = 200;
            this.ttMensaje.GenerateAutoCloseDuration = false;
            this.ttMensaje.IconMargin = 6;
            this.ttMensaje.InitialDelay = 0;
            this.ttMensaje.Name = "ttMensaje";
            this.ttMensaje.Opacity = 1D;
            this.ttMensaje.OverrideToolTipTitles = false;
            this.ttMensaje.Padding = new System.Windows.Forms.Padding(10);
            this.ttMensaje.ReshowDelay = 100;
            this.ttMensaje.ShowAlways = true;
            this.ttMensaje.ShowBorders = false;
            this.ttMensaje.ShowIcons = true;
            this.ttMensaje.ShowShadows = true;
            this.ttMensaje.Tag = null;
            this.ttMensaje.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ttMensaje.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ttMensaje.TextMargin = 2;
            this.ttMensaje.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ttMensaje.TitleForeColor = System.Drawing.Color.Black;
            this.ttMensaje.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ttMensaje.ToolTipTitle = null;
            // 
            // ctlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ctlUsuario";
            this.Size = new System.Drawing.Size(1038, 81);
            this.ttMensaje.SetToolTip(this, "");
            this.ttMensaje.SetToolTipIcon(this, null);
            this.ttMensaje.SetToolTipTitle(this, "");
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pictureUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Panel panel5;
        public FontAwesome.Sharp.Material.MaterialButton btnEliminar;
        public FontAwesome.Sharp.Material.MaterialButton btnEditar;
        public FontAwesome.Sharp.Material.MaterialButton btnVerQR;
        private Bunifu.UI.WinForms.BunifuToolTip ttMensaje;
    }
}
