using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class StatuVM:BaseVM
    {
        public string StatuAdi { get; set; }
        //Eklendi
        //public int TipAciklamaID { get; set; }

        public override string ToString()
        {
            return StatuAdi.ToString();
        }

    }
}
