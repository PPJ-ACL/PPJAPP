using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Drawing.Drawing2D;//Agregar en cada Ventana
using System.Runtime.InteropServices;//Agregar en cada ventana

namespace UI
{
    public partial class SubirPDF : Form
    {
        public SubirPDF()
        {
            InitializeComponent();
            CenterToScreen();
        }
        /*
        Abrir Archivo
        Desarrollado 07/03 08/03
        */
        private void btnExplorar_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = false;
            if(dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string nombreArchivo = dlg.FileName;
                string valArchivo = nombreArchivo.Substring(nombreArchivo.Length - 3);
                if (valArchivo=="pdf")
                {
                    txtDireccion.Text = nombreArchivo;
                }else
                {
                    
                    ErrorMsg em = new ErrorMsg();
                    em.lblError.Text = "El Archivo seleccionado no es valido";
                    em.Show();
                }
                
            }
        }
        /*
        Subir PDF por Luis C
        Desarrollado 07/03 - 08/03
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio ng = new Negocio();
                UserCredential credential;
                string[] Scopes = { DriveService.Scope.Drive };

                using (var stream =
                    new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    //El archivo token.json almacena los tokens de acceso y actualización del usuario
                    ////y se crea automáticamente cuando el flujo de autorización se completa por primera vez. 
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }
                string ApplicationName = "SAPJ ACL";
                // Creacion del api
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
                ng.subirPdf(txtDireccion.Text, service);
                //Mensaje de ERROR
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Se subío correctamente a Drive";
                em.Show();
                txtDireccion.Text = "";
            }
            catch (Exception ex)
            {
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Error en la conexion a base de datos, Favor contacte a un administrador" + ex.Message;
                em.Show();
            }
            


        }
        //Cambio Ventana
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Vista_Admin va = new Vista_Admin();
            va.Show();
            this.Hide();
        }
        //Cerrar App
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar App
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void SubirPDF_Paint(object sender, PaintEventArgs e)
        {
            //Llamada a la funcion
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
