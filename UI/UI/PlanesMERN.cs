using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PlanesMERN : Form
    {
        private WebClient clie;
        
        public PlanesMERN()
        {
            InitializeComponent();
            CenterToScreen();
            clie = new WebClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PlanEstudio planestudio = new PlanEstudio();
            planestudio.Show();
            this.Close();
        }

        private void PlanesMERN_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PlanEstudio planEstudio = new PlanEstudio();
            planEstudio.Show();
            this.Close();
        }

        /*
         Codigo para descargar desde Google Drive
         Desarrollado el 01/03/2022
        */
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string linkurl = "https://drive.google.com/uc?id=12Vx5m87dNNI4zanzL6578O524a40-Wa-&export=download";
                string almacenamiento= Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PlanMERN.pdf";
                clie.DownloadFileAsync(new Uri(linkurl), almacenamiento);
                MessageBox.Show("Se descargó con exito, favor revise su escritorio", "PPJ APP");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message, "PPJ APP Error");
            }
            
        }

        private void degradePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
