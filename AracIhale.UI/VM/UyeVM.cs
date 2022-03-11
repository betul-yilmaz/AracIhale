using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class UyeVM:BaseVM
    {
        public string UyeTipAdi { get; set; }
        public override string ToString()
        {
            return UyeTipAdi;
        }
    }
}
