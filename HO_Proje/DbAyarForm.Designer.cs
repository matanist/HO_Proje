namespace HOProje
{
    partial class DbAyarForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtServer = new Telerik.WinControls.UI.RadTextBox();
            this.txtKullaniciAdi = new Telerik.WinControls.UI.RadTextBox();
            this.txtSifre = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(43, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(43, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Server :";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 59);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(73, 18);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Kullanıcı Adı :";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(52, 85);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(34, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Şifre :";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(92, 33);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(129, 20);
            this.txtServer.TabIndex = 0;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(92, 58);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(129, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(92, 83);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(129, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(13, 120);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(86, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Doğrula";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(135, 120);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(86, 24);
            this.radButton2.TabIndex = 4;
            this.radButton2.Text = "Kaydet";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // DbAyarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 160);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "DbAyarForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "DbAyarForm";
            this.ThemeName = "ControlDefault";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DbAyarForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtServer;
        private Telerik.WinControls.UI.RadTextBox txtKullaniciAdi;
        private Telerik.WinControls.UI.RadTextBox txtSifre;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}
