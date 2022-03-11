using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class FirmaEklemeDAL
    {
        Repository<Firma> repo = new Repository<Firma>();
        public int FirmaEkle(FirmaKayitVM eklenecekFirma)
        {
            Firma FirmaEkle = new Firma()
            {
                FirmaAdi = eklenecekFirma.FirmaAdi,
                FaliyetAlanı = eklenecekFirma.FirmaFaaliyetAlani,
                VergiNo = eklenecekFirma.FirmaVergiNo,
                FirmaID = eklenecekFirma.FirmaID,
                CreatedDate = eklenecekFirma.CreatedDate,
                CreatedBy = eklenecekFirma.CreatedBy,
                ModifiedBy = eklenecekFirma.ModifiedBy,
                ModifiedDate = eklenecekFirma.ModifiedDate,
                isActive = eklenecekFirma.IsActive
                  

            };
            return repo.Insert(FirmaEkle,1);
        }
    }
}
