using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.Repository.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        MyAracIhaleEntities _dbContext;
        DbSet<T> _table;
        public Repository()
        {
            _dbContext = new MyAracIhaleEntities();
            _table = _dbContext.Set<T>();
        }
        public int Delete(T silinecek, int? userid = null)//
        {
            silinecek.GetType().GetProperty("isActive").SetValue(silinecek, false);
            return Update(silinecek);
        }
        public int Delete2(T silinecek, int? userid = null)//
        {
            silinecek.GetType().GetProperty("IsActive").SetValue(silinecek, false);
            return Update(silinecek);
        }
        public int Onayla(T onaylanacak, int? userid = null)//
        {
            onaylanacak.GetType().GetProperty("isActive").SetValue(onaylanacak, true);
            return Update(onaylanacak);
        }
        public int HardDelete(int Id, int? userid = null)//
        {
            _table.Remove(_table.Find(Id));
            return _dbContext.SaveChanges(userid);
         
        }

        public int Insert(T eklenecek, int? userid = null)//
        {
            _table.Add(eklenecek);
            return _dbContext.SaveChanges(userid);
           
        }

        public List<T> Select(Expression<Func<T, bool>> kosul)
        {
          return _table.Where(kosul).ToList();
        }

        public List<T> Select()
        {
           return _table.ToList();
        }

        public T SelectByID(int Id)
        {
          return _table.Find(Id);
        }

        public int Update(T guncellenecek, int? userid = null)//
        {
            _table.Attach(guncellenecek);
            _dbContext.Entry(guncellenecek).State = EntityState.Modified;
            return _dbContext.SaveChanges(userid);
        }

    
    }
}
