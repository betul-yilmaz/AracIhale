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
    public partial class frmPaketEkle : Form
    {
        public frmPaketEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PaketDAL dal = new PaketDAL();
            PaketVM paketKayit = new PaketVM()
            {
                Tur = txtPaket.Text,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                IsActive = true,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now



            };
            dal.FirmaEkle(paketKayit);
        }




        private void btnPaketDetay_Click(object sender, EventArgs e)
        {

            PaketDetayVM EklenecekPaket = new PaketDetayVM();
            EklenecekPaket.FirmaID = (cmbFirma.SelectedItem as FirmaAdiListVM).Id;
            EklenecekPaket.PaketID = (cmbPaketAdi.SelectedItem as PaketVM).Id;


            PaketDetayDAL PaketDAL = new PaketDetayDAL();
            PaketDAL.PaketEkle(EklenecekPaket);


        }

        private void frmPaketEkle_Load(object sender, EventArgs e)
        {
            PaketGetir();
            FirmaGetir();


        }
        private void PaketGetir()
        {

            PaketDAL paket = new PaketDAL();
            List<PaketVM> listem = paket.PaketListele();
            foreach (var item in listem)
            {
                cmbPaketAdi.Items.Add(item);

            }
        }

        private void FirmaGetir()
        {

            FirmaDAL paket = new FirmaDAL();
            List<FirmaAdiListVM> listem = paket.FirmaListele();
            foreach (var item in listem)
            {
                cmbFirma.Items.Add(item);

            }
        }

    }

}
