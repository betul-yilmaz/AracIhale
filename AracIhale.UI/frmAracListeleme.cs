using AracIhale.UI.DAL;
using AracIhale.UI.DAL.MarkaDAL;
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
    public partial class frmAracListeleme : Form
    {
        public frmAracListeleme()
        {
            InitializeComponent();
        }
        int kuID;
        private void frmAracListeleme_Load(object sender, EventArgs e)
        {
            kuID = StaticLogin.KullaniciID;
            MarkaGetir();
            //ModelGetir();
            UyeTipGetir();
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
        //private void ModelGetir()
        //{

        //    ModelDAL Dal = new ModelDAL();
        //    List<ModelListVM> liste = Dal.ModelListele();
        //    foreach (var item in liste)
        //    {
        //        cmbModel.Items.Add(item);
        //    }
        //}

        //private void StatuGetir()
        //{
        //    StatuDAL dal = new StatuDAL();
        //    List<StatuVM> liste = dal.StatuListele();
        //    foreach (var item in liste)
        //    {
        //        cmbStatu.Items.Add(item);
        //    }
        //}

        private void UyeTipGetir()
        {
            UyeTipAdiDAL dal = new UyeTipAdiDAL();
            List<UyeVM> liste = dal.UyeTipAciklamaListele();
            foreach (var item in liste)
            {
                cmbBireyselKurumsal.Items.Add(item);
            }
        }

        private void MarkaGetir()
        {
            MarkaDAL marka = new MarkaDAL();
            List<MarkaVM> listem = marka.MarkaListele();
            foreach (var item in listem)
            {
                cmbAracMarka.Items.Add(item);
            }
        }

        //private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmbModel.Items.Clear();
        //    cmbModel.Text = string.Empty;
        //    MarkaIDGoreModelGetir((cmbAracMarka.SelectedItem as MarkaVM).Id);
        //}
        private void MarkaIDGoreModelGetir(int MarkaID)
        {

            ModelDAL Dal = new ModelDAL();
            List<ModelListVM> liste = Dal.MarkaIDgoreModelListele(MarkaID);
            foreach (var item in liste)
            {
                cmbModel.Items.Add(item);
            }
        }

        //private void cmbBireyselKurumsal_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmbStatu.Items.Clear();
        //    cmbStatu.Text = string.Empty;
        //    UyeTipGoreStatuGetir((cmbBireyselKurumsal.SelectedItem as UyeVM).Id);
        //}
        private void UyeTipGoreStatuGetir(int uyeTipID)
        {
            StatuDAL dal = new StatuDAL();
            List<StatuVM> liste = dal.UyeTipGoreStatuListele(uyeTipID);
            foreach (var item in liste)
            {
                cmbStatu.Items.Add(item);
            }
        }
        private void cmbAracMarka_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            cmbModel.Text = string.Empty;
            MarkaIDGoreModelGetir((cmbAracMarka.SelectedItem as MarkaVM).Id);
        }

        private void cmbBireyselKurumsal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbStatu.Items.Clear();
            cmbStatu.Text = string.Empty;
            UyeTipGoreStatuGetir((cmbBireyselKurumsal.SelectedItem as UyeVM).Id);
        }
        int x = 1;
        private void btnListele_Click_1(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                AracListelemeDAL araclstDal = new AracListelemeDAL();
                int markaID = (cmbAracMarka.SelectedItem as MarkaVM).Id;
                int modelID = (cmbModel.SelectedItem as ModelListVM).Id;
                int uyeTipID = (cmbBireyselKurumsal.SelectedItem as UyeVM).Id;
                int statuID = (cmbStatu.SelectedItem as StatuVM).Id;
                List<AracListelemeVM> donulenAracListe = araclstDal.AracListesiGetir(markaID, modelID, uyeTipID, statuID, kuID);
                if (donulenAracListe.Count == 0)
                {
                    MessageBox.Show("filtreye uygun aracınız yoktur");
                    lstAracListesi.Items.Clear();
                }
                else
                {
                    lstAracListesi.Items.Clear();
                    foreach (var item in donulenAracListe)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = x++.ToString();
                        li.SubItems.Add(item.MarkaAdi);
                        li.SubItems.Add(item.ModelAdi);
                        li.SubItems.Add(item.UyeTipID.ToString());
                        li.SubItems.Add(item.StatuAdi);
                        li.SubItems.Add(item.KullaniciAdi);
                        li.SubItems.Add(item.KaydetmeZamani.ToString());
                        lstAracListesi.Items.Add(li);
                    }
                    Fonksiyon.Temizle(this.Controls);
                }
                

            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmAracSatisEkle f = new frmAracSatisEkle();
            f.Show();
        }
        private bool IsValidate()
        {
            if (cmbAracMarka.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbAracMarka, "boş geçilemez");
                return false;
            }
            if (cmbModel.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbModel, "boş geçilemez");
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
    }
}
