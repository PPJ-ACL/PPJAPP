using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace UI
{
    public partial class SubirPDF : Form
    {
        public SubirPDF()
        {
            InitializeComponent();
            CenterToScreen();
        }
        /*
        Abrir Archivo
        Desarrollado 07/03 08/03
        */
        private void btnExplorar_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = false;
            if(dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string nombreArchivo = dlg.FileName;
                string valArchivo = nombreArchivo.Substring(nombreArchivo.Length - 3);
                if (valArchivo=="pdf")
                {
                    txtDireccion.Text = nombreArchivo;
                }else
                {
                    MessageBox.Show("El Archivo seleccionado no es valido","SAPJ ACL Error:");
                }
                
            }
        }
        /*
        Subir PDF por Luis C
        Desarrollado 07/03 - 08/03
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio ng = new Negocio();
                UserCredential credential;
                string[] Scopes = { DriveService.Scope.Drive };

                using (var stream =
                    new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    //El archivo token.json almacena los tokens de acceso y actualización del usuario
                    ////y se crea automáticamente cuando el flujo de autorización se completa por primera vez. 
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }
                string ApplicationName = "SAPJ ACL";
                // Creacion del api
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
                ng.subirPdf(txtDireccion.Text, service);
                //Mensaje de ERROR
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Se subío correctamente a Drive";
                em.Show();
                txtDireccion.Text = "";
            }
            catch (Exception ex)
            {
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Error en la conexion a base de datos, Favor contacte a un administrador" + ex.Message;
                em.Show();
            }
            


        }
        //Cambio Ventana
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Vista_Admin va = new Vista_Admin();
            va.Show();
            this.Hide();
        }
        //Cerrar App
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar App
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
