using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOEntity
{
    public class ERandevu
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string HastaAd { get; set; }
        public string HastaTCKimlik { get; set; }
        public string HastaneAdi { get; set; }
        public string BransAdi { get; set; }
        public string DoktorAdi { get; set; }
    }
}
