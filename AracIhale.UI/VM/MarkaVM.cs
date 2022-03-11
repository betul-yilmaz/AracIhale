using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class MarkaVM:BaseVM
    {
        public  string MarkaAdi { get; set; }
        public override string ToString()
        {
            return MarkaAdi.ToUpper();
        }
    }
  
}
