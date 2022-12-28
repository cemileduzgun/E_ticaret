using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{

    public class Yemek : BaseEntity
    {
        public DateTime SKT { get; set; }
        public int Porsiyon { get; set; }
    }
}
