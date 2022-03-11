using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class AracSatisAddVM:BaseVM
    {
        public int KullaniciID { get; set; }
        public int AracID { get; set; }
        public string Aciklama { get; set; }
    }
}
