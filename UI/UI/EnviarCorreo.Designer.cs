namespace UI
{
    partial class EnviarCorreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarCorreo));
            this.degradePanel1 = new UI.DegradePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.degradePanel2 = new UI.DegradePanel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.txtCorreo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.degradePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.degradePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // degradePanel1
            // 
            this.degradePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.degradePanel1.BackgroundImage = global::UI.Properties.Resources.imagen_4;
            this.degradePanel1.ColorBottom = System.Drawing.Color.Empty;
            this.degradePanel1.ColorTop = System.Drawing.Color.Empty;
            this.degradePanel1.Controls.Add(this.label5);
            this.degradePanel1.Controls.Add(this.pictureBox1);
            this.degradePanel1.Controls.Add(this.degradePanel2);
            this.degradePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.degradePanel1.Location = new System.Drawing.Point(0, 0);
            this.degradePanel1.Name = "degradePanel1";
            this.degradePanel1.Size = new System.Drawing.Size(1319, 825);
            this.degradePanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(73, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre De Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UI.Properties.Resources.Circulo_User;
            this.pictureBox1.Location = new System.Drawing.Point(107, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // degradePanel2
            // 
            this.degradePanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.degradePanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.degradePanel2.Controls.Add(this.btnEnviar);
            this.degradePanel2.Controls.Add(this.txtMensaje);
            this.degradePanel2.Controls.Add(this.txtCorreo);
            this.degradePanel2.Controls.Add(this.label3);
            this.degradePanel2.Controls.Add(this.label2);
            this.degradePanel2.Location = new System.Drawing.Point(370, 76);
            this.degradePanel2.Name = "degradePanel2";
            this.degradePanel2.Size = new System.Drawing.Size(906, 645);
            this.degradePanel2.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = global::UI.Properties.Resources.Icono_enviar;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviar.Location = new System.Drawing.Point(320, 531);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(303, 91);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensaje.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMensaje.Location = new System.Drawing.Point(239, 129);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(471, 396);
            this.txtMensaje.TabIndex = 5;
            this.txtMensaje.Text = "";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Location = new System.Drawing.Point(239, 82);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(471, 30);
            this.txtCorreo.TabIndex = 4;
            this.txtCorreo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(124, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(124, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo";
            // 
            // EnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 825);
            this.Controls.Add(this.degradePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnviarCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarCorreo";
            this.degradePanel1.ResumeLayout(false);
            this.degradePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.degradePanel2.ResumeLayout(false);
            this.degradePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DegradePanel degradePanel1;
        private DegradePanel degradePanel2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Label label3;
        private RichTextBox txtMensaje;
        private Button btnEnviar;
        public RichTextBox txtCorreo;
    }
}