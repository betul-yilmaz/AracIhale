using AracIhale.UI.DAL;
using AracIhale.UI.VM;
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
    public partial class frmKurumsalUyeOnay : Form
    {
        public frmKurumsalUyeOnay()
        {
            InitializeComponent();
        }

        private void frmKurumsalUyeOnay_Load(object sender, EventArgs e)
        {
            KurumsalUyeListele();
        }
        int x = 1;
        private void KurumsalUyeListele()
        {
            KurumsalUyeDAL dal = new KurumsalUyeDAL();

            List<KurumsalUyeKayitVM> donulenListe = dal.KurumsalUyeListesiGetir();
            foreach (var item in donulenListe)
            {
                ListViewItem li = new ListViewItem();
                li.Text = x++.ToString();
                li.SubItems.Add(item.KurumsalKullaniciID.ToString());
                li.SubItems.Add(item.KullaniciAdi);
                li.SubItems.Add(item.AdSoyad);
                li.SubItems.Add(item.TC);
                li.SubItems.Add(item.FirmaAdi);
                li.SubItems.Add(item.IsActive.ToString());
                li.Tag = item;
                lstKurumsalKullanicilar.Items.Add(li);
            }

            Fonksiyon.Temizle(this.Controls);
        }
        KurumsalUyeKayitVM kvm = new KurumsalUyeKayitVM();

        private void lstKurumsalKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            KurumsalUyeDAL dal = new KurumsalUyeDAL();
            if (lstKurumsalKullanicilar.SelectedItems.Count == 1)
            {
                //kvm = lstKurumsalKullanicilar.SelectedItems[0].Tag as KurumsalUyeKayitVM;
                var a = lstKurumsalKullanicilar.SelectedItems[0].Tag as KurumsalUyeKayitVM;
                kvm.KurumsalKullaniciID = a.KurumsalKullaniciID;
                kvm.IsActive = a.IsActive;
                btnKaydet.Enabled = true;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KurumsalUyeDAL dal = new KurumsalUyeDAL();
             dal.UyeOnay(kvm);

            MessageBox.Show("Kullanıcı onaylandı");
            btnKaydet.Enabled = false;
            lstKurumsalKullanicilar.Items.Clear();
            KurumsalUyeListele();
        }
    }
}
