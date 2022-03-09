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
        //Cambio Ventana
        private void btnEstudio_Click(object sender, EventArgs e)
        {
            PlanEstudio planEstudio = new PlanEstudio();
            planEstudio.Show();
            this.Close();
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
        //Cambio Ventana
        private void btnConfig_Click(object sender, EventArgs e)
        {
            ConfigUI configUI = new ConfigUI(); 
            configUI.Show();
            this.Close();
        }
        //Maximizar App
        private void btnMax_Click(object sender, EventArgs e)
        {

        }
        //Cambio Ventana
        private void btnTips_Click(object sender, EventArgs e)
        {
            TipsJava tj = new TipsJava();  
            tj.Show();
            this.Hide();
        }
    }
}
