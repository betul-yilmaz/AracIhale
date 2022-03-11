using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class IhaleListVM:BaseVM
    {
        public string IhaleAdi { get; set; }
        public string UyeTipiAciklamasi { get; set; }
        public DateTime BaslangicTarih { get; set; }

        public DateTime BitisTarih { get; set; }
        public string StatuAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime KayedilmeZamani { get; set; }
        public int KullaniciID { get; set; }
        public string BaslangicSaat { get; set; }
        public string BitisSaat { get; set; }
       
    }
}
