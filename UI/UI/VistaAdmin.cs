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
    public partial class Vista_Admin : Form
    {
        public Vista_Admin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //Cambio Ventana
        private void button3_Click(object sender, EventArgs e)
        {
            SubirPDF sp = new SubirPDF();
            sp.Show();
            this.Hide();
        }
        //Cambio Ventana
        private void button1_Click(object sender, EventArgs e)
        {
            PanelPrincipal panel2 = new PanelPrincipal();
            panel2.Show();
            this.Hide();
        }
        //Cerrar App
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar Ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
