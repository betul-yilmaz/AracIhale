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
    public partial class frmIhaleAracFiyat : Form
    {
        public frmIhaleAracFiyat()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            if (txtMinAlimFiyati.Text != "" && txtIhaleBaslangicFiyat.Text != ""  && textBox1.Text != "")
            {
                IhaleAracVM FiyatGir = new IhaleAracVM()
                {
                    
                    BaslangicFiyat = Convert.ToInt32(txtIhaleBaslangicFiyat.Text),
                    MinFiyat = Convert.ToInt32(txtMinAlimFiyati.Text),
                    IhaleID = Convert.ToInt32(textBox1.Text),
                    AracId=comboBox1.SelectedIndex,
                    CreatedBy=1,
                    CreatedDate=DateTime.Now,
                    IsActive=true,
                    ModifiedBy=1,
                    ModifiedDate=DateTime.Now,

                    
                };
                IhaleAracDAL ad = new IhaleAracDAL();
                ad.FiyatGir(FiyatGir);
                Fonksiyon.Temizle(this.Controls);
                MessageBox.Show("Araç Eklendi");
            }
            else MessageBox.Show("Araç Eklenemedi Bilgilerinizi Kontrol Ediniz");
        }

        private void frmIhaleAracFiyat_Load(object sender, EventArgs e)
        {

           
                AracListelemeDAL dal = new AracListelemeDAL();
                List<AracListelemeVM> liste = dal.AracListele();
                foreach (var item in liste)
                {
                    comboBox1.Items.Add(item.AracPlaka);
                }
          





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMinAlimFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIhaleBaslangicFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
                errorProvider1.SetError(groupBox1, "Sadece Sayı Girilebilir");

            }
        }
    }
}
