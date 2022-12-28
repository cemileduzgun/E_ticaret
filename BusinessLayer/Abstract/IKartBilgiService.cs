using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
namespace BusinessLayer.Abstract
{
    public interface IKartBilgiService
    {
        void AddKartBilgi(KartBilgi kartBilgi);

        void DeleteKartBlgi(KartBilgi kartBilgi);

        KartBilgi GetKartBilgiById(int id);
    }
}
