using CapaNegocio;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;//Agregar en cada Ventana
using System.Runtime.InteropServices;//Agregar en cada ventana


namespace UI
{
    public partial class Form1 : Form
    {

        //Cadena Luis
        //String ConnectString = @"Data Source=LUCHITO-PC\SQLEXPRESS;Initial Catalog=SAPJDEV ;Integrated Security=True";
        //Cadena Francisco
        String ConnectString = @"Data Source=MARUCHANBOOK;Initial Catalog=SAPJDEV ;Integrated Security=True"; 
        public Form1()
        {
            
            InitializeComponent();
            CenterToScreen();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            
        }
        //Cerrar Programa
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        //Minimizar Programa
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Relleno Campo
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
               
        }
        /*
         Validaciones Correo
         Desarrollado el 28/02/2022
        */
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.White;
            }
            else if(txtCorreo.TextLength > 8)
            {
                //Validacion Correo ACL
                string cor = txtCorreo.Text;
                string valAcl = cor.Substring(cor.Length - 7);
                if (valAcl == "@acl.cl")
                {
                   
                }else
                {
                    txtCorreo.Focus();
                    //Mensaje Error
                    ErrorMsg em = new ErrorMsg();
                    em.lblError.Text = "Error en el correo ingresado.";
                    em.Show();
                    
                }
                
            }
            else
            {
                //Mensaje Error
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Error en el correo ingresado.";
                em.Show();
            }
        }
        //Relleno Contra
        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.White;
            }
        }
        //Relleno Contra
        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.White;
                txtContra.UseSystemPasswordChar = false;
            }
        }
        /*
         Codigo para logearse con la BD
         Desarrollado el 27/02/2022 -- Modificado 08/03/2022-07/03/2022
        */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String selectStock = "SELECT COUNT(Correo) AS NUMUSUARIO, IdTipo AS TIPOUSUARIO FROM VistaLogin WHERE VistaLogin.Correo = '" + txtCorreo.Text + "' AND VistaLogin.contrasenna = '" + txtContra.Text + "' GROUP BY IdTipo;";
            SqlConnection con = new SqlConnection(ConnectString);
            SqlCommand cmd = new SqlCommand(selectStock, con);
            SqlDataReader mReader;
            try
            {
                con.Open();
                mReader = cmd.ExecuteReader();
                while (mReader.Read())
                {
                    int valUsu = mReader.GetInt32("NUMUSUARIO");
                    int tipoUsu = mReader.GetInt32("TIPOUSUARIO");
                    if (valUsu != 1)
                    { 
                    }
                    else
                    {
                        txtValUsu.Text = valUsu+"";
                        txtTipoUsuario.Text = tipoUsu+"";
                    }
                }
                if (txtValUsu.Text != "1")
                {
                    ErrorMsg em = new ErrorMsg();
                    em.lblError.Text = "Error en el Inicio de Sesion.";
                    em.Show();
                }
                else
                {  
                    if(txtTipoUsuario.Text == "1")
                    {
                        Vista_Admin va = new Vista_Admin();
                        va.txtTipoUsuario.Text = txtTipoUsuario.Text;
                        va.Show();
                        this.Hide();
                    }else if(txtTipoUsuario.Text != "1")
                    {
                        PanelPrincipal panel2 = new PanelPrincipal();
                        panel2.Show();
                        this.Hide();
                    }        
                }
            }
            catch (Exception ex)
            {
                ErrorMsg em = new ErrorMsg();  
                em.lblError.Text = "Error en la conexion a base de datos, Favor contacte a un administrador" + ex.Message;
                em.Show();
            }
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

        private void degradePanel1_Paint(object sender, PaintEventArgs e)
        {
            //Llamada a la funcion
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void degradePanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}