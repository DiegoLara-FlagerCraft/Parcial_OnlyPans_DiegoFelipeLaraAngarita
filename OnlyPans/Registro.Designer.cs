
namespace OnlyPans
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.TxtTitilo = new System.Windows.Forms.Label();
            this.TxtSaludo = new System.Windows.Forms.Label();
            this.BtnCerrarAdmin = new System.Windows.Forms.Button();
            this.PictureBoxAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(141, 140);
            this.PictureBoxLogo.TabIndex = 1;
            this.PictureBoxLogo.TabStop = false;
            // 
            // TxtTitilo
            // 
            this.TxtTitilo.AutoSize = true;
            this.TxtTitilo.BackColor = System.Drawing.Color.Transparent;
            this.TxtTitilo.Font = new System.Drawing.Font("Vladimir Script", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtTitilo.Location = new System.Drawing.Point(240, -6);
            this.TxtTitilo.Name = "TxtTitilo";
            this.TxtTitilo.Size = new System.Drawing.Size(455, 129);
            this.TxtTitilo.TabIndex = 2;
            this.TxtTitilo.Text = "Only Pans";
            // 
            // TxtSaludo
            // 
            this.TxtSaludo.AutoSize = true;
            this.TxtSaludo.BackColor = System.Drawing.Color.Transparent;
            this.TxtSaludo.Font = new System.Drawing.Font("Lucida Bright", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaludo.Location = new System.Drawing.Point(159, 148);
            this.TxtSaludo.Name = "TxtSaludo";
            this.TxtSaludo.Size = new System.Drawing.Size(622, 160);
            this.TxtSaludo.TabIndex = 3;
            this.TxtSaludo.Text = "BUENOS DIAS ADMINISTRADORA\r\nBIENVENIDA A ONLY PANS\r\n\r\nONLY PANS PARA SERVIRLE\r\n";
            this.TxtSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrarAdmin
            // 
            this.BtnCerrarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCerrarAdmin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarAdmin.Location = new System.Drawing.Point(233, 569);
            this.BtnCerrarAdmin.Name = "BtnCerrarAdmin";
            this.BtnCerrarAdmin.Size = new System.Drawing.Size(434, 38);
            this.BtnCerrarAdmin.TabIndex = 24;
            this.BtnCerrarAdmin.Text = "CERRAR SESIÓN";
            this.BtnCerrarAdmin.UseVisualStyleBackColor = false;
            this.BtnCerrarAdmin.Click += new System.EventHandler(this.BtnCerrarAdmin_Click);
            // 
            // PictureBoxAdmin
            // 
            this.PictureBoxAdmin.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAdmin.Image")));
            this.PictureBoxAdmin.Location = new System.Drawing.Point(363, 334);
            this.PictureBoxAdmin.Name = "PictureBoxAdmin";
            this.PictureBoxAdmin.Size = new System.Drawing.Size(200, 200);
            this.PictureBoxAdmin.TabIndex = 25;
            this.PictureBoxAdmin.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 631);
            this.Controls.Add(this.PictureBoxAdmin);
            this.Controls.Add(this.BtnCerrarAdmin);
            this.Controls.Add(this.TxtSaludo);
            this.Controls.Add(this.TxtTitilo);
            this.Controls.Add(this.PictureBoxLogo);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label TxtTitilo;
        private System.Windows.Forms.Label TxtSaludo;
        private System.Windows.Forms.Button BtnCerrarAdmin;
        private System.Windows.Forms.PictureBox PictureBoxAdmin;
    }
}