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

        private void TSMI_SifreOlustur_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(SifreOlustur))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                SifreOlustur SifreOlusturForm = new SifreOlustur();
                SifreOlusturForm.MdiParent = this;
                SifreOlusturForm.WindowState = FormWindowState.Maximized;
                SifreOlusturForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikMi = false;

            foreach (Form form in acikFormlar)
            {
                if (form.GetType() == typeof(SifreOlustur))
                {
                    acikMi = true;
                    form.Activate();
                }
            }
            if (acikMi == false)
            {
                SifreOlustur SifreOlusturForm = new SifreOlustur();
                SifreOlusturForm.MdiParent = this;
                SifreOlusturForm.WindowState = FormWindowState.Maximized;
                SifreOlusturForm.Show();
            }
        }
    }
}
