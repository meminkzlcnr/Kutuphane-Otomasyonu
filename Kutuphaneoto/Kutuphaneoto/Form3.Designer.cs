namespace Kutuphaneoto
{
    partial class FrmKitapYonetimi
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
            buttonGeriKitap = new Button();
            label1 = new Label();
            grpKitapEkle = new GroupBox();
            btnKitapEkle = new Button();
            txtKategori = new TextBox();
            txtISBN = new TextBox();
            txtYazar = new TextBox();
            txtKitapAdi = new TextBox();
            labelKategori = new Label();
            labelisbn = new Label();
            labelYazar = new Label();
            labelKitapAdi = new Label();
            grpKitapListesi = new GroupBox();
            listBoxKitaplar = new ListBox();
            txtKitapAra = new TextBox();
            labelAra = new Label();
            grpKitapSil = new GroupBox();
            btnKitapSil = new Button();
            txtSecilenKitap = new TextBox();
            grpKitapEkle.SuspendLayout();
            grpKitapListesi.SuspendLayout();
            grpKitapSil.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGeriKitap
            // 
            buttonGeriKitap.BackColor = Color.CornflowerBlue;
            buttonGeriKitap.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGeriKitap.Location = new Point(1, 1);
            buttonGeriKitap.Name = "buttonGeriKitap";
            buttonGeriKitap.Size = new Size(57, 56);
            buttonGeriKitap.TabIndex = 0;
            buttonGeriKitap.Text = "<";
            buttonGeriKitap.UseVisualStyleBackColor = false;
            buttonGeriKitap.Click += buttonGeriKitap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Cyan;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(454, 8);
            label1.Name = "label1";
            label1.Size = new Size(226, 45);
            label1.TabIndex = 1;
            label1.Text = "Kitap Yönetimi";
            // 
            // grpKitapEkle
            // 
            grpKitapEkle.BackColor = Color.CornflowerBlue;
            grpKitapEkle.Controls.Add(btnKitapEkle);
            grpKitapEkle.Controls.Add(txtKategori);
            grpKitapEkle.Controls.Add(txtISBN);
            grpKitapEkle.Controls.Add(txtYazar);
            grpKitapEkle.Controls.Add(txtKitapAdi);
            grpKitapEkle.Controls.Add(labelKategori);
            grpKitapEkle.Controls.Add(labelisbn);
            grpKitapEkle.Controls.Add(labelYazar);
            grpKitapEkle.Controls.Add(labelKitapAdi);
            grpKitapEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKitapEkle.Location = new Point(12, 90);
            grpKitapEkle.Name = "grpKitapEkle";
            grpKitapEkle.Size = new Size(517, 564);
            grpKitapEkle.TabIndex = 2;
            grpKitapEkle.TabStop = false;
            grpKitapEkle.Text = "                           Kitap Ekleme";
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.Chartreuse;
            btnKitapEkle.Location = new Point(194, 383);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(219, 64);
            btnKitapEkle.TabIndex = 8;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(121, 308);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(369, 39);
            txtKategori.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(121, 224);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(369, 39);
            txtISBN.TabIndex = 6;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(121, 142);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(369, 39);
            txtYazar.TabIndex = 5;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(121, 59);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(369, 39);
            txtKitapAdi.TabIndex = 4;
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(13, 308);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(108, 32);
            labelKategori.TabIndex = 3;
            labelKategori.Text = "Kategori:";
            // 
            // labelisbn
            // 
            labelisbn.AutoSize = true;
            labelisbn.Location = new Point(51, 227);
            labelisbn.Name = "labelisbn";
            labelisbn.Size = new Size(70, 32);
            labelisbn.TabIndex = 2;
            labelisbn.Text = "İSBN:";
            // 
            // labelYazar
            // 
            labelYazar.AutoSize = true;
            labelYazar.Location = new Point(48, 142);
            labelYazar.Name = "labelYazar";
            labelYazar.Size = new Size(73, 32);
            labelYazar.TabIndex = 1;
            labelYazar.Text = "Yazar:";
            // 
            // labelKitapAdi
            // 
            labelKitapAdi.AutoSize = true;
            labelKitapAdi.Location = new Point(6, 59);
            labelKitapAdi.Name = "labelKitapAdi";
            labelKitapAdi.Size = new Size(115, 32);
            labelKitapAdi.TabIndex = 0;
            labelKitapAdi.Text = "Kitap Adı:";
            // 
            // grpKitapListesi
            // 
            grpKitapListesi.BackColor = Color.CornflowerBlue;
            grpKitapListesi.Controls.Add(listBoxKitaplar);
            grpKitapListesi.Controls.Add(txtKitapAra);
            grpKitapListesi.Controls.Add(labelAra);
            grpKitapListesi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKitapListesi.Location = new Point(582, 90);
            grpKitapListesi.Name = "grpKitapListesi";
            grpKitapListesi.Size = new Size(589, 389);
            grpKitapListesi.TabIndex = 3;
            grpKitapListesi.TabStop = false;
            grpKitapListesi.Text = "                            Kitap Listesi";
            // 
            // listBoxKitaplar
            // 
            listBoxKitaplar.FormattingEnabled = true;
            listBoxKitaplar.ItemHeight = 32;
            listBoxKitaplar.Location = new Point(116, 99);
            listBoxKitaplar.Name = "listBoxKitaplar";
            listBoxKitaplar.Size = new Size(429, 260);
            listBoxKitaplar.TabIndex = 2;
            listBoxKitaplar.SelectedIndexChanged += listBoxKitaplar_SelectedIndexChanged_1;
            // 
            // txtKitapAra
            // 
            txtKitapAra.Location = new Point(116, 41);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(429, 39);
            txtKitapAra.TabIndex = 1;
            txtKitapAra.TextChanged += txtKitapAra_TextChanged_1;
            // 
            // labelAra
            // 
            labelAra.AutoSize = true;
            labelAra.Location = new Point(6, 41);
            labelAra.Name = "labelAra";
            labelAra.Size = new Size(115, 32);
            labelAra.TabIndex = 0;
            labelAra.Text = "Kitap Ara:";
            // 
            // grpKitapSil
            // 
            grpKitapSil.BackColor = Color.CornflowerBlue;
            grpKitapSil.Controls.Add(btnKitapSil);
            grpKitapSil.Controls.Add(txtSecilenKitap);
            grpKitapSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKitapSil.Location = new Point(582, 485);
            grpKitapSil.Name = "grpKitapSil";
            grpKitapSil.Size = new Size(589, 169);
            grpKitapSil.TabIndex = 4;
            grpKitapSil.TabStop = false;
            grpKitapSil.Text = "Seçilen Kitap";
            // 
            // btnKitapSil
            // 
            btnKitapSil.BackColor = Color.Crimson;
            btnKitapSil.Location = new Point(212, 90);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(228, 61);
            btnKitapSil.TabIndex = 1;
            btnKitapSil.Text = "Kitap Sil";
            btnKitapSil.UseVisualStyleBackColor = false;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // txtSecilenKitap
            // 
            txtSecilenKitap.Location = new Point(116, 38);
            txtSecilenKitap.Multiline = true;
            txtSecilenKitap.Name = "txtSecilenKitap";
            txtSecilenKitap.ReadOnly = true;
            txtSecilenKitap.Size = new Size(429, 46);
            txtSecilenKitap.TabIndex = 0;
            // 
            // FrmKitapYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1198, 698);
            Controls.Add(grpKitapSil);
            Controls.Add(grpKitapListesi);
            Controls.Add(grpKitapEkle);
            Controls.Add(label1);
            Controls.Add(buttonGeriKitap);
            Name = "FrmKitapYonetimi";
            Text = "Kitap Yönetimi";
            FormClosing += FrmKitapYonetimi_FormClosing;
            Load += FrmKitapYonetimi_Load;
            grpKitapEkle.ResumeLayout(false);
            grpKitapEkle.PerformLayout();
            grpKitapListesi.ResumeLayout(false);
            grpKitapListesi.PerformLayout();
            grpKitapSil.ResumeLayout(false);
            grpKitapSil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGeriKitap;
        private Label label1;
        private GroupBox grpKitapEkle;
        private TextBox txtKategori;
        private TextBox txtISBN;
        private TextBox txtYazar;
        private TextBox txtKitapAdi;
        private Label labelKategori;
        private Label labelisbn;
        private Label labelYazar;
        private Label labelKitapAdi;
        private Button btnKitapEkle;
        private GroupBox grpKitapListesi;
        private Label labelAra;
        private ListBox listBoxKitaplar;
        private TextBox txtKitapAra;
        private GroupBox grpKitapSil;
        private TextBox txtSecilenKitap;
        private Button btnKitapSil;
    }
}