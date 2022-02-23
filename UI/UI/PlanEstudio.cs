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
        }

        private void degradePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlanesMERN  planMern = new PlanesMERN();
            planMern.Show();
            this.Close();   
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal panelPrincipal = new PanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }
    }
}
