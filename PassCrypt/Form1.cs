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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormuAc<SifreKaydet>();
        }

        private void TSMI_SifreOlustur_Click(object sender, EventArgs e)
        {
            FormuAc<SifreOlustur>();
        }

        private void TSMI_SifreKaydet_Click(object sender, EventArgs e)
        {
            FormuAc<SifreKaydet>();
        }

        private void TSMI_KayitliSifrelerim_Click(object sender, EventArgs e)
        {
            FormuAc<Sifrelerim>();
        }

        private void FormuAc<T>() where T : Form, new()
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form f in acikFormlar)
            {
                if (f is T)
                {
                    acikMi = true;
                    f.Activate();
                }
            }
            if (!acikMi)
            {
                T form = new T();
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }

       
    }
}
