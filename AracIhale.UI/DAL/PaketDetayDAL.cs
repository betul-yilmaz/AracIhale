using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class PaketDetayDAL
    {
        Repository<PaketDetay> repo = new Repository<PaketDetay>();
        public int PaketEkle(PaketDetayVM eklenecekFirmaPaket)
        {
            PaketDetay PaketEkle = new PaketDetay()
            {

                PaketId = eklenecekFirmaPaket.PaketID,
                FirmaID = eklenecekFirmaPaket.FirmaID,
                CreatedBy = 1,
                isActive = true,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now,

            };
            return repo.Insert(PaketEkle);
        }
    }
}
