using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class TramerTipDAL
    {
        public List<TramerOzellikTipVM> TramListele()
        {
            Repository<TramerTipi> repo = new Repository<TramerTipi>();
            List<TramerOzellikTipVM> liste = new List<TramerOzellikTipVM>();
            {
                foreach (var item in repo.Select())
                {
                    TramerOzellikTipVM tm = new TramerOzellikTipVM()
                    {
                        TramerTip = item.TramerTipi1,
                    };
                    liste.Add(tm);
                }
                return liste;
            }
        }
        public List<TramerTipVM> TramListele2()
        {
            Repository<Tramer> repo = new Repository<Tramer>();
            List<TramerTipVM> liste = new List<TramerTipVM>();
            {
                foreach (var item in repo.Select())
                {
                    TramerTipVM tm2 = new TramerTipVM()
                    {
                        TramerAdi = item.TramerAdi,

                    };
                    liste.Add(tm2);


                }
                return liste;
            }

        }
    }
}
