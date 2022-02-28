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
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
               
        }

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
                    MessageBox.Show("Error en el correo ingresado", "PPJ APP Error");
                    txtCorreo.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Error en el correo ingresado", "PPJ APP Error");
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.White;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.White;
                txtContra.UseSystemPasswordChar = false;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String ConnectString = @"Data Source=DESKTOP-398JQJ0\SQLEXPRESS;Initial Catalog=SAPJDEV ;Integrated Security=True";
            String selectStock = "SELECT COUNT(Correo) AS NUMUSUARIO FROM VistaLogin WHERE VistaLogin.Correo = '" + txtCorreo.Text + "' AND VistaLogin.contrasenna = '" + txtContra.Text + "';";
            //SELECT COUNT(Correo) AS NUMUSUARIO FROM VistaLogin WHERE VistaLogin.Correo = 'lcordova@acl.cl' AND VistaLogin.contrasenna = 'LCordova123';
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
                    
                    if (valUsu == 1)
                    {
                        PanelPrincipal panel2 = new PanelPrincipal();
                        panel2.Show();
                    }
                    else if (valUsu == 0)
                    {
                        MessageBox.Show("Error en inicio de sesión", "PPJ APP Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion a base de datos, Favor contacte a un administrador"+ex.Message, "PPJ APP Error");
            }



        }
        /*
         
         
         */
    }
}