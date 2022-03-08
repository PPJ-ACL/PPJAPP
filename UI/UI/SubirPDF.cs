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
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Negocio ng = new Negocio();
            UserCredential credential;
            string[] Scopes = { DriveService.Scope.Drive };

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                //GoogleClientSecrets.Load
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
            // Create Drive API service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            ng.subirImg("C:\\demoDrive\\EjemploMERN.pdf", service);
        }
    }
}
