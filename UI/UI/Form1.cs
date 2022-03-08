using CapaNegocio;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class Form1 : Form
    {
        //Cadena Luis
        String ConnectString = @"Data Source=LUCHITO-PC\SQLEXPRESS;Initial Catalog=SAPJDEV ;Integrated Security=True";
        //Cadena Francisco
        //String ConnectString = @"Data Source=MARUCHANBOOK;Initial Catalog=SAPJDEV ;Integrated Security=True"; 
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        //Cerrar Programa
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        //Minimizar Programa
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Relleno Campo
        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
               
        }
        /*
         Validaciones Correo
         Desarrollado el 28/02/2022
        */
        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.White;
            }
            else if(txtCorreo.TextLength > 8)
            {
                //Validacion Correo ACL
                string cor = txtCorreo.Text;
                string valAcl = cor.Substring(cor.Length - 7);
                if (valAcl == "@acl.cl")
                {
                   
                }else
                {
                    //Mensaje Error
                    ErrorMsg em = new ErrorMsg();
                    em.lblError.Text = "Error en el correo ingresado.";
                    em.Show();
                    txtCorreo.Focus();
                }
                
            }
            else
            {
                //Mensaje Error
                ErrorMsg em = new ErrorMsg();
                em.lblError.Text = "Error en el correo ingresado.";
                em.Show();
            }
        }
        //Relleno Contra
        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.White;
            }
        }
        //Relleno Contra
        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.White;
                txtContra.UseSystemPasswordChar = false;
            }
        }
        /*
         Codigo para logearse con la BD
         Desarrollado el 27/02/2022 -- Modificado 08/03/2022-07/03/2022
        */
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String selectStock = "SELECT COUNT(Correo) AS NUMUSUARIO, TipoUsuario AS TIPOUSUARIO FROM VistaLogin WHERE VistaLogin.Correo = '" + txtCorreo.Text + "' AND VistaLogin.contrasenna = '" + txtContra.Text + "' GROUP BY TipoUsuario;";
            SqlConnection con = new SqlConnection(ConnectString);
            SqlCommand cmd = new SqlCommand(selectStock, con);
            SqlDataReader mReader;
            try
            {
                con.Open();
                mReader = cmd.ExecuteReader();
                while (mReader.Read())
                {
                    int valUsu = mReader.GetInt32("NUMUSUARIO");
                    string tipoUsu = mReader.GetString("TIPOUSUARIO");
                    if (valUsu != 1)
                    { 
                    }
                    else
                    {
                        txtValUsu.Text = valUsu+"";
                        txtTipoUsuario.Text = tipoUsu;
                    }
                }
                if (txtValUsu.Text != "1")
                {
                    ErrorMsg em = new ErrorMsg();
                    em.lblError.Text = "Error en el Inicio de Sesion.";
                    em.Show();
                }
                else
                {  
                    if(txtTipoUsuario.Text == "admin")
                    {
                        Vista_Admin va = new Vista_Admin();
                        va.txtTipoUsuario.Text = txtTipoUsuario.Text;
                        va.Show();
                        this.Hide();
                    }else if(txtTipoUsuario.Text != "admin")
                    {
                        PanelPrincipal panel2 = new PanelPrincipal();
                        panel2.Show();
                        this.Hide();
                    }        
                }
            }
            catch (Exception ex)
            {
                ErrorMsg em = new ErrorMsg();  
                em.lblError.Text = "Error en la conexion a base de datos, Favor contacte a un administrador" + ex.Message;
                em.Show();
            }
        }
        
    }
}