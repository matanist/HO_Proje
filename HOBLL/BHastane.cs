using HOFacade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOBLL
{
    public class BHastane
    {
        public bool HastaneEkle(string hastaneAdi)
        {
            FVT baglanti = new FVT();
            if (string.IsNullOrEmpty(hastaneAdi)) return false;
            bool sonuc = baglanti.HastaneEkle(hastaneAdi.Trim());
            return sonuc;
        }
        public DataTable TumHastaneler()
        {
            FVT baglanti = new FVT();
            return baglanti.TumHastaneler();
            //adfkjakdfj
        }


        public bool HastaneSil(int hastaneID)
        {
            FVT baglanti = new FVT();
            return baglanti.hastaneSil(hastaneID);
            
        }
    }
}
