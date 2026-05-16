namespace Kutuphaneoto
{
    partial class FrmIadeAl
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
            grpOgrenciSec = new GroupBox();
            listBoxOgrenciler = new ListBox();
            txtOgrenciAra = new TextBox();
            btnGeri = new Button();
            grpOgrenciBilgi = new GroupBox();
            listBoxOgrenciKitaplar = new ListBox();
            txtSecilenAdSoyad = new TextBox();
            txtSecilenOgrNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpKitapBilgi = new GroupBox();
            txtKategori = new TextBox();
            txtISBN = new TextBox();
            txtYazar = new TextBox();
            txtKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            buttonIadeAl = new Button();
            grpOgrenciSec.SuspendLayout();
            grpOgrenciBilgi.SuspendLayout();
            grpKitapBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // grpOgrenciSec
            // 
            grpOgrenciSec.BackColor = Color.CornflowerBlue;
            grpOgrenciSec.Controls.Add(listBoxOgrenciler);
            grpOgrenciSec.Controls.Add(txtOgrenciAra);
            grpOgrenciSec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpOgrenciSec.Location = new Point(12, 55);
            grpOgrenciSec.Name = "grpOgrenciSec";
            grpOgrenciSec.Size = new Size(563, 293);
            grpOgrenciSec.TabIndex = 3;
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
            // btnGeri
            // 
            btnGeri.BackColor = Color.CornflowerBlue;
            btnGeri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGeri.Location = new Point(1, 3);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(55, 46);
            btnGeri.TabIndex = 4;
            btnGeri.Text = "<";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
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
            grpOgrenciBilgi.Location = new Point(12, 360);
            grpOgrenciBilgi.Name = "grpOgrenciBilgi";
            grpOgrenciBilgi.Size = new Size(563, 341);
            grpOgrenciBilgi.TabIndex = 5;
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
            listBoxOgrenciKitaplar.SelectedIndexChanged += listBoxOgrenciKitaplar_SelectedIndexChanged;
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
            // grpKitapBilgi
            // 
            grpKitapBilgi.BackColor = Color.CornflowerBlue;
            grpKitapBilgi.Controls.Add(txtKategori);
            grpKitapBilgi.Controls.Add(txtISBN);
            grpKitapBilgi.Controls.Add(txtYazar);
            grpKitapBilgi.Controls.Add(txtKitapAdi);
            grpKitapBilgi.Controls.Add(label7);
            grpKitapBilgi.Controls.Add(label6);
            grpKitapBilgi.Controls.Add(label5);
            grpKitapBilgi.Controls.Add(label4);
            grpKitapBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpKitapBilgi.Location = new Point(613, 92);
            grpKitapBilgi.Name = "grpKitapBilgi";
            grpKitapBilgi.Size = new Size(586, 242);
            grpKitapBilgi.TabIndex = 6;
            grpKitapBilgi.TabStop = false;
            grpKitapBilgi.Text = "Kitap Bilgisi";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(136, 176);
            txtKategori.Name = "txtKategori";
            txtKategori.ReadOnly = true;
            txtKategori.Size = new Size(382, 39);
            txtKategori.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(136, 128);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(382, 39);
            txtISBN.TabIndex = 6;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(136, 83);
            txtYazar.Name = "txtYazar";
            txtYazar.ReadOnly = true;
            txtYazar.Size = new Size(382, 39);
            txtYazar.TabIndex = 5;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(136, 38);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.ReadOnly = true;
            txtKitapAdi.Size = new Size(382, 39);
            txtKitapAdi.TabIndex = 4;
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
            // buttonIadeAl
            // 
            buttonIadeAl.BackColor = Color.Crimson;
            buttonIadeAl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonIadeAl.Location = new Point(820, 370);
            buttonIadeAl.Name = "buttonIadeAl";
            buttonIadeAl.Size = new Size(194, 60);
            buttonIadeAl.TabIndex = 7;
            buttonIadeAl.Text = "İade Al";
            buttonIadeAl.UseVisualStyleBackColor = false;
            buttonIadeAl.Click += buttonIadeAl_Click;
            // 
            // FrmIadeAl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1211, 713);
            Controls.Add(buttonIadeAl);
            Controls.Add(grpKitapBilgi);
            Controls.Add(grpOgrenciBilgi);
            Controls.Add(btnGeri);
            Controls.Add(grpOgrenciSec);
            Name = "FrmIadeAl";
            Text = "FrmIadeAl";
            Load += FrmIadeAl_Load;
            grpOgrenciSec.ResumeLayout(false);
            grpOgrenciSec.PerformLayout();
            grpOgrenciBilgi.ResumeLayout(false);
            grpOgrenciBilgi.PerformLayout();
            grpKitapBilgi.ResumeLayout(false);
            grpKitapBilgi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOgrenciSec;
        private ListBox listBoxOgrenciler;
        private TextBox txtOgrenciAra;
        private Button btnGeri;
        private GroupBox grpOgrenciBilgi;
        private ListBox listBoxOgrenciKitaplar;
        private TextBox txtSecilenAdSoyad;
        private TextBox txtSecilenOgrNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpKitapBilgi;
        private TextBox txtKategori;
        private TextBox txtISBN;
        private TextBox txtYazar;
        private TextBox txtKitapAdi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button buttonIadeAl;
    }
}