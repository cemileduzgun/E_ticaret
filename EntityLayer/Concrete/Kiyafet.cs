using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kiyafet : BaseEntity
    {
        [StringLength(3, ErrorMessage = "hatalı giriş", MinimumLength = 1)]
        public string Beden { get; set; }
        public bool Cinsiyet { get; set; }

    }
}
