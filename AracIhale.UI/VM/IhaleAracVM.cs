using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class IhaleAracVM:BaseVM
    {
        public int BaslangicFiyat { get; set; }
        public int MinFiyat { get; set; }

        public int AracId { get; set; }
        public int IhaleID { get; set; }
    }
}
