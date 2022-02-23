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
    }
}
