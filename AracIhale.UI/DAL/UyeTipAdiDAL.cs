using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class UyeTipAdiDAL
    {
        Repository<UyeTip> r = new Repository<UyeTip>();
        public List<UyeVM> UyeTipAciklamaListele()
        {
            List<UyeVM> liste = new List<UyeVM>();
            foreach (var item in r.Select(x => x.UyeTipId == 1 || x.UyeTipId == 2))
            {
                UyeVM mv = new UyeVM()
                {
                    Id = item.UyeTipId,
                    UyeTipAdi = item.UyeTipAciklama,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<UyeVM> UyeTipAciklamaListele2()
        {
            List<UyeVM> liste = new List<UyeVM>();
            foreach (var item in r.Select().Where(x => x.UyeTipId == 1 || x.UyeTipId == 2))
            {
                UyeVM mv = new UyeVM()
                {
                    UyeTipAdi = item.UyeTipAciklama,
                };
                liste.Add(mv);
            }
            return liste;
        }
    }
}
