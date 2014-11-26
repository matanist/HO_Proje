using HOBLL;
using System;
using System.Windows.Forms;
namespace HO_Proje
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            HastaneEkleForm form2 = new HastaneEkleForm();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {


            dgvRandevulariDoldur();

        }

        private void ddlHastaneler_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ddlDoktorSecimi.SelectedIndexChanged -= ddlDoktorSecimi_SelectedIndexChanged;
            BBrans branslar = new BBrans();
            ddlBransSecimi.DataSource = branslar.SeciliHastaneninTumBranslari(Convert.ToInt32(ddlHastaneler.SelectedItem.Value));
            ddlBransSecimi.DisplayMember = "Ad";
            ddlBransSecimi.ValueMember = "ID";
            ddlDoktorSecimi.SelectedIndexChanged += ddlDoktorSecimi_SelectedIndexChanged;
        }

        private void ddlHastaneler_PopupOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ddlHastaneler.SelectedIndexChanged -= ddlHastaneler_SelectedIndexChanged;
            BHastane hastaneler = new BHastane();
            
            ddlHastaneler.DataSource = hastaneler.TumHastaneler();
            ddlHastaneler.DisplayMember = "Ad";
            ddlHastaneler.ValueMember = "ID";
            ddlHastaneler.SelectedIndexChanged += ddlHastaneler_SelectedIndexChanged;
        }

        private void ddlDoktorSecimi_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
        }

        private void ddlHastaneler_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ddlDoktorSecimi.SelectedIndexChanged -= ddlDoktorSecimi_SelectedIndexChanged;
            BBrans branslar = new BBrans();
            ddlBransSecimi.DataSource = branslar.SeciliHastaneninTumBranslari(Convert.ToInt32(ddlHastaneler.SelectedItem.Value));
            ddlBransSecimi.DisplayMember = "Ad";
            ddlBransSecimi.ValueMember = "ID";
            ddlDoktorSecimi.SelectedIndexChanged += ddlDoktorSecimi_SelectedIndexChanged;
        }

        private void ddlBransSecimi_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            BDoktor doktorlar = new BDoktor();
            ddlDoktorSecimi.DataSource = doktorlar.SeciliHastaneveBranstakiTumDoktorlar(Convert.ToInt32(ddlHastaneler.SelectedItem.Value), Convert.ToInt32(ddlBransSecimi.SelectedItem.Value));
            ddlDoktorSecimi.DisplayMember = "Ad";
            ddlDoktorSecimi.ValueMember = "ID";
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            BRandevu randevu = new BRandevu();
            if (randevu.RandevuEkle(dtpRandevuTarihi.Value, txbHastaAdi.Text, txbTcKimlikNo.Text, Convert.ToInt32(ddlHastaneler.SelectedItem.Value), Convert.ToInt32(ddlBransSecimi.SelectedItem.Value), Convert.ToInt32(ddlDoktorSecimi.SelectedItem.Value)))
            {
                MessageBox.Show("Randevu Kaydı Başarılı");
                dgvRandevulariDoldur();
            }
            else
            {
                MessageBox.Show("Kayıt Sırasında bir sorun oluştu");
            }
        }

        private void dgvRandevulariDoldur()
        {
            BRandevu randevular=new BRandevu();
            grdKayitliRandevular.DataSource = randevular.TumRandevular();
            grdKayitliRandevular.Columns[0].HeaderText = "ID";
            grdKayitliRandevular.Columns[1].HeaderText = "Randevu Tarihi";
            grdKayitliRandevular.Columns[2].HeaderText = "Hasta Adı";
            grdKayitliRandevular.Columns[3].HeaderText = "Hasta TC Kimlik No";
            grdKayitliRandevular.Columns[4].HeaderText = "Hastane";
            grdKayitliRandevular.Columns[5].HeaderText = "Branş";
            grdKayitliRandevular.Columns[6].HeaderText = "Doktor";

            grdKayitliRandevular.DataSource = randevular.TumRandevular();
            
        }


    }
}
