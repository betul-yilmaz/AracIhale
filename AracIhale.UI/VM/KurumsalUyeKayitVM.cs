using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class KurumsalUyeKayitVM : BaseVM
    {
        public string KullaniciAdi { get; set; }
        public int KurumsalKullaniciID { get; set; }
        public string TC { get; set; }
        public string AdSoyad { get; set; }
        public string FirmaAdi { get; set; }
        public string CepTelefonu { get; set; }
        public string Sifre { get; set; }
        public string FirmaBilgisi { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public string KullaniciAdSoyad { get; set; }
        public int KullaniciID { get; set; }
        public int FirmaID { get; set; }
        public bool? Onay { get; set; }
        public override string ToString()
        {
            return " AdSoyad:" + AdSoyad + ", TC" + TC + ", Onay Durumu" + IsActive.ToString();
        }
    }
}
