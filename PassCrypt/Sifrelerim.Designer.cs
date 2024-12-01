namespace PassCrypt
{
    partial class Sifrelerim
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_guvenlik = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_platformlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_platform = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(124, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 48);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifrelerim";
            // 
            // tb_guvenlik
            // 
            this.tb_guvenlik.Location = new System.Drawing.Point(144, 63);
            this.tb_guvenlik.Name = "tb_guvenlik";
            this.tb_guvenlik.Size = new System.Drawing.Size(100, 20);
            this.tb_guvenlik.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 25;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_platformlar
            // 
            this.lb_platformlar.FormattingEnabled = true;
            this.lb_platformlar.Location = new System.Drawing.Point(106, 126);
            this.lb_platformlar.Name = "lb_platformlar";
            this.lb_platformlar.Size = new System.Drawing.Size(192, 199);
            this.lb_platformlar.TabIndex = 26;
            this.lb_platformlar.SelectedIndexChanged += new System.EventHandler(this.lb_platformlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Site/Platform :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(157, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Şifre :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(206, 383);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(0, 23);
            this.lbl_sifre.TabIndex = 30;
            // 
            // lbl_platform
            // 
            this.lbl_platform.AutoSize = true;
            this.lbl_platform.Font = new System.Drawing.Font("Poppins", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_platform.Location = new System.Drawing.Point(206, 349);
            this.lbl_platform.Name = "lbl_platform";
            this.lbl_platform.Size = new System.Drawing.Size(0, 23);
            this.lbl_platform.TabIndex = 29;
            // 
            // Sifrelerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_platform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_platformlar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_guvenlik);
            this.Controls.Add(this.label2);
            this.Name = "Sifrelerim";
            this.Text = "Sifrelerim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_guvenlik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_platformlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_platform;
    }
}