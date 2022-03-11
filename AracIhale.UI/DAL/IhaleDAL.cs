using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class IhaleDAL
    {
        Repository<Ihale> r = new Repository<Ihale>();
        public List<IhaleVM> IhaleListele()
        {
            List<IhaleVM> liste = new List<IhaleVM>();

            foreach (var item in r.Select())
            {
                IhaleVM mv = new IhaleVM()
                {
                    Id = item.IhaleId,
                    IhaleAdi = item.Adi

                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<IhaleListVM> IhaleListesiGetir(int ihaleID, int uyeTipID, int statuID,int kid)
        {
            List<IhaleListVM> listem = new List<IhaleListVM>();
            using (var db = new MyAracIhaleEntities())
            {
                listem = (
                          from k in db.Kullanici
                          //join ut in db.UyeTip on k.KullaniciId equals ut.KullaniciId
                          join ut in db.UyeTip on k.UyeTipID equals ut.UyeTipId
                          join i in db.Ihale on k.KullaniciId equals i.KullaniciId
                          join ia in db.IhaleArac on i.IhaleId equals ia.IhaleID
                          join s in db.Statu on ia.StatuId equals s.StatuID
                          where i.IhaleId == ihaleID && k.UyeTipID== uyeTipID && s.StatuID == statuID && k.KullaniciId==kid
                          select new IhaleListVM()
                          {
                              Id = i.IhaleId,
                              IhaleAdi = i.Adi,
                              UyeTipiAciklamasi = ut.UyeTipAciklama,
                              BaslangicTarih = i.BaslangicTarih.Value,
                              BitisTarih = i.BitisTarih.Value,
                              KullaniciAdi = k.KullaniciAdi,
                              StatuAdi = s.StatuAdi,

                              KayedilmeZamani = i.CreatedDate.Value
                          }).ToList();
            }

            return listem;
        }
        public List<IhaleListVM> IhaleListesiGetir()
        {
            List<IhaleListVM> listem = new List<IhaleListVM>();
            using (var db = new MyAracIhaleEntities())
            {

                listem = (
                          from k in db.Kullanici
                    //      join ut in db.UyeTip on k.KullaniciId equals ut.KullaniciId
                          join ua in db.UyeTip on k.UyeTipID equals ua.UyeTipId
                          join i in db.Ihale on k.KullaniciId equals i.KullaniciId
                          join ia in db.IhaleArac on i.IhaleId equals ia.IhaleID
                          join s in db.Statu on ia.StatuId equals s.StatuID

                          select new IhaleListVM()
                          {
                              Id = i.IhaleId,
                              IhaleAdi = i.Adi,
                              UyeTipiAciklamasi = ua.UyeTipAciklama,
                              BaslangicTarih = i.BaslangicTarih.Value,
                              BitisTarih = i.BitisTarih.Value,
                              KullaniciAdi = k.KullaniciAdi,
                              StatuAdi = s.StatuAdi,
                              KayedilmeZamani = i.CreatedDate.Value
                          }).ToList();

            }

            return listem;

        }
        public int IhaleEkle(IhaleListVM eklenecek)
        {
            Ihale Marka = new Ihale()
            {
                Adi = eklenecek.IhaleAdi,
                KullaniciId=eklenecek.KullaniciID,
                 BaslangicTarih=eklenecek.BaslangicTarih,
                  BitisTarih=eklenecek.BitisTarih,
                   
                CreatedBy = eklenecek.CreatedBy,
                ModifiedBy = eklenecek.ModifiedBy,
                ModifiedDate = eklenecek.ModifiedDate,
                CreatedDate = eklenecek.CreatedDate,
                isActive = eklenecek.IsActive
            };
            return r.Insert(Marka);
        }
    }
}
