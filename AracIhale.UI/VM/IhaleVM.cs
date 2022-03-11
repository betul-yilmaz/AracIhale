using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class IhaleVM:BaseVM
    {
        public int KullaniciID { get; set; }
        public string IhaleAdi { get; set; }
        public override string ToString()
        {
            return IhaleAdi;
        }
    }
}
