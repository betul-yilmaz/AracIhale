using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class StatuDAL
    {
        Repository<Statu> r = new Repository<Statu>();

        public List<StatuVM> StatuListele()
        {
            List<StatuVM> liste = new List<StatuVM>();

            foreach (var item in r.Select())
            {
                StatuVM mv = new StatuVM()
                {
                    StatuAdi = item.StatuAdi,
                    Id = item.StatuID


                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<StatuVM> UyeTipGoreStatuListele(int UyeTipID)
        {
            List<StatuVM> liste = new List<StatuVM>();

            foreach (var item in r.Select().Where(x => x.UyeTipAciklamaID == UyeTipID))
            {
                StatuVM mv = new StatuVM()
                {
                    StatuAdi = item.StatuAdi,
                    Id = item.StatuID
                };
                liste.Add(mv);
            }
            return liste;
        }
    }
}
