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
    public partial class frmFirmaKayit : Form
    {
        public frmFirmaKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void frmFirmaKayit_Load(object sender, EventArgs e)
        {

        }

        private void txtVergiNo_TextChanged(object sender, EventArgs e)
        {
           
        }
        public bool IsValidateIhale()
        {
            if (string.IsNullOrWhiteSpace(txtVergiNo.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtVergiNo, "boş geçilemez");
                errorProvider1.SetError(txtFirmaAdi, "boş geçilemez");
                errorProvider1.SetError(txtFaaliyet, "boş geçilemez");
                return false;
            }
            else { MessageBox.Show("İşlem Başarılı"); }
            errorProvider1.Clear();
            return true;
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if((txtVergiNo.Text!="" && txtFirmaAdi.Text!=""&&txtFaaliyet.Text!=""))
            { 
            FirmaEklemeDAL dal = new FirmaEklemeDAL();
            FirmaKayitVM frmkyt = new FirmaKayitVM()
            {
                FirmaAdi = txtFirmaAdi.Text,
                FirmaFaaliyetAlani = txtFaaliyet.Text,
                FirmaVergiNo = txtFaaliyet.Text,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ModifiedBy = 1,
                IsActive = true,


            };

            dal.FirmaEkle(frmkyt);

            IsValidateIhale();
            MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız");
            }

        }
    }
}
