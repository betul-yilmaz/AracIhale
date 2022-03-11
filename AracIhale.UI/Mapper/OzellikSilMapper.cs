using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.Mapper
{
    public class OzellikSilMapper
    {
        public Ozellik VMToMarka(OzellikVM vm)
        {
            return new Ozellik()
            {
                OzellikAdi = vm.OzellikAdi,
                OzellikID = vm.Id,

                CreatedBy = vm.CreatedBy,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate,
                CreatedDate = vm.CreatedDate,
                IsActive = vm.IsActive
            };
        }
    }
}
