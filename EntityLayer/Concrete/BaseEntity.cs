using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Hatalı Giriş ", MinimumLength = 0)]
        public string Adi { get; set; }
        public int Fiyat { get; set; }
        public string Marka { get; set; }
        public string Tur { get; set; }



    }
}
