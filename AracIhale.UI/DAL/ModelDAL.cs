using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{

    public class ModelDAL
    {
        Repository<Model> repo = new Repository<Model>();
       public int ModelEkle(ModelAddVM eklenecekModel)
        {
            Model ModelEkle = new Model()
            {
                ModelAdi = eklenecekModel.ModelAdi,
                MarkaID = eklenecekModel.MarkaId,
                ModifiedBy=eklenecekModel.ModifiedBy,
                CreatedBy=eklenecekModel.CreatedBy,
                ModifiedDate=eklenecekModel.ModifiedDate, CreatedDate=eklenecekModel.CreatedDate,
                Aciklama=eklenecekModel.ModelAdi,  
                isActive = eklenecekModel.IsActive
            };
            return repo.Insert(ModelEkle);
        }


        public List<ModelListVM> ModelListele()
        {
            List<ModelListVM> liste = new List<ModelListVM>();

            foreach (var item in repo.Select())
            {
                ModelListVM mv = new ModelListVM()
                {
                    Id = item.ModelID,
                    ModelAdi = item.ModelAdi,
                    MarkaAdi = repo.SelectByID(item.MarkaID).Marka.MarkaAdi//???
                };
                liste.Add(mv);
            }
            return liste;
        }
        public List<ModelListVM> MarkaIDgoreModelListele(int MarkaID)
        {
            List<ModelListVM> liste = new List<ModelListVM>();

            foreach (var item in repo.Select().Where(x => x.MarkaID == MarkaID))
            {
                ModelListVM mv = new ModelListVM()
                {
                    Id = item.ModelID,
                    ModelAdi = item.ModelAdi,
                    MarkaAdi = repo.SelectByID(item.MarkaID).Marka.MarkaAdi
                };
                liste.Add(mv);
            }
            return liste;
        }
    }
}
