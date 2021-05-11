namespace Cambiar_Color_Imagen_SVG
{
    partial class FormCambiarSVG
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ResizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLogo = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximizarNormal = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnTamaño = new Guna.UI2.WinForms.Guna2Button();
            this.panelTamaño = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAmpliar = new System.Windows.Forms.PictureBox();
            this.btnAlto = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblAlto = new System.Windows.Forms.Label();
            this.nupAncho = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblAncho = new System.Windows.Forms.Label();
            this.btnColor = new Guna.UI2.WinForms.Guna2Button();
            this.panelColor = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCambiar = new Guna.UI2.WinForms.Guna2Button();
            this.lblColorxRemplazar = new System.Windows.Forms.Label();
            this.btnColorDestino = new System.Windows.Forms.Button();
            this.btnElegirOrigen = new Guna.UI2.WinForms.Guna2Button();
            this.btnColorOrigen = new System.Windows.Forms.Button();
            this.lblColorRemplazar = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnReducir = new System.Windows.Forms.PictureBox();
            this.panelherramientas = new System.Windows.Forms.Panel();
            this.pickImagen = new System.Windows.Forms.PictureBox();
            this.btnElegirDestino = new Guna.UI2.WinForms.Guna2Button();
            this.panelSuperior.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.panelTamaño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAmpliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAncho)).BeginInit();
            this.panelColor.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // ResizeForm
            // 
            this.ResizeForm.TargetForm = this;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(176)))));
            this.panelSuperior.Controls.Add(this.lblLogo);
            this.panelSuperior.Controls.Add(this.btnLogo);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Controls.Add(this.btnMaximizarNormal);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSuperior.Location = new System.Drawing.Point(1, 1);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(798, 34);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(41, 7);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(117, 21);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "Código limpio";
            this.lblLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseDown);
            // 
            // btnLogo
            // 
            this.btnLogo.CheckedState.Parent = this.btnLogo;
            this.btnLogo.CustomImages.Parent = this.btnLogo;
            this.btnLogo.FillColor = System.Drawing.Color.Transparent;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.HoverState.Parent = this.btnLogo;
            this.btnLogo.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.Código_Limpio;
            this.btnLogo.Location = new System.Drawing.Point(4, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.ShadowDecoration.Parent = this.btnLogo;
            this.btnLogo.Size = new System.Drawing.Size(30, 30);
            this.btnLogo.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.CheckedState.Parent = this.btnMinimizar;
            this.btnMinimizar.CustomImages.Parent = this.btnMinimizar;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.HoverState.Parent = this.btnMinimizar;
            this.btnMinimizar.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.minimizar_2;
            this.btnMinimizar.Location = new System.Drawing.Point(692, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizarNormal
            // 
            this.btnMaximizarNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarNormal.CheckedState.Parent = this.btnMaximizarNormal;
            this.btnMaximizarNormal.CustomImages.Parent = this.btnMaximizarNormal;
            this.btnMaximizarNormal.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximizarNormal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximizarNormal.ForeColor = System.Drawing.Color.White;
            this.btnMaximizarNormal.HoverState.Parent = this.btnMaximizarNormal;
            this.btnMaximizarNormal.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.Maximizar;
            this.btnMaximizarNormal.Location = new System.Drawing.Point(728, 0);
            this.btnMaximizarNormal.Name = "btnMaximizarNormal";
            this.btnMaximizarNormal.ShadowDecoration.Parent = this.btnMaximizarNormal;
            this.btnMaximizarNormal.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizarNormal.TabIndex = 2;
            this.btnMaximizarNormal.Click += new System.EventHandler(this.btnMaximizarNormal_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.CheckedState.Parent = this.btnCerrar;
            this.btnCerrar.CustomImages.Parent = this.btnCerrar;
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.HoverState.Parent = this.btnCerrar;
            this.btnCerrar.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(764, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(123)))), ((int)(((byte)(225)))));
            this.panelIzquierdo.Controls.Add(this.btnTamaño);
            this.panelIzquierdo.Controls.Add(this.panelTamaño);
            this.panelIzquierdo.Controls.Add(this.btnColor);
            this.panelIzquierdo.Controls.Add(this.panelColor);
            this.panelIzquierdo.Controls.Add(this.guna2Button1);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(1, 35);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(220, 504);
            this.panelIzquierdo.TabIndex = 1;
            this.panelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIzquierdo_Paint);
            // 
            // btnTamaño
            // 
            this.btnTamaño.AutoRoundedCorners = true;
            this.btnTamaño.BorderColor = System.Drawing.Color.White;
            this.btnTamaño.BorderRadius = 11;
            this.btnTamaño.BorderThickness = 2;
            this.btnTamaño.CheckedState.Parent = this.btnTamaño;
            this.btnTamaño.CustomImages.Parent = this.btnTamaño;
            this.btnTamaño.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamaño.ForeColor = System.Drawing.Color.White;
            this.btnTamaño.HoverState.Parent = this.btnTamaño;
            this.btnTamaño.Location = new System.Drawing.Point(27, 271);
            this.btnTamaño.Name = "btnTamaño";
            this.btnTamaño.ShadowDecoration.Parent = this.btnTamaño;
            this.btnTamaño.Size = new System.Drawing.Size(123, 25);
            this.btnTamaño.TabIndex = 3;
            this.btnTamaño.Text = "Tamaño";
            // 
            // panelTamaño
            // 
            this.panelTamaño.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTamaño.BorderColor = System.Drawing.Color.White;
            this.panelTamaño.BorderRadius = 20;
            this.panelTamaño.BorderThickness = 2;
            this.panelTamaño.Controls.Add(this.btnReducir);
            this.panelTamaño.Controls.Add(this.btnAmpliar);
            this.panelTamaño.Controls.Add(this.btnAlto);
            this.panelTamaño.Controls.Add(this.lblAlto);
            this.panelTamaño.Controls.Add(this.nupAncho);
            this.panelTamaño.Controls.Add(this.lblAncho);
            this.panelTamaño.Location = new System.Drawing.Point(4, 281);
            this.panelTamaño.Name = "panelTamaño";
            this.panelTamaño.ShadowDecoration.Parent = this.panelTamaño;
            this.panelTamaño.Size = new System.Drawing.Size(210, 172);
            this.panelTamaño.TabIndex = 4;
            this.panelTamaño.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.subir;
            this.btnAmpliar.Location = new System.Drawing.Point(53, 120);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(40, 40);
            this.btnAmpliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAmpliar.TabIndex = 17;
            this.btnAmpliar.TabStop = false;
            this.btnAmpliar.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btnAmpliar.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // btnAlto
            // 
            this.btnAlto.BackColor = System.Drawing.Color.Transparent;
            this.btnAlto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnAlto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnAlto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnAlto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnAlto.DisabledState.Parent = this.btnAlto;
            this.btnAlto.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.btnAlto.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.btnAlto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAlto.FocusedState.Parent = this.btnAlto;
            this.btnAlto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAlto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnAlto.Location = new System.Drawing.Point(96, 69);
            this.btnAlto.Name = "btnAlto";
            this.btnAlto.ShadowDecoration.Parent = this.btnAlto;
            this.btnAlto.Size = new System.Drawing.Size(100, 36);
            this.btnAlto.TabIndex = 16;
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.ForeColor = System.Drawing.Color.White;
            this.lblAlto.Location = new System.Drawing.Point(21, 80);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(43, 21);
            this.lblAlto.TabIndex = 15;
            this.lblAlto.Text = "Alto";
            // 
            // nupAncho
            // 
            this.nupAncho.BackColor = System.Drawing.Color.Transparent;
            this.nupAncho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupAncho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nupAncho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nupAncho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nupAncho.DisabledState.Parent = this.nupAncho;
            this.nupAncho.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nupAncho.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nupAncho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupAncho.FocusedState.Parent = this.nupAncho;
            this.nupAncho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupAncho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nupAncho.Location = new System.Drawing.Point(96, 21);
            this.nupAncho.Name = "nupAncho";
            this.nupAncho.ShadowDecoration.Parent = this.nupAncho;
            this.nupAncho.Size = new System.Drawing.Size(100, 36);
            this.nupAncho.TabIndex = 14;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.ForeColor = System.Drawing.Color.White;
            this.lblAncho.Location = new System.Drawing.Point(21, 28);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(63, 21);
            this.lblAncho.TabIndex = 13;
            this.lblAncho.Text = "Ancho";
            // 
            // btnColor
            // 
            this.btnColor.AutoRoundedCorners = true;
            this.btnColor.BorderColor = System.Drawing.Color.White;
            this.btnColor.BorderRadius = 11;
            this.btnColor.BorderThickness = 2;
            this.btnColor.CheckedState.Parent = this.btnColor;
            this.btnColor.CustomImages.Parent = this.btnColor;
            this.btnColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.HoverState.Parent = this.btnColor;
            this.btnColor.Location = new System.Drawing.Point(27, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.ShadowDecoration.Parent = this.btnColor;
            this.btnColor.Size = new System.Drawing.Size(123, 25);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BorderColor = System.Drawing.Color.White;
            this.panelColor.BorderRadius = 20;
            this.panelColor.BorderThickness = 2;
            this.panelColor.Controls.Add(this.btnElegirDestino);
            this.panelColor.Controls.Add(this.btnCambiar);
            this.panelColor.Controls.Add(this.lblColorxRemplazar);
            this.panelColor.Controls.Add(this.btnColorDestino);
            this.panelColor.Controls.Add(this.btnElegirOrigen);
            this.panelColor.Controls.Add(this.btnColorOrigen);
            this.panelColor.Controls.Add(this.lblColorRemplazar);
            this.panelColor.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelColor.Location = new System.Drawing.Point(4, 38);
            this.panelColor.Name = "panelColor";
            this.panelColor.ShadowDecoration.Parent = this.panelColor;
            this.panelColor.Size = new System.Drawing.Size(210, 227);
            this.panelColor.TabIndex = 2;
            // 
            // btnCambiar
            // 
            this.btnCambiar.AutoRoundedCorners = true;
            this.btnCambiar.BorderColor = System.Drawing.Color.White;
            this.btnCambiar.BorderRadius = 19;
            this.btnCambiar.BorderThickness = 2;
            this.btnCambiar.CheckedState.Parent = this.btnCambiar;
            this.btnCambiar.CustomImages.Parent = this.btnCambiar;
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCambiar.ForeColor = System.Drawing.Color.White;
            this.btnCambiar.HoverState.Parent = this.btnCambiar;
            this.btnCambiar.Location = new System.Drawing.Point(29, 174);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.ShadowDecoration.Parent = this.btnCambiar;
            this.btnCambiar.Size = new System.Drawing.Size(148, 41);
            this.btnCambiar.TabIndex = 12;
            this.btnCambiar.Text = "Cambiar";
            // 
            // lblColorxRemplazar
            // 
            this.lblColorxRemplazar.AutoSize = true;
            this.lblColorxRemplazar.ForeColor = System.Drawing.Color.White;
            this.lblColorxRemplazar.Location = new System.Drawing.Point(19, 95);
            this.lblColorxRemplazar.Name = "lblColorxRemplazar";
            this.lblColorxRemplazar.Size = new System.Drawing.Size(170, 22);
            this.lblColorxRemplazar.TabIndex = 11;
            this.lblColorxRemplazar.Text = "Color por reemplazar";
            // 
            // btnColorDestino
            // 
            this.btnColorDestino.BackColor = System.Drawing.Color.Blue;
            this.btnColorDestino.Location = new System.Drawing.Point(23, 120);
            this.btnColorDestino.Name = "btnColorDestino";
            this.btnColorDestino.Size = new System.Drawing.Size(69, 41);
            this.btnColorDestino.TabIndex = 9;
            this.btnColorDestino.UseVisualStyleBackColor = false;
            // 
            // btnElegirOrigen
            // 
            this.btnElegirOrigen.AutoRoundedCorners = true;
            this.btnElegirOrigen.BorderColor = System.Drawing.Color.White;
            this.btnElegirOrigen.BorderRadius = 13;
            this.btnElegirOrigen.BorderThickness = 2;
            this.btnElegirOrigen.CheckedState.Parent = this.btnElegirOrigen;
            this.btnElegirOrigen.CustomImages.Parent = this.btnElegirOrigen;
            this.btnElegirOrigen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElegirOrigen.ForeColor = System.Drawing.Color.White;
            this.btnElegirOrigen.HoverState.Parent = this.btnElegirOrigen;
            this.btnElegirOrigen.Location = new System.Drawing.Point(96, 58);
            this.btnElegirOrigen.Name = "btnElegirOrigen";
            this.btnElegirOrigen.ShadowDecoration.Parent = this.btnElegirOrigen;
            this.btnElegirOrigen.Size = new System.Drawing.Size(58, 28);
            this.btnElegirOrigen.TabIndex = 8;
            this.btnElegirOrigen.Text = "Elegir";
            this.btnElegirOrigen.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnColorOrigen
            // 
            this.btnColorOrigen.BackColor = System.Drawing.Color.Red;
            this.btnColorOrigen.Location = new System.Drawing.Point(21, 51);
            this.btnColorOrigen.Name = "btnColorOrigen";
            this.btnColorOrigen.Size = new System.Drawing.Size(69, 41);
            this.btnColorOrigen.TabIndex = 7;
            this.btnColorOrigen.UseVisualStyleBackColor = false;
            // 
            // lblColorRemplazar
            // 
            this.lblColorRemplazar.AutoSize = true;
            this.lblColorRemplazar.ForeColor = System.Drawing.Color.White;
            this.lblColorRemplazar.Location = new System.Drawing.Point(19, 20);
            this.lblColorRemplazar.Name = "lblColorRemplazar";
            this.lblColorRemplazar.Size = new System.Drawing.Size(153, 22);
            this.lblColorRemplazar.TabIndex = 6;
            this.lblColorRemplazar.Text = "Color a reemplazar";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 459);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(220, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Acerca de";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.panelCentral.Controls.Add(this.pickImagen);
            this.panelCentral.Controls.Add(this.panelherramientas);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(221, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(578, 504);
            this.panelCentral.TabIndex = 2;
            // 
            // btnReducir
            // 
            this.btnReducir.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.bajar;
            this.btnReducir.Location = new System.Drawing.Point(114, 121);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(40, 40);
            this.btnReducir.TabIndex = 18;
            this.btnReducir.TabStop = false;
            this.btnReducir.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btnReducir.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.btnReducir.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // panelherramientas
            // 
            this.panelherramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelherramientas.Location = new System.Drawing.Point(0, 0);
            this.panelherramientas.Name = "panelherramientas";
            this.panelherramientas.Size = new System.Drawing.Size(578, 107);
            this.panelherramientas.TabIndex = 0;
            // 
            // pickImagen
            // 
            this.pickImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickImagen.Location = new System.Drawing.Point(0, 107);
            this.pickImagen.Name = "pickImagen";
            this.pickImagen.Size = new System.Drawing.Size(578, 397);
            this.pickImagen.TabIndex = 1;
            this.pickImagen.TabStop = false;
            // 
            // btnElegirDestino
            // 
            this.btnElegirDestino.AutoRoundedCorners = true;
            this.btnElegirDestino.BorderColor = System.Drawing.Color.White;
            this.btnElegirDestino.BorderRadius = 13;
            this.btnElegirDestino.BorderThickness = 2;
            this.btnElegirDestino.CheckedState.Parent = this.btnElegirDestino;
            this.btnElegirDestino.CustomImages.Parent = this.btnElegirDestino;
            this.btnElegirDestino.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnElegirDestino.ForeColor = System.Drawing.Color.White;
            this.btnElegirDestino.HoverState.Parent = this.btnElegirDestino;
            this.btnElegirDestino.Location = new System.Drawing.Point(97, 127);
            this.btnElegirDestino.Name = "btnElegirDestino";
            this.btnElegirDestino.ShadowDecoration.Parent = this.btnElegirDestino;
            this.btnElegirDestino.Size = new System.Drawing.Size(58, 28);
            this.btnElegirDestino.TabIndex = 13;
            this.btnElegirDestino.Text = "Elegir";
            // 
            // FormCambiarSVG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "FormCambiarSVG";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
            this.panelTamaño.ResumeLayout(false);
            this.panelTamaño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAmpliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAncho)).EndInit();
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ResizeForm ResizeForm;
        private System.Windows.Forms.Panel panelSuperior;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
        private Guna.UI2.WinForms.Guna2Button btnMaximizarNormal;
        private Guna.UI2.WinForms.Guna2Button btnLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelIzquierdo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnColor;
        private Guna.UI2.WinForms.Guna2Panel panelColor;
        private Guna.UI2.WinForms.Guna2Button btnTamaño;
        private Guna.UI2.WinForms.Guna2Panel panelTamaño;
        private System.Windows.Forms.Label lblColorRemplazar;
        private System.Windows.Forms.Button btnColorOrigen;
        private Guna.UI2.WinForms.Guna2Button btnCambiar;
        private System.Windows.Forms.Label lblColorxRemplazar;
        private System.Windows.Forms.Button btnColorDestino;
        private Guna.UI2.WinForms.Guna2Button btnElegirOrigen;
        private Guna.UI2.WinForms.Guna2NumericUpDown btnAlto;
        private System.Windows.Forms.Label lblAlto;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupAncho;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.PictureBox btnAmpliar;
        private System.Windows.Forms.PictureBox btnReducir;
        private System.Windows.Forms.PictureBox pickImagen;
        private System.Windows.Forms.Panel panelherramientas;
        private Guna.UI2.WinForms.Guna2Button btnElegirDestino;
    }
}

