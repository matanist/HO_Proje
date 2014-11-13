namespace HO_Proje
{
    partial class HastaneEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaneEkleForm));
            this.gbHastaneEkle = new Telerik.WinControls.UI.RadGroupBox();
            this.lstvHastaneler = new Telerik.WinControls.UI.RadListView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnRandevuSil = new Telerik.WinControls.UI.RadButton();
            this.lblHastaneAdi = new Telerik.WinControls.UI.RadLabel();
            this.txbHastaneAdi = new Telerik.WinControls.UI.RadTextBox();
            this.gbBransEkle = new Telerik.WinControls.UI.RadGroupBox();
            this.lstvBranslar = new Telerik.WinControls.UI.RadListView();
            this.btnBransKaydet = new Telerik.WinControls.UI.RadButton();
            this.btnBransSil = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txbBransAdi = new Telerik.WinControls.UI.RadTextBox();
            this.gbDoktorEkle = new Telerik.WinControls.UI.RadGroupBox();
            this.lstvDoktorlar = new Telerik.WinControls.UI.RadListView();
            this.btnDoktorKaydet = new Telerik.WinControls.UI.RadButton();
            this.btnDoktorSil = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txbDoktorAdi = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbHastaneEkle)).BeginInit();
            this.gbHastaneEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvHastaneler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHastaneAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHastaneAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbBransEkle)).BeginInit();
            this.gbBransEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvBranslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBransKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBransSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBransAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoktorEkle)).BeginInit();
            this.gbDoktorEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoktorKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoktorSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDoktorAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHastaneEkle
            // 
            this.gbHastaneEkle.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbHastaneEkle.Controls.Add(this.lstvHastaneler);
            this.gbHastaneEkle.Controls.Add(this.radButton1);
            this.gbHastaneEkle.Controls.Add(this.btnRandevuSil);
            this.gbHastaneEkle.Controls.Add(this.lblHastaneAdi);
            this.gbHastaneEkle.Controls.Add(this.txbHastaneAdi);
            this.gbHastaneEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbHastaneEkle.HeaderText = "Hastane Ekle";
            this.gbHastaneEkle.Location = new System.Drawing.Point(0, 3);
            this.gbHastaneEkle.Name = "gbHastaneEkle";
            this.gbHastaneEkle.Size = new System.Drawing.Size(247, 487);
            this.gbHastaneEkle.TabIndex = 2;
            this.gbHastaneEkle.Text = "Hastane Ekle";
            // 
            // lstvHastaneler
            // 
            this.lstvHastaneler.AllowEdit = false;
            this.lstvHastaneler.AllowRemove = false;
            this.lstvHastaneler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstvHastaneler.Location = new System.Drawing.Point(2, 155);
            this.lstvHastaneler.Name = "lstvHastaneler";
            this.lstvHastaneler.Size = new System.Drawing.Size(243, 330);
            this.lstvHastaneler.TabIndex = 8;
            this.lstvHastaneler.Text = "radListView1";
            this.lstvHastaneler.SelectedIndexChanged += new System.EventHandler(this.lstvHastaneler_SelectedIndexChanged);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radButton1.Location = new System.Drawing.Point(109, 116);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(106, 33);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "Kaydet";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuSil.Location = new System.Drawing.Point(12, 116);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(80, 33);
            this.btnRandevuSil.TabIndex = 1;
            this.btnRandevuSil.Text = "Sil";
            // 
            // lblHastaneAdi
            // 
            this.lblHastaneAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHastaneAdi.Location = new System.Drawing.Point(12, 42);
            this.lblHastaneAdi.Name = "lblHastaneAdi";
            this.lblHastaneAdi.Size = new System.Drawing.Size(119, 21);
            this.lblHastaneAdi.TabIndex = 1;
            this.lblHastaneAdi.Text = "Hastane Adı Girin :";
            // 
            // txbHastaneAdi
            // 
            this.txbHastaneAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbHastaneAdi.Location = new System.Drawing.Point(12, 69);
            this.txbHastaneAdi.Name = "txbHastaneAdi";
            this.txbHastaneAdi.Size = new System.Drawing.Size(203, 23);
            this.txbHastaneAdi.TabIndex = 0;
            // 
            // gbBransEkle
            // 
            this.gbBransEkle.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbBransEkle.Controls.Add(this.lstvBranslar);
            this.gbBransEkle.Controls.Add(this.btnBransKaydet);
            this.gbBransEkle.Controls.Add(this.btnBransSil);
            this.gbBransEkle.Controls.Add(this.radLabel1);
            this.gbBransEkle.Controls.Add(this.txbBransAdi);
            this.gbBransEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbBransEkle.HeaderText = "Branş Ekle";
            this.gbBransEkle.Location = new System.Drawing.Point(253, 3);
            this.gbBransEkle.Name = "gbBransEkle";
            this.gbBransEkle.Size = new System.Drawing.Size(247, 487);
            this.gbBransEkle.TabIndex = 2;
            this.gbBransEkle.Text = "Branş Ekle";
            // 
            // lstvBranslar
            // 
            this.lstvBranslar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstvBranslar.Location = new System.Drawing.Point(2, 155);
            this.lstvBranslar.Name = "lstvBranslar";
            this.lstvBranslar.Size = new System.Drawing.Size(243, 330);
            this.lstvBranslar.TabIndex = 7;
            this.lstvBranslar.Text = "radListView1";
            // 
            // btnBransKaydet
            // 
            this.btnBransKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBransKaydet.Location = new System.Drawing.Point(109, 116);
            this.btnBransKaydet.Name = "btnBransKaydet";
            this.btnBransKaydet.Size = new System.Drawing.Size(106, 33);
            this.btnBransKaydet.TabIndex = 6;
            this.btnBransKaydet.Text = "Kaydet";
            this.btnBransKaydet.Click += new System.EventHandler(this.btnBransKaydet_Click);
            // 
            // btnBransSil
            // 
            this.btnBransSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBransSil.Location = new System.Drawing.Point(12, 116);
            this.btnBransSil.Name = "btnBransSil";
            this.btnBransSil.Size = new System.Drawing.Size(80, 33);
            this.btnBransSil.TabIndex = 5;
            this.btnBransSil.Text = "Sil";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(12, 42);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(103, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Branş Adı Girin :";
            // 
            // txbBransAdi
            // 
            this.txbBransAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbBransAdi.Location = new System.Drawing.Point(12, 69);
            this.txbBransAdi.Name = "txbBransAdi";
            this.txbBransAdi.Size = new System.Drawing.Size(203, 23);
            this.txbBransAdi.TabIndex = 4;
            // 
            // gbDoktorEkle
            // 
            this.gbDoktorEkle.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbDoktorEkle.Controls.Add(this.lstvDoktorlar);
            this.gbDoktorEkle.Controls.Add(this.btnDoktorKaydet);
            this.gbDoktorEkle.Controls.Add(this.btnDoktorSil);
            this.gbDoktorEkle.Controls.Add(this.radLabel2);
            this.gbDoktorEkle.Controls.Add(this.txbDoktorAdi);
            this.gbDoktorEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDoktorEkle.HeaderText = "Doktor Ekle";
            this.gbDoktorEkle.Location = new System.Drawing.Point(506, 3);
            this.gbDoktorEkle.Name = "gbDoktorEkle";
            this.gbDoktorEkle.Size = new System.Drawing.Size(247, 487);
            this.gbDoktorEkle.TabIndex = 2;
            this.gbDoktorEkle.Text = "Doktor Ekle";
            // 
            // lstvDoktorlar
            // 
            this.lstvDoktorlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstvDoktorlar.Location = new System.Drawing.Point(2, 155);
            this.lstvDoktorlar.Name = "lstvDoktorlar";
            this.lstvDoktorlar.Size = new System.Drawing.Size(243, 330);
            this.lstvDoktorlar.TabIndex = 11;
            this.lstvDoktorlar.Text = "radListView1";
            // 
            // btnDoktorKaydet
            // 
            this.btnDoktorKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoktorKaydet.Location = new System.Drawing.Point(109, 116);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(106, 33);
            this.btnDoktorKaydet.TabIndex = 10;
            this.btnDoktorKaydet.Text = "Kaydet";
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoktorSil.Location = new System.Drawing.Point(12, 116);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(80, 33);
            this.btnDoktorSil.TabIndex = 9;
            this.btnDoktorSil.Text = "Sil";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(12, 42);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(112, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Doktor Adı Girin :";
            // 
            // txbDoktorAdi
            // 
            this.txbDoktorAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbDoktorAdi.Location = new System.Drawing.Point(12, 69);
            this.txbDoktorAdi.Name = "txbDoktorAdi";
            this.txbDoktorAdi.Size = new System.Drawing.Size(203, 23);
            this.txbDoktorAdi.TabIndex = 8;
            // 
            // HastaneEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 493);
            this.Controls.Add(this.gbDoktorEkle);
            this.Controls.Add(this.gbBransEkle);
            this.Controls.Add(this.gbHastaneEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaneEkleForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Hastane Ekle";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HastaneEkleForm_FormClosing);
            this.Load += new System.EventHandler(this.HastaneEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbHastaneEkle)).EndInit();
            this.gbHastaneEkle.ResumeLayout(false);
            this.gbHastaneEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvHastaneler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandevuSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHastaneAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbHastaneAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbBransEkle)).EndInit();
            this.gbBransEkle.ResumeLayout(false);
            this.gbBransEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvBranslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBransKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBransSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbBransAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDoktorEkle)).EndInit();
            this.gbDoktorEkle.ResumeLayout(false);
            this.gbDoktorEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstvDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoktorKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDoktorSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbDoktorAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbHastaneEkle;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton btnRandevuSil;
        private Telerik.WinControls.UI.RadLabel lblHastaneAdi;
        private Telerik.WinControls.UI.RadTextBox txbHastaneAdi;
        private Telerik.WinControls.UI.RadGroupBox gbBransEkle;
        private Telerik.WinControls.UI.RadListView lstvBranslar;
        private Telerik.WinControls.UI.RadButton btnBransKaydet;
        private Telerik.WinControls.UI.RadButton btnBransSil;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txbBransAdi;
        private Telerik.WinControls.UI.RadGroupBox gbDoktorEkle;
        private Telerik.WinControls.UI.RadListView lstvDoktorlar;
        private Telerik.WinControls.UI.RadButton btnDoktorKaydet;
        private Telerik.WinControls.UI.RadButton btnDoktorSil;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txbDoktorAdi;
        private Telerik.WinControls.UI.RadListView lstvHastaneler;
    }
}
