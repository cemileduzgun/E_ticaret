using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kullanici
    {

        [StringLength(30, ErrorMessage = "Hatalı Giriş ")]
        public string KullaniciAdi { get; set; }

        public string Mail { get; set; }
        [StringLength(15, ErrorMessage = "Hatalı Giriş ", MinimumLength = 10)]
        public string Sifre { get; set; }
        public int KullaniciId { get; set; }
        public KartBilgi KartBilgi { get; set; }

    }
}
