using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class IhaleAracDAL
    {
        Repository<IhaleArac> repo = new Repository<IhaleArac>();
        public int FiyatGir(IhaleAracVM eklenecekfiyat)
        {
            IhaleArac FiyatEkle = new IhaleArac()
            {
                BaslangicFiyat = eklenecekfiyat.BaslangicFiyat,
                MinimumAlimFiyat = eklenecekfiyat.MinFiyat,
                AracId = eklenecekfiyat.AracId,
                IhaleID = eklenecekfiyat.IhaleID,
            };
            return repo.Insert(FiyatEkle);
        }
    }
}
