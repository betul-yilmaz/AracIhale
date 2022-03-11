using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class GorselDAL
    {
        Repository<AracGorsel> r = new Repository<AracGorsel>();
        public int GorselEkle(GorselEkleVM EklenecekGorsel)
        {
            AracGorsel Gorsel = new AracGorsel()
            {
                AracId=EklenecekGorsel.AracID,
                Gorsel=EklenecekGorsel.Foto
            };
            return r.Insert(Gorsel);
        }
    }
}
