
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
            this.TxtRegistro = new System.Windows.Forms.Label();
            this.richTextRegistro = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
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
            this.TxtTitilo.Font = new System.Drawing.Font("Vladimir Script", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtTitilo.Location = new System.Drawing.Point(257, -16);
            this.TxtTitilo.Name = "TxtTitilo";
            this.TxtTitilo.Size = new System.Drawing.Size(410, 116);
            this.TxtTitilo.TabIndex = 2;
            this.TxtTitilo.Text = "Only Pans";
            // 
            // TxtRegistro
            // 
            this.TxtRegistro.AutoSize = true;
            this.TxtRegistro.BackColor = System.Drawing.Color.Transparent;
            this.TxtRegistro.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegistro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TxtRegistro.Location = new System.Drawing.Point(365, 112);
            this.TxtRegistro.Name = "TxtRegistro";
            this.TxtRegistro.Size = new System.Drawing.Size(200, 40);
            this.TxtRegistro.TabIndex = 22;
            this.TxtRegistro.Text = "REGISTRO";
            // 
            // richTextRegistro
            // 
            this.richTextRegistro.Location = new System.Drawing.Point(277, 155);
            this.richTextRegistro.Name = "richTextRegistro";
            this.richTextRegistro.Size = new System.Drawing.Size(341, 464);
            this.richTextRegistro.TabIndex = 23;
            this.richTextRegistro.Text = "";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 631);
            this.Controls.Add(this.richTextRegistro);
            this.Controls.Add(this.TxtRegistro);
            this.Controls.Add(this.TxtTitilo);
            this.Controls.Add(this.PictureBoxLogo);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label TxtTitilo;
        private System.Windows.Forms.Label TxtRegistro;
        private System.Windows.Forms.RichTextBox richTextRegistro;
    }
}