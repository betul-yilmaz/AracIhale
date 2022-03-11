using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAracOzellik_Click(object sender, EventArgs e)
        {
            frmAracOzellik f = new frmAracOzellik();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAracListeleme f = new frmAracListeleme();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKullaniciIslem f = new frmKullaniciIslem();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmIhaleEkle f = new frmIhaleEkle();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmIhaleListeleme f = new frmIhaleListeleme();
            f.Show();
        }

        private void btnTramer_Click(object sender, EventArgs e)
        {
            frmTramer f = new frmTramer();
            f.Show();
        }

        private void btnkullaniciislem_Click(object sender, EventArgs e)
        {
            frmKurumsalUyeKayit f = new frmKurumsalUyeKayit();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKurumsalUyeOnay f = new frmKurumsalUyeOnay();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPaketEkle f = new frmPaketEkle();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmFirmaKayit f = new frmFirmaKayit();
            f.Show();
        }
    }
}
