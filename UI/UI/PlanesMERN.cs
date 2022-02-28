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
    public partial class PlanesMERN : Form
    {
        public PlanesMERN()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
