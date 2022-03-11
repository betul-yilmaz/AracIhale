using AracIhale.UI.Mapper;
using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class OzellikDAL
    {
        Repository<Ozellik> r = new Repository<Ozellik>();
        public int OzellikEkle(OzellikVM EklenecekOzellik)
        {           
            Ozellik Ozellik = new Ozellik()
            {
                CreatedBy = EklenecekOzellik.CreatedBy,
                ModifiedBy = EklenecekOzellik.ModifiedBy,
                OzellikAdi = EklenecekOzellik.OzellikAdi, 
                ModifiedDate = EklenecekOzellik.ModifiedDate,
                CreatedDate = EklenecekOzellik.CreatedDate,
                IsActive = EklenecekOzellik.IsActive
            };
            return r.Insert(Ozellik);
        }
        public List<OzellikVM> OzellikListele()
        {
            List<OzellikVM> liste = new List<OzellikVM>();

            foreach (var item in r.Select(x => x.IsActive == true))
            {
                OzellikVM mv = new OzellikVM()
                {
                    Id = item.OzellikID,
                    OzellikAdi = item.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<OzellikDetayListVM> OzellikDetayListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select())
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi
                };
                liste.Add(mv);
            }
            return liste;
        }
        public int OzellikDetayEkle(OzellikDetayVM EklenecekOzellikDetay)
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            OzellikDetay OzellikDetay = new OzellikDetay();
            OzellikDetay.CreatedBy = EklenecekOzellikDetay.CreatedBy;
            OzellikDetay.ModifiedBy = EklenecekOzellikDetay.ModifiedBy;
            OzellikDetay.OzellikDetayAdi = EklenecekOzellikDetay.Deger;
            OzellikDetay.OzellikID = EklenecekOzellikDetay.OzellikID;
            OzellikDetay.ModifiedDate = EklenecekOzellikDetay.ModifiedDate;
            OzellikDetay.CreatedDate = EklenecekOzellikDetay.CreatedDate;
            OzellikDetay.IsActive = EklenecekOzellikDetay.IsActive;

            return ro.Insert(OzellikDetay);
        }

        public List<OzellikDetayListVM> OzellikDetayGövdeTipListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select().Where(x=>x.OzellikID==3))
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    //OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<OzellikDetayListVM> OzellikDetayYakıtTipListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select().Where(x => x.OzellikID == 4))
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    //OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<OzellikDetayListVM> OzellikDetayVitesTipListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select().Where(x => x.OzellikID == 2))
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    //OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<OzellikDetayListVM> OzellikDetayRenkTipListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select().Where(x => x.OzellikID == 1))
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    //OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<OzellikDetayListVM> OzellikDetayDonanimTipListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select().Where(x => x.OzellikID == 7))
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    //OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<OzellikDetayListVM> OzellikDetayVersiyonTipListele()
        {
            Repository<OzellikDetay> ro = new Repository<OzellikDetay>();
            List<OzellikDetayListVM> liste = new List<OzellikDetayListVM>();

            foreach (var item in ro.Select().Where(x => x.OzellikID == 6))
            {
                OzellikDetayListVM mv = new OzellikDetayListVM()
                {
                    Id = item.OzellikDetayID,
                    DegerAdi = item.OzellikDetayAdi,
                    //OzellikAdi = ro.SelectByID(item.OzellikID).Ozellik.OzellikAdi,
                };
                liste.Add(mv);
            }
            return liste;
        }
        public void OzellikSil(OzellikVM silinecek)
        {
            r.Delete2(new OzellikSilMapper().VMToMarka(silinecek), 1);
        }
    }
}
