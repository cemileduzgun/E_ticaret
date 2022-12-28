using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace BusinessLayer.Abstract
{
    public interface IUrunService
    {
        void AddUrun(Urun urun);
        void UpdateUrun(Urun urun);
        void DeleteUrun(Urun urun);
        List<Urun> GetAllUrunler();
        Urun GetUrunById(int id);
    }
}
