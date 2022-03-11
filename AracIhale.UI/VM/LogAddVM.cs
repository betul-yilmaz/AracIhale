using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class LogAddVM
    {
        public int LogID { get; set; }
        public string Islem { get; set; }
        public string TabloAdi { get; set; }
        public int KullaniciID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
