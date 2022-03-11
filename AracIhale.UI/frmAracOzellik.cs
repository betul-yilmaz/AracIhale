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
    public partial class frmAracOzellik : Form
    {
        public frmAracOzellik()
        {
            InitializeComponent();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            if (IsValidateMarka())
            {
                MarkaVM MarkaEkle = new MarkaVM()
                {
                    MarkaAdi = txtMarka.Text,
                    IsActive = true,
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };
                //MarkaEkle.MarkaAdi = txtMarka.Text;

                MarkaDAL me = new MarkaDAL();
                me.MarkaEkle(MarkaEkle);
                lstMarka.Items.Clear();
                MarkaGetir();
                Temizle(this.Controls);
                MessageBox.Show("başarıyla eklendi");
            }
        }
        private void Temizle(Control.ControlCollection koleksiyon) //--->>>>>>>>>>>><
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                        {
                            TextBox txt = (TextBox)tb;
                            txt.Clear();
                        }
                        else if (tb is ComboBox)
                        {
                            ComboBox cb = (ComboBox)tb;
                            cb.SelectedIndex = -1;
                        }
                        else if (tb is NumericUpDown)
                        {
                            NumericUpDown nmr = (NumericUpDown)tb;
                            nmr.Value = 0;
                        }
                    }
                }
            }
        }
        private void frmAracOzellik_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            OzellikGetir();
            ModelGetir();
            OzellikDetayGetir();
        }

        private void OzellikDetayGetir()
        {
            
            OzellikDAL Dal = new OzellikDAL();
            List<OzellikDetayListVM> liste = Dal.OzellikDetayListele();
            foreach (var item in liste)
            {
                ListViewItem li = new ListViewItem();
                li.Text = a++.ToString();
                li.SubItems.Add(item.OzellikAdi);
                li.SubItems.Add(item.DegerAdi);
                //li.Tag = item;
                listVDeger.Items.Add(li);
            }
        }
        int x = 1;
        private void ModelGetir()
        {
            ModelDAL Dal = new ModelDAL();
            List<ModelListVM> liste = Dal.ModelListele();
            foreach (var item in liste)
            {
                ListViewItem li = new ListViewItem();
                li.Text = x++.ToString();
                li.SubItems.Add(item.MarkaAdi);
                li.SubItems.Add(item.ModelAdi);
                //li.Tag = item;
                lstVModel.Items.Add(li);
            }
        }
        int a = 1;

        private void OzellikGetir()
        {
            cmbOzellik.Items.Clear();
            OzellikDAL ozellikDal = new OzellikDAL();
            List<OzellikVM> liste = ozellikDal.OzellikListele();
            foreach (var item in liste)
            {
                lstOzellik.Items.Add(item);
                cmbOzellik.Items.Add(item);
            }
        }
        private void MarkaGetir()
        {
            cmbMarka.Items.Clear();
            MarkaDAL marka = new MarkaDAL();
            List<MarkaVM> listem = marka.MarkaListele();
            foreach (var item in listem)
            {
                lstMarka.Items.Add(item);
                lstMarka.Tag = item;
                cmbMarka.Items.Add(item);
            }
        }
        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            if (IsValidateModel())
            {
                ModelAddVM EklenecekModel = new ModelAddVM();
                EklenecekModel.ModelAdi = txtModel.Text;
                EklenecekModel.MarkaId = (cmbMarka.SelectedItem as MarkaVM).Id;
                EklenecekModel.IsActive = true;

                ModelDAL ModelDAL = new ModelDAL();
                ModelDAL.ModelEkle(EklenecekModel);
                lstVModel.Items.Clear();
                ModelGetir();
                Temizle(this.Controls);
                MessageBox.Show("başarıyla eklendi");
            }
        }
        private void btnOzellikEkle_Click(object sender, EventArgs e)
        {
            if (IsValidateOzellik())
            {
                OzellikDAL ozellikDal = new OzellikDAL();
                OzellikVM ovm = new OzellikVM()
                {
                    OzellikAdi = txtOzellik.Text,
                    IsActive = true,
                    CreatedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = 1,
                    ModifiedDate = DateTime.Now
                };
                ozellikDal.OzellikEkle(ovm);
                OzellikGetir();
                Fonksiyon.Temizle(this.Controls);
                MessageBox.Show("Özellik eklendi");
            }
        }
        private void btnDegerEkle_Click(object sender, EventArgs e)
        {
            if (IsValidateOzellikDeger())
            {
                OzellikDetayVM EklenecekOzellik = new OzellikDetayVM();
                EklenecekOzellik.Deger = txtDeger.Text;
                EklenecekOzellik.OzellikID = (cmbOzellik.SelectedItem as OzellikVM).Id;
                EklenecekOzellik.IsActive = true;
                EklenecekOzellik.ModifiedBy = 1;
                EklenecekOzellik.ModifiedDate = DateTime.Now;
                EklenecekOzellik.CreatedBy = 1;
                EklenecekOzellik.CreatedDate = DateTime.Now;

                OzellikDAL OzellikDAL = new OzellikDAL();
                OzellikDAL.OzellikDetayEkle(EklenecekOzellik);

                listVDeger.Items.Clear();
                OzellikDetayGetir();
                Fonksiyon.Temizle(this.Controls);
                MessageBox.Show("Değer eklendi");
            }
        }
        public bool IsValidateMarka()
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtMarka, "boş geçilemez");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        public bool IsValidateModel()
        {
            if (cmbMarka.SelectedIndex < 0)
            {
                errorProvider2.Clear();
                errorProvider2.SetError(cmbMarka, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                errorProvider2.Clear();
                errorProvider2.SetError(txtModel, "boş geçilemez");
                return false;
            }
            errorProvider2.Clear();
            return true;
        }
        private bool IsValidateOzellik()
        {
            if (string.IsNullOrWhiteSpace(txtOzellik.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtOzellik, "boş geçilemez");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        public bool IsValidateOzellikDeger()
        {
            if (cmbOzellik.SelectedIndex < 0)
            {
                errorProvider2.Clear();
                errorProvider2.SetError(cmbOzellik, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDeger.Text))
            {
                errorProvider2.Clear();
                errorProvider2.SetError(txtDeger, "boş geçilemez");
                return false;
            }
            errorProvider2.Clear();
            return true;
        }

        private void txtMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        MarkaVM markaDelete = new MarkaVM();
        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            if (lstMarka.SelectedItems.Count > 0)
            {
                errorProvider1.Clear();
                MarkaDAL markaDal = new MarkaDAL();
                markaDal.MarkaSil(markaDelete);
                lstMarka.Items.Clear();
                MarkaGetir();
                Temizle(this.Controls);
                MessageBox.Show("başarıyla silindi");
            }
            else
            {
                errorProvider1.SetError(lstMarka, "silinecek değer seçiniz");
            }
        }
        OzellikVM ozellikDelete = new OzellikVM();
        private void btnOzellikSil_Click(object sender, EventArgs e)
        {

            if (lstOzellik.SelectedItems.Count > 0)
            {
                OzellikDAL oz = new OzellikDAL();
                oz.OzellikSil(ozellikDelete);
                lstOzellik.Items.Clear();
                OzellikGetir();
                Temizle(this.Controls);
                MessageBox.Show("başarıyla silindi");
            }
            else
            {
                errorProvider1.SetError(lstOzellik, "silinecek değer seçiniz");
            }
        }

        private void lstMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            markaDelete = lstMarka.SelectedItem as MarkaVM;
        }

        private void lstOzellik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ozellikDelete = lstOzellik.SelectedItem as OzellikVM;
        }
    }
}
