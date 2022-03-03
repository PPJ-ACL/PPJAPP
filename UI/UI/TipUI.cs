using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TipUI : Form
    {
        public TipUI()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal panelPrincipal = new PanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        private void btnTJava_Click(object sender, EventArgs e)
        {
            TipsJava tipsJava = new TipsJava(); 
            tipsJava.Show();
            this.Close();
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
