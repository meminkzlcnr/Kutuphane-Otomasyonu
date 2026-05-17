namespace Kutuphaneoto
{
    partial class FrmGecikmisList
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
            this.lblBaslik        = new System.Windows.Forms.Label();
            this.lblToplamSayac   = new System.Windows.Forms.Label();
            this.lblAciklama      = new System.Windows.Forms.Label();
            this.listViewGecikmiş = new System.Windows.Forms.ListView();
            this.colOgrNo         = new System.Windows.Forms.ColumnHeader();
            this.colAdSoyad       = new System.Windows.Forms.ColumnHeader();
            this.colKitap         = new System.Windows.Forms.ColumnHeader();
            this.colAlisTarihi    = new System.Windows.Forms.ColumnHeader();
            this.colSonIade       = new System.Windows.Forms.ColumnHeader();
            this.colGecikme       = new System.Windows.Forms.ColumnHeader();
            this.btnYenile        = new System.Windows.Forms.Button();
            this.btnGeri          = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.AutoSize  = true;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBaslik.Location  = new System.Drawing.Point(20, 15);
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Gecikmiş İadeler";

            // lblToplamSayac
            this.lblToplamSayac.AutoSize  = true;
            this.lblToplamSayac.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamSayac.ForeColor = System.Drawing.Color.DarkRed;
            this.lblToplamSayac.Location  = new System.Drawing.Point(20, 50);
            this.lblToplamSayac.Name      = "lblToplamSayac";
            this.lblToplamSayac.Text      = "Gecikmiş İade: 0";

            // lblAciklama
            this.lblAciklama.AutoSize  = true;
            this.lblAciklama.ForeColor = System.Drawing.Color.Gray;
            this.lblAciklama.Location  = new System.Drawing.Point(200, 53);
            this.lblAciklama.Name      = "lblAciklama";
            this.lblAciklama.Text      = "Sarı = 1-6 gün gecikme   |   Kırmızı = 7+ gün gecikme";

            // listViewGecikmiş
            this.listViewGecikmiş.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colOgrNo,
                this.colAdSoyad,
                this.colKitap,
                this.colAlisTarihi,
                this.colSonIade,
                this.colGecikme
            });
            this.listViewGecikmiş.FullRowSelect = true;
            this.listViewGecikmiş.GridLines     = true;
            this.listViewGecikmiş.Location      = new System.Drawing.Point(20, 80);
            this.listViewGecikmiş.Name          = "listViewGecikmiş";
            this.listViewGecikmiş.Size          = new System.Drawing.Size(760, 380);
            this.listViewGecikmiş.TabIndex      = 0;
            this.listViewGecikmiş.UseCompatibleStateImageBehavior = false;
            this.listViewGecikmiş.View          = System.Windows.Forms.View.Details;

            this.colOgrNo.Text       = "Öğrenci No";   this.colOgrNo.Width     = 100;
            this.colAdSoyad.Text     = "Ad Soyad";     this.colAdSoyad.Width   = 150;
            this.colKitap.Text       = "Kitap Adı";    this.colKitap.Width     = 200;
            this.colAlisTarihi.Text  = "Alış Tarihi";  this.colAlisTarihi.Width = 100;
            this.colSonIade.Text     = "Son İade";     this.colSonIade.Width   = 100;
            this.colGecikme.Text     = "Gecikme";      this.colGecikme.Width   = 90;

            // btnYenile
            this.btnYenile.Location = new System.Drawing.Point(20, 475);
            this.btnYenile.Name     = "btnYenile";
            this.btnYenile.Size     = new System.Drawing.Size(120, 35);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text     = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;

            // btnGeri
            this.btnGeri.Location = new System.Drawing.Point(660, 475);
            this.btnGeri.Name     = "btnGeri";
            this.btnGeri.Size     = new System.Drawing.Size(120, 35);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text     = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 530);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox         = false;
            this.Name                = "FrmGecikmisList";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Gecikmiş İadeler";

            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblToplamSayac);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.listViewGecikmiş);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnGeri);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label      lblBaslik;
        private System.Windows.Forms.Label      lblToplamSayac;
        private System.Windows.Forms.Label      lblAciklama;
        private System.Windows.Forms.ListView   listViewGecikmiş;
        private System.Windows.Forms.ColumnHeader colOgrNo;
        private System.Windows.Forms.ColumnHeader colAdSoyad;
        private System.Windows.Forms.ColumnHeader colKitap;
        private System.Windows.Forms.ColumnHeader colAlisTarihi;
        private System.Windows.Forms.ColumnHeader colSonIade;
        private System.Windows.Forms.ColumnHeader colGecikme;
        private System.Windows.Forms.Button     btnYenile;
        private System.Windows.Forms.Button     btnGeri;
    }
}