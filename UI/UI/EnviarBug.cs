using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;//Agregar en cada Ventana
using System.Runtime.InteropServices;//Agregar en cada ventana

namespace UI
{
    public partial class EnviarBug : Form
    {
        public EnviarBug()
        {
            InitializeComponent();
            CenterToScreen();
        }

        /*
         Codigo para enviar el correo
         Desarrollado el 02/03/2022
        */
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //string body = @"<div style=font-size:32px;color:#FFFFFF;background-color:#E02957;>ACL<br></div><div style=font-size:20px;color:#000000> El Mensaje del usuario fue:<br>" + tbBug.Text + " <br>Correo del Usuario:<div>" + txtCorreo.Text + "</div>  <div style= background-color:#7D1630;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ  <br> <a href ='https://www.facebook.com/aclconsultores/'><font style=color:white>Facebook           </font></a> <a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= color:white>Linkedin</font></a> </div> </div>";
                string body = @"<div style=background-color:#E02957;height:100px;width:100%></div><!-- Poppins SemiBlod --><div style=font-size:32px;font-family:Poppins,sans-serif;font-weight:600;color:#FFFFFF;background-color:#E02957;><style>@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap');</style>ACL<br></div><div style=font-size:20px;font-family:Poppins,sans-serif;color:#000000>El Mensaje del usuario fue:<br>" + tbBug.Text + "<br>Correo del Usuario:<div>" + txtCorreo.Text + "</div><div style= font-size:18px;font-family:Poppins,sans-serif;background-color:#1F2937;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ<br>Mas informacion en nuestras redes sociales.<br></div> <div>	<a href ='https://www.facebook.com/aclconsultores/'> <font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Facebook    </font></a><a href ='https://www.instagram.com/acl.consultores/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Instragram    </font></a><a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Linkedin    </font></a></div></div>";
                Negocio ng = new Negocio();
                //lcordova@acl.cl
                ng.enviarMail("SAPJACL@hotmail.com", "BUG SAPJ ACL", body);
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Mensaje Enviado Con Exito.";
                em.Show();

            }
            catch (Exception ex)
            {
                //Mensaje Error
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Error:" + ex.Message;
                em.Show();
            }
            
        }

        //Cerrar App
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {

        }
        //Minimizar App
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Cambio Ventana
        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConfigUI config = new ConfigUI();
            config.Show();
            this.Close();

        }
        //Valores Bordes
        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(224, 41, 87);

        //Bordes Redondos Config
        //Metodo de Arrastre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //Metodos Privados de Bordes Redondos
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {

            using (GraphicsPath roundPath = GetRoundedPath(rect, borderSize))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        //----------------------------------------------------------------------------------------------------------




        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);


            //Borde suave 

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectForm = this.ClientRectangle;
            int mWidth = rectForm.Width / 2;
            int mHeigth = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Top Izquierda
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);

            //Top Derecha
            Rectangle rectTopRigth = new Rectangle(mWidth, rectForm.Y, mWidth, mHeigth);
            DrawPath(rectTopRigth, e.Graphics, fbColors.TopRightColor);

            //Bot Izquierda
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeigth, mWidth, mHeigth);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bot Derecha
            Rectangle rectBottomRigth = new Rectangle(mWidth, rectForm.Y + mHeigth, mWidth, mHeigth);
            DrawPath(rectBottomRigth, e.Graphics, fbColors.BottomRightColor);





        }

        //Obtencion de colores Fondos
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Izquierda
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Derecha
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bot Izquierda
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bot Derecha
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;

            //            //Llamada a la funcion
            // FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Llamada a la funcion
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

    }
}
