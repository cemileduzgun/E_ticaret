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
    public class UrunManager : IUrunService
    {
        GenericRepositories<Urun> efUrunRepositories;
        public UrunManager()
        {
            efUrunRepositories = new GenericRepositories<Urun>();
        }
        public void AddUrun(Urun urun)
        {
            efUrunRepositories.Insert(urun);
        }

        public void DeleteUrun(Urun urun)
        {

            // tanımlarken zaten null olamaz dedim
            efUrunRepositories.Delete(urun);

        }

        public List<Urun> GetAllUrunler()
        {
            return efUrunRepositories.GetListAll();
        }

        public Urun GetUrunById(int id)
        {
            return efUrunRepositories.GetById(id);
        }

        public void UpdateUrun(Urun urun)
        {
            efUrunRepositories.Update(urun);
        }
    }
}
