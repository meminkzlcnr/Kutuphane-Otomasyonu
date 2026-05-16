namespace Kutuphaneoto
{
    partial class FrmOgrenciYonetimi
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
            buttonGeriOgrenci = new Button();
            label1 = new Label();
            grpOgrenciEkle = new GroupBox();
            dtpDogumTarihi = new DateTimePicker();
            btnOgrenciEkle = new Button();
            txtSinif = new TextBox();
            txtFakulte = new TextBox();
            txtBolum = new TextBox();
            txtAdSoyad = new TextBox();
            txtOgrNo = new TextBox();
            labelSinif = new Label();
            labelFakulte = new Label();
            labelBolum = new Label();
            labelDogumTar = new Label();
            labelAdSoyad = new Label();
            labelOgrenciNo = new Label();
            grpOgreniListesi = new GroupBox();
            listBoxOgrenciler = new ListBox();
            label2 = new Label();
            txtOgrenciAra = new TextBox();
            grpOgrenciSil = new GroupBox();
            btnOgrenciSil = new Button();
            txtSecilenOgrenci = new TextBox();
            btnDetay = new Button();
            grpOgrenciEkle.SuspendLayout();
            grpOgreniListesi.SuspendLayout();
            grpOgrenciSil.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGeriOgrenci
            // 
            buttonGeriOgrenci.BackColor = Color.CornflowerBlue;
            buttonGeriOgrenci.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGeriOgrenci.Location = new Point(1, 3);
            buttonGeriOgrenci.Margin = new Padding(4);
            buttonGeriOgrenci.Name = "buttonGeriOgrenci";
            buttonGeriOgrenci.Size = new Size(75, 78);
            buttonGeriOgrenci.TabIndex = 0;
            buttonGeriOgrenci.Text = "<";
            buttonGeriOgrenci.UseVisualStyleBackColor = false;
            buttonGeriOgrenci.Click += buttonGeriOgrenci_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(502, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 45);
            label1.TabIndex = 2;
            label1.Text = "Öğrenci Yönetimi";
            // 
            // grpOgrenciEkle
            // 
            grpOgrenciEkle.BackColor = Color.CornflowerBlue;
            grpOgrenciEkle.Controls.Add(dtpDogumTarihi);
            grpOgrenciEkle.Controls.Add(btnOgrenciEkle);
            grpOgrenciEkle.Controls.Add(txtSinif);
            grpOgrenciEkle.Controls.Add(txtFakulte);
            grpOgrenciEkle.Controls.Add(txtBolum);
            grpOgrenciEkle.Controls.Add(txtAdSoyad);
            grpOgrenciEkle.Controls.Add(txtOgrNo);
            grpOgrenciEkle.Controls.Add(labelSinif);
            grpOgrenciEkle.Controls.Add(labelFakulte);
            grpOgrenciEkle.Controls.Add(labelBolum);
            grpOgrenciEkle.Controls.Add(labelDogumTar);
            grpOgrenciEkle.Controls.Add(labelAdSoyad);
            grpOgrenciEkle.Controls.Add(labelOgrenciNo);
            grpOgrenciEkle.Location = new Point(26, 88);
            grpOgrenciEkle.Name = "grpOgrenciEkle";
            grpOgrenciEkle.Size = new Size(585, 608);
            grpOgrenciEkle.TabIndex = 6;
            grpOgrenciEkle.TabStop = false;
            grpOgrenciEkle.Text = "                          Öğrenci Ekleme";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(158, 187);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(414, 39);
            dtpDogumTarihi.TabIndex = 13;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.BackColor = Color.FromArgb(128, 255, 128);
            btnOgrenciEkle.Location = new Point(211, 469);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(300, 65);
            btnOgrenciEkle.TabIndex = 12;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = false;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(158, 399);
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(414, 39);
            txtSinif.TabIndex = 11;
            // 
            // txtFakulte
            // 
            txtFakulte.Location = new Point(158, 329);
            txtFakulte.Name = "txtFakulte";
            txtFakulte.Size = new Size(414, 39);
            txtFakulte.TabIndex = 10;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(158, 259);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(414, 39);
            txtBolum.TabIndex = 9;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(158, 121);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(414, 39);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtOgrNo
            // 
            txtOgrNo.Location = new Point(158, 58);
            txtOgrNo.Name = "txtOgrNo";
            txtOgrNo.Size = new Size(414, 39);
            txtOgrNo.TabIndex = 6;
            // 
            // labelSinif
            // 
            labelSinif.AutoSize = true;
            labelSinif.Location = new Point(86, 402);
            labelSinif.Name = "labelSinif";
            labelSinif.Size = new Size(66, 32);
            labelSinif.TabIndex = 5;
            labelSinif.Text = "Sınıf:";
            // 
            // labelFakulte
            // 
            labelFakulte.AutoSize = true;
            labelFakulte.Location = new Point(57, 332);
            labelFakulte.Name = "labelFakulte";
            labelFakulte.Size = new Size(95, 32);
            labelFakulte.TabIndex = 4;
            labelFakulte.Text = "Fakülte:";
            // 
            // labelBolum
            // 
            labelBolum.AutoSize = true;
            labelBolum.Location = new Point(64, 259);
            labelBolum.Name = "labelBolum";
            labelBolum.Size = new Size(88, 32);
            labelBolum.TabIndex = 3;
            labelBolum.Text = "Bölüm:";
            // 
            // labelDogumTar
            // 
            labelDogumTar.AutoSize = true;
            labelDogumTar.Location = new Point(0, 192);
            labelDogumTar.Name = "labelDogumTar";
            labelDogumTar.Size = new Size(162, 32);
            labelDogumTar.TabIndex = 2;
            labelDogumTar.Text = "Doğum Tarihi:";
            // 
            // labelAdSoyad
            // 
            labelAdSoyad.AutoSize = true;
            labelAdSoyad.Location = new Point(32, 121);
            labelAdSoyad.Name = "labelAdSoyad";
            labelAdSoyad.Size = new Size(120, 32);
            labelAdSoyad.TabIndex = 1;
            labelAdSoyad.Text = "Ad Soyad:";
            // 
            // labelOgrenciNo
            // 
            labelOgrenciNo.AutoSize = true;
            labelOgrenciNo.Location = new Point(10, 58);
            labelOgrenciNo.Name = "labelOgrenciNo";
            labelOgrenciNo.Size = new Size(142, 32);
            labelOgrenciNo.TabIndex = 0;
            labelOgrenciNo.Text = "Öğrenci No:";
            // 
            // grpOgreniListesi
            // 
            grpOgreniListesi.BackColor = Color.CornflowerBlue;
            grpOgreniListesi.Controls.Add(listBoxOgrenciler);
            grpOgreniListesi.Controls.Add(label2);
            grpOgreniListesi.Controls.Add(txtOgrenciAra);
            grpOgreniListesi.Location = new Point(630, 88);
            grpOgreniListesi.Name = "grpOgreniListesi";
            grpOgreniListesi.Size = new Size(631, 342);
            grpOgreniListesi.TabIndex = 7;
            grpOgreniListesi.TabStop = false;
            grpOgreniListesi.Text = "                      Öğrenci Listesi";
            // 
            // listBoxOgrenciler
            // 
            listBoxOgrenciler.FormattingEnabled = true;
            listBoxOgrenciler.ItemHeight = 32;
            listBoxOgrenciler.Location = new Point(157, 96);
            listBoxOgrenciler.Name = "listBoxOgrenciler";
            listBoxOgrenciler.Size = new Size(460, 228);
            listBoxOgrenciler.TabIndex = 2;
            listBoxOgrenciler.SelectedIndexChanged += listBoxOgrenciler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Ara:";
            // 
            // txtOgrenciAra
            // 
            txtOgrenciAra.Location = new Point(157, 51);
            txtOgrenciAra.Name = "txtOgrenciAra";
            txtOgrenciAra.Size = new Size(460, 39);
            txtOgrenciAra.TabIndex = 0;
            txtOgrenciAra.TextChanged += txtOgrenciAra_TextChanged;
            // 
            // grpOgrenciSil
            // 
            grpOgrenciSil.BackColor = Color.CornflowerBlue;
            grpOgrenciSil.Controls.Add(btnOgrenciSil);
            grpOgrenciSil.Controls.Add(txtSecilenOgrenci);
            grpOgrenciSil.Location = new Point(630, 436);
            grpOgrenciSil.Name = "grpOgrenciSil";
            grpOgrenciSil.Size = new Size(631, 186);
            grpOgrenciSil.TabIndex = 8;
            grpOgrenciSil.TabStop = false;
            grpOgrenciSil.Text = "Seçilen Öğrenci";
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.BackColor = Color.Crimson;
            btnOgrenciSil.Location = new Point(267, 103);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(249, 77);
            btnOgrenciSil.TabIndex = 1;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = false;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // txtSecilenOgrenci
            // 
            txtSecilenOgrenci.Location = new Point(157, 38);
            txtSecilenOgrenci.Multiline = true;
            txtSecilenOgrenci.Name = "txtSecilenOgrenci";
            txtSecilenOgrenci.ReadOnly = true;
            txtSecilenOgrenci.Size = new Size(460, 46);
            txtSecilenOgrenci.TabIndex = 0;
            // 
            // btnDetay
            // 
            btnDetay.BackColor = Color.DarkTurquoise;
            btnDetay.Location = new Point(787, 646);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(352, 59);
            btnDetay.TabIndex = 9;
            btnDetay.Text = "Öğrenci Detay ->";
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // FrmOgrenciYonetimi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1282, 723);
            Controls.Add(btnDetay);
            Controls.Add(grpOgrenciSil);
            Controls.Add(grpOgreniListesi);
            Controls.Add(grpOgrenciEkle);
            Controls.Add(label1);
            Controls.Add(buttonGeriOgrenci);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOgrenciYonetimi";
            Text = "Öğrenci Yönetimi";
            FormClosing += FrmOgrenciYonetimi_FormClosing;
            Load += FrmOgrenciYonetimi_Load;
            grpOgrenciEkle.ResumeLayout(false);
            grpOgrenciEkle.PerformLayout();
            grpOgreniListesi.ResumeLayout(false);
            grpOgreniListesi.PerformLayout();
            grpOgrenciSil.ResumeLayout(false);
            grpOgrenciSil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGeriOgrenci;
        private Label label1;
        private GroupBox grpOgrenciEkle;
        private TextBox txtOgrNo;
        private Label labelSinif;
        private Label labelFakulte;
        private Label labelBolum;
        private Label labelDogumTar;
        private Label labelAdSoyad;
        private Label labelOgrenciNo;
        private TextBox txtAdSoyad;
        private Button btnOgrenciEkle;
        private TextBox txtSinif;
        private TextBox txtFakulte;
        private TextBox txtBolum;
        private GroupBox grpOgreniListesi;
        private TextBox txtOgrenciAra;
        private Label label2;
        private ListBox listBoxOgrenciler;
        private GroupBox grpOgrenciSil;
        private Button btnOgrenciSil;
        private TextBox txtSecilenOgrenci;
        private Button btnDetay;
        private DateTimePicker dtpDogumTarihi;
    }
}