namespace Kutuphaneoto
{
    partial class FrmKullaniciYonetimi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Kontroller ────────────────────────────────────────────────
            this.lblBaslikEkle         = new System.Windows.Forms.Label();
            this.lblKullaniciAdi       = new System.Windows.Forms.Label();
            this.txtKullaniciAdi       = new System.Windows.Forms.TextBox();
            this.lblSifre              = new System.Windows.Forms.Label();
            this.txtSifre              = new System.Windows.Forms.TextBox();
            this.lblAdSoyad            = new System.Windows.Forms.Label();
            this.txtAdSoyad            = new System.Windows.Forms.TextBox();
            this.lblRol                = new System.Windows.Forms.Label();
            this.cmbRol                = new System.Windows.Forms.ComboBox();
            this.btnEkle               = new System.Windows.Forms.Button();
            this.btnGuncelle           = new System.Windows.Forms.Button();
            this.lblBaslikListe        = new System.Windows.Forms.Label();
            this.lblAra                = new System.Windows.Forms.Label();
            this.txtAra                = new System.Windows.Forms.TextBox();
            this.listBoxKullanicilar   = new System.Windows.Forms.ListBox();
            this.lblSecilenKullanici   = new System.Windows.Forms.Label();
            this.txtSecilenBilgi       = new System.Windows.Forms.TextBox();
            this.btnSil                = new System.Windows.Forms.Button();
            this.btnGeri               = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ── Sol Panel: Ekle / Güncelle ────────────────────────────────

            // lblBaslikEkle
            this.lblBaslikEkle.AutoSize  = true;
            this.lblBaslikEkle.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaslikEkle.Location  = new System.Drawing.Point(20, 15);
            this.lblBaslikEkle.Name      = "lblBaslikEkle";
            this.lblBaslikEkle.Text      = "Kullanıcı Ekle / Güncelle";

            // lblKullaniciAdi
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 55);
            this.lblKullaniciAdi.Name     = "lblKullaniciAdi";
            this.lblKullaniciAdi.Text     = "Kullanıcı Adı:";

            // txtKullaniciAdi
            this.txtKullaniciAdi.Location = new System.Drawing.Point(20, 73);
            this.txtKullaniciAdi.Name     = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size     = new System.Drawing.Size(210, 23);
            this.txtKullaniciAdi.TabIndex = 0;

            // lblSifre
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(20, 110);
            this.lblSifre.Name     = "lblSifre";
            this.lblSifre.Text     = "Şifre:";

            // txtSifre
            this.txtSifre.Location     = new System.Drawing.Point(20, 128);
            this.txtSifre.Name         = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size         = new System.Drawing.Size(210, 23);
            this.txtSifre.TabIndex     = 1;

            // lblAdSoyad
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(20, 165);
            this.lblAdSoyad.Name     = "lblAdSoyad";
            this.lblAdSoyad.Text     = "Ad Soyad:";

            // txtAdSoyad
            this.txtAdSoyad.Location = new System.Drawing.Point(20, 183);
            this.txtAdSoyad.Name     = "txtAdSoyad";
            this.txtAdSoyad.Size     = new System.Drawing.Size(210, 23);
            this.txtAdSoyad.TabIndex = 2;

            // lblRol
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(20, 220);
            this.lblRol.Name     = "lblRol";
            this.lblRol.Text     = "Rol:";

            // cmbRol
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Items.AddRange(new object[] { "Yönetici", "Personel" });
            this.cmbRol.Location  = new System.Drawing.Point(20, 238);
            this.cmbRol.Name      = "cmbRol";
            this.cmbRol.Size      = new System.Drawing.Size(210, 23);
            this.cmbRol.TabIndex  = 3;

            // btnEkle
            this.btnEkle.Location  = new System.Drawing.Point(20, 285);
            this.btnEkle.Name      = "btnEkle";
            this.btnEkle.Size      = new System.Drawing.Size(100, 32);
            this.btnEkle.TabIndex  = 4;
            this.btnEkle.Text      = "Kullanıcı Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click    += new System.EventHandler(this.btnEkle_Click);

            // btnGuncelle
            this.btnGuncelle.Location  = new System.Drawing.Point(130, 285);
            this.btnGuncelle.Name      = "btnGuncelle";
            this.btnGuncelle.Size      = new System.Drawing.Size(100, 32);
            this.btnGuncelle.TabIndex  = 5;
            this.btnGuncelle.Text      = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click    += new System.EventHandler(this.btnGuncelle_Click);

            // ── Sağ Panel: Liste / Detay ──────────────────────────────────

            // lblBaslikListe
            this.lblBaslikListe.AutoSize = true;
            this.lblBaslikListe.Font     = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBaslikListe.Location = new System.Drawing.Point(265, 15);
            this.lblBaslikListe.Name     = "lblBaslikListe";
            this.lblBaslikListe.Text     = "Kullanıcı Listesi";

            // lblAra
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(265, 55);
            this.lblAra.Name     = "lblAra";
            this.lblAra.Text     = "Kullanıcı Ara:";

            // txtAra
            this.txtAra.Location     = new System.Drawing.Point(265, 73);
            this.txtAra.Name         = "txtAra";
            this.txtAra.Size         = new System.Drawing.Size(310, 23);
            this.txtAra.TabIndex     = 6;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);

            // listBoxKullanicilar
            this.listBoxKullanicilar.FormattingEnabled  = true;
            this.listBoxKullanicilar.ItemHeight         = 15;
            this.listBoxKullanicilar.Location           = new System.Drawing.Point(265, 110);
            this.listBoxKullanicilar.Name               = "listBoxKullanicilar";
            this.listBoxKullanicilar.Size               = new System.Drawing.Size(310, 130);
            this.listBoxKullanicilar.TabIndex           = 7;
            this.listBoxKullanicilar.SelectedIndexChanged += new System.EventHandler(this.listBoxKullanicilar_SelectedIndexChanged);

            // lblSecilenKullanici
            this.lblSecilenKullanici.AutoSize = true;
            this.lblSecilenKullanici.Location = new System.Drawing.Point(265, 255);
            this.lblSecilenKullanici.Name     = "lblSecilenKullanici";
            this.lblSecilenKullanici.Text     = "Seçilen Kullanıcı Bilgileri:";

            // txtSecilenBilgi
            this.txtSecilenBilgi.Location   = new System.Drawing.Point(265, 273);
            this.txtSecilenBilgi.Multiline  = true;
            this.txtSecilenBilgi.Name       = "txtSecilenBilgi";
            this.txtSecilenBilgi.ReadOnly   = true;
            this.txtSecilenBilgi.Size       = new System.Drawing.Size(310, 65);
            this.txtSecilenBilgi.TabIndex   = 8;
            this.txtSecilenBilgi.BackColor  = System.Drawing.SystemColors.Control;

            // btnSil
            this.btnSil.Location  = new System.Drawing.Point(265, 355);
            this.btnSil.Name      = "btnSil";
            this.btnSil.Size      = new System.Drawing.Size(100, 32);
            this.btnSil.TabIndex  = 9;
            this.btnSil.Text      = "Kullanıcı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click    += new System.EventHandler(this.btnSil_Click);

            // btnGeri
            this.btnGeri.Location  = new System.Drawing.Point(475, 355);
            this.btnGeri.Name      = "btnGeri";
            this.btnGeri.Size      = new System.Drawing.Size(100, 32);
            this.btnGeri.TabIndex  = 10;
            this.btnGeri.Text      = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click    += new System.EventHandler(this.btnGeri_Click);

            // ── Form Ayarları ─────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(610, 410);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.Name                = "FrmKullaniciYonetimi";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Kullanıcı Yönetimi";

            this.Controls.Add(this.lblBaslikEkle);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblBaslikListe);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.listBoxKullanicilar);
            this.Controls.Add(this.lblSecilenKullanici);
            this.Controls.Add(this.txtSecilenBilgi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGeri);

            this.Load         += new System.EventHandler(this.FrmKullaniciYonetimi_Load);
            this.FormClosing  += new System.Windows.Forms.FormClosingEventHandler(this.FrmKullaniciYonetimi_FormClosing);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Kontrol Tanımlamaları ─────────────────────────────────────────
        private System.Windows.Forms.Label    lblBaslikEkle;
        private System.Windows.Forms.Label    lblKullaniciAdi;
        private System.Windows.Forms.TextBox  txtKullaniciAdi;
        private System.Windows.Forms.Label    lblSifre;
        private System.Windows.Forms.TextBox  txtSifre;
        private System.Windows.Forms.Label    lblAdSoyad;
        private System.Windows.Forms.TextBox  txtAdSoyad;
        private System.Windows.Forms.Label    lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button   btnEkle;
        private System.Windows.Forms.Button   btnGuncelle;
        private System.Windows.Forms.Label    lblBaslikListe;
        private System.Windows.Forms.Label    lblAra;
        private System.Windows.Forms.TextBox  txtAra;
        private System.Windows.Forms.ListBox  listBoxKullanicilar;
        private System.Windows.Forms.Label    lblSecilenKullanici;
        private System.Windows.Forms.TextBox  txtSecilenBilgi;
        private System.Windows.Forms.Button   btnSil;
        private System.Windows.Forms.Button   btnGeri;
    }
}
