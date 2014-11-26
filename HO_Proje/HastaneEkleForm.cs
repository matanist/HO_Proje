using HOBLL;
using HOEntity;
using HOFacade;
using System;
using System.Data;
using System.Windows.Forms;

namespace HO_Proje
{
    public partial class HastaneEkleForm : Telerik.WinControls.UI.RadForm
    {
        public HastaneEkleForm()
        {
            InitializeComponent();
        }

        private void HastaneEkleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void lstvHastaneDoldur(BHastane hastane)
        {

            //listview'in kaynağı, görünen değeri ve arkaplanda tutacağı value ayarlanıyor. 
            lstvHastaneler.DataSource = hastane.TumHastaneler();
            lstvHastaneler.DisplayMember = "Ad";
            lstvHastaneler.ValueMember = "ID";
        }
        private void radButton1_Click(object sender, EventArgs e)
        {

            //eh nesnesi Hastane sınıfından hazırlandı. Ad özelliğine de textbox'dan gelen değer atandı. 
            EHastane eh = new EHastane();
            eh.AD = txbHastaneAdi.Text.Trim();
            //hastane nesnesi BHastane sınıfından hazırlandı. HastaneEkle metodundan dönen değerin durumuna göre kullanıcıya bilgi veriliyor. 
            BHastane hastane = new BHastane();
            MessageBox.Show(hastane.HastaneEkle(eh.AD) ? "Kayıt Başarılı" : "Kayıt Başarısız");
            lstvHastaneDoldur(hastane);
        }

        private void HastaneEkleForm_Load(object sender, EventArgs e)
        {
            //Entity katmanını devreye sokacak bir durum olmadığından kullanılmadı. 
            BHastane hastane = new BHastane();

            //DataSource'un belirlenmesi ile birlikte listview'in eventleri tetikleniyordu. Formun loadında tetiklenen bu olayı, form load olayından çıkardım ve en sona tekrar ekledim. 
            lstvHastaneler.SelectedIndexChanged -= lstvHastaneler_SelectedIndexChanged;
            lstvHastaneDoldur(hastane);

            //Brans ve Doktor gruplarının listviewleri etkisi hale getiriliyor. 
            lstvBranslar.Enabled = false;
            lstvDoktorlar.Enabled = false;
            lstvHastaneler.SelectedIndexChanged += lstvHastaneler_SelectedIndexChanged;

        }
        private void lstvBransDoldur(BBrans bransEkle, int ID)
        {

            lstvBranslar.DataSource = bransEkle.SeciliHastaneninTumBranslari(ID);
            lstvBranslar.DisplayMember = "Ad";
            lstvBranslar.ValueMember = "ID";
        }
        private void btnBransKaydet_Click(object sender, EventArgs e)
        {
            //Entity Brans Sınıfından yeni instans alındı ve bunun AD propertisine txtbox'ın içerisindeki değer atandı. 
            EBrans yeniBrans = new EBrans();
            yeniBrans.AD = txbBransAdi.Text;
            EHastane seciliHastane = new EHastane();
            seciliHastane.ID = Convert.ToInt32(lstvHastaneler.SelectedItem.Value.ToString());
            //yeniBrans.Hastane.ID =Convert.ToInt32(lstvHastaneler.SelectedItem.Value);
            yeniBrans.Hastane = seciliHastane;
            BBrans bransEkle = new BBrans();
            //Mevcut branşlar arasında eklenmek istenen varsa uyarılıyor. 
            foreach (var item in lstvBranslar.Items)
            {
                if (item.Text == yeniBrans.AD)
                {
                    MessageBox.Show("Bu Branş zaten mevcut");
                    return;
                }
            }

            if (lstvBranslar.Items.Contains(yeniBrans.AD))
            {
                MessageBox.Show("Bu hastanede bu branş zaten mevcut");
                return;
            }
            MessageBox.Show(bransEkle.BransEkle(yeniBrans.Hastane.ID, yeniBrans.AD) ? "Branş Ekleme Başarılı" : "Branş Eklemede bir sorun oldu");
            lstvBransDoldur(bransEkle, yeniBrans.Hastane.ID);

        }

        private void lstvHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvBranslar.SelectedIndexChanged -= lstvBranslar_SelectedIndexChanged;
            lstvBranslar.Enabled = true;
            BBrans branslar = new BBrans();
            if (lstvHastaneler.SelectedItem == null) lstvHastaneler.SelectedIndex = 0 ;
            lstvBransDoldur(branslar, Convert.ToInt32(lstvHastaneler.SelectedItem.Value));
            lstvBranslar.SelectedIndexChanged += lstvBranslar_SelectedIndexChanged;
        }
        private void lstvDoktorDoldur(BDoktor doktorlar, int hastaneID, int bransID)
        {

            lstvDoktorlar.DataSource = doktorlar.SeciliHastaneveBranstakiTumDoktorlar(hastaneID, bransID);
            lstvDoktorlar.DisplayMember = "Ad";
            lstvDoktorlar.ValueMember = "ID";
        }
        private void lstvBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbDoktorEkle.Enabled = true;
            lstvDoktorlar.Enabled = true;
            BDoktor doktorlar = new BDoktor();
            if (lstvBranslar.SelectedItem == null) lstvBranslar.SelectedIndex = 0;
           lstvDoktorDoldur(doktorlar, Convert.ToInt32(lstvHastaneler.SelectedItem.Value), Convert.ToInt32(lstvBranslar.SelectedItem.Value));
        }

        private void btnDoktorKaydet_Click(object sender, EventArgs e)
        {
            EDoktor yeniDoktor = new EDoktor();
            yeniDoktor.Ad = txbDoktorAdi.Text;
            EBrans seciliDoktorBransi = new EBrans();
            seciliDoktorBransi.ID = Convert.ToInt32(lstvBranslar.SelectedItem.Value.ToString());
            yeniDoktor.Brans = seciliDoktorBransi;
            EHastane seciliDoktorHastanesi = new EHastane();
            seciliDoktorHastanesi.ID = Convert.ToInt32(lstvHastaneler.SelectedItem.Value.ToString());
            yeniDoktor.Hastane = seciliDoktorHastanesi;
            //Yeni doktorun tüm bilgilerini UI'den aldık. Şimdi İş katmanına gönderelim. 

            BDoktor doktorEkle = new BDoktor();
            //Mevcut branşlar arasında eklenmek istenen varsa uyarılıyor. 
            foreach (var item in lstvDoktorlar.Items)
            {
                if (item.Text == yeniDoktor.Ad)
                {
                    MessageBox.Show("Bu Doktor zaten mevcut");
                    return;
                }
            }
            if (doktorEkle.DoktorVarMi(yeniDoktor.Ad))
            {
                MessageBox.Show("Bu Doktor başka bir branş veya hastanede görev yapmakta");
                return;
            }
            MessageBox.Show(doktorEkle.DoktorEkle(seciliDoktorHastanesi.ID, seciliDoktorBransi.ID, yeniDoktor.Ad) ? "Doktor Ekleme Başarılı" : "Doktor Ekleme Sırasında Bir Sorun Oluştu");
            lstvDoktorDoldur(doktorEkle, seciliDoktorHastanesi.ID, seciliDoktorBransi.ID);
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            if (lstvDoktorlar.SelectedItem == null) return;
            BDoktor doktorSil = new BDoktor();
            MessageBox.Show(doktorSil.DoktorSil(Convert.ToInt32(lstvDoktorlar.SelectedItem.Value)) ? "Doktor Silme Başarılı" : "Doktor silerken hata oluştu");
            lstvDoktorlar.Items.Remove(lstvDoktorlar.Items[lstvDoktorlar.SelectedIndex]);

        }

        private void btnBransSil_Click(object sender, EventArgs e)
        {
            if (lstvBranslar.SelectedItem == null) return;
            BBrans bransSil = new BBrans();

            if (bransSil.BransSil(Convert.ToInt32(lstvBranslar.SelectedItem.Value)))
            {
                MessageBox.Show("Branş Silme Başarılı");
                lstvBranslar.Items.Remove(lstvBranslar.Items[lstvBranslar.SelectedIndex]);
                if(lstvBranslar.Items.Count>0)
                lstvBranslar.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Brans Silme sırasında bir hata oluştu. \nBranş silerken branşa ait doktor olmamalıdır!");
            }

        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (lstvHastaneler.SelectedItem == null) return;
            BHastane hastaneSil = new BHastane();
           
            if (hastaneSil.HastaneSil(Convert.ToInt32(lstvHastaneler.SelectedItem.Value)))
            {
                MessageBox.Show("Hastane Silme Başarılı");
                lstvHastaneler.Items.Remove(lstvHastaneler.Items[lstvHastaneler.SelectedIndex]);
            }
            else
            {
                MessageBox.Show("Hastane silerken hata oluştu. \nÖncelikle hastaneye ait branşları silmeniz gerekir");
            }
        }

        private void lstvBranslar_SelectedIndexChanged(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            gbDoktorEkle.Enabled = true;
            lstvDoktorlar.Enabled = true;
            BDoktor doktorlar = new BDoktor();
            if (lstvBranslar.SelectedItem == null) lstvBranslar.SelectedIndex = 0;
            lstvDoktorDoldur(doktorlar, Convert.ToInt32(lstvHastaneler.SelectedItem.Value), Convert.ToInt32(lstvBranslar.SelectedItem.Value));
        }

        private void lstvHastaneler_SelectedIndexChanged(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            lstvBranslar.SelectedIndexChanged -= lstvBranslar_SelectedIndexChanged;
            lstvBranslar.Enabled = true;
            BBrans branslar = new BBrans();
            if (lstvHastaneler.SelectedItem == null) lstvHastaneler.SelectedIndex = 0;
            lstvBransDoldur(branslar, Convert.ToInt32(lstvHastaneler.SelectedItem.Value));
            lstvBranslar.SelectedIndexChanged += lstvBranslar_SelectedIndexChanged;
        }
    }
}
