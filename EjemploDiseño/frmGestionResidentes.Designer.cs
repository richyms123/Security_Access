namespace EjemploDiseño
{
    partial class frmGestionResidentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionResidentes));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.ttMensaje = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnNuevoUsuario = new FontAwesome.Sharp.Material.MaterialButton();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.Location = new System.Drawing.Point(12, 146);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1048, 409);
            this.pnlContenedor.TabIndex = 1;
            this.ttMensaje.SetToolTip(this.pnlContenedor, "");
            this.ttMensaje.SetToolTipIcon(this.pnlContenedor, null);
            this.ttMensaje.SetToolTipTitle(this.pnlContenedor, "");
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
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnNuevoUsuario);
            this.bunifuPanel1.Controls.Add(this.txtBuscar);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 22);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1048, 100);
            this.bunifuPanel1.TabIndex = 0;
            this.ttMensaje.SetToolTip(this.bunifuPanel1, "");
            this.ttMensaje.SetToolTipIcon(this.bunifuPanel1, null);
            this.ttMensaje.SetToolTipTitle(this.bunifuPanel1, "");
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(14)))), ((int)(((byte)(172)))));
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.ForeColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.IconChar = FontAwesome.Sharp.MaterialIcons.PlusCircle;
            this.btnNuevoUsuario.IconColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.IconSize = 38;
            this.btnNuevoUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(818, 23);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(206, 51);
            this.btnNuevoUsuario.TabIndex = 7;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.ttMensaje.SetToolTip(this.btnNuevoUsuario, "");
            this.ttMensaje.SetToolTipIcon(this.btnNuevoUsuario, null);
            this.ttMensaje.SetToolTipTitle(this.btnNuevoUsuario, "");
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AcceptsReturn = false;
            this.txtBuscar.AcceptsTab = false;
            this.txtBuscar.AnimationSpeed = 200;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(14)))), ((int)(((byte)(172)))));
            this.txtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscar.BorderColorHover = System.Drawing.Color.Silver;
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.BorderThickness = 1;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.FillColor = System.Drawing.Color.White;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.IconLeft = null;
            this.txtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.IconPadding = 10;
            this.txtBuscar.IconRight = null;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(460, 23);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscar.Modified = false;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(14)))), ((int)(((byte)(172)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Silver;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnIdleState = stateProperties4;
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.PlaceholderText = "Buscar por nombre o domicilio";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(338, 51);
            this.txtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMarginBottom = 0;
            this.txtBuscar.TextMarginLeft = 3;
            this.txtBuscar.TextMarginTop = 0;
            this.txtBuscar.TextPlaceholder = "Buscar por nombre o domicilio";
            this.ttMensaje.SetToolTip(this.txtBuscar, "");
            this.ttMensaje.SetToolTipIcon(this.txtBuscar, null);
            this.ttMensaje.SetToolTipTitle(this.txtBuscar, "");
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.WordWrap = true;
            this.txtBuscar.TextChange += new System.EventHandler(this.txtBuscar_TextChange);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(20, 56);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(395, 28);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Administra la información de los residentes";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ttMensaje.SetToolTip(this.bunifuLabel2, "");
            this.ttMensaje.SetToolTipIcon(this.bunifuLabel2, null);
            this.ttMensaje.SetToolTipTitle(this.bunifuLabel2, "");
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(20, 13);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(252, 37);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Lista de Residentes";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ttMensaje.SetToolTip(this.bunifuLabel1, "");
            this.ttMensaje.SetToolTipIcon(this.bunifuLabel1, null);
            this.ttMensaje.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // frmGestionResidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1072, 567);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionResidentes";
            this.Text = "frmGestionResidentes";
            this.Load += new System.EventHandler(this.frmGestionResidentes_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private FontAwesome.Sharp.Material.MaterialButton btnNuevoUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.UI.WinForms.BunifuToolTip ttMensaje;
    }
}