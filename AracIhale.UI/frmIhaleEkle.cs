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
    public partial class frmIhaleEkle : Form
    {
        public frmIhaleEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsValidateIhale())
            {
                IhaleDAL dal = new IhaleDAL();
                IhaleListVM ovm = new IhaleListVM()
                {
                    IhaleAdi = txtIhaleAdi.Text,
                    UyeTipiAciklamasi = comboBox1.SelectedItem.ToString(),
                    StatuAdi = cmbStatu.SelectedItem.ToString(),
                    BaslangicTarih = dateTimePicker1.Value.Date,
                    BitisTarih = dateTimePicker2.Value.Date,
                    BaslangicSaat = txtIhaleBaslangicSaat.Text,
                    BitisSaat = textBox1.Text,
                    IsActive = true,
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    KullaniciID = 1

                };
                dal.IhaleEkle(ovm);
                lstIhaleListesi.Items.Clear();
                IhaleListelet();

                Fonksiyon.Temizle(this.Controls);
                MessageBox.Show("İhale bilgileri başarıyla eklendi");
            }
        }
        int x = 1;
        private void IhaleListelet()
        {
            IhaleDAL dal = new IhaleDAL();
           
            List<IhaleListVM> donulenListe = dal.IhaleListesiGetir();
            foreach (var item in donulenListe)
            {
                ListViewItem li = new ListViewItem();
                li.Text = x++.ToString();
                li.SubItems.Add(item.IhaleAdi);
                li.SubItems.Add(item.UyeTipiAciklamasi);
                li.SubItems.Add(item.BaslangicTarih.ToString());
                li.SubItems.Add(item.BitisTarih.ToString());
                li.SubItems.Add(item.StatuAdi);
                li.SubItems.Add(item.KullaniciAdi);
                
              
                li.SubItems.Add(item.CreatedDate.ToString());
                lstIhaleListesi.Items.Add(li);
            }
            
            Fonksiyon.Temizle(this.Controls);
        }

        private void FirmaGetir()
        {
            FirmaDAL dal = new FirmaDAL();
            List<FirmaAdiListVM> liste = dal.FirmaListele();
            foreach (var item in liste)
            {
                cmbSirketAdi.Items.Add(item.FirmaAdi);
            }
        }

        private void UyeTipGetir()
        {
            UyeTipAdiDAL dal = new UyeTipAdiDAL();
            List<UyeVM> liste = dal.UyeTipAciklamaListele();
            foreach (var item in liste)
            {
                comboBox1.Items.Add(item);
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
        private void button3_Click_1(object sender, EventArgs e)
        {
            frmIhaleListeleme f = new frmIhaleListeleme();
            f.Show();
        }
        private void frmIhaleEkle_Load_1(object sender, EventArgs e)
        {
            UyeTipGetir();
            StatuGetir();
            IhaleListelet();
            FirmaGetir();
            //Listele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmIhaleAracFiyat f = new frmIhaleAracFiyat ();
            f.Show();
        }
        public bool IsValidateIhale()
        {
            if (string.IsNullOrWhiteSpace(txtIhaleAdi.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIhaleAdi, "boş geçilemez");
                return false;
            }

            if (comboBox1.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBox1, "boş geçilemez");
                return false;
            }
            if (cmbStatu.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbStatu, "boş geçilemez");
                return false;
            }
            if (dateTimePicker1.Value == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dateTimePicker1, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIhaleBaslangicSaat.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIhaleBaslangicSaat, "boş geçilemez");
                return false;
            }
            if (dateTimePicker2.Value == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dateTimePicker2, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "boş geçilemez");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void cmbSirketAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStatu.Items.Clear();
            cmbStatu.Text = string.Empty;
            UyeTipGoreStatuGetir((comboBox1.SelectedItem as UyeVM).Id);
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
    }
}
