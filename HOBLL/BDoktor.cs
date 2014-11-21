using HOFacade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOBLL
{
    public class BDoktor
    {
        public bool DoktorEkle(int hastaneID,int bransID,string doktorAdi)
        {
            FVT baglanti = new FVT();
            if (string.IsNullOrEmpty(doktorAdi)) return false;
            bool sonuc = baglanti.DoktorEkle(hastaneID,bransID,doktorAdi.Trim());
            return sonuc;
        }
        public DataTable SeciliHastaneveBranstakiTumDoktorlar(int hastaneID, int bransID)
        {
            FVT baglanti = new FVT();
            return baglanti.DoktorlariGetirHastaneIDveBransIDyeGore(hastaneID, bransID);
        }
        public bool DoktorVarMi(string doktorAdi)
        {
            FVT baglanti = new FVT();
            if (string.IsNullOrEmpty(doktorAdi)) return false;
            bool sonuc = baglanti.DoktorMevcutMu(doktorAdi);
            return sonuc;
        }
    }
}
