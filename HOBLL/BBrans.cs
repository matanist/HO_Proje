using HOFacade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOBLL
{
    public class BBrans
    {
        public bool BransEkle(int hastaneID,string bransAdi)
        {
           
            FVT vt = new FVT();
            if (string.IsNullOrEmpty(bransAdi)) return false;
            return vt.BransEkle(hastaneID,bransAdi.Trim());
            
        }
        public DataTable SeciliHastaneninTumBranslari(int hastaneID)
        {
            FVT vt = new FVT();
            if (string.IsNullOrEmpty(hastaneID.ToString())) return null;
            return vt.BranslariGetir(hastaneID);

        }
    }
}
