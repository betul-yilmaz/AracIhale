using AracIhale.UI.DAL;
using AracIhale.UI.DAL.MarkaDAL;
using AracIhale.UI.VM;
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

namespace AracIhale.UI
{
    public partial class frmAracSatisEkle : Form
    {
        public frmAracSatisEkle()
        {
            InitializeComponent();
        }
        string base64 = "";
        private void frmAracSatisEkle_Load(object sender, EventArgs e)
        {
            UyeTipGetir();
            StatuGetir();
            MarkaGetir();
            //ModelGetir();
            GovdeTipGetir();
            YakıtTipGetir();
            VitesTipGetir();
            RenkTipGetir();
            DonanımTipGetir();
            VersiyonTipGetir();
        }
        private void VersiyonTipGetir()
        {
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayVersiyonTipListele();
            foreach (var item in liste)
            {
                cmbVersiyon.Items.Add(item);
            }
        }
        private void DonanımTipGetir()
        {
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayDonanimTipListele();
            foreach (var item in liste)
            {
                cmbDonanim.Items.Add(item);
            }
        }
        private void RenkTipGetir()
        {
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayRenkTipListele();
            foreach (var item in liste)
            {
                cmbRenk.Items.Add(item);
            }
        }
        private void VitesTipGetir()
        {
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayVitesTipListele();
            foreach (var item in liste)
            {
                cmbVitesTipi.Items.Add(item);
            }
        }
        private void YakıtTipGetir()
        {
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayYakıtTipListele();
            foreach (var item in liste)
            {
                cmbYakitTipi.Items.Add(item);
            }
        }
        private void GovdeTipGetir()
        {
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayGövdeTipListele();
            foreach (var item in liste)
            {
                cmbGovdeTipi.Items.Add(item);
            }
        }
        //private void ModelGetir()
        //{
        //    ModelDAL Dal = new ModelDAL();
        //    List<ModelListVM> liste = Dal.ModelListele();
        //    foreach (var item in liste)
        //    {
        //        cmbAracModel.Items.Add(item);
        //    }
        //}
        private void MarkaGetir()
        {
            MarkaDAL marka = new MarkaDAL();
            List<MarkaVM> listem = marka.MarkaListele();
            foreach (var item in listem)
            {
                cmbAracMarka.Items.Add(item);
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
        private void UyeTipGoreStatuGetir(int uyeTipID)
        {
            StatuDAL dal = new StatuDAL();
            List<StatuVM> liste = dal.UyeTipGoreStatuListele(uyeTipID);
            foreach (var item in liste)
            {
                cmbStatu.Items.Add(item);
            }
        }
        private void FirmaAdiGetir(int firmaTipID)
        {
            AracSatisDAL dal = new AracSatisDAL();
            List<FirmaAdiListVM> liste = dal.FirmaAdiListesiGetir(firmaTipID);
            foreach (var item in liste)
            {
                cmbKurumsalSirketAdi.Items.Add(item);
            }
        }
        private void MarkaIDGoreModelGetir(int MarkaID)
        {

            ModelDAL Dal = new ModelDAL();
            List<ModelListVM> liste = Dal.MarkaIDgoreModelListele(MarkaID);
            foreach (var item in liste)
            {
                cmbAracModel.Items.Add(item);
            }
        }
        void FotoSec()
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Seçilen gösteri bir resim kutusunda göstermek istersen
                //pictureBox1.Image = new Bitmap(open.FileName);

                var dosya = File.ReadAllBytes(open.FileName);
                base64 = Convert.ToBase64String(dosya);
                //Bu base64 te dbye yazılacak
                MessageBox.Show("Fotoğraf Başarıyla Seçildi");
                btnFoto1.Text = ("image");

            }
        }    
        private void txtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                errorProvider1.SetError(groupBox1, "Sadece Sayı Girilebilir");

            }
        }
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                errorProvider1.SetError(grpAracDetayBilgileri, "Sadece Sayı Girilebilir");

            }
        }
        private void btnHasarTramer_Click(object sender, EventArgs e)
        {
            frmTramer frmtrm = new frmTramer();
            frmtrm.Show();
        }
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && txtKM.Text != "" && txtFiyat.Text != "" && txtAciklama.Text != "" && cmbAracMarka.Text != "" && cmbAracMarka2.Text != "" && cmbAracModel.Text != "" && cmbBireyselKurumsal.Text != ""
             && cmbDonanim.Text != "" && cmbGovdeTipi.Text != "" && cmbKurumsalSirketAdi.Text != "" && cmbRenk.Text != "" && cmbStatu.Text != "" && cmbVersiyon.Text != "" && cmbVitesTipi.Text != ""
             && cmbYakitTipi.Text != "")
            {
                AracSatisAddVM AracSatisEkle = new AracSatisAddVM()
                {
                    Aciklama = txtAciklama.Text,
                    IsActive = true,
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    KullaniciID = 1,
                    AracID = 5
                };
                //MarkaEkle.MarkaAdi = txtMarka.Text;
                AracSatisDAL me = new AracSatisDAL();
                me.AracSatisEkle(AracSatisEkle);
                GorselEkleVM GorselEkle = new GorselEkleVM()
                {
                    Foto = base64,
                    IsActive = true,
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AracID = 5
                };
                //MarkaEkle.MarkaAdi = txtMarka.Text;

                GorselDAL a = new GorselDAL();
                a.GorselEkle(GorselEkle);
                Fonksiyon.Temizle(this.Controls);
                MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            }
            else MessageBox.Show("İşlem Başarısız");
        }
        private void btnFoto1_Click_1(object sender, EventArgs e)
        {
            FotoSec();
        }
        private void cmbAracMarka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbAracModel.Items.Clear();
            cmbAracModel.Text = string.Empty;
            MarkaIDGoreModelGetir((cmbAracMarka.SelectedItem as MarkaVM).Id);
        }
        private void cmbBireyselKurumsal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbStatu.Items.Clear();
            cmbStatu.Text = string.Empty;
            UyeTipGoreStatuGetir((cmbBireyselKurumsal.SelectedItem as UyeVM).Id);
            FirmaAdiGetir((cmbBireyselKurumsal.SelectedItem as UyeVM).Id);
        }

        private void cmbStatu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
