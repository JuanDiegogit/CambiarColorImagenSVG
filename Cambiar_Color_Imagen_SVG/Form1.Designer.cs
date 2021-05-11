namespace Cambiar_Color_Imagen_SVG
{
    partial class Form1
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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.btnLogo = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaximizarNormal = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.LayoutPanelIzquierdo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSuperior.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
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
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(123)))), ((int)(((byte)(225)))));
            this.panelIzquierdo.Controls.Add(this.LayoutPanelIzquierdo);
            this.panelIzquierdo.Controls.Add(this.guna2Button1);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(1, 35);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(220, 484);
            this.panelIzquierdo.TabIndex = 1;
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
            this.guna2Button1.Location = new System.Drawing.Point(0, 439);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(220, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Acerca de";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(168)))), ((int)(((byte)(251)))));
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(221, 35);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(578, 484);
            this.panelCentral.TabIndex = 2;
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
            // LayoutPanelIzquierdo
            // 
            this.LayoutPanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanelIzquierdo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutPanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanelIzquierdo.Name = "LayoutPanelIzquierdo";
            this.LayoutPanelIzquierdo.Padding = new System.Windows.Forms.Padding(3);
            this.LayoutPanelIzquierdo.Size = new System.Drawing.Size(220, 439);
            this.LayoutPanelIzquierdo.TabIndex = 1;
            this.LayoutPanelIzquierdo.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPanelIzquierdo_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelIzquierdo;
    }
}

