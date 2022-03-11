using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class AracListelemeDAL
    {
        public List<AracListelemeVM> AracListesiGetir(int markaID, int modelID, int uyeTipID, int statuID, int kuid)
        {
            List<AracListelemeVM> listem = new List<AracListelemeVM>();
            using (var db = new MyAracIhaleEntities())
            { //IhaleId degıstı
                listem = (from ia in db.AracSatis
                              //join i in db.Ihale on ia.IhaleID equals i.IhaleId
                          join asa in db.AracSatisDetay on ia.AracSatisId equals asa.AracSatisId
                          join k in db.Kullanici on ia.KullaniciId equals k.KullaniciId
                          join a in db.Arac on ia.AracId equals a.AracID
                          join s in db.Statu on asa.StatuId equals s.StatuID
                          join mo in db.Model on a.ModelID equals mo.ModelID
                          join ma in db.Marka on mo.MarkaID equals ma.MarkaID

                          where a.ModelID == modelID && k.KullaniciId==kuid && ma.MarkaID == markaID && k.UyeTipID == uyeTipID && asa.StatuId == statuID
                          select new AracListelemeVM()
                          {
                              AracID = a.AracID,
                              MarkaAdi = ma.MarkaAdi,
                              ModelAdi = mo.ModelAdi,
                              UyeTipID = k.UyeTipID,
                              StatuAdi = s.StatuAdi,
                              KullaniciAdi = k.KullaniciAdi,
                              KaydetmeZamani = ia.CreatedDate.Value,
                              AracPlaka = a.Plaka

                          }).ToList();
            }          
            return listem;
        }

        public List<AracListelemeVM> AracListele()
        {
            Repository<Arac> r = new Repository<Arac>();
            List<AracListelemeVM> liste = new List<AracListelemeVM>();

            foreach (var item in r.Select())
            {
                AracListelemeVM mv = new AracListelemeVM()
                {                  
                    AracID=item.AracID,
                    AracPlaka=item.Plaka,
                };
                liste.Add(mv);
            }
            return liste;
        }
    }
}
