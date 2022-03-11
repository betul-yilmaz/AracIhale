using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class OzellikVM:BaseVM
    {
        public string OzellikAdi { get; set; }

        public override string ToString()
        {
            return OzellikAdi.ToUpper();
        }
    }
}
