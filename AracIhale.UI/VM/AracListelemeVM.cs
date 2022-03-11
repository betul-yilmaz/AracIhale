using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class AracListelemeVM
    {
        public int AracID { get; set; }
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
        public int UyeTipID { get; set; }
        public string StatuAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime KaydetmeZamani { get; set; }
        public string AracPlaka { get; set; }
    }
}
