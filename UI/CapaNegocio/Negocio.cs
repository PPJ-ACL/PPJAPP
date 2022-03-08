using CapaConexion;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Negocio
    {
        //Nueva ConexionSQL
        private ConexionSQL conec;

        static string[] Scopes = { DriveService.Scope.Drive };


        //Get y Set BD
        public ConexionSQL Conec { get => conec; set => conec = value; }
        /*
         Codigo para configurar un acceso a bd
         Desarrollado el 18/02/2022
        */
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

        /*
         Codigo para logearse con credenciales
         Desarrollado el 21/02/2022
        */
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
        /*
         Codigo para enviar un correo bajo el sistema de soporte
         Desarrollado el 02/03/2022
        */
        public string enviarMail(string to, string asunto, string body)
        {
            //Msg Error
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            //Correo Origen
            string from = "SAPJACL@gmail.com";
            //Alias
            string displayName = "SAPJ ACL";
            try
            {
                //Instancia
                MailMessage mail = new MailMessage();
                //Desde donde sale el correo
                mail.From = new MailAddress(from, displayName);
                //Destinatario
                mail.To.Add(to);
                //Copia Segundo Destinatario
                mail.CC.Add("fveas@acl.cl");
                mail.CC.Add("lcordova@acl.cl");
                //Asunto
                mail.Subject = asunto;
                //Cuerpo
                mail.Body = body;
                //Validacion Cuerpo HTML
                mail.IsBodyHtml = true;

                //Server a usar
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                //Credenciales
                client.Credentials = new NetworkCredential(from, "SAPJ2021.");
                //Cifrado SSL
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false

                //Enviar 
                client.Send(mail);
                //Msg Confirma
                msge = "¡Correo enviado exitosamente! Pronto te contactaremos.";

            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }

        public void subirImg(string v, DriveService service)
        {
            throw new NotImplementedException();
        }

        /*
        Codigo para enviar un correo bajo el sistema de soporte
        Desarrollado el 07/03/2022
        */
        public string enviarCorreoContactos(string to, string asunto, string body)
        {
            //Msg Error
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            //Correo Origen
            string from = "SAPJACL@gmail.com";
            //Alias
            string displayName = "SAPJ ACL";
            try
            {
                //Instancia
                MailMessage mail = new MailMessage();
                //Desde donde sale el correo
                mail.From = new MailAddress(from, displayName);
                //Destinatario
                mail.To.Add(to);
                //Asunto
                mail.Subject = asunto;
                //Cuerpo
                mail.Body = body;
                //Validacion Cuerpo HTML
                mail.IsBodyHtml = true;

                //Server a usar
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                //Credenciales
                client.Credentials = new NetworkCredential(from, "SAPJ2021.");
                //Cifrado SSL
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false

                //Enviar 
                client.Send(mail);
                //Msg Confirma
                msge = "¡Correo enviado exitosamente!";

            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }



        /*
            Codigo para subir un PDF
            Desarrollado el 07/03/2022-08/03/2022
        */
        public void subirPdf(string path, DriveService service)
        {
            var fileMetadata= new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = Path.GetFileName(path);
            fileMetadata.MimeType = "application/pdf";
            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(path,System.IO.FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "application/pdf");
                request.Fields = "id";
                request.Upload();
            }
            var file = request.ResponseBody;
            Console.WriteLine("File ID:" + file.Id);
        }






















    }
}
