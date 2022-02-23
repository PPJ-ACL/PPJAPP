namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void degradePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PanelPrincipal panel2 = new PanelPrincipal();
        
            panel2.Show();            

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
    }
}