using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PassCrypt
{
    public partial class Sifrelerim : Form
    {
        public Sifrelerim()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\doga\Desktop\Sifrelerim"; //Değiştirelecek

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_guvenlik.Text == "1234")
            {
                string[] sifreDosyalari = Directory.GetFiles(path);

                foreach (string dosya in sifreDosyalari)
                {
                    StreamReader sr = new StreamReader(dosya);
                    string platform = sr.ReadLine();
                    lb_platformlar.Items.Add(platform);
                }
            }
            else
            {
                MessageBox.Show("Güvenlik şifresi hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_platformlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sifreDosyalari = Directory.GetFiles(path);
            string secili = lb_platformlar.SelectedItem.ToString();

            foreach (string dosya in sifreDosyalari)
            {
                StreamReader sr = new StreamReader(dosya);
                string platform = sr.ReadLine();
                string sifre = sr.ReadLine();
                sifre = SifreCoz(sifre);

                if (platform == secili)
                {
                    lbl_platform.Text = platform;
                    lbl_sifre.Text = sifre;
                }
            }
        }

    private string SifreCoz(string sifre)
    {
        string cozulmus = "";
        foreach (char harf in sifre)
        {
            int intHarf = (int)harf;
            intHarf += 5;
            char yeniharf = (char)intHarf;
            cozulmus += yeniharf;
        }
        return cozulmus;
    }
}
}
