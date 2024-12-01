using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassCrypt
{
    public partial class SifreKaydet : Form
    {
        public SifreKaydet()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\doga\Desktop\Sifrelerim"; //Değiştirelecek

        private void btn_sifreKaydet_Click(object sender, EventArgs e)
        {
            string platform = tb_platform.Text;
            string sifre = tb_sifre.Text;
            string sifrelenmis = "";

            //Şifreleme
            foreach (char harf in sifre)
            {
                int intHarf = (int)harf;
                intHarf -= 5;
                char yeniharf = (char)intHarf;
                sifrelenmis += yeniharf;
            }

            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                di.Create();
            }

            string fileName = platform;
            string filePath = path + "/" + fileName + ".crypt";
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(platform);
            sw.WriteLine(sifrelenmis);
            sw.Close();
            MessageBox.Show("Şifre kaydedildi.");
            tb_platform.Text = "";
            tb_sifre.Text = "";
        }
    }
}
