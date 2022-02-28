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
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEstudio_Click(object sender, EventArgs e)
        {
            PlanEstudio planEstudio = new PlanEstudio();
            planEstudio.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
