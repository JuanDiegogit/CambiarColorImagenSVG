using Cambiar_Color_Imagen_SVG.SVG;
using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

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
            if (ValidarForm())
            {
                int W = (int)nupAncho.Value;
                int H = (int)nupAlto.Value;

                if ((W - 10) > 0 && (H - 10) > 0)
                {
                    W -= 10;
                    nupAncho.Value = W;

                    H -= 10;
                    nupAlto.Value = H;

                    svgDocument.Width = W;
                    svgDocument.Height = H;

                    pickImagen.Image = svgDocument.Draw();
                }
            }
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
                nupAlto.Value = (int)  svgDocument.Height.Value;
                pickImagen.Image = SVGParser.GetBitmapFromSVG(selectedPath);
                Guardar.FileName = filePicker.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnColorFondo.BackColor = colorPicker.Color;
                pickImagen.BackColor = colorPicker.Color;
            }
        }

        private void btnColorOrigen_Click(object sender, EventArgs e)
        {
            DialogResult result = colorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnColorOrigen.BackColor = colorPicker.Color;
            }
        }

        private void btnColorDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = colorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnColorDestino.BackColor = colorPicker.Color;
            }
        }

        private void btnElegirOrigen_CheckedChanged(object sender, EventArgs e)
        {
           
            if (btnElegirOrigen.Checked)
            {
                btnElegirDestino.Checked = false;
                btnElegirOrigen.FillColor = Color.LightPink;
                pickImagen.Cursor = Cursors.Cross;
            }
            else
            {
                btnElegirOrigen.FillColor = Color.FromArgb(94,148, 255);
                pickImagen.Cursor = Cursors.Default;
            }
        }

        private void btnElegirDestino_Click(object sender, EventArgs e)
        {
           
        }

        private void btnElegirDestino_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {

            if (btnElegirDestino.Checked)
            {

                btnElegirOrigen.Checked = false;
                btnElegirDestino.FillColor = Color.LightPink;
                pickImagen.Cursor = Cursors.Cross;
            }
            else
            {
                btnElegirDestino.FillColor = Color.FromArgb(94, 148, 255);
                pickImagen.Cursor = Cursors.Default;
            }
        }

        private void btnAmpliar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                int W = (int)nupAncho.Value;
                int H = (int)nupAlto.Value;

                if ((W + 10) < pickImagen.Width && (H + 10) < pickImagen.Height)
                {
                    W += 10;
                    nupAncho.Value = W;

                    H += 10;
                    nupAlto.Value = H;

                    svgDocument.Width = W;
                    svgDocument.Height = H;

                    pickImagen.Image = svgDocument.Draw();
                }
            }
        }
        private bool ValidarForm()
        {
            if (svgDocument == null || pickImagen.Image == null)
            {
                MessageBox.Show("Por favor, Seleccione una imagen SVG");
                return false;
            }
            return true;
        }

        private void guna2Button2_Click_3(object sender, EventArgs e)
        {
         
            svgDocument.Width = pickImagen.Width;
            svgDocument.Height = pickImagen.Height;
            nupAncho.Value = (int)svgDocument.Width.Value;
            nupAlto.Value = (int)svgDocument.Height.Value;
            pickImagen.Image = svgDocument.Draw();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            foreach (Svg.SvgElement item in svgDocument.Children)
            {
                ChangeFill(item, btnColorOrigen.BackColor, btnColorDestino.BackColor);
            }
            pickImagen.Image = svgDocument.Draw();
        }

        private void ChangeFill(SvgElement element, Color sourceColor, Color replaceColor)
        {
            try
            {
                if (element is SvgPath)
                {

                    if (((element as SvgPath).Fill as SvgColourServer).Colour.ToArgb() == sourceColor.ToArgb())
                    {
                        (element as SvgPath).Fill = new SvgColourServer(replaceColor);
                    }
                }
            }
            catch (Exception)
            {


            }

            if (element.Children.Count > 0)
            {
                foreach (var item in element.Children)
                {
                    ChangeFill(item, sourceColor, replaceColor);
                }
            }

        }

        private void pickImagen_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnElegirOrigen.Checked)
            {
                if (ValidarForm())
                {


                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {

                        btnColorOrigen.BackColor = GetColorAt(Cursor.Position);
                        btnElegirOrigen.Checked = false;
                    }
                }
            }

            if (btnElegirDestino.Checked)
            {
                if (ValidarForm())
                {


                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {

                        btnColorDestino.BackColor = GetColorAt(Cursor.Position);
                        btnElegirDestino.Checked = false;
                    }
                }
            }
        }

        private void nupAncho_ValueChanged(object sender, EventArgs e)
        {
            int W = (int)nupAncho.Value;
            int H = (int)nupAlto.Value;

            if (W != 0 && H !=0 && pickImagen.Image != null)
            {

                if (ValidarForm())
                {
                    svgDocument.Width = W;
                    svgDocument.Height = H;

                    pickImagen.Image = svgDocument.Draw();
                }

            }
        }

        private void nupAlto_ValueChanged(object sender, EventArgs e)
        {

            int W = (int)nupAncho.Value;
            int H = (int)nupAlto.Value;

            if (W != 0 && H != 0 && pickImagen.Image != null)
            {
                if (ValidarForm())
                {
                    svgDocument.Width = W;
                    svgDocument.Height = H;

                    pickImagen.Image = svgDocument.Draw();
                }

            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                Guardar.FileName = Guardar.FileName.ToString().Replace(".SVG", ".PNG").Replace(".svg", ".png");
                Image Imagen = pickImagen.Image;
                Guardar.ShowDialog();
                Imagen.Save(Guardar.FileName);
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SVGParser.MaximumSize = pickImagen.MaximumSize;
            SVGParser.SizeInicio = new Size(pickImagen.Width, pickImagen.Height);
            svgDocument = SVGParser.GetSvgDocument(selectedPath);
            nupAncho.Value = (int)svgDocument.Width.Value;
            nupAlto.Value = (int)svgDocument.Height.Value;
            pickImagen.Image = SVGParser.GetBitmapFromSVG(selectedPath);
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este software fue hecho por Juan Diego\npara el canal de código Limpio");
        }
    }
}
