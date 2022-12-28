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
    public class AdminManager : IAdminService
    {
        GenericRepositories<Admin> efAdminRepositories;
        public AdminManager()
        {
            efAdminRepositories = new GenericRepositories<Admin>();
        }
        public void AddAdmin(Admin admin)
        {
            efAdminRepositories.Insert(admin);
        }

        public object GetAllAdmins()
        {
            throw new NotImplementedException();
        }
    }
}
