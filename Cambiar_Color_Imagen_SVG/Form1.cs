using Cambiar_Color_Imagen_SVG.SVG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambiar_Color_Imagen_SVG
{
    public partial class FormCambiarSVG : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //Declaración de variables
        private string selectedPath;
        private Svg.SvgDocument svgDocument;

        public FormCambiarSVG()
        {
            InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizarNormal_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.Padding =  new Padding(0);
                WindowState = FormWindowState.Maximized;
                btnMaximizarNormal.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.Icono_Restaurar;
            }
            else
            {
                this.Padding = new Padding(1);
                WindowState = FormWindowState.Normal;
                btnMaximizarNormal.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.Maximizar;
            }
        }

        private void lblLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panelModerno2_Load(object sender, EventArgs e)
        {

        }

        private void LayoutPanelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnAmpliar.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.subir_hover; 
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnAmpliar.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.subir;
        }

    

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            btnReducir.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.bajar_hover;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnReducir.Image = global::Cambiar_Color_Imagen_SVG.Properties.Resources.bajar;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult selectResult = filePicker.ShowDialog();
            if (selectResult == System.Windows.Forms.DialogResult.OK)
            {
                SVGParser.MaximumSize = pickImagen.MaximumSize;
                SVGParser.SizeInicio = new Size(pickImagen.Width, pickImagen.Height);
                selectedPath = filePicker.FileName;
                txtBuscar.Text = selectedPath;
                svgDocument = SVGParser.GetSvgDocument(selectedPath);
                nupAncho.Value = (int) svgDocument.Width.Value;
                btnAlto.Value = (int)  svgDocument.Height.Value;
                //pickImagen.Image =   svgDocument.Draw();
                pickImagen.Image = SVGParser.GetBitmapFromSVG(selectedPath);
            }
        }
    }
}
