using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOFacade
{
    public class FVT
    {
        public static string connectionCumlecigi = "Server=MATO\\MSSQLSERVER2014;Database=HastaneOtomasyon;UID=sa;PWD=1";
        public static SqlConnection conn = new SqlConnection(connectionCumlecigi);
        public bool HastaneEkle(string hastaneAdi)
        {

            SqlConnection conn = new SqlConnection("Server=MATO\\MSSQLSERVER2014;Database=HastaneOtomasyon;UID=sa;PWD=1");
            SqlCommand comm = new SqlCommand("Insert INTO Hastane Values(@hastaneAdi)", conn);
            comm.Parameters.AddWithValue("@hastaneAdi", hastaneAdi);
            
            if(conn.State==ConnectionState.Closed)conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
        public DataTable TumHastaneler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Hastane", connectionCumlecigi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool BransEkle(int hastaneID,string bransAdi)
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
            SqlDataAdapter da = new SqlDataAdapter("Select * From Brans Where HastaneID=@hastaneID", connectionCumlecigi);
            da.SelectCommand.Parameters.AddWithValue("@hastaneID", hastaneID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool DoktorEkle(int hastaneID,int bransID, string doktorAdi)
        {
            SqlCommand comm = new SqlCommand("Insert INTO Doktor Values(@doktorAdi,@hastaneID,@bransID)", conn);
            comm.Parameters.AddWithValue("@doktorAdi", doktorAdi);
            comm.Parameters.AddWithValue("@hastaneID", hastaneID);
            comm.Parameters.AddWithValue("@bransID", bransID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = comm.ExecuteNonQuery() > 0;
            return sonuc;
        }
        public DataTable DoktorlariGetirHastaneIDveBransIDyeGore(int hastaneID,int bransID)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Doktor Where HastaneID=@hastaneID and BransID=@bransID", connectionCumlecigi);
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
            bool sonuc =comm.ExecuteScalar()!=null ;
            return sonuc;
        }

        public bool DoktorSil(int doktorID)
        {
            SqlCommand comm = new SqlCommand("Delete From Doktor Where ID=@doktorID", conn);
            comm.Parameters.AddWithValue("@doktorID", doktorID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            return comm.ExecuteNonQuery() > 0;
        }
    }
}
