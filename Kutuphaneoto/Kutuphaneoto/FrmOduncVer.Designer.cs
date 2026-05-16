namespace Kutuphaneoto
{
    partial class FrmOduncVer
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
            btnGeriodver = new Button();
            grpOgrenciSec = new GroupBox();
            listBoxOgrenciler = new ListBox();
            txtOgrenciAra = new TextBox();
            grpOgrenciBilgi = new GroupBox();
            listBoxOgrenciKitaplar = new ListBox();
            txtSecilenAdSoyad = new TextBox();
            txtSecilenOgrNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpKitapSec = new GroupBox();
            listBoxKitaplar = new ListBox();
            txtKitapAra = new TextBox();
            grpKitapBilgi = new GroupBox();
            txtSecilenKategori = new TextBox();
            txtSecilenISBN = new TextBox();
            txtSecilenYazar = new TextBox();
            txtSecilenKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnOduncVer = new Button();
            btnSirayaEkle = new Button();
            grpOgrenciSec.SuspendLayout();
            grpOgrenciBilgi.SuspendLayout();
            grpKitapSec.SuspendLayout();
            grpKitapBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // btnGeriodver
            // 
            btnGeriodver.BackColor = Color.CornflowerBlue;
            btnGeriodver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGeriodver.Location = new Point(6, 10);
            btnGeriodver.Name = "btnGeriodver";
            btnGeriodver.Size = new Size(49, 39);
            btnGeriodver.TabIndex = 0;
            btnGeriodver.Text = "<";
            btnGeriodver.UseVisualStyleBackColor = false;
            btnGeriodver.Click += btnGeriodver_Click;
            // 
            // grpOgrenciSec
            // 
            grpOgrenciSec.BackColor = Color.CornflowerBlue;
            grpOgrenciSec.Controls.Add(listBoxOgrenciler);
            grpOgrenciSec.Controls.Add(txtOgrenciAra);
            grpOgrenciSec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpOgrenciSec.Location = new Point(12, 55);
            grpOgrenciSec.Name = "grpOgrenciSec";
            grpOgrenciSec.Size = new Size(563, 325);
            grpOgrenciSec.TabIndex = 2;
            grpOgrenciSec.TabStop = false;
            grpOgrenciSec.Text = "Öğrenci Seçiniz:";
            // 
            // listBoxOgrenciler
            // 
            listBoxOgrenciler.FormattingEnabled = true;
            listBoxOgrenciler.ItemHeight = 32;
            listBoxOgrenciler.Location = new Point(44, 83);
            listBoxOgrenciler.Name = "listBoxOgrenciler";
            listBoxOgrenciler.Size = new Size(494, 196);
            listBoxOgrenciler.TabIndex = 1;
            listBoxOgrenciler.SelectedIndexChanged += listBoxOgrenciler_SelectedIndexChanged;
            // 
            // txtOgrenciAra
            // 
            txtOgrenciAra.Location = new Point(44, 38);
            txtOgrenciAra.Name = "txtOgrenciAra";
            txtOgrenciAra.Size = new Size(494, 39);
            txtOgrenciAra.TabIndex = 0;
            txtOgrenciAra.TextChanged += txtOgrenciAra_TextChanged;
            // 
            // grpOgrenciBilgi
            // 
            grpOgrenciBilgi.BackColor = Color.CornflowerBlue;
            grpOgrenciBilgi.Controls.Add(listBoxOgrenciKitaplar);
            grpOgrenciBilgi.Controls.Add(txtSecilenAdSoyad);
            grpOgrenciBilgi.Controls.Add(txtSecilenOgrNo);
            grpOgrenciBilgi.Controls.Add(label3);
            grpOgrenciBilgi.Controls.Add(label2);
            grpOgrenciBilgi.Controls.Add(label1);
            grpOgrenciBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpOgrenciBilgi.Location = new Point(629, 55);
            grpOgrenciBilgi.Name = "grpOgrenciBilgi";
            grpOgrenciBilgi.Size = new Size(586, 341);
            grpOgrenciBilgi.TabIndex = 3;
            grpOgrenciBilgi.TabStop = false;
            grpOgrenciBilgi.Text = "Öğrenci Bilgisi";
            // 
            // listBoxOgrenciKitaplar
            // 
            listBoxOgrenciKitaplar.FormattingEnabled = true;
            listBoxOgrenciKitaplar.ItemHeight = 32;
            listBoxOgrenciKitaplar.Location = new Point(29, 161);
            listBoxOgrenciKitaplar.Name = "listBoxOgrenciKitaplar";
            listBoxOgrenciKitaplar.Size = new Size(489, 164);
            listBoxOgrenciKitaplar.TabIndex = 5;
            // 
            // txtSecilenAdSoyad
            // 
            txtSecilenAdSoyad.Location = new Point(157, 85);
            txtSecilenAdSoyad.Name = "txtSecilenAdSoyad";
            txtSecilenAdSoyad.ReadOnly = true;
            txtSecilenAdSoyad.Size = new Size(361, 39);
            txtSecilenAdSoyad.TabIndex = 4;
            // 
            // txtSecilenOgrNo
            // 
            txtSecilenOgrNo.Location = new Point(157, 34);
            txtSecilenOgrNo.Name = "txtSecilenOgrNo";
            txtSecilenOgrNo.ReadOnly = true;
            txtSecilenOgrNo.Size = new Size(361, 39);
            txtSecilenOgrNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 126);
            label3.Name = "label3";
            label3.Size = new Size(219, 32);
            label3.TabIndex = 2;
            label3.Text = "Üzerindeki Kitaplar;";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 83);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci No:";
            // 
            // grpKitapSec
            // 
            grpKitapSec.BackColor = Color.CornflowerBlue;
            grpKitapSec.Controls.Add(listBoxKitaplar);
            grpKitapSec.Controls.Add(txtKitapAra);
            grpKitapSec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKitapSec.Location = new Point(12, 386);
            grpKitapSec.Name = "grpKitapSec";
            grpKitapSec.Size = new Size(563, 300);
            grpKitapSec.TabIndex = 4;
            grpKitapSec.TabStop = false;
            grpKitapSec.Text = "Kitap Seçiniz:";
            // 
            // listBoxKitaplar
            // 
            listBoxKitaplar.FormattingEnabled = true;
            listBoxKitaplar.ItemHeight = 32;
            listBoxKitaplar.Location = new Point(44, 83);
            listBoxKitaplar.Name = "listBoxKitaplar";
            listBoxKitaplar.Size = new Size(494, 196);
            listBoxKitaplar.TabIndex = 1;
            listBoxKitaplar.SelectedIndexChanged += listBoxKitaplar_SelectedIndexChanged;
            // 
            // txtKitapAra
            // 
            txtKitapAra.Location = new Point(44, 38);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(494, 39);
            txtKitapAra.TabIndex = 0;
            txtKitapAra.TextChanged += txtKitapAra_TextChanged;
            // 
            // grpKitapBilgi
            // 
            grpKitapBilgi.BackColor = Color.CornflowerBlue;
            grpKitapBilgi.Controls.Add(txtSecilenKategori);
            grpKitapBilgi.Controls.Add(txtSecilenISBN);
            grpKitapBilgi.Controls.Add(txtSecilenYazar);
            grpKitapBilgi.Controls.Add(txtSecilenKitapAdi);
            grpKitapBilgi.Controls.Add(label7);
            grpKitapBilgi.Controls.Add(label6);
            grpKitapBilgi.Controls.Add(label5);
            grpKitapBilgi.Controls.Add(label4);
            grpKitapBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKitapBilgi.Location = new Point(629, 402);
            grpKitapBilgi.Name = "grpKitapBilgi";
            grpKitapBilgi.Size = new Size(586, 235);
            grpKitapBilgi.TabIndex = 5;
            grpKitapBilgi.TabStop = false;
            grpKitapBilgi.Text = "Kitap Bilgisi";
            // 
            // txtSecilenKategori
            // 
            txtSecilenKategori.Location = new Point(136, 176);
            txtSecilenKategori.Name = "txtSecilenKategori";
            txtSecilenKategori.ReadOnly = true;
            txtSecilenKategori.Size = new Size(382, 39);
            txtSecilenKategori.TabIndex = 7;
            // 
            // txtSecilenISBN
            // 
            txtSecilenISBN.Location = new Point(136, 128);
            txtSecilenISBN.Name = "txtSecilenISBN";
            txtSecilenISBN.ReadOnly = true;
            txtSecilenISBN.Size = new Size(382, 39);
            txtSecilenISBN.TabIndex = 6;
            // 
            // txtSecilenYazar
            // 
            txtSecilenYazar.Location = new Point(136, 83);
            txtSecilenYazar.Name = "txtSecilenYazar";
            txtSecilenYazar.ReadOnly = true;
            txtSecilenYazar.Size = new Size(382, 39);
            txtSecilenYazar.TabIndex = 5;
            // 
            // txtSecilenKitapAdi
            // 
            txtSecilenKitapAdi.Location = new Point(136, 38);
            txtSecilenKitapAdi.Name = "txtSecilenKitapAdi";
            txtSecilenKitapAdi.ReadOnly = true;
            txtSecilenKitapAdi.Size = new Size(382, 39);
            txtSecilenKitapAdi.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 176);
            label7.Name = "label7";
            label7.Size = new Size(108, 32);
            label7.TabIndex = 3;
            label7.Text = "Kategori:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 128);
            label6.Name = "label6";
            label6.Size = new Size(70, 32);
            label6.TabIndex = 2;
            label6.Text = "İSBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 86);
            label5.Name = "label5";
            label5.Size = new Size(73, 32);
            label5.TabIndex = 1;
            label5.Text = "Yazar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 41);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 0;
            label4.Text = "Kitap Adı:";
            // 
            // btnOduncVer
            // 
            btnOduncVer.BackColor = Color.CornflowerBlue;
            btnOduncVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOduncVer.Location = new Point(689, 656);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(196, 60);
            btnOduncVer.TabIndex = 6;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnSirayaEkle
            // 
            btnSirayaEkle.BackColor = Color.Cyan;
            btnSirayaEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSirayaEkle.Location = new Point(950, 656);
            btnSirayaEkle.Name = "btnSirayaEkle";
            btnSirayaEkle.Size = new Size(197, 60);
            btnSirayaEkle.TabIndex = 7;
            btnSirayaEkle.Text = "Sıraya Ekle";
            btnSirayaEkle.UseVisualStyleBackColor = false;
            btnSirayaEkle.Click += btnSirayaEkle_Click;
            // 
            // FrmOduncVer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1257, 748);
            Controls.Add(btnSirayaEkle);
            Controls.Add(btnOduncVer);
            Controls.Add(grpKitapBilgi);
            Controls.Add(grpKitapSec);
            Controls.Add(grpOgrenciBilgi);
            Controls.Add(grpOgrenciSec);
            Controls.Add(btnGeriodver);
            Name = "FrmOduncVer";
            Text = "FrmOduncVer";
            Load += FrmOduncVer_Load;
            grpOgrenciSec.ResumeLayout(false);
            grpOgrenciSec.PerformLayout();
            grpOgrenciBilgi.ResumeLayout(false);
            grpOgrenciBilgi.PerformLayout();
            grpKitapSec.ResumeLayout(false);
            grpKitapSec.PerformLayout();
            grpKitapBilgi.ResumeLayout(false);
            grpKitapBilgi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGeriodver;
        private GroupBox grpOgrenciSec;
        private ListBox listBoxOgrenciler;
        private TextBox txtOgrenciAra;
        private GroupBox grpOgrenciBilgi;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSecilenAdSoyad;
        private TextBox txtSecilenOgrNo;
        private ListBox listBoxOgrenciKitaplar;
        private GroupBox grpKitapSec;
        private ListBox listBoxKitaplar;
        private TextBox txtKitapAra;
        private GroupBox grpKitapBilgi;
        private TextBox txtSecilenKategori;
        private TextBox txtSecilenISBN;
        private TextBox txtSecilenYazar;
        private TextBox txtSecilenKitapAdi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnOduncVer;
        private Button btnSirayaEkle;
    }
}