namespace UI
{
    partial class SubirPDF
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.lblDire = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.degradePanel1 = new UI.DegradePanel();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.degradePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.txtDireccion.Location = new System.Drawing.Point(255, 130);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(308, 23);
            this.txtDireccion.TabIndex = 0;
            // 
            // btnExplorar
            // 
            this.btnExplorar.BackColor = System.Drawing.Color.Transparent;
            this.btnExplorar.BackgroundImage = global::UI.Properties.Resources.Group_20;
            this.btnExplorar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExplorar.Location = new System.Drawing.Point(578, 117);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(51, 47);
            this.btnExplorar.TabIndex = 1;
            this.btnExplorar.UseVisualStyleBackColor = false;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // lblDire
            // 
            this.lblDire.AutoSize = true;
            this.lblDire.BackColor = System.Drawing.Color.Transparent;
            this.lblDire.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDire.Location = new System.Drawing.Point(153, 128);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(96, 25);
            this.lblDire.TabIndex = 3;
            this.lblDire.Text = "Direccion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::UI.Properties.Resources.Group_19;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(343, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 123);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // degradePanel1
            // 
            this.degradePanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.degradePanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(87)))));
            this.degradePanel1.Controls.Add(this.label1);
            this.degradePanel1.Controls.Add(this.pictureBox5);
            this.degradePanel1.Controls.Add(this.lblDire);
            this.degradePanel1.Controls.Add(this.button1);
            this.degradePanel1.Controls.Add(this.txtDireccion);
            this.degradePanel1.Controls.Add(this.btnExplorar);
            this.degradePanel1.Location = new System.Drawing.Point(405, 165);
            this.degradePanel1.Name = "degradePanel1";
            this.degradePanel1.Size = new System.Drawing.Size(845, 507);
            this.degradePanel1.TabIndex = 5;
            this.degradePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.degradePanel1_Paint);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Image = global::UI.Properties.Resources.iconFull1;
            this.btnMax.Location = new System.Drawing.Point(1208, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 18;
            this.btnMax.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::UI.Properties.Resources.iconExit;
            this.btnCerrar.Location = new System.Drawing.Point(1255, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::UI.Properties.Resources.iconMin;
            this.btnMinimizar.Location = new System.Drawing.Point(1161, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::UI.Properties.Resources.Boton_Volver;
            this.btnVolver.Location = new System.Drawing.Point(405, 707);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(236, 69);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 26;
            this.btnVolver.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(330, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subir Archivo";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::UI.Properties.Resources.Line_2;
            this.pictureBox5.Location = new System.Drawing.Point(16, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(826, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // SubirPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(87)))));
            this.BackgroundImage = global::UI.Properties.Resources.imagen_4;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.degradePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubirPDF";
            this.Text = "SubirPDF";
            this.degradePanel1.ResumeLayout(false);
            this.degradePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtDireccion;
        private Button btnExplorar;
        private Label lblDire;
        private Button button1;
        private DegradePanel degradePanel1;
        private PictureBox btnMax;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnVolver;
        private Label label1;
        private PictureBox pictureBox5;
    }
}