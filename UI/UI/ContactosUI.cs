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
    public partial class ContactosUI : Form
    {
        public ContactosUI()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "a.abanero@acl.cl";
            ec.Show();
            this.Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "a.abanero@acl.cl";
            ec.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "a.abanero@acl.cl";
            ec.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "a.abanero@acl.cl";
            ec.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "agutierrez@acl.cl";
            ec.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "agutierrez@acl.cl";
            ec.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "agutierrez@acl.cl";
            ec.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "agutierrez@acl.cl";
            ec.Show();
            this.Hide();
        }


    }
}
