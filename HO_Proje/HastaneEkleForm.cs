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

        private void radButton1_Click(object sender, EventArgs e)
        {

            //eh nesnesi Hastane sınıfından hazırlandı. Ad özelliğine de textbox'dan gelen değer atandı. 
            EHastane eh = new EHastane();
            eh.AD = txbHastaneAdi.Text.Trim();
            //hastane nesnesi BHastane sınıfından hazırlandı. HastaneEkle metodundan dönen değerin durumuna göre kullanıcıya bilgi veriliyor. 
            BHastane hastane = new BHastane();
            MessageBox.Show(hastane.HastaneEkle(eh.AD) ? "Kayıt Başarılı" : "Kayıt Başarısız");

            //listview'in kaynağı, görünen değeri ve arkaplanda tutacağı value ayarlanıyor. 
            lstvHastaneler.DataSource = hastane.TumHastaneler();
            lstvHastaneler.DisplayMember = "Ad";
            lstvHastaneler.ValueMember = "ID";
        }

        private void HastaneEkleForm_Load(object sender, EventArgs e)
        {
            //Entity katmanını devreye sokacak bir durum olmadığından kullanılmadı. 
            BHastane hastane = new BHastane();

            //DataSource'un belirlenmesi ile birlikte listview'in eventleri tetikleniyordu. Formun loadında tetiklenen bu olayı, form load olayından çıkardım ve en sona tekrar ekledim. 
            lstvHastaneler.SelectedIndexChanged -= lstvHastaneler_SelectedIndexChanged;
            lstvHastaneler.DataSource = hastane.TumHastaneler();
            lstvHastaneler.DisplayMember = "Ad";
            lstvHastaneler.ValueMember = "ID";

            //Brans ve Doktor gruplarının listviewleri etkisi hale getiriliyor. 
            lstvBranslar.Enabled = false;
            lstvDoktorlar.Enabled = false;
            lstvHastaneler.SelectedIndexChanged += lstvHastaneler_SelectedIndexChanged;

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
            lstvBranslar.DataSource = bransEkle.SeciliHastaneninTumBranslari(yeniBrans.Hastane.ID);
            lstvBranslar.DisplayMember = "Ad";
            lstvBranslar.ValueMember = "ID";
            //Brans ekleme grubundaki listview'in içeriği branslarla doldurulacak. 
        }

        private void lstvHastaneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstvBranslar.Enabled = true;
            BBrans branslar = new BBrans();
            lstvBranslar.DataSource = branslar.SeciliHastaneninTumBranslari(Convert.ToInt32(lstvHastaneler.SelectedItem.Value));
            lstvBranslar.DisplayMember = "Ad";
            lstvBranslar.ValueMember = "ID";
        }
    }
}
