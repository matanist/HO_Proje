


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
            
            
        }

        
    }
}
