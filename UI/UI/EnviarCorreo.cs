using CapaNegocio;
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
    public partial class EnviarCorreo : Form
    {
        public string correo;
        public EnviarCorreo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //string body = @"<div style=font-size:32px;color:#FFFFFF;background-color:#E02957;>ACL<br></div><div style=font-size:20px;color:#000000> El Mensaje del usuario fue:<br>" + tbBug.Text + " <br>Correo del Usuario:<div>" + txtCorreo.Text + "</div>  <div style= background-color:#7D1630;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ  <br> <a href ='https://www.facebook.com/aclconsultores/'><font style=color:white>Facebook           </font></a> <a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= color:white>Linkedin</font></a> </div> </div>";
                string body = @"<div style=background-color:#E02957;height:100px;width:100%></div><!-- Poppins SemiBlod --><div style=font-size:32px;font-family:Poppins,sans-serif;font-weight:600;color:#FFFFFF;background-color:#E02957;><style>@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap');</style>ACL<br></div><div style=font-size:20px;font-family:Poppins,sans-serif;color:#000000>El Mensaje del usuario fue:<br>" + txtMensaje.Text + "<br>Correo del Usuario:<div>" + txtCorreo.Text + "</div><div style= font-size:18px;font-family:Poppins,sans-serif;background-color:#1F2937;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ<br>Mas informacion en nuestras redes sociales.<br></div> <div>	<a href ='https://www.facebook.com/aclconsultores/'> <font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Facebook    </font></a><a href ='https://www.instagram.com/acl.consultores/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Instragram    </font></a><a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Linkedin    </font></a></div></div>";
                Negocio ng = new Negocio();
                ng.enviarMail(correo, "Solicitud Ayuda", body);
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Mensaje Enviado Con Exito.";
                em.Show();

            }
            catch (Exception ex)
            {
                //Mensaje Error
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Error:" + ex.Message;
                em.Show();
            }

        }
    }
}
