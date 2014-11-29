using HOBLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using HOEntity;
using System.Linq;
using HOProje;
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
            grdKayitliRandevular.CurrentRowChanged -= grdKayitliRandevular_CurrentRowChanged;

            dgvRandevulariDoldur();
            grdKayitliRandevular.CurrentRowChanged += grdKayitliRandevular_CurrentRowChanged;

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
            if (string.IsNullOrEmpty(txbHastaAdi.Text) || string.IsNullOrEmpty(txbTcKimlikNo.Text) || ddlBransSecimi.SelectedValue == null || ddlDoktorSecimi.SelectedValue == null || ddlHastaneler.SelectedValue == null || dtpRandevuTarihi.Value == null) return; 
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

        private void grdKayitliRandevular_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            int seciliRandevuID = Convert.ToInt32(grdKayitliRandevular.CurrentRow.Cells["ID"].Value);
            BRandevu bRandevu=new BRandevu();
            List<ERandevu> randevular = bRandevu.TumRandevular();
            ERandevu randevu = new ERandevu();
            randevu = (from r in randevular
                      where r.ID == seciliRandevuID
                      select r).FirstOrDefault();
            txbHastaAdi.Text = randevu.HastaAd;
            txbTcKimlikNo.Text = randevu.HastaTCKimlik;
            ddlBransSecimi.Text = randevu.BransAdi;
            ddlHastaneler.Text = randevu.HastaneAdi;
            ddlDoktorSecimi.Text = randevu.DoktorAdi;
            dtpRandevuTarihi.Value = randevu.Tarih;
        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            BRandevu randevuGuncelle = new BRandevu();
            if (string.IsNullOrEmpty(txbTcKimlikNo.Text)) return;
            MessageBox.Show(randevuGuncelle.RandevuDuzenle(Convert.ToInt32(grdKayitliRandevular.CurrentRow.Cells["ID"].Value),dtpRandevuTarihi.Value,txbHastaAdi.Text,txbTcKimlikNo.Text)?"Güncelleme Başarılı":"Güncelleme sırasında bir sorun oluştu");
            grdKayitliRandevular.Rows.Clear();
            grdKayitliRandevular.DataSource = randevuGuncelle.TumRandevular();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            BRandevu randevuSil = new BRandevu();
            if (grdKayitliRandevular.CurrentRow.Cells["ID"].Value == null) return;
            DialogResult dialogSonuc = MessageBox.Show("Silmek istediğinize emin misiniz?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogSonuc == DialogResult.No) return;
            MessageBox.Show(randevuSil.RandevuSil(Convert.ToInt32(grdKayitliRandevular.CurrentRow.Cells["ID"].Value))?"Randevu Başarı ile silindi":"Randevu silerken hata oluştu"); 
            grdKayitliRandevular.Rows.Clear();
            grdKayitliRandevular.DataSource = randevuSil.TumRandevular();
            
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            DbAyarForm yeniForm = new DbAyarForm();
            yeniForm.Show();
            this.Hide();
        }


    }
}
