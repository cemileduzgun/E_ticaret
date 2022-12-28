using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
namespace BusinessLayer.Concrete
{
    internal class KullaniciManager : IKullaniciService
    {
        GenericRepositories<Kullanici> efKullaniciRepositories;
        public KullaniciManager()
        {
            efKullaniciRepositories = new GenericRepositories<Kullanici>();
        }
        public void AddKullanici(Kullanici kullanici)
        {
            efKullaniciRepositories.Insert(kullanici);
        }

        public List<Kullanici> GetAllKullanicilar()
        {
            return efKullaniciRepositories.GetListAll();
        }
    }
}
