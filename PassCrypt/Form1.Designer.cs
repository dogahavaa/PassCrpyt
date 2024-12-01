namespace PassCrypt
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_SifreOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SifreKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KayitliSifrelerim = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_SifreOlustur,
            this.TSMI_SifreKaydet,
            this.TSMI_KayitliSifrelerim});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_SifreOlustur
            // 
            this.TSMI_SifreOlustur.Name = "TSMI_SifreOlustur";
            this.TSMI_SifreOlustur.Size = new System.Drawing.Size(84, 20);
            this.TSMI_SifreOlustur.Text = "Şifre Oluştur";
            this.TSMI_SifreOlustur.Click += new System.EventHandler(this.TSMI_SifreOlustur_Click);
            // 
            // TSMI_SifreKaydet
            // 
            this.TSMI_SifreKaydet.Name = "TSMI_SifreKaydet";
            this.TSMI_SifreKaydet.Size = new System.Drawing.Size(81, 20);
            this.TSMI_SifreKaydet.Text = "Şifre Kaydet";
            this.TSMI_SifreKaydet.Click += new System.EventHandler(this.TSMI_SifreKaydet_Click);
            // 
            // TSMI_KayitliSifrelerim
            // 
            this.TSMI_KayitliSifrelerim.Name = "TSMI_KayitliSifrelerim";
            this.TSMI_KayitliSifrelerim.Size = new System.Drawing.Size(104, 20);
            this.TSMI_KayitliSifrelerim.Text = "Kayıtlı Şifrelerim";
            this.TSMI_KayitliSifrelerim.Click += new System.EventHandler(this.TSMI_KayitliSifrelerim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SifreOlustur;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SifreKaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KayitliSifrelerim;
    }
}

