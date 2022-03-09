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
    public partial class ConfigUI : Form
    {
        public ConfigUI()
        {
            InitializeComponent();
            CenterToScreen();
        }



        /*
         Codigo para enviar a un nuevo form
         Desarrollado el 28/02/2022
        */
        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal panelPrincipal = new PanelPrincipal();
            panelPrincipal.Show();
            this.Close();
        }

        //Cerrar App
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }
        //Minimizar App
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        /*
         Codigo para enviar a un nuevo form
         Desarrollado el 01/03/2022
        */
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        /*
         Codigo para enviar a un nuevo form
         Desarrollado el 02/03/2022
        */
        private void btnBug_Click(object sender, EventArgs e)
        {
            EnviarBug eb = new EnviarBug();
            eb.Show();
            this.Hide();
        }
    }
}
