namespace PassCrypt
{
    partial class SifreOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_olusturulanSifre = new System.Windows.Forms.TextBox();
            this.cb_kucukHarf = new System.Windows.Forms.CheckBox();
            this.cb_ozelKarakter = new System.Windows.Forms.CheckBox();
            this.cb_buyukHarf = new System.Windows.Forms.CheckBox();
            this.cb_sayi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(78, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre Oluşturucu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifre Uzunluğu";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 257);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sayi);
            this.groupBox1.Controls.Add(this.cb_buyukHarf);
            this.groupBox1.Controls.Add(this.cb_ozelKarakter);
            this.groupBox1.Controls.Add(this.cb_kucukHarf);
            this.groupBox1.Location = new System.Drawing.Point(86, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 111);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Özellikleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.button1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.button1.Location = new System.Drawing.Point(86, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Şifre Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_olusturulanSifre
            // 
            this.tb_olusturulanSifre.Location = new System.Drawing.Point(86, 368);
            this.tb_olusturulanSifre.Name = "tb_olusturulanSifre";
            this.tb_olusturulanSifre.Size = new System.Drawing.Size(237, 20);
            this.tb_olusturulanSifre.TabIndex = 14;
            // 
            // cb_kucukHarf
            // 
            this.cb_kucukHarf.AutoSize = true;
            this.cb_kucukHarf.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_kucukHarf.Location = new System.Drawing.Point(13, 32);
            this.cb_kucukHarf.Name = "cb_kucukHarf";
            this.cb_kucukHarf.Size = new System.Drawing.Size(93, 26);
            this.cb_kucukHarf.TabIndex = 15;
            this.cb_kucukHarf.Text = "Küçük Harf";
            this.cb_kucukHarf.UseVisualStyleBackColor = true;
            // 
            // cb_ozelKarakter
            // 
            this.cb_ozelKarakter.AutoSize = true;
            this.cb_ozelKarakter.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ozelKarakter.Location = new System.Drawing.Point(120, 32);
            this.cb_ozelKarakter.Name = "cb_ozelKarakter";
            this.cb_ozelKarakter.Size = new System.Drawing.Size(106, 26);
            this.cb_ozelKarakter.TabIndex = 16;
            this.cb_ozelKarakter.Text = "Özel Karakter";
            this.cb_ozelKarakter.UseVisualStyleBackColor = true;
            // 
            // cb_buyukHarf
            // 
            this.cb_buyukHarf.AutoSize = true;
            this.cb_buyukHarf.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_buyukHarf.Location = new System.Drawing.Point(13, 62);
            this.cb_buyukHarf.Name = "cb_buyukHarf";
            this.cb_buyukHarf.Size = new System.Drawing.Size(93, 26);
            this.cb_buyukHarf.TabIndex = 17;
            this.cb_buyukHarf.Text = "Büyük Harf";
            this.cb_buyukHarf.UseVisualStyleBackColor = true;
            // 
            // cb_sayi
            // 
            this.cb_sayi.AutoSize = true;
            this.cb_sayi.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_sayi.Location = new System.Drawing.Point(120, 62);
            this.cb_sayi.Name = "cb_sayi";
            this.cb_sayi.Size = new System.Drawing.Size(54, 26);
            this.cb_sayi.TabIndex = 18;
            this.cb_sayi.Text = "Sayı";
            this.cb_sayi.UseVisualStyleBackColor = true;
            // 
            // SifreOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.tb_olusturulanSifre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "SifreOlustur";
            this.Text = "SifreOlustur";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_olusturulanSifre;
        private System.Windows.Forms.CheckBox cb_sayi;
        private System.Windows.Forms.CheckBox cb_buyukHarf;
        private System.Windows.Forms.CheckBox cb_ozelKarakter;
        private System.Windows.Forms.CheckBox cb_kucukHarf;
    }
}