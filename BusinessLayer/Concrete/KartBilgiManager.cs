using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KartBilgiManager : IKartBilgiService
    {
        GenericRepositories<KartBilgi> efKartBilgiRepositories;
        public KartBilgiManager()
        {
            efKartBilgiRepositories = new GenericRepositories<KartBilgi>();
        }
        public void AddKartBilgi(KartBilgi kartBilgi)
        {
            efKartBilgiRepositories.Insert(kartBilgi);

        }

        public void DeleteKartBlgi(KartBilgi kartBilgi)
        {
            if (kartBilgi.KartBilgiId != 0)
            {
                efKartBilgiRepositories.Delete(kartBilgi);
            }
        }

        public KartBilgi GetKartBilgiById(int id)
        {
            return efKartBilgiRepositories.GetById(id);
        }
    }
}
