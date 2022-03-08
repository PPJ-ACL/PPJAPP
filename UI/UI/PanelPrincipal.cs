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
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnEstudio_Click(object sender, EventArgs e)
        {
            PlanEstudio planEstudio = new PlanEstudio();
            planEstudio.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigUI configUI = new ConfigUI(); 
            configUI.Show();
            this.Close();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {

        }
        private void btnTips_Click(object sender, EventArgs e)
        {
            TipsJava tj = new TipsJava();  
            tj.Show();
            this.Hide();
        }
    }
}
