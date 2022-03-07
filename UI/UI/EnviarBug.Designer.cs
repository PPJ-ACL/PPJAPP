namespace UI
{
    partial class EnviarBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarBug));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBug = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.degradePanel1 = new UI.DegradePanel();
            this.txtCorreo = new System.Windows.Forms.RichTextBox();
            this.btnBug = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAyuda = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.degradePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(141, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(161, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Error";
            // 
            // tbBug
            // 
            this.tbBug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.tbBug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBug.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBug.ForeColor = System.Drawing.SystemColors.Window;
            this.tbBug.Location = new System.Drawing.Point(239, 129);
            this.tbBug.Name = "tbBug";
            this.tbBug.Size = new System.Drawing.Size(471, 396);
            this.tbBug.TabIndex = 4;
            this.tbBug.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = global::UI.Properties.Resources.Icono_enviar;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnviar.Location = new System.Drawing.Point(316, 541);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(303, 91);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Image = global::UI.Properties.Resources.iconFull1;
            this.btnMax.Location = new System.Drawing.Point(1236, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 18;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::UI.Properties.Resources.iconExit;
            this.btnCerrar.Location = new System.Drawing.Point(1283, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::UI.Properties.Resources.iconMin;
            this.btnMinimizar.Location = new System.Drawing.Point(1189, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // degradePanel1
            // 
            this.degradePanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.degradePanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.degradePanel1.Controls.Add(this.txtCorreo);
            this.degradePanel1.Controls.Add(this.btnBug);
            this.degradePanel1.Controls.Add(this.label3);
            this.degradePanel1.Controls.Add(this.pictureBox5);
            this.degradePanel1.Controls.Add(this.label2);
            this.degradePanel1.Controls.Add(this.pictureBox2);
            this.degradePanel1.Controls.Add(this.pictureBox1);
            this.degradePanel1.Controls.Add(this.tbBug);
            this.degradePanel1.Controls.Add(this.btnEnviar);
            this.degradePanel1.Controls.Add(this.label1);
            this.degradePanel1.Location = new System.Drawing.Point(370, 76);
            this.degradePanel1.Name = "degradePanel1";
            this.degradePanel1.Size = new System.Drawing.Size(906, 645);
            this.degradePanel1.TabIndex = 19;
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
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "";
            // 
            // btnBug
            // 
            this.btnBug.BackColor = System.Drawing.Color.Transparent;
            this.btnBug.Image = global::UI.Properties.Resources.icon_Bug;
            this.btnBug.Location = new System.Drawing.Point(40, 262);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(104, 104);
            this.btnBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBug.TabIndex = 10;
            this.btnBug.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(347, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reporte de Bug";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::UI.Properties.Resources.Line_2;
            this.pictureBox5.Location = new System.Drawing.Point(40, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(826, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UI.Properties.Resources.PPJ;
            this.pictureBox2.Location = new System.Drawing.Point(808, 550);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UI.Properties.Resources.ACL_1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 522);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::UI.Properties.Resources.Circulo_User;
            this.pictureBox3.Location = new System.Drawing.Point(107, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 187);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Image = global::UI.Properties.Resources.Pregunta_Icon;
            this.btnAyuda.Location = new System.Drawing.Point(275, 325);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(70, 70);
            this.btnAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAyuda.TabIndex = 22;
            this.btnAyuda.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::UI.Properties.Resources.Brazuca_Sitting1;
            this.pictureBox10.Location = new System.Drawing.Point(47, 338);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(282, 482);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::UI.Properties.Resources.Boton_Volver;
            this.btnVolver.Location = new System.Drawing.Point(370, 739);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(236, 69);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 27;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // EnviarBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.BackgroundImage = global::UI.Properties.Resources.imagen_4;
            this.ClientSize = new System.Drawing.Size(1320, 820);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.degradePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnviarBug";
            this.Text = "EnviarBug";
            this.Load += new System.EventHandler(this.EnviarBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.degradePanel1.ResumeLayout(false);
            this.degradePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private RichTextBox tbBug;
        private Button btnEnviar;
        private PictureBox btnMax;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private DegradePanel degradePanel1;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox btnAyuda;
        private PictureBox pictureBox10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox5;
        private PictureBox btnBug;
        private PictureBox btnVolver;
        private RichTextBox txtCorreo;
    }
}