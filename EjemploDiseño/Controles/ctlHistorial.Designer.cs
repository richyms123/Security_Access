namespace EjemploDiseño.Controles
{
    partial class ctlHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlHistorial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureInvitador = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblDireccionInvitador = new System.Windows.Forms.Label();
            this.lblNombreInvitador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFechaVigencia = new System.Windows.Forms.Label();
            this.lblNombreInvitado = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFechaEntrada = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.pictureEntro = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInvitador)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEntro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureInvitador);
            this.panel1.Controls.Add(this.lblDireccionInvitador);
            this.panel1.Controls.Add(this.lblNombreInvitador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 75);
            this.panel1.TabIndex = 4;
            // 
            // pictureInvitador
            // 
            this.pictureInvitador.AllowFocused = false;
            this.pictureInvitador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureInvitador.AutoSizeHeight = true;
            this.pictureInvitador.BorderRadius = 25;
            this.pictureInvitador.Image = ((System.Drawing.Image)(resources.GetObject("pictureInvitador.Image")));
            this.pictureInvitador.IsCircle = true;
            this.pictureInvitador.Location = new System.Drawing.Point(23, 12);
            this.pictureInvitador.Name = "pictureInvitador";
            this.pictureInvitador.Size = new System.Drawing.Size(50, 50);
            this.pictureInvitador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInvitador.TabIndex = 0;
            this.pictureInvitador.TabStop = false;
            this.pictureInvitador.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblDireccionInvitador
            // 
            this.lblDireccionInvitador.AutoEllipsis = true;
            this.lblDireccionInvitador.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionInvitador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDireccionInvitador.Location = new System.Drawing.Point(73, 41);
            this.lblDireccionInvitador.Name = "lblDireccionInvitador";
            this.lblDireccionInvitador.Size = new System.Drawing.Size(295, 23);
            this.lblDireccionInvitador.TabIndex = 2;
            this.lblDireccionInvitador.Text = "luis123@gmail.com";
            // 
            // lblNombreInvitador
            // 
            this.lblNombreInvitador.AutoEllipsis = true;
            this.lblNombreInvitador.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInvitador.Location = new System.Drawing.Point(72, 16);
            this.lblNombreInvitador.Name = "lblNombreInvitador";
            this.lblNombreInvitador.Size = new System.Drawing.Size(296, 23);
            this.lblNombreInvitador.TabIndex = 1;
            this.lblNombreInvitador.Text = "Luis Enrique Fonseca Sosa";
            this.lblNombreInvitador.Click += new System.EventHandler(this.lblNombreInvitador_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureEntro);
            this.panel2.Controls.Add(this.lblFechaVigencia);
            this.panel2.Controls.Add(this.lblNombreInvitado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(374, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 75);
            this.panel2.TabIndex = 5;
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.AutoEllipsis = true;
            this.lblFechaVigencia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVigencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaVigencia.Location = new System.Drawing.Point(61, 41);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(208, 23);
            this.lblFechaVigencia.TabIndex = 2;
            // 
            // lblNombreInvitado
            // 
            this.lblNombreInvitado.AutoEllipsis = true;
            this.lblNombreInvitado.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInvitado.Location = new System.Drawing.Point(61, 16);
            this.lblNombreInvitado.Name = "lblNombreInvitado";
            this.lblNombreInvitado.Size = new System.Drawing.Size(240, 23);
            this.lblNombreInvitado.TabIndex = 1;
            this.lblNombreInvitado.Text = "[RESIDENTE]";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblFechaEntrada);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(684, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 75);
            this.panel3.TabIndex = 6;
            // 
            // lblFechaEntrada
            // 
            this.lblFechaEntrada.AutoEllipsis = true;
            this.lblFechaEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaEntrada.Location = new System.Drawing.Point(10, 25);
            this.lblFechaEntrada.Name = "lblFechaEntrada";
            this.lblFechaEntrada.Size = new System.Drawing.Size(162, 23);
            this.lblFechaEntrada.TabIndex = 2;
            this.lblFechaEntrada.Text = "11/03/2005";
            this.lblFechaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFechaSalida);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(862, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 75);
            this.panel4.TabIndex = 7;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoEllipsis = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaSalida.Location = new System.Drawing.Point(9, 25);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(166, 23);
            this.lblFechaSalida.TabIndex = 2;
            this.lblFechaSalida.Text = "11/03/2005";
            this.lblFechaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureEntro
            // 
            this.pictureEntro.AllowFocused = false;
            this.pictureEntro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureEntro.AutoSizeHeight = true;
            this.pictureEntro.BorderRadius = 25;
            this.pictureEntro.Image = ((System.Drawing.Image)(resources.GetObject("pictureEntro.Image")));
            this.pictureEntro.IsCircle = true;
            this.pictureEntro.Location = new System.Drawing.Point(7, 13);
            this.pictureEntro.Name = "pictureEntro";
            this.pictureEntro.Size = new System.Drawing.Size(50, 50);
            this.pictureEntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEntro.TabIndex = 3;
            this.pictureEntro.TabStop = false;
            this.pictureEntro.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ctlHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ctlHistorial";
            this.Size = new System.Drawing.Size(1048, 75);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInvitador)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFechaEntrada;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFechaSalida;
        public Bunifu.UI.WinForms.BunifuPictureBox pictureInvitador;
        public System.Windows.Forms.Label lblDireccionInvitador;
        public System.Windows.Forms.Label lblNombreInvitador;
        public System.Windows.Forms.Label lblFechaVigencia;
        public System.Windows.Forms.Label lblNombreInvitado;
        public Bunifu.UI.WinForms.BunifuPictureBox pictureEntro;
    }
}
