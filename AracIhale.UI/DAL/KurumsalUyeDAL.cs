using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class KurumsalUyeDAL
    {
        Repository<KurumsalKullanici> r = new Repository<KurumsalKullanici>();
        public int KurumsalKullaniciEkle(KurumsalUyeKayitVM eklenecek)
        {
            KurumsalKullanici k = new KurumsalKullanici()
            {
                AdSoyad = eklenecek.KullaniciAdSoyad,
                KurumsalKulID = eklenecek.KullaniciID, ///emin değilim
                FirmaID = eklenecek.FirmaID,
                KullaniciID = eklenecek.KullaniciID,
                //  TC=eklenecek.TC,

                CreatedBy = eklenecek.CreatedBy,
                ModifiedBy = eklenecek.ModifiedBy,
                ModifiedDate = eklenecek.ModifiedDate,
                CreatedDate = eklenecek.CreatedDate,
                isActive = eklenecek.IsActive

            };
            return r.Insert(k);

        }

        public List<KurumsalUyeKayitVM> KurumsalUyeListesiGetir()
        {
            List<KurumsalUyeKayitVM> listem = new List<KurumsalUyeKayitVM>();
            using (var db = new MyAracIhaleEntities())
            {

                listem = (from k in db.Kullanici
                          join ku in db.KurumsalKullanici
   on k.KullaniciId equals ku.KullaniciID
                          join f in db.Firma
                          on ku.FirmaID equals f.FirmaID
                          select new KurumsalUyeKayitVM()
                          {
                              KurumsalKullaniciID = ku.KurumsalKulID,
                              KullaniciAdi = k.KullaniciAdi,
                              AdSoyad = ku.AdSoyad,
                              TC = ku.TC,
                              FirmaAdi = f.FirmaAdi,
                              IsActive = ku.isActive
                          }).ToList();
            }

            return listem;

        }
        /// <summary>
        /// ///////////////////
        /// </summary>
        /// <returns></returns>
        public KurumsalKullanici KurumsalUyeKayitVMToKurumsalKullanici(KurumsalUyeKayitVM ku)
        {
            return new KurumsalKullanici()
            {
                KurumsalKulID = ku.KurumsalKullaniciID,

                AdSoyad = ku.AdSoyad,
                TC = ku.TC,
                //FirmaID=ku.FirmaID, KullaniciID=ku.KullaniciID,
                //     Firma=(ku.FirmaAdi as Firma)
                CreatedBy = ku.CreatedBy,
                ModifiedBy = ku.ModifiedBy,
                ModifiedDate = ku.ModifiedDate,
                CreatedDate = ku.CreatedDate,
                isActive = true
            };
        }

        public int UyeOnay(KurumsalUyeKayitVM vm)
        {
              Repository<KurumsalKullanici> repo = new Repository<KurumsalKullanici>();
           return repo.Onayla(KurumsalUyeKayitVMToKurumsalKullanici(vm));

        }


    }
}
