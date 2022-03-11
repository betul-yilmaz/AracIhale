using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.Repository
{
    public interface IRepository<T> where T:class
    {
        int Insert(T eklenecek, int? userid);//
        T SelectByID(int Id);
        List<T> Select(Expression<Func <T,bool>> kosul);//Bak
        List<T> Select();
        int Delete(T silinecek, int? userid);//
        int HardDelete(int Id, int? userid);//
        int Update(T guncellenecek, int? userid);//
        int Delete2(T silinecek, int? userid = null);
        int Onayla(T onaylanacak, int? userid = null);
    }
}
