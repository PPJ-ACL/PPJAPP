﻿using System;
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

        private void btnEstudio_Click(object sender, EventArgs e)
        {
                    }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EnviarCorreo ec = new EnviarCorreo();
            ec.correo = "agutierrez@acl.cl";
            ec.Show();
            this.Hide();
        }
    }
}