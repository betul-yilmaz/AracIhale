using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.Mapper
{
    public class MarkaSilMapper
    {

        public Marka VMToMarka(MarkaVM vm)
        {
            return new Marka()
            {

                MarkaAdi = vm.MarkaAdi,
                MarkaID = vm.Id,
                CreatedBy = vm.CreatedBy,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate,
                CreatedDate = vm.CreatedDate,
                isActive = vm.IsActive
            };
        }

    }
}
