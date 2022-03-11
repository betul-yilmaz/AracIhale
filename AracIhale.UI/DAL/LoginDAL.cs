using AracIhale.UI.Repository.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.UI.DAL
{
    public class LoginDAL
    {
        Repository<Kullanici> k = new Repository<Kullanici>();

        public int KullaniciVarMi(string KullaniciAdi, string Sifre)
        {
            Kullanici s = k.Select(x => x.KullaniciAdi == KullaniciAdi && x.Sifre == Sifre && x.isActive == true).SingleOrDefault();
            if (s!= null)
            {
                StaticLogin.KullaniciAdi = s.KullaniciAdi;
                StaticLogin.Sifre = s.Sifre;
                StaticLogin.RolID = s.RolID;
                StaticLogin.KullaniciID = s.KullaniciId;
                if (s.RolID==1)
                {
                    return 1;
                }
                else if (s.RolID==2)
                {
                   return 2;
                }
                else
                {
                    return 0;
                }
                
            }
            else
            {
                return 0;
            }
        }
    }
}
