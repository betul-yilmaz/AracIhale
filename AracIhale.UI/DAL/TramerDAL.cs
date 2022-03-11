using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class TramerDAL
    {
        Repository<AracTramerUcret> repo = new Repository<AracTramerUcret>();
        public int TramerUcretEkle(TramerVM eklenecekfiyat)
        {
            AracTramerUcret TramerUcretEkle = new AracTramerUcret()
            {
                AracId = eklenecekfiyat.AracId,
                Fiyat = eklenecekfiyat.Fiyat,
            };
            return repo.Insert(TramerUcretEkle);
        }
    }
}
