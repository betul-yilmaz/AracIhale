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
    public partial class frmTramer : Form
    {
        public frmTramer()
        {
            InitializeComponent();
        }

        private void frmTramer_Load(object sender, EventArgs e)
        {
            AracListelemeDAL dal = new AracListelemeDAL();
            List<AracListelemeVM> liste = dal.AracListele();
            foreach (var item in liste)
            {
                comboBox1.Items.Add(item.AracPlaka);
                comboBox2.Items.Add(item.AracPlaka);
            }

            TramerTipiGetir();
            TramerTipiGetir2();
            cmbDurum.SelectedIndex = 1;
            cmbParca.SelectedIndex = 1;
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            

        }
        private void btnTramerEkle_Click(object sender, EventArgs e)
        {



            if (cmbParca.Text != "" && cmbDurum.Text != "")
            {
                AracTramerDetayVM TramDtyEkle = new AracTramerDetayVM()
                {


                   
                    //  TramerID = Convert.ToInt32(cmbParca.Text),
                    TramerID = cmbParca.SelectedIndex + 1,
                    // TramerTipID = Convert.ToInt32(cmbDurum.Text)
                    TramerTipID = cmbDurum.SelectedIndex + 1


                };

                TramerOzellikDAL to = new TramerOzellikDAL();
                to.TramDtyEkle(TramDtyEkle);
                Fonksiyon.Temizle(this.Controls);

                MessageBox.Show("Tramer Bilgileri Başarıyla Eklendi");

            }
            else MessageBox.Show("Bilgileri Doğru Giriniz");



        }
        private void TramerTipiGetir()
        {
            TramerTipDAL tipgetir = new TramerTipDAL();
            List<TramerOzellikTipVM> liste = tipgetir.TramListele();
            foreach (var item in liste)
            {
                cmbDurum.Items.Add(item);
            }
        }
        private void TramerTipiGetir2()
        {
            TramerTipDAL tipgetir2 = new TramerTipDAL();
            List<TramerTipVM> liste = tipgetir2.TramListele2();
            foreach (var item in liste)
            {
                cmbParca.Items.Add(item);
            }
        }

        private void btnFiyatEkle_Click(object sender, EventArgs e)
        {

            TramerVM TramerEkle = new TramerVM()
            {
                Fiyat = Convert.ToInt32(txtToplamTramerTurari.Text),
            };
            TramerDAL tr = new TramerDAL();
            tr.TramerUcretEkle(TramerEkle);
            Fonksiyon.Temizle(this.Controls);

            MessageBox.Show("Tramer Tutarı Başarıyla Eklendi");

        }


        private void txtAracIDTramer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtAracId_TextChaned(object sender, EventArgs e)
        {

        }

        private void txtAracId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;

            }
        }

        private void txtToplamTramerTurari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                errorProvider1.SetError(txtToplamTramerTurari, "Sadece Sayı Girilebilir");

            }
        }

        private void btnFiyatEkle_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTramerEkle_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbParca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtToplamTramerTurari_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtToplamTramerTurari_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                errorProvider1.SetError(groupBox1, "Sadece Sayı Girilebilir");

            }
        }
    }


}
