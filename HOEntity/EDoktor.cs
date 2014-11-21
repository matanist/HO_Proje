using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOEntity
{
 public    class EDoktor
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        
        public EHastane Hastane { get; set; }
        public EBrans Brans { get; set; }
    }
}
