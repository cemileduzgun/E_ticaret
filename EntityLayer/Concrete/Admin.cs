using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [StringLength(30, ErrorMessage = "Hatalı Giriş ", MinimumLength = 0)]
        public string AdminAdi { get; set; }

        [StringLength(15, ErrorMessage = "Hatalı Giriş ", MinimumLength = 10)]
        public string Sifre { get; set; }
        public int AdminId { get; set; }
        public int UrunId { get; set; }
    }
}
