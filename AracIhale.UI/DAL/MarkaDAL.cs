using AracIhale.UI.Mapper;
using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AracIhale.UI.DAL.MarkaDAL
{
    public class MarkaDAL
    {
        //MarkaVM _markaVM;
        //public MarkaDAL()
        //{
        //    _markaVM = ;
        //}
     
        Repository<Marka> r = new Repository<Marka>();  
        public int MarkaEkle(MarkaVM EklenecekMarka)
        {
            Marka Marka = new Marka()
            {
                CreatedBy = EklenecekMarka.CreatedBy,
                ModifiedBy = EklenecekMarka.ModifiedBy,
                MarkaAdi = EklenecekMarka.MarkaAdi,
                ModifiedDate = EklenecekMarka.ModifiedDate,
                CreatedDate = EklenecekMarka.CreatedDate,
                isActive = EklenecekMarka.IsActive
            };
            return r.Insert(Marka,1);
        }
        public List<MarkaVM> MarkaListele()
        {
            List<MarkaVM> liste = new List<MarkaVM>();
           
            foreach (var item in r.Select(x => x.isActive == true))
            {
                MarkaVM mv = new MarkaVM()
                {
                    Id = item.MarkaID,
                    MarkaAdi = item.MarkaAdi,

                };
                liste.Add(mv);
            }  
           return liste ;
        }
        public void MarkaSil(MarkaVM silinecek)
        {
            r.Delete(new MarkaSilMapper().VMToMarka(silinecek), 1);
        }

    }

}
