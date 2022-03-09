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
    public partial class PlanesJAVA : Form
    {
        public PlanesJAVA()
        {
            InitializeComponent();
            CenterToScreen();
        }
        //Cambio Ventana
        private void btnVolver_Click(object sender, EventArgs e)
        {
            PlanEstudio planEstudio = new PlanEstudio();
            planEstudio.Show();
            this.Close();
        }
        //Cerrar App
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar App
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Maximizar App
        private void btnMax_Click(object sender, EventArgs e)
        {

        }
    }
}
