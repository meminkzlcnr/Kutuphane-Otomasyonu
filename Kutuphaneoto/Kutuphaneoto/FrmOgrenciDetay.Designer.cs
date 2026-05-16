namespace Kutuphaneoto
{
    partial class FrmOgrenciDetay
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
            groupBoxOgrenciList = new GroupBox();
            listBoxOgrenciler = new ListBox();
            txtAra = new TextBox();
            labelOgrAraa = new Label();
            btnGeri = new Button();
            groupBoxOgrenciBilgisi = new GroupBox();
            txtDetayDogum = new TextBox();
            txtDetaySinif = new TextBox();
            txtDetayFakulte = new TextBox();
            txtDetayBolum = new TextBox();
            txtDetayAdSoyad = new TextBox();
            txtDetayOgrNo = new TextBox();
            labeLDogumTarr = new Label();
            labelSiniff = new Label();
            labelFakultee = new Label();
            labelBolumm = new Label();
            labelAdSoyadd = new Label();
            labelOgrenciNoo = new Label();
            groupBoxOgrenciList.SuspendLayout();
            groupBoxOgrenciBilgisi.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOgrenciList
            // 
            groupBoxOgrenciList.BackColor = Color.CornflowerBlue;
            groupBoxOgrenciList.Controls.Add(listBoxOgrenciler);
            groupBoxOgrenciList.Controls.Add(txtAra);
            groupBoxOgrenciList.Controls.Add(labelOgrAraa);
            groupBoxOgrenciList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBoxOgrenciList.Location = new Point(12, 75);
            groupBoxOgrenciList.Name = "groupBoxOgrenciList";
            groupBoxOgrenciList.Size = new Size(563, 560);
            groupBoxOgrenciList.TabIndex = 0;
            groupBoxOgrenciList.TabStop = false;
            groupBoxOgrenciList.Text = "             Öğrenci Listesi";
            // 
            // listBoxOgrenciler
            // 
            listBoxOgrenciler.FormattingEnabled = true;
            listBoxOgrenciler.ItemHeight = 32;
            listBoxOgrenciler.Location = new Point(21, 107);
            listBoxOgrenciler.Name = "listBoxOgrenciler";
            listBoxOgrenciler.Size = new Size(536, 420);
            listBoxOgrenciler.TabIndex = 2;
            listBoxOgrenciler.SelectedIndexChanged += listBoxOgrenciler_SelectedIndexChanged;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(154, 51);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(403, 39);
            txtAra.TabIndex = 1;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // labelOgrAraa
            // 
            labelOgrAraa.AutoSize = true;
            labelOgrAraa.Location = new Point(3, 54);
            labelOgrAraa.Name = "labelOgrAraa";
            labelOgrAraa.Size = new Size(145, 32);
            labelOgrAraa.TabIndex = 0;
            labelOgrAraa.Text = "Öğrenci Ara:";
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.CornflowerBlue;
            btnGeri.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGeri.Location = new Point(1, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(52, 55);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "<";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // groupBoxOgrenciBilgisi
            // 
            groupBoxOgrenciBilgisi.BackColor = Color.CornflowerBlue;
            groupBoxOgrenciBilgisi.Controls.Add(txtDetayDogum);
            groupBoxOgrenciBilgisi.Controls.Add(txtDetaySinif);
            groupBoxOgrenciBilgisi.Controls.Add(txtDetayFakulte);
            groupBoxOgrenciBilgisi.Controls.Add(txtDetayBolum);
            groupBoxOgrenciBilgisi.Controls.Add(txtDetayAdSoyad);
            groupBoxOgrenciBilgisi.Controls.Add(txtDetayOgrNo);
            groupBoxOgrenciBilgisi.Controls.Add(labeLDogumTarr);
            groupBoxOgrenciBilgisi.Controls.Add(labelSiniff);
            groupBoxOgrenciBilgisi.Controls.Add(labelFakultee);
            groupBoxOgrenciBilgisi.Controls.Add(labelBolumm);
            groupBoxOgrenciBilgisi.Controls.Add(labelAdSoyadd);
            groupBoxOgrenciBilgisi.Controls.Add(labelOgrenciNoo);
            groupBoxOgrenciBilgisi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBoxOgrenciBilgisi.Location = new Point(598, 75);
            groupBoxOgrenciBilgisi.Name = "groupBoxOgrenciBilgisi";
            groupBoxOgrenciBilgisi.Size = new Size(602, 560);
            groupBoxOgrenciBilgisi.TabIndex = 2;
            groupBoxOgrenciBilgisi.TabStop = false;
            groupBoxOgrenciBilgisi.Text = "                        Öğrenci Bilgisi";
            // 
            // txtDetayDogum
            // 
            txtDetayDogum.Location = new Point(165, 423);
            txtDetayDogum.Name = "txtDetayDogum";
            txtDetayDogum.ReadOnly = true;
            txtDetayDogum.Size = new Size(431, 39);
            txtDetayDogum.TabIndex = 11;
            // 
            // txtDetaySinif
            // 
            txtDetaySinif.Location = new Point(165, 348);
            txtDetaySinif.Name = "txtDetaySinif";
            txtDetaySinif.ReadOnly = true;
            txtDetaySinif.Size = new Size(431, 39);
            txtDetaySinif.TabIndex = 10;
            // 
            // txtDetayFakulte
            // 
            txtDetayFakulte.Location = new Point(165, 277);
            txtDetayFakulte.Name = "txtDetayFakulte";
            txtDetayFakulte.ReadOnly = true;
            txtDetayFakulte.Size = new Size(431, 39);
            txtDetayFakulte.TabIndex = 9;
            // 
            // txtDetayBolum
            // 
            txtDetayBolum.Location = new Point(165, 209);
            txtDetayBolum.Name = "txtDetayBolum";
            txtDetayBolum.ReadOnly = true;
            txtDetayBolum.Size = new Size(431, 39);
            txtDetayBolum.TabIndex = 8;
            // 
            // txtDetayAdSoyad
            // 
            txtDetayAdSoyad.Location = new Point(165, 141);
            txtDetayAdSoyad.Name = "txtDetayAdSoyad";
            txtDetayAdSoyad.ReadOnly = true;
            txtDetayAdSoyad.Size = new Size(431, 39);
            txtDetayAdSoyad.TabIndex = 7;
            // 
            // txtDetayOgrNo
            // 
            txtDetayOgrNo.Location = new Point(165, 70);
            txtDetayOgrNo.Name = "txtDetayOgrNo";
            txtDetayOgrNo.ReadOnly = true;
            txtDetayOgrNo.Size = new Size(431, 39);
            txtDetayOgrNo.TabIndex = 6;
            // 
            // labeLDogumTarr
            // 
            labeLDogumTarr.AutoSize = true;
            labeLDogumTarr.Location = new Point(6, 423);
            labeLDogumTarr.Name = "labeLDogumTarr";
            labeLDogumTarr.Size = new Size(162, 32);
            labeLDogumTarr.TabIndex = 5;
            labeLDogumTarr.Text = "Doğum Tarihi:";
            // 
            // labelSiniff
            // 
            labelSiniff.AutoSize = true;
            labelSiniff.Location = new Point(102, 351);
            labelSiniff.Name = "labelSiniff";
            labelSiniff.Size = new Size(66, 32);
            labelSiniff.TabIndex = 4;
            labelSiniff.Text = "Sınıf:";
            // 
            // labelFakultee
            // 
            labelFakultee.AutoSize = true;
            labelFakultee.Location = new Point(73, 280);
            labelFakultee.Name = "labelFakultee";
            labelFakultee.Size = new Size(95, 32);
            labelFakultee.TabIndex = 3;
            labelFakultee.Text = "Fakülte:";
            // 
            // labelBolumm
            // 
            labelBolumm.AutoSize = true;
            labelBolumm.Location = new Point(80, 212);
            labelBolumm.Name = "labelBolumm";
            labelBolumm.Size = new Size(88, 32);
            labelBolumm.TabIndex = 2;
            labelBolumm.Text = "Bölüm:";
            // 
            // labelAdSoyadd
            // 
            labelAdSoyadd.AutoSize = true;
            labelAdSoyadd.Location = new Point(48, 141);
            labelAdSoyadd.Name = "labelAdSoyadd";
            labelAdSoyadd.Size = new Size(120, 32);
            labelAdSoyadd.TabIndex = 1;
            labelAdSoyadd.Text = "Ad Soyad:";
            // 
            // labelOgrenciNoo
            // 
            labelOgrenciNoo.AutoSize = true;
            labelOgrenciNoo.Location = new Point(26, 73);
            labelOgrenciNoo.Name = "labelOgrenciNoo";
            labelOgrenciNoo.Size = new Size(142, 32);
            labelOgrenciNoo.TabIndex = 0;
            labelOgrenciNoo.Text = "Öğrenci No:";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1212, 660);
            Controls.Add(groupBoxOgrenciBilgisi);
            Controls.Add(btnGeri);
            Controls.Add(groupBoxOgrenciList);
            Name = "FrmOgrenciDetay";
            Text = "FrmOgrenciDetay";
            Load += FrmOgrenciDetay_Load;
            groupBoxOgrenciList.ResumeLayout(false);
            groupBoxOgrenciList.PerformLayout();
            groupBoxOgrenciBilgisi.ResumeLayout(false);
            groupBoxOgrenciBilgisi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOgrenciList;
        private Button btnGeri;
        private TextBox txtAra;
        private Label labelOgrAraa;
        private GroupBox groupBoxOgrenciBilgisi;
        private ListBox listBoxOgrenciler;
        private TextBox txtDetayDogum;
        private TextBox txtDetaySinif;
        private TextBox txtDetayFakulte;
        private TextBox txtDetayBolum;
        private TextBox txtDetayAdSoyad;
        private TextBox txtDetayOgrNo;
        private Label labeLDogumTarr;
        private Label labelSiniff;
        private Label labelFakultee;
        private Label labelBolumm;
        private Label labelAdSoyadd;
        private Label labelOgrenciNoo;
    }
}