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
    public partial class frmIhaleListeleme : Form
    {
        public frmIhaleListeleme()
        {
            InitializeComponent();
        }
        int kuID;
        private void frmIhaleListeleme_Load(object sender, EventArgs e)
        {
            IhaleGetir();
            UyeTipGetir();
            kuID=StaticLogin.KullaniciID;
            StatuGetir();
            if (StaticLogin.RolID == 2)
            {
                btnYeni.Enabled = false;
            }
        }


        private void StatuGetir()
        {
            StatuDAL dal = new StatuDAL();
            List<StatuVM> liste = dal.StatuListele();
            foreach (var item in liste)
            {
                cmbStatu.Items.Add(item);
            }
        }
        private void UyeTipGetir()
        {
            UyeTipAdiDAL dal = new UyeTipAdiDAL();
            List<UyeVM> liste = dal.UyeTipAciklamaListele();
            foreach (var item in liste)
            {
                cmbBireyselKurumsal.Items.Add(item);
            }
        }

        private void IhaleGetir()
        {
            IhaleDAL ihale = new IhaleDAL();
            List<IhaleVM> listem = ihale.IhaleListele();
            foreach (var item in listem)
            {
                cmbIhaleAdi.Items.Add(item);
            }
        }
        private void cmbBireyselKurumsal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbStatu.Items.Clear();
            cmbStatu.Text = string.Empty;
            UyeTipGoreStatuGetir((cmbBireyselKurumsal.SelectedItem as UyeVM).Id);
        }
        private void UyeTipGoreStatuGetir(int uyeTipID)
        {
            StatuDAL dal = new StatuDAL();
            List<StatuVM> liste = dal.UyeTipGoreStatuListele(uyeTipID);
            foreach (var item in liste)
            {
                cmbStatu.Items.Add(item);
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmIhaleEkle frm = new frmIhaleEkle();
            frm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
        int x = 1;
        private void btnListele_Click_1(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                IhaleDAL dal = new IhaleDAL();
                int ihaleid = (cmbIhaleAdi.SelectedItem as IhaleVM).Id;
                int bireyselkurumsal = (cmbBireyselKurumsal.SelectedItem as UyeVM).Id;
                int statu = (cmbStatu.SelectedItem as StatuVM).Id;
                List<IhaleListVM> donulenListe = dal.IhaleListesiGetir(ihaleid, bireyselkurumsal, statu, kuID);
                if (donulenListe.Count == 0)
                {
                    MessageBox.Show("filtreye uygun ihale bulunamadı");
                }
                else
                {
                    foreach (var item in donulenListe)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = x++.ToString();
                        li.SubItems.Add(item.IhaleAdi);
                        li.SubItems.Add(item.UyeTipiAciklamasi);
                        li.SubItems.Add(item.BaslangicTarih.ToString());
                        li.SubItems.Add(item.BitisTarih.ToString());
                        li.SubItems.Add(cmbStatu.Text);
                        li.SubItems.Add(item.KullaniciAdi);
                        li.SubItems.Add(item.CreatedDate.ToString());
                        lstIhaleListesi.Items.Add(li);
                    }
                    IhaleGetir();
                    Fonksiyon.Temizle(this.Controls);
                }
            }
        }
        private bool IsValidate()
        {
            if (cmbIhaleAdi.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbIhaleAdi, "boş geçilemez");
                return false;
            }
            if (cmbBireyselKurumsal.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbBireyselKurumsal, "boş geçilemez");
                return false;
            }
            if (cmbStatu.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbStatu, "boş geçilemez");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void grpAracTanimlamaListeleme_Enter(object sender, EventArgs e)
        {

        }
    }
}
