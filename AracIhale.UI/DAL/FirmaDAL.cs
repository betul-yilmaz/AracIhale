using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class FirmaDAL
    {
        public List<FirmaAdiListVM> FirmaListele()
        {
            Repository<Firma> r = new Repository<Firma>();
            List<FirmaAdiListVM> liste = new List<FirmaAdiListVM>();

            foreach (var item in r.Select())
            {
                FirmaAdiListVM mv = new FirmaAdiListVM()
                {

                    Id = item.FirmaID,
                    FirmaAdi = item.FirmaAdi,

                };
                liste.Add(mv);
            }
            return liste;
        }
    }
}
