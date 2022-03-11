using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class TramerOzellikDAL
    {
        public int TramDtyEkle(AracTramerDetayVM eklenecekdetay)
        {
            Repository<AracTramerDetay> repo = new Repository<AracTramerDetay>();
            AracTramerDetay TrmDtyEkle = new AracTramerDetay()
            {
                AracID = eklenecekdetay.AracID,
                TramerID = eklenecekdetay.TramerID,
                TramerTipID = eklenecekdetay.TramerTipID
            };
            return repo.Insert(TrmDtyEkle);
        }
    }
}
