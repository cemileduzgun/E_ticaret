using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KartBilgi
    {
        public DateTime SKT { get; set; }

        [StringLength(16, ErrorMessage = "Hatlı Giriş", MinimumLength = 16)]
        public string HesapNo { get; set; }
        [StringLength(3, ErrorMessage = "Hatlı Giriş", MinimumLength = 3)]
        public string CVV { get; set; }
        public int KartBilgiId { get; set; }

    }
}
