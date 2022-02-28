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
    public partial class AyudaUI : Form
    {
        public AyudaUI()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal panelPrincipal = new PanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }
    }
}
