namespace Kutuphaneoto
{
    partial class FrmGirisEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            textBoxKullaniciadi = new TextBox();
            textBoxSifre = new TextBox();
            girisbutton = new Button();
            labelYapanKisi = new Label();
            labelKlncAdi = new Label();
            labelSfre = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(112, 147);
            label2.Name = "label2";
            label2.Size = new Size(233, 32);
            label2.TabIndex = 1;
            label2.Text = "personel kullancı adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(171, 238);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 2;
            label3.Text = "personel şifresi";
            // 
            // textBoxKullaniciadi
            // 
            textBoxKullaniciadi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxKullaniciadi.Location = new Point(351, 140);
            textBoxKullaniciadi.Name = "textBoxKullaniciadi";
            textBoxKullaniciadi.Size = new Size(354, 39);
            textBoxKullaniciadi.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxSifre.Location = new Point(351, 235);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(354, 39);
            textBoxSifre.TabIndex = 4;
            // 
            // girisbutton
            // 
            girisbutton.BackColor = Color.FromArgb(128, 255, 128);
            girisbutton.Location = new Point(429, 321);
            girisbutton.Name = "girisbutton";
            girisbutton.Size = new Size(194, 62);
            girisbutton.TabIndex = 5;
            girisbutton.Text = "giriş yap";
            girisbutton.UseVisualStyleBackColor = false;
            girisbutton.Click += girisbutton_Click;
            // 
            // labelYapanKisi
            // 
            labelYapanKisi.AutoSize = true;
            labelYapanKisi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelYapanKisi.Location = new Point(309, 9);
            labelYapanKisi.Name = "labelYapanKisi";
            labelYapanKisi.Size = new Size(0, 32);
            labelYapanKisi.TabIndex = 6;
            // 
            // labelKlncAdi
            // 
            labelKlncAdi.AutoSize = true;
            labelKlncAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelKlncAdi.Location = new Point(734, 143);
            labelKlncAdi.Name = "labelKlncAdi";
            labelKlncAdi.Size = new Size(213, 32);
            labelKlncAdi.TabIndex = 7;
            labelKlncAdi.Text = "kullancı adı: admin";
            // 
            // labelSfre
            // 
            labelSfre.AutoSize = true;
            labelSfre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelSfre.Location = new Point(734, 238);
            labelSfre.Name = "labelSfre";
            labelSfre.Size = new Size(184, 32);
            labelSfre.TabIndex = 8;
            labelSfre.Text = "şifre : admin123";
            // 
            // FrmGirisEkrani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1007, 667);
            Controls.Add(labelSfre);
            Controls.Add(labelKlncAdi);
            Controls.Add(labelYapanKisi);
            Controls.Add(girisbutton);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciadi);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmGirisEkrani";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBoxKullaniciadi;
        private TextBox textBoxSifre;
        private Button girisbutton;
        private Label labelYapanKisi;
        private Label labelKlncAdi;
        private Label labelSfre;
    }
}
