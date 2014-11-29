using HO_Proje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace HOProje
{
    public partial class DbAyarForm : Telerik.WinControls.UI.RadForm
    {
        public DbAyarForm()
        {
            InitializeComponent();
        }

        private void DbAyarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 anaForm = new Form1();
            anaForm.Show();
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            string sqlCumlesi = "";
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtServer.Text) || string.IsNullOrEmpty(txtSifre.Text)) return;
            sqlCumlesi = "Server=" + txtServer.Text.Trim() + ";Database=HastaneOtomasyon;UID=" + txtKullaniciAdi.Text.Trim() + ";PWD=" + txtSifre.Text.Trim();
            SqlConnection conn = new SqlConnection(sqlCumlesi);
            if (conn.State == ConnectionState.Open) conn.Close();
            try
            {
                conn.Open();
                MessageBox.Show("Bağlantı başarılı");
                conn.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bağlantıda hata oluştu. İlgili hata :\n"+hata.Message);
            }
            
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtServer.Text) || string.IsNullOrEmpty(txtSifre.Text)) return;
            string AdoNetBaglanti = "";
            string EntityBaglanti = "";
            AdoNetBaglanti = "Server=" + txtServer.Text.Trim() + ";Database=HastaneOtomasyon;UID=" + txtKullaniciAdi.Text.Trim() + ";PWD=" + txtSifre.Text.Trim();
            EntityBaglanti = "metadata=res://*/HastaneOtomasyonModel.csdl|res://*/HastaneOtomasyonModel.ssdl|res://*/HastaneOtomasyonModel.msl;provider=System.Data.SqlClient;provider connection string=\"data source=" + txtServer.Text.Trim() + ";initial catalog=HastaneOtomasyon;persist security info=True;user id=" + txtKullaniciAdi.Text.Trim() + ";password=" + txtSifre.Text.Trim() + ";MultipleActiveResultSets=True;App=EntityFramework\"";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["SunucuBaglanti"].ConnectionString = AdoNetBaglanti;
            config.Save();
            connectionStringsSection.ConnectionStrings["HastaneOtomasyonEntities"].ConnectionString = EntityBaglanti;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
