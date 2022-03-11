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
    public partial class frmKurumsalUyeKayit : Form
    {
        public frmKurumsalUyeKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsValidation())
            {
                KurumsalUyeDAL dal = new KurumsalUyeDAL();
                KurumsalUyeKayitVM vm = new KurumsalUyeKayitVM()
                {
                    KullaniciAdSoyad = txtKullaniciAdi.Text,
                    FirmaAdi = txtFirmaAdi.Text,
                    AdSoyad = txtAd.Text,
                    CepTelefonu = txtCepTelefonu.Text,
                    Sifre = txtSifre.Text,
                    FirmaBilgisi = cmbFirma.SelectedItem.ToString(),
                    Il = txtIl.Text,
                    Ilce = txtIlce.Text,
                    Adres = txtAdres.Text,
                    Onay = false,
                    FirmaID = 1,
                    IsActive = false, ////
                    CreatedBy = 1,
                    ModifiedBy = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    KullaniciID = 1,

                };
                dal.KurumsalKullaniciEkle(vm);
                MessageBox.Show("Kayıt talebi başarıyla gönderildi.");
                Fonksiyon.Temizle(this.Controls);
                cbKvkk.Checked = false;
                cbUyelik.Checked = false;
            }
        }
        private bool IsValidation()
        {

            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAd, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtKullaniciAdi, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCepTelefonu.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtCepTelefonu, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtSifre, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirmaAdi.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtFirmaAdi, "boş geçilemez");
                return false;
            }
            if (cmbFirma.SelectedIndex < 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbFirma, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIl.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIl, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIlce.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtIlce, "boş geçilemez");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtAdres, "boş geçilemez");
                return false;
            }
            if (cbUyelik.Checked == false)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbUyelik, "boş geçilemez");
                return false;
            }
            if (cbKvkk.Checked == false)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cbKvkk, "boş geçilemez");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        public void FirmaBilgisiDoldur()
        {
            cmbFirma.Items.Add("Şahıs");
            cmbFirma.Items.Add("Anonim/Limited");
        }

        private void frmKurumsalUyeKayit_Load(object sender, EventArgs e)
        {
            FirmaBilgisiDoldur();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("ÜYELİK SÖZLEŞMESİ\nGizli bilgiyi alan taraf, bu Sözleşme süresince ve Sözleşme’nin aşağıdaki 8. maddeye uygun olarak feshedilmesi veya geçerlilik süresinin bitmesi halinde, fesih veya sona erme tarihinden itibaren süresiz olarak şekilde Gizli Bilgi’nin koruma ve kullanımına yönelik olarak aşağıdaki maddelereuymayı kabul, beyan ve taahhüt eder:a) Gizli Bilgiyi sadece diğer Tarafça verilme amacına uygun olarak kullanmak,b) Gizli Bilgiyi konuyla ilgili olmaları şartıyla “bilmesi gereken” prensibine göre kendi personelinebu Sözleşme şartlarına uymalarını sağlamak sureti ile vermek,c) Gizli bilgiyi açan tarafın Gizli Bilgisine en az kendisine ait olan ve aynı derecede önemli GizliBilgiyi korumak için sarf ettiği itinayı göstermek,d) Gizli Bilgiyi, Gizli Bilgiyi açan Tarafın yazılı onayı olmadan hissedarları, bağlı şirketleri ve yankuruluşları dahil olmak üzere üçüncü şahıslara açıklamamak,e) İşbu Sözleşme’nin amaçlarının yerine getirilmesi için gerekli olan haller dışında, Gizli Bilgiyitamamen veya kısmen herhangi bir şekilde kopyalamamak veya çoğaltmamak; eğer buSözleşme'nin amacı dahilince tamamen veya kısmen kopyalanmış veya çoğaltılmışsa, kopyalanmışveya çoğaltılmış nüshaların üzerinde orijinal metnin üzerinde bulunanlara eşdeğer kısıtlayıcı biribare koymak,f) İşbu Sözleşme amacına uygun olarak gerekmesi halinde, Gizli Bilginin aktarıldığı kuruluş, altyüklenici ya da diğer üçüncü tarafların da Gizli Bilginin saklanması ve açıklanması ile ilgili olarakaynı sınırlamalara bağlı olmasını sağlamak.");

        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("6698 sayılı Kişisel Verilerin Korunması Kanunu (“KVKK”) uyarınca, Şirketimiz tarafından, Veri Sorumlusu sıfatıyla, kişisel verileriniz, iş amaçlarıyla bağlı olarak, aşağıda açıklandığı çerçevede kullanılmak, kaydedilmek, saklanmak, güncellenmek, aktarılmak ve/veya sınıflandırılmak suretiyle işlenecektir.  Bu kapsamda Şirketimiz tarafından başta özel hayatın gizliliği olmak üzere, kişilerin temel hak ve özgürlüklerini korumak ve kişisel verilerin korunması amacıyla düzenlenen Kanun ve Yönetmelikler gereğince Şirketimiz, kişisel verilerinizin hukuka aykırı olarak işlenmesini önleme, hukuka aykırı olarak erişilmesini önleme ve muhafazasını sağlama amacıyla, uygun güvenlik düzeyini temin etmeye yönelik tüm teknik ve idari tedbirleri almaktadır.Bu metnin hedef kitlesi, Şirketimiz çalışanları veya Şirketimize iş başvurusu yapmış olan çalışan adayları dışındaki, Şirketimiz tarafından kişisel verileri işlenen tüm gerçek kişilerdir.Veri sorumlusu sıfatıyla işlenen kişisel verilere, burada belirtilenlerle sınırlı sayıda olmamak üzere aşağıda yer verilmektedir; İsim, soy isim, T.C.kimlik numarası, adres, telefon numarası, e - posta adresi, imza, fiziksel mekan/ güvenlik görüntü kaydı, çağrı merkezi / hizmet kalitesi ses kaydı, banka hesap numarası, cookie kayıtları Kişisel verilerin toplanma ve saklanma yöntemi; Şirketimizle paylaştığınız kişisel verileriniz, otomatik ya da otomatik olmayan yöntemlerle, ofisler, şubeler, çağrı merkezi, internet sitesi, sosyal medya mecraları, mobil uygulamalar ve benzeri vasıtalarla sözlü, yazılı ya da elektronik olarak toplanabilir. Kişisel verileriniz elektronik ve/veya fiziksel ortamlarda saklanacaktır. Şirketimiz tarafından temin edilen ve saklanan kişisel verilerinizin saklandıkları ortamlarda yetkisiz erişime maruz kalmamaları, manipülasyona uğramamaları, kaybolmamaları ve zarar görmemeleri amacıyla gereken iş süreçlerinin tasarımı ile teknik güvenlik altyapı geliştirmeleri uygulanmaktadır. Kişisel verileriniz, size bildirilen amaçlar ve kapsam dışında kullanılmamak kaydı ile gerekli tüm bilgi güvenliği tedbirleri de alınarak işlenecek ve yasal saklama süresince veya böyle bir süre öngörülmemişse işleme amacının gerekli kıldığı süre boyunca saklanacak ve işlenecektir.Bu süre sona erdiğinde, kişisel verileriniz silinme, yok edilme ya da anonimleştirme yöntemleri ile Şirketimizin veri akışlarından çıkarılacaktır.");

        }

        private void txtCepTelefonu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
