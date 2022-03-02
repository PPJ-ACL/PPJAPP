﻿using CapaNegocio;
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
    public partial class EnviarBug : Form
    {
        public EnviarBug()
        {
            InitializeComponent();
            CenterToScreen();
        }

        /*
         Codigo para enviar el correo
         Desarrollado el 02/03/2022
        */
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {   
                string body = @"<div style=font-size:32px;color:#FFFFFF;background-color:#E02957;>ACL<br></div><div style=font-size:20px;color:#000000> El Mensaje del usuario fue:<br>" + tbBug.Text + " <br>Correo del Usuario:<div>" + txtCorreo.Text + "</div>  <div style= background-color:#7D1630;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ  <br> <a href ='https://www.facebook.com/aclconsultores/'><font style=color:white>Facebook           </font></a> <a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= color:white>Linkedin</font></a> </div> </div>";
                Negocio ng = new Negocio();
                
                ng.sendMail("lcordova@acl.cl", "BUG SAPJ ACL", body);
                MessageBox.Show("Mensaje Enviado Con Exito", "PPJ APP");
                
            }
            catch (Exception ex)
            {
                //Mensaje Error
                MessageBox.Show("Error:"+ex.Message, "PPJ APP Error");
            }
            
        }
    }
}
