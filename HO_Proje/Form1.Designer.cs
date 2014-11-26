namespace HO_Proje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.grdKayitliRandevular = new Telerik.WinControls.UI.RadGridView();
            this.gbHastaKayitPaneli = new Telerik.WinControls.UI.RadGroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRandevuEkle = new Telerik.WinControls.UI.RadButton();
            this.btnRandevuGuncelle = new Telerik.WinControls.UI.RadButton();
            this.btnRandevuSil = new Telerik.WinControls.UI.RadButton();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.ddlDoktorSecimi = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlBransSecimi = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlHastaneler = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txbTcKimlikNo = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txbHastaAdi = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKayitliRandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKayitliRandevular.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbHastaKayitPaneli)).BeginInit();
            this.gbHastaKayitPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDoktorSecimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlBransSecimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlHastaneler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTcKimlikNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHastaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.grdKayitliRandevular);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.HeaderText = "Kayıtlı Randevular";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 231);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(662, 329);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Kayıtlı Randevular";
            // 
            // grdKayitliRandevular
            // 
            this.grdKayitliRandevular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.grdKayitliRandevular.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.grdKayitliRandevular.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdKayitliRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKayitliRandevular.EnableKineticScrolling = true;
            this.grdKayitliRandevular.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdKayitliRandevular.ForeColor = System.Drawing.Color.Black;
            this.grdKayitliRandevular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdKayitliRandevular.Location = new System.Drawing.Point(2, 18);
            // 
            // grdKayitliRandevular
            // 
            this.grdKayitliRandevular.MasterTemplate.AllowAddNewRow = false;
            this.grdKayitliRandevular.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdKayitliRandevular.MasterTemplate.EnablePaging = true;
            this.grdKayitliRandevular.Name = "grdKayitliRandevular";
            this.grdKayitliRandevular.ReadOnly = true;
            this.grdKayitliRandevular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdKayitliRandevular.Size = new System.Drawing.Size(658, 309);
            this.grdKayitliRandevular.TabIndex = 10;
            this.grdKayitliRandevular.Text = "radGridView1";
            // 
            // gbHastaKayitPaneli
            // 
            this.gbHastaKayitPaneli.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbHastaKayitPaneli.Controls.Add(this.linkLabel1);
            this.gbHastaKayitPaneli.Controls.Add(this.btnRandevuEkle);
            this.gbHastaKayitPaneli.Controls.Add(this.btnRandevuGuncelle);
            this.gbHastaKayitPaneli.Controls.Add(this.btnRandevuSil);
            this.gbHastaKayitPaneli.Controls.Add(this.dtpRandevuTarihi);
            this.gbHastaKayitPaneli.Controls.Add(this.ddlDoktorSecimi);
            this.gbHastaKayitPaneli.Controls.Add(this.ddlBransSecimi);
            this.gbHastaKayitPaneli.Controls.Add(this.ddlHastaneler);
            this.gbHastaKayitPaneli.Controls.Add(this.radLabel6);
            this.gbHastaKayitPaneli.Controls.Add(this.radLabel5);
            this.gbHastaKayitPaneli.Controls.Add(this.radLabel4);
            this.gbHastaKayitPaneli.Controls.Add(this.radLabel3);
            this.gbHastaKayitPaneli.Controls.Add(this.radLabel2);
            this.gbHastaKayitPaneli.Controls.Add(this.txbTcKimlikNo);
            this.gbHastaKayitPaneli.Controls.Add(this.radLabel1);
            this.gbHastaKayitPaneli.Controls.Add(this.txbHastaAdi);
            this.gbHastaKayitPaneli.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHastaKayitPaneli.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbHastaKayitPaneli.HeaderText = "Hasta Kayıt Paneli";
            this.gbHastaKayitPaneli.Location = new System.Drawing.Point(0, 0);
            this.gbHastaKayitPaneli.Name = "gbHastaKayitPaneli";
            this.gbHastaKayitPaneli.Size = new System.Drawing.Size(662, 225);
            this.gbHastaKayitPaneli.TabIndex = 1;
            this.gbHastaKayitPaneli.Text = "Hasta Kayıt Paneli";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(43, 163);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hastane Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRandevuEkle
            // 
            this.btnRandevuEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuEkle.Location = new System.Drawing.Point(480, 142);
            this.btnRandevuEkle.Name = "btnRandevuEkle";
            this.btnRandevuEkle.Size = new System.Drawing.Size(146, 61);
            this.btnRandevuEkle.TabIndex = 8;
            this.btnRandevuEkle.Text = "EKLE";
            this.btnRandevuEkle.Click += new System.EventHandler(this.btnRandevuEkle_Click);
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(328, 142);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(146, 61);
            this.btnRandevuGuncelle.TabIndex = 7;
            this.btnRandevuGuncelle.Text = "GÜNCELLE";
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuSil.Location = new System.Drawing.Point(176, 142);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(146, 61);
            this.btnRandevuSil.TabIndex = 6;
            this.btnRandevuSil.Text = "SİL";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(454, 98);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(169, 25);
            this.dtpRandevuTarihi.TabIndex = 5;
            // 
            // ddlDoktorSecimi
            // 
            this.ddlDoktorSecimi.AllowShowFocusCues = false;
            this.ddlDoktorSecimi.AutoCompleteDisplayMember = null;
            this.ddlDoktorSecimi.AutoCompleteValueMember = null;
            this.ddlDoktorSecimi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ddlDoktorSecimi.Location = new System.Drawing.Point(453, 69);
            this.ddlDoktorSecimi.Name = "ddlDoktorSecimi";
            this.ddlDoktorSecimi.Size = new System.Drawing.Size(170, 23);
            this.ddlDoktorSecimi.TabIndex = 4;
            this.ddlDoktorSecimi.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlDoktorSecimi_SelectedIndexChanged);
            // 
            // ddlBransSecimi
            // 
            this.ddlBransSecimi.AllowShowFocusCues = false;
            this.ddlBransSecimi.AutoCompleteDisplayMember = null;
            this.ddlBransSecimi.AutoCompleteValueMember = null;
            this.ddlBransSecimi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ddlBransSecimi.Location = new System.Drawing.Point(453, 42);
            this.ddlBransSecimi.Name = "ddlBransSecimi";
            this.ddlBransSecimi.Size = new System.Drawing.Size(170, 23);
            this.ddlBransSecimi.TabIndex = 3;
            this.ddlBransSecimi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ddlBransSecimi_MouseClick);
            // 
            // ddlHastaneler
            // 
            this.ddlHastaneler.AllowShowFocusCues = false;
            this.ddlHastaneler.AutoCompleteDisplayMember = null;
            this.ddlHastaneler.AutoCompleteValueMember = null;
            this.ddlHastaneler.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ddlHastaneler.Location = new System.Drawing.Point(135, 96);
            this.ddlHastaneler.Name = "ddlHastaneler";
            this.ddlHastaneler.Size = new System.Drawing.Size(170, 23);
            this.ddlHastaneler.TabIndex = 2;
            this.ddlHastaneler.PopupOpening += new System.ComponentModel.CancelEventHandler(this.ddlHastaneler_PopupOpening);
            this.ddlHastaneler.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlHastaneler_SelectedIndexChanged);
            this.ddlHastaneler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ddlHastaneler_MouseClick);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel6.Location = new System.Drawing.Point(344, 99);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(103, 21);
            this.radLabel6.TabIndex = 1;
            this.radLabel6.Text = "Randevu Tarihi :";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(348, 69);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(99, 21);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Doktor Seçimi :";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(357, 42);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(90, 21);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Branş Seçimi :";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(56, 96);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(63, 21);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Hastane :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(7, 69);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(112, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Kimlik Numarası :";
            // 
            // txbTcKimlikNo
            // 
            this.txbTcKimlikNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbTcKimlikNo.Location = new System.Drawing.Point(135, 69);
            this.txbTcKimlikNo.Name = "txbTcKimlikNo";
            this.txbTcKimlikNo.Size = new System.Drawing.Size(170, 23);
            this.txbTcKimlikNo.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(47, 41);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Hasta Adı :";
            // 
            // txbHastaAdi
            // 
            this.txbHastaAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbHastaAdi.Location = new System.Drawing.Point(135, 41);
            this.txbHastaAdi.Name = "txbHastaAdi";
            this.txbHastaAdi.Size = new System.Drawing.Size(170, 23);
            this.txbHastaAdi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 560);
            this.Controls.Add(this.gbHastaKayitPaneli);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "HASTANE OTOMASYON";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKayitliRandevular.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdKayitliRandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbHastaKayitPaneli)).EndInit();
            this.gbHastaKayitPaneli.ResumeLayout(false);
            this.gbHastaKayitPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDoktorSecimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlBransSecimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlHastaneler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTcKimlikNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHastaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox gbHastaKayitPaneli;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txbHastaAdi;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txbTcKimlikNo;
        private Telerik.WinControls.UI.RadDropDownList ddlDoktorSecimi;
        private Telerik.WinControls.UI.RadDropDownList ddlBransSecimi;
        private Telerik.WinControls.UI.RadDropDownList ddlHastaneler;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private Telerik.WinControls.UI.RadButton btnRandevuEkle;
        private Telerik.WinControls.UI.RadButton btnRandevuGuncelle;
        private Telerik.WinControls.UI.RadButton btnRandevuSil;
        private Telerik.WinControls.UI.RadGridView grdKayitliRandevular;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
