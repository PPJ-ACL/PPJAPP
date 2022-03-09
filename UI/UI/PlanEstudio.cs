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
    public partial class PlanEstudio : Form
    {
        public PlanEstudio()
        {
            InitializeComponent();
            CenterToScreen();
        }
        //Cambio Ventana
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlanesMERN  planMern = new PlanesMERN();
            planMern.Show();
            this.Close();   
        }
        //Cambio Ventana
        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal panelPrincipal = new PanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }
        //Cambio Ventana
        private void btnEPostMan_Click(object sender, EventArgs e)
        {
        }
        //Cerrar App
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //Minimizar App
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
