using HOEntity;
using HOFacade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOBLL
{
    public class BRandevu
    {
        public bool RandevuEkle(DateTime tarih, string hastaAd, string hastaTCKimlikNo, int hastaneID, int bransID, int doktorID)
        {
            FVT baglanti = new FVT();
            if (tarih < DateTime.Now) return false;
            if (string.IsNullOrEmpty(hastaAd)) return false;
            if (string.IsNullOrEmpty(hastaTCKimlikNo)) return false;
            return baglanti.RandevuEkle(tarih, hastaAd, hastaTCKimlikNo, hastaneID, bransID, doktorID);
        }
        public List<ERandevu> TumRandevular()
        {
            FVT baglanti = new FVT();
            return baglanti.TumRandevular();
        }
        public bool RandevuDuzenle(int id, DateTime tarih, string hastaAd, string hastaTCKimlik)
        {
            FVT baglanti = new FVT();
            return baglanti.RandevuDuzenle(id, tarih, hastaAd, hastaTCKimlik);
        }
        public bool RandevuSil(int id)
        {
            FVT baglanti = new FVT();
            return baglanti.RandevuSil(id);
        }
    }
}
