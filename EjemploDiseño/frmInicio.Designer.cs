namespace EjemploDiseño
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnIniciarScanner = new FontAwesome.Sharp.Material.MaterialButton();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDetenerScanner = new FontAwesome.Sharp.Material.MaterialButton();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnConsultar = new FontAwesome.Sharp.Material.MaterialButton();
            this.panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnRegistrarSalida = new FontAwesome.Sharp.Material.MaterialButton();
            this.btnRegistrarEntrada = new FontAwesome.Sharp.Material.MaterialButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtIdUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.materialPictureBox1 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.btnIniciarScanner;
            // 
            // btnIniciarScanner
            // 
            this.btnIniciarScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnIniciarScanner.FlatAppearance.BorderSize = 0;
            this.btnIniciarScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarScanner.ForeColor = System.Drawing.Color.White;
            this.btnIniciarScanner.IconChar = FontAwesome.Sharp.MaterialIcons.PlayCircle;
            this.btnIniciarScanner.IconColor = System.Drawing.Color.White;
            this.btnIniciarScanner.IconSize = 38;
            this.btnIniciarScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarScanner.Location = new System.Drawing.Point(32, 326);
            this.btnIniciarScanner.Name = "btnIniciarScanner";
            this.btnIniciarScanner.Size = new System.Drawing.Size(186, 42);
            this.btnIniciarScanner.TabIndex = 2;
            this.btnIniciarScanner.Text = "Iniciar Escáner";
            this.btnIniciarScanner.UseVisualStyleBackColor = false;
            this.btnIniciarScanner.Click += new System.EventHandler(this.btnIniciarScanner_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.btnDetenerScanner;
            // 
            // btnDetenerScanner
            // 
            this.btnDetenerScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btnDetenerScanner.FlatAppearance.BorderSize = 0;
            this.btnDetenerScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetenerScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetenerScanner.ForeColor = System.Drawing.Color.White;
            this.btnDetenerScanner.IconChar = FontAwesome.Sharp.MaterialIcons.FlipToFront;
            this.btnDetenerScanner.IconColor = System.Drawing.Color.White;
            this.btnDetenerScanner.IconSize = 38;
            this.btnDetenerScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetenerScanner.Location = new System.Drawing.Point(301, 321);
            this.btnDetenerScanner.Name = "btnDetenerScanner";
            this.btnDetenerScanner.Size = new System.Drawing.Size(186, 42);
            this.btnDetenerScanner.TabIndex = 3;
            this.btnDetenerScanner.Text = "Detener Escáner";
            this.btnDetenerScanner.UseVisualStyleBackColor = false;
            this.btnDetenerScanner.Click += new System.EventHandler(this.btnDetenerScanner_Click);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.btnConsultar;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnConsultar.Enabled = false;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.IconChar = FontAwesome.Sharp.MaterialIcons.PlayCircle;
            this.btnConsultar.IconColor = System.Drawing.Color.White;
            this.btnConsultar.IconSize = 38;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(281, 401);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(206, 42);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar en la BD";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panel
            // 
            this.panel.BackgroundColor = System.Drawing.Color.White;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 20;
            this.panel.BorderThickness = 1;
            this.panel.Controls.Add(this.pnlContenedor);
            this.panel.Controls.Add(this.btnRegistrarSalida);
            this.panel.Controls.Add(this.btnRegistrarEntrada);
            this.panel.Location = new System.Drawing.Point(561, 21);
            this.panel.Name = "panel";
            this.panel.ShowBorders = true;
            this.panel.Size = new System.Drawing.Size(499, 492);
            this.panel.TabIndex = 1;
            this.panel.Click += new System.EventHandler(this.bunifuPanel2_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Location = new System.Drawing.Point(18, 14);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(466, 365);
            this.pnlContenedor.TabIndex = 43;
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRegistrarSalida.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSalida.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSalida.IconChar = FontAwesome.Sharp.MaterialIcons.ArrowLeftCircle;
            this.btnRegistrarSalida.IconColor = System.Drawing.Color.White;
            this.btnRegistrarSalida.IconSize = 38;
            this.btnRegistrarSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarSalida.Location = new System.Drawing.Point(73, 439);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(379, 42);
            this.btnRegistrarSalida.TabIndex = 42;
            this.btnRegistrarSalida.Text = "Registrar salida";
            this.btnRegistrarSalida.UseVisualStyleBackColor = false;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click);
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnRegistrarEntrada.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEntrada.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEntrada.IconChar = FontAwesome.Sharp.MaterialIcons.ArrowRightCircle;
            this.btnRegistrarEntrada.IconColor = System.Drawing.Color.White;
            this.btnRegistrarEntrada.IconSize = 38;
            this.btnRegistrarEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(73, 385);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(379, 42);
            this.btnRegistrarEntrada.TabIndex = 41;
            this.btnRegistrarEntrada.Text = "Registrar entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = false;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnConsultar);
            this.bunifuPanel1.Controls.Add(this.txtIdUsuario);
            this.bunifuPanel1.Controls.Add(this.materialPictureBox1);
            this.bunifuPanel1.Controls.Add(this.btnDetenerScanner);
            this.bunifuPanel1.Controls.Add(this.btnIniciarScanner);
            this.bunifuPanel1.Controls.Add(this.pictureBoxCamara);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(22, 21);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(514, 492);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AcceptsReturn = false;
            this.txtIdUsuario.AcceptsTab = false;
            this.txtIdUsuario.AnimationSpeed = 200;
            this.txtIdUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtIdUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtIdUsuario.BackgroundImage")));
            this.txtIdUsuario.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtIdUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtIdUsuario.BorderColorHover = System.Drawing.Color.Silver;
            this.txtIdUsuario.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtIdUsuario.BorderRadius = 20;
            this.txtIdUsuario.BorderThickness = 1;
            this.txtIdUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtIdUsuario.DefaultText = "";
            this.txtIdUsuario.FillColor = System.Drawing.Color.White;
            this.txtIdUsuario.HideSelection = true;
            this.txtIdUsuario.IconLeft = null;
            this.txtIdUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.IconPadding = 10;
            this.txtIdUsuario.IconRight = null;
            this.txtIdUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdUsuario.Lines = new string[0];
            this.txtIdUsuario.Location = new System.Drawing.Point(32, 402);
            this.txtIdUsuario.MaxLength = 32767;
            this.txtIdUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIdUsuario.Modified = false;
            this.txtIdUsuario.Multiline = false;
            this.txtIdUsuario.Name = "txtIdUsuario";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIdUsuario.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtIdUsuario.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Silver;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIdUsuario.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIdUsuario.OnIdleState = stateProperties4;
            this.txtIdUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.txtIdUsuario.PasswordChar = '\0';
            this.txtIdUsuario.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtIdUsuario.PlaceholderText = "ID del Visitante";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdUsuario.SelectedText = "";
            this.txtIdUsuario.SelectionLength = 0;
            this.txtIdUsuario.SelectionStart = 0;
            this.txtIdUsuario.ShortcutsEnabled = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(186, 41);
            this.txtIdUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtIdUsuario.TabIndex = 5;
            this.txtIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdUsuario.TextMarginBottom = 0;
            this.txtIdUsuario.TextMarginLeft = 3;
            this.txtIdUsuario.TextMarginTop = 0;
            this.txtIdUsuario.TextPlaceholder = "ID del Visitante";
            this.txtIdUsuario.UseSystemPasswordChar = false;
            this.txtIdUsuario.WordWrap = true;
            // 
            // materialPictureBox1
            // 
            this.materialPictureBox1.BackColor = System.Drawing.Color.White;
            this.materialPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox1.IconChar = FontAwesome.Sharp.MaterialIcons.Qrcode;
            this.materialPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox1.IconSize = 40;
            this.materialPictureBox1.Location = new System.Drawing.Point(41, 14);
            this.materialPictureBox1.Name = "materialPictureBox1";
            this.materialPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.materialPictureBox1.TabIndex = 4;
            this.materialPictureBox1.TabStop = false;
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.AccessibleDescription = "Enfoca el qr";
            this.pictureBoxCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxCamara.Location = new System.Drawing.Point(32, 60);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(455, 248);
            this.pictureBoxCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamara.TabIndex = 1;
            this.pictureBoxCamara.TabStop = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(87, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(248, 37);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Escaner Código QR";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.pictureBoxCamara;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1072, 567);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.PictureBox pictureBoxCamara;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private FontAwesome.Sharp.Material.MaterialButton btnDetenerScanner;
        private FontAwesome.Sharp.Material.MaterialButton btnIniciarScanner;
        private Bunifu.UI.WinForms.BunifuPanel panel;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.UI.WinForms.BunifuTextBox txtIdUsuario;
        private FontAwesome.Sharp.Material.MaterialButton btnConsultar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        public FontAwesome.Sharp.Material.MaterialButton btnRegistrarSalida;
        public FontAwesome.Sharp.Material.MaterialButton btnRegistrarEntrada;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
    }
}