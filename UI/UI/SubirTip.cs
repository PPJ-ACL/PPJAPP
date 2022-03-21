using CapaNegocio;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
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
    public partial class SubirTip : Form
    {
        public SubirTip()
        {
            InitializeComponent();
        }

        private async void btnTMERN_Click(object sender, EventArgs e)
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
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var request = service.Files.List();
                var results = await request.ExecuteAsync();
                foreach (var driveFile in results.Files)
                {
                    if (driveFile.MimeType == "application/vnd.google-apps.folder")
                    {
                        if (driveFile.Name == "TipsMern")
                        {
                            SubirPDF sp = new SubirPDF();
                            sp.nombreCarpeta = driveFile.Name;
                            sp.idCarpeta = driveFile.Id;
                            sp.Show();
                            this.Hide();                            
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private async void btnTPostMan_Click(object sender, EventArgs e)
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
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var request = service.Files.List();
                var results = await request.ExecuteAsync();
                foreach (var driveFile in results.Files)
                {
                    if (driveFile.MimeType == "application/vnd.google-apps.folder")
                    {
                        if (driveFile.Name == "TipsPostMan")
                        {
                            SubirPDF sp = new SubirPDF();
                            sp.nombreCarpeta = driveFile.Name;
                            sp.idCarpeta = driveFile.Id;
                            sp.Show();
                            this.Hide();
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnTJava_Click(object sender, EventArgs e)
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
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var request = service.Files.List();
                var results = await request.ExecuteAsync();
                foreach (var driveFile in results.Files)
                {
                    if (driveFile.MimeType == "application/vnd.google-apps.folder")
                    {
                        if (driveFile.Name == "TipsJava")
                        {
                            SubirPDF sp = new SubirPDF();
                            sp.nombreCarpeta = driveFile.Name;
                            sp.idCarpeta = driveFile.Id;
                            sp.Show();
                            this.Hide();
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void btnTKarate_Click(object sender, EventArgs e)
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
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                var request = service.Files.List();
                var results = await request.ExecuteAsync();
                foreach (var driveFile in results.Files)
                {
                    if (driveFile.MimeType == "application/vnd.google-apps.folder")
                    {
                        if (driveFile.Name == "TipsKarate")
                        {
                            SubirPDF sp = new SubirPDF();
                            sp.nombreCarpeta = driveFile.Name;
                            sp.idCarpeta = driveFile.Id;
                            sp.Show();
                            this.Hide();
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Vista_Admin va = new Vista_Admin();
            va.Show();
            this.Hide();
        }
    }
}

