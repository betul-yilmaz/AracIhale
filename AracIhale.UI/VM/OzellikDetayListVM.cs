using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class OzellikDetayListVM:BaseVM
    {
        public string DegerAdi { get; set; }
        public string OzellikAdi { get; set; }

        public override string ToString()
        {
            return DegerAdi.ToUpper();
        }
    }
}
