namespace PassCrypt
{
    partial class SifreKaydet
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
            this.btn_sifreKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_platform = new System.Windows.Forms.TextBox();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sifreKaydet
            // 
            this.btn_sifreKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btn_sifreKaydet.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifreKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn_sifreKaydet.Location = new System.Drawing.Point(93, 215);
            this.btn_sifreKaydet.Name = "btn_sifreKaydet";
            this.btn_sifreKaydet.Size = new System.Drawing.Size(225, 31);
            this.btn_sifreKaydet.TabIndex = 19;
            this.btn_sifreKaydet.Text = "Kaydet";
            this.btn_sifreKaydet.UseVisualStyleBackColor = false;
            this.btn_sifreKaydet.Click += new System.EventHandler(this.btn_sifreKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Site/Platform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(104, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 48);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre Kaydet";
            // 
            // tb_platform
            // 
            this.tb_platform.Location = new System.Drawing.Point(187, 119);
            this.tb_platform.Name = "tb_platform";
            this.tb_platform.Size = new System.Drawing.Size(131, 20);
            this.tb_platform.TabIndex = 20;
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(187, 163);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(131, 20);
            this.tb_sifre.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Şifre";
            // 
            // SifreKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(409, 319);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_platform);
            this.Controls.Add(this.btn_sifreKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "SifreKaydet";
            this.Text = "SifreKaydet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sifreKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_platform;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label label3;
    }
}