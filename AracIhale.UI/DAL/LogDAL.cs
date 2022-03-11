using AracIhale.UI.Repository.Repo;
using AracIhale.UI.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class LogDAL
    {
        Repository<Log> r = new Repository<Log>();
        public int LogEkle(LogAddVM EklenecekLog)
        {
            Log Log = new Log()
            {
                
                CreatedDate = EklenecekLog.CreatedDate,
             
            };
            return r.Insert(Log);
        }
    }
}
