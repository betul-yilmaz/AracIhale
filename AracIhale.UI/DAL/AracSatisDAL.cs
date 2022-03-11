using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class AracSatisDAL
    {
        Repository<AracSatis> repo = new Repository<AracSatis>();
        public int AracSatisEkle(AracSatisAddVM eklenecekArac)
        {
            AracSatis AracSatisEkle = new AracSatis()
            {
                Aciklama = eklenecekArac.Aciklama,
                AracId = eklenecekArac.AracID,
                isActive = eklenecekArac.IsActive,
                KullaniciId = eklenecekArac.KullaniciID,
                CreatedBy = eklenecekArac.CreatedBy,
                CreatedDate = eklenecekArac.CreatedDate,
                ModifiedBy = eklenecekArac.ModifiedBy,
                ModifiedDate = eklenecekArac.ModifiedDate,
            };
            return repo.Insert(AracSatisEkle);
        }

        public List<FirmaAdiListVM> FirmaAdiListesiGetir(int UyeTipID)
        {
            List<FirmaAdiListVM> listem = new List<FirmaAdiListVM>();
            using (var db = new MyAracIhaleEntities())
            { 
                listem = (from f in db.Firma
                          select new FirmaAdiListVM()
                          {
                              FirmaAdi=f.FirmaAdi,
                          }).ToList();
            }
            return listem;
        }
    }
}
