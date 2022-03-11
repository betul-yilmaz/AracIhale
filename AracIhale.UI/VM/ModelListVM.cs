using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.VM
{
    public class ModelListVM:BaseVM
    {
        public string ModelAdi { get; set; }
        public string MarkaAdi { get; set; }
        public override string ToString()
        {
            return ModelAdi;
        }
    }
}
