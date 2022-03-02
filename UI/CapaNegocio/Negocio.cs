using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Negocio
    {
        //Nueva ConexionSQL
        private ConexionSQL conec;
        //Get y Set BD
        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configConex()
        {
            this.Conec = new ConexionSQL();
            //Nombre Tabla Principal BD
            this.Conec.NombreTabla = "Profesional";
            //Nombre BD SQL Server
            this.Conec.NombreBaseDatos = "SAPJDEV";
            //Cadena Conexion Francisco
            //this.Conec.CadenaConexion = @"Data Source=MARUCHANBOOK;Initial Catalog=SAPJDEV ;Integrated Security=True"; 
            //Cadena Conexion Luis
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-398JQJ0\SQLEXPRESS;Initial Catalog=SAPJDEV ;Integrated Security=True";
        }

        public DataSet Login(string correo, string cont)
        {
            //Configura Conexion
            this.configConex();
            //Sentencia Select
            this.Conec.CadenaSQL = "SELECT * FROM VistaLogin WHERE VistaLogin.Correo = '" + correo + "' AND VistaLogin.contrasenna = '" + cont + "';";
            //Confirmación de Sentencia Select
            this.Conec.EsSelect = true;
            //Conexion a BD con envio de la cadena
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        public string sendMail(string to, string asunto, string body)
        {
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            string from = "SAPJACL@hotmail.com";
            string displayName = "SAPJ ACL";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;


                SmtpClient client = new SmtpClient("smtp.office365.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                client.Credentials = new NetworkCredential(from, "SAPJ2022.");
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false


                client.Send(mail);
                msge = "¡Correo enviado exitosamente! Pronto te contactaremos.";

            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }

    }
}
