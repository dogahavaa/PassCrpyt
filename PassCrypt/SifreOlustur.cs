using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassCrypt
{
    public partial class SifreOlustur : Form
    {
        public SifreOlustur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<char> harfHaznesi = new List<char>();
            string sifre = "";

            if (cb_buyukHarf.Checked)
            {
                harfHaznesi.AddRange(buyukHarfler());
            }
            if (cb_kucukHarf.Checked)
            {
                harfHaznesi.AddRange(kucukHarfler());
            }
            if (cb_ozelKarakter.Checked)
            {
                harfHaznesi.AddRange(ozelKarakterler());
            }
            if (cb_sayi.Checked)
            {
                harfHaznesi.AddRange(sayilar());
            }

            if (harfHaznesi.Count != 0)
            {
                Random rnd = new Random();
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    int randomSayi = rnd.Next(harfHaznesi.Count);
                    sifre += harfHaznesi[randomSayi];
                }
                tb_olusturulanSifre.Text = sifre;

            }




        }

        private List<char> kucukHarfler()
        {
            List<char> harfler = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                harfler.Add((char)i);
            }
            return harfler;
        }
        private List<char> buyukHarfler()
        {
            List<char> harfler = new List<char>();
            for (int i = 65; i < 91; i++)
            {
                harfler.Add((char)i);
            }
            return harfler;
        }
        private List<char> sayilar()
        {
            List<char> sayilar = new List<char>();
            for (int i = 48; i < 58; i++)
            {
                sayilar.Add((char)i);
            }
            return sayilar;
        }
        private List<char> ozelKarakterler()
        {
            List<char> karakterler = new List<char>();
            for (int i = 33; i < 48; i++)
            {
                if (i == 39 || i == 34)
                {
                    continue;
                }
                karakterler.Add((char)i);
            }
            return karakterler;
        }

    }
}
