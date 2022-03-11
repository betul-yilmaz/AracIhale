using AracIhale.UI.DAL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      
        private void btnGiris_Click(object sender, EventArgs e)
        {
           
                LoginDAL loginDAL = new LoginDAL();
                string kullaniciAdi = tBoxKulAdi.Text;
                string sifre = tBoxSifre.Text;
                int varMi = loginDAL.KullaniciVarMi(kullaniciAdi, sifre);
                if (varMi == 1)
                {
                    frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
                    frmAnaSayfa.Show();
                    frmAnaSayfa.Text = kullaniciAdi + " Hoşgeldiniz";
                }
                else if(varMi==2)
                {
                frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
                frmAnaSayfa.Show();
                frmAnaSayfa.button4.Visible = false;
                frmAnaSayfa.btnTramer.Visible = false;
                frmAnaSayfa.btnkullaniciislem.Visible = false;
                frmAnaSayfa.btnAracOzellik.Visible = false;
                frmAnaSayfa.button1.Visible = false;
                frmAnaSayfa.button6.Visible = false;
                frmAnaSayfa.button7.Visible = false;
                frmAnaSayfa.button4.Visible = false;
                frmAnaSayfa.button3.Visible = false;
                frmAnaSayfa.Text = StaticLogin.KullaniciAdi + " Hoşgeldiniz";
                }
                else
                {
                    MessageBox.Show("hatalı");
                }
           
        }
    }
}
