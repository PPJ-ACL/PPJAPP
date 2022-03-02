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
    public partial class TipsJava : Form
    {
        private WebClient clie;
        public TipsJava()
        {
            InitializeComponent();
            CenterToScreen();
            clie = new WebClient();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            TipUI tipUI = new TipUI();  
            tipUI.Show();
            this.Close();
        }

        private void btnPDF1_Click(object sender, EventArgs e)
        {
            try
            {
                string linkurl = "https://drive.google.com/uc?id=18Wt6mPTm4tsYPraY0F-vQevSvSI4o8I9&export=download";
                string almacenamiento = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CheatsheetJS.pdf";
                clie.DownloadFileAsync(new Uri(linkurl), almacenamiento);
                MessageBox.Show("Se descargó con exito, favor revise su escritorio", "PPJ APP");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "PPJ APP Error");
            }
        }
    }
}
