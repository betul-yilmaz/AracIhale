using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class PaketDAL
    {
        Repository<Paket> repo = new Repository<Paket>();
        public int FirmaEkle(PaketVM eklenecekTur)
        {
            Paket PaketEkle = new Paket()
            {
                Tur = eklenecekTur.Tur,
                CreatedBy = eklenecekTur.CreatedBy,
                CreatedDate = eklenecekTur.CreatedDate,
                ModifiedBy = eklenecekTur.ModifiedBy,
                isActive = eklenecekTur.IsActive,
                ModifiedDate = eklenecekTur.ModifiedDate



            };
            return repo.Insert(PaketEkle);
        }

        public List<PaketVM> PaketListele()
        {
            List<PaketVM> liste = new List<PaketVM>();

            foreach (var item in repo.Select())
            {
                PaketVM mv = new PaketVM()
                {
                    Id = item.PaketId,
                    Tur = item.Tur,
                    // Id = item.ModelID,
                    // ModelAdi = item.ModelAdi,
                    // MarkaAdi = repo.SelectByID(item.ModelID).Marka.MarkaAdi//???
                };
                liste.Add(mv);
            }
            return liste;
        }

    }
}
