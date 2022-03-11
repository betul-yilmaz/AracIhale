using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class OzellikDetayVM:BaseVM
    {
        public string Deger { get; set; }
        public int OzellikID { get; set; }

        public override string ToString()
        {
            return Deger.ToUpper();
        }

    }
}
