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
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 26);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(215, 23);
            this.txtDireccion.TabIndex = 0;
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(337, 26);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(75, 23);
            this.btnExplorar.TabIndex = 1;
            this.btnExplorar.Text = "Explorar";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // lblDire
            // 
            this.lblDire.AutoSize = true;
            this.lblDire.Location = new System.Drawing.Point(53, 29);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(57, 15);
            this.lblDire.TabIndex = 3;
            this.lblDire.Text = "Direccion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Subir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubirPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDire);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.txtDireccion);
            this.Name = "SubirPDF";
            this.Text = "SubirPDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDireccion;
        private Button btnExplorar;
        private Label lblDire;
        private Button button1;
    }
}