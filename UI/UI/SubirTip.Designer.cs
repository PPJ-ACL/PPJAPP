namespace UI
{
    partial class SubirTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubirTip));
            this.degradePanel1 = new UI.DegradePanel();
            this.degradePanel2 = new UI.DegradePanel();
            this.btnTJava = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTPostMan = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnTMERN = new System.Windows.Forms.PictureBox();
            this.btnTKarate = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.degradePanel1.SuspendLayout();
            this.degradePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTJava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTPostMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTMERN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTKarate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // degradePanel1
            // 
            this.degradePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(87)))));
            this.degradePanel1.BackgroundImage = global::UI.Properties.Resources.imagen_4;
            this.degradePanel1.ColorBottom = System.Drawing.Color.Empty;
            this.degradePanel1.ColorTop = System.Drawing.Color.Empty;
            this.degradePanel1.Controls.Add(this.btnAceptar);
            this.degradePanel1.Controls.Add(this.btnVolver);
            this.degradePanel1.Controls.Add(this.degradePanel2);
            this.degradePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.degradePanel1.Location = new System.Drawing.Point(0, 0);
            this.degradePanel1.Name = "degradePanel1";
            this.degradePanel1.Size = new System.Drawing.Size(1300, 800);
            this.degradePanel1.TabIndex = 0;
            // 
            // degradePanel2
            // 
            this.degradePanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.degradePanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(41)))), ((int)(((byte)(87)))));
            this.degradePanel2.Controls.Add(this.btnTJava);
            this.degradePanel2.Controls.Add(this.label1);
            this.degradePanel2.Controls.Add(this.btnTPostMan);
            this.degradePanel2.Controls.Add(this.pictureBox5);
            this.degradePanel2.Controls.Add(this.btnTMERN);
            this.degradePanel2.Controls.Add(this.btnTKarate);
            this.degradePanel2.Location = new System.Drawing.Point(228, 147);
            this.degradePanel2.Name = "degradePanel2";
            this.degradePanel2.Size = new System.Drawing.Size(845, 507);
            this.degradePanel2.TabIndex = 6;
            // 
            // btnTJava
            // 
            this.btnTJava.BackColor = System.Drawing.Color.Transparent;
            this.btnTJava.Image = global::UI.Properties.Resources.icon_Tips_Java;
            this.btnTJava.Location = new System.Drawing.Point(448, 348);
            this.btnTJava.Name = "btnTJava";
            this.btnTJava.Size = new System.Drawing.Size(272, 122);
            this.btnTJava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTJava.TabIndex = 14;
            this.btnTJava.TabStop = false;
            this.btnTJava.Click += new System.EventHandler(this.btnTJava_Click);
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
            // btnTPostMan
            // 
            this.btnTPostMan.BackColor = System.Drawing.Color.Transparent;
            this.btnTPostMan.Image = global::UI.Properties.Resources.icon_TipsPostman;
            this.btnTPostMan.Location = new System.Drawing.Point(437, 101);
            this.btnTPostMan.Name = "btnTPostMan";
            this.btnTPostMan.Size = new System.Drawing.Size(272, 122);
            this.btnTPostMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTPostMan.TabIndex = 13;
            this.btnTPostMan.TabStop = false;
            this.btnTPostMan.Click += new System.EventHandler(this.btnTPostMan_Click);
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
            // btnTMERN
            // 
            this.btnTMERN.BackColor = System.Drawing.Color.Transparent;
            this.btnTMERN.Image = global::UI.Properties.Resources.icon_TipsMern;
            this.btnTMERN.Location = new System.Drawing.Point(119, 101);
            this.btnTMERN.Name = "btnTMERN";
            this.btnTMERN.Size = new System.Drawing.Size(272, 122);
            this.btnTMERN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTMERN.TabIndex = 12;
            this.btnTMERN.TabStop = false;
            this.btnTMERN.Click += new System.EventHandler(this.btnTMERN_Click);
            // 
            // btnTKarate
            // 
            this.btnTKarate.BackColor = System.Drawing.Color.Transparent;
            this.btnTKarate.Image = global::UI.Properties.Resources.Icon_karate_Tips;
            this.btnTKarate.Location = new System.Drawing.Point(119, 348);
            this.btnTKarate.Name = "btnTKarate";
            this.btnTKarate.Size = new System.Drawing.Size(272, 122);
            this.btnTKarate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTKarate.TabIndex = 11;
            this.btnTKarate.TabStop = false;
            this.btnTKarate.Click += new System.EventHandler(this.btnTKarate_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::UI.Properties.Resources.Boton_Volver;
            this.btnVolver.Location = new System.Drawing.Point(228, 695);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(236, 69);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolver.TabIndex = 27;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Image = global::UI.Properties.Resources.Boton_Login;
            this.btnAceptar.Location = new System.Drawing.Point(800, 695);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(236, 69);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Subir Plan de Estudio";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // SubirTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.degradePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubirTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubirTip";
            this.degradePanel1.ResumeLayout(false);
            this.degradePanel2.ResumeLayout(false);
            this.degradePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTJava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTPostMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTMERN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTKarate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DegradePanel degradePanel1;
        private DegradePanel degradePanel2;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox btnTJava;
        private PictureBox btnTPostMan;
        private PictureBox btnTMERN;
        private PictureBox btnTKarate;
        private PictureBox btnVolver;
        private Button btnAceptar;
    }
}