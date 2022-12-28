using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IKullaniciService
    {
        void AddKullanici(Kullanici kullanici);


        List<Kullanici> GetAllKullanicilar();

    }
}
