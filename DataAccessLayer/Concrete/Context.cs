using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Admin> adminler { get; set; }
        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<KartBilgi> kartbilgileri { get; set; }

        public DbSet<Urun> urunler { get; set; }
        public DbSet<Kiyafet> kiyafetler { get; set; }
        public DbSet<Siparis> siparisler { get; set; }
        public DbSet<Kozmetik> kozmetikesyalari { get; set; }
        public DbSet<Yemek> yemekler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("DataSource=localhost;port=3306;Initial Catalog=alisverissitesi;uid=root; pwd=Rojtemel271202");

        }
    }
}
