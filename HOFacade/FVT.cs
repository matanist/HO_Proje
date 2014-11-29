using HOEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HOFacade
{
    public class FVT
    {
        
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SunucuBaglanti"].ConnectionString);
        public bool HastaneEkle(string hastaneAdi)
        {

            
            SqlCommand comm = new SqlCommand("Insert INTO Hastane Values(@hastaneAdi)", conn);
            comm.Parameters.AddWithValue("@hastaneAdi", hastaneAdi);

            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
        public DataTable TumHastaneler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Hastane",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool BransEkle(int hastaneID, string bransAdi)
        {
            SqlCommand comm = new SqlCommand("Insert INTO Brans Values(@bransAdi,@hastaneID)", conn);
            comm.Parameters.AddWithValue("@bransAdi", bransAdi);
            comm.Parameters.AddWithValue("@hastaneID", hastaneID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
        public DataTable BranslariGetir(int hastaneID)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Brans Where HastaneID=@hastaneID", conn);
            da.SelectCommand.Parameters.AddWithValue("@hastaneID", hastaneID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool DoktorEkle(int hastaneID, int bransID, string doktorAdi)
        {
            SqlCommand comm = new SqlCommand("Insert INTO Doktor Values(@doktorAdi,@hastaneID,@bransID)", conn);
            comm.Parameters.AddWithValue("@doktorAdi", doktorAdi);
            comm.Parameters.AddWithValue("@hastaneID", hastaneID);
            comm.Parameters.AddWithValue("@bransID", bransID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
        public DataTable DoktorlariGetirHastaneIDveBransIDyeGore(int hastaneID, int bransID)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Doktor Where HastaneID=@hastaneID and BransID=@bransID", conn);
            da.SelectCommand.Parameters.AddWithValue("@hastaneID", hastaneID);
            da.SelectCommand.Parameters.AddWithValue("@bransID", bransID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool DoktorMevcutMu(string doktorAdi)
        {
            SqlCommand comm = new SqlCommand("Select * From Doktor Where Ad=@doktorAdi", conn);
            comm.Parameters.AddWithValue("@doktorAdi", doktorAdi);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteScalar() != null;
            return sonuc;
        }

        public bool DoktorSil(int doktorID)
        {
            SqlCommand comm = new SqlCommand("Delete From Doktor Where ID=@doktorID", conn);
            comm.Parameters.AddWithValue("@doktorID", doktorID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            return comm.ExecuteNonQuery() > 0;
        }

        public bool BransSil(int bransID)
        {
            //BransID'ye ait doktorlar var mı kontrol ediliyor. 
            SqlCommand comm = new SqlCommand("Select * From Doktor Where BransID=@bransID", conn);
            comm.Parameters.AddWithValue("@bransID", bransID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (comm.ExecuteScalar() != null)
            {
                return false;

            }
            else
            {
                comm = new SqlCommand("Delete From Brans Where ID=@bransID", conn);
                comm.Parameters.AddWithValue("@bransID", bransID);
                if (conn.State == ConnectionState.Closed) conn.Open();
                if (comm.ExecuteNonQuery() > 0) return true;
            }
            return false;
        }

        public bool hastaneSil(int hastaneID)
        {
            SqlCommand comm = new SqlCommand("Select * From Brans Where HastaneID=@hastaneID", conn);
            comm.Parameters.AddWithValue("@hastaneID", hastaneID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (comm.ExecuteScalar() != null)
            {
                return false;
            }
            else
            {
                comm = new SqlCommand("Delete From Hastane Where ID=@hastaneID", conn);
                comm.Parameters.AddWithValue("@hastaneID", hastaneID);
                if (comm.ExecuteNonQuery() > 0) return true;
            }
            return false;
        }
        public bool RandevuEkle(DateTime tarih, string hastaAd, string hastaTCKimlikNo, int hastaneID, int bransID, int doktorID)
        {
            SqlCommand comm = new SqlCommand("Insert Into Randevu(Tarih,HastaAd,HastaTCKimlikNo,HastaneID,BransID,DoktorID) Values(@tarih,@hastaAd,@hastaTCKimlikNo,@hastaneID,@bransID,@doktorID)", conn);
            comm.Parameters.AddWithValue("@tarih", tarih);
            comm.Parameters.AddWithValue("@hastaAd", hastaAd);
            comm.Parameters.AddWithValue("@hastaTCKimlikNo", hastaTCKimlikNo);
            comm.Parameters.AddWithValue("@hastaneID", hastaneID);
            comm.Parameters.AddWithValue("@bransID", bransID);
            comm.Parameters.AddWithValue("@doktorID", doktorID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            if (comm.ExecuteNonQuery() > 0) return true;

            return false;
        }
        public List<ERandevu> TumRandevular()
        {
            ERandevu randevu = new ERandevu();
            HastaneOtomasyonEntities db = new HastaneOtomasyonEntities();
            return db.Randevu.Select(p => new ERandevu
            {
                ID = p.ID,
                Tarih = p.Tarih,
                HastaAd = p.HastaAd,
                HastaTCKimlik = p.HastaTCKimlikNo,
                HastaneAdi = p.Hastane.Ad,
                BransAdi = p.Brans.Ad,
                DoktorAdi = p.Doktor.Ad
            }).ToList();

        }

        public bool RandevuDuzenle(int id, DateTime tarih, string hastaAd, string hastaTCKimlik)
        {
            SqlCommand comm = new SqlCommand("Update Randevu SET Tarih=@tarih,HastaAd=@hastaAd,HastaTCKimlikNo=@hastaTCKimlik Where ID=@id", conn);
            comm.Parameters.AddWithValue("@id", id);
            comm.Parameters.AddWithValue("@tarih", tarih);
            comm.Parameters.AddWithValue("@hastaAd", hastaAd);
            comm.Parameters.AddWithValue("@hastaTCKimlik", hastaTCKimlik);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
        public bool RandevuSil(int id)
        {
            SqlCommand comm = new SqlCommand("Delete From Randevu Where ID=@id", conn);
            comm.Parameters.AddWithValue("@id", id);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
    }
}
