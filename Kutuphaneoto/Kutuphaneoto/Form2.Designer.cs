namespace Kutuphaneoto
{
    partial class FrmAnaMenu
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
            buttonKitapYon = new Button();
            buttonOgrenciYon = new Button();
            buttonOduncİade = new Button();
            buttonİstatistik = new Button();
            buttonLogKay = new Button();
            buttonKullaniciYon = new Button();
            SuspendLayout();
            // 
            // buttonKitapYon
            // 
            buttonKitapYon.BackColor = Color.FromArgb(128, 128, 255);
            buttonKitapYon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonKitapYon.Location = new Point(86, 72);
            buttonKitapYon.Name = "buttonKitapYon";
            buttonKitapYon.Size = new Size(311, 83);
            buttonKitapYon.TabIndex = 0;
            buttonKitapYon.Text = "Kitap Yönetimi";
            buttonKitapYon.UseVisualStyleBackColor = false;
            buttonKitapYon.Click += buttonKitapYon_Click;
            // 
            // buttonOgrenciYon
            // 
            buttonOgrenciYon.BackColor = Color.Red;
            buttonOgrenciYon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonOgrenciYon.Location = new Point(86, 181);
            buttonOgrenciYon.Name = "buttonOgrenciYon";
            buttonOgrenciYon.Size = new Size(311, 83);
            buttonOgrenciYon.TabIndex = 1;
            buttonOgrenciYon.Text = "Öğrenci Yönetimi";
            buttonOgrenciYon.UseVisualStyleBackColor = false;
            buttonOgrenciYon.Click += buttonOgrenciYon_Click;
            // 
            // buttonOduncİade
            // 
            buttonOduncİade.BackColor = Color.Lime;
            buttonOduncİade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonOduncİade.Location = new Point(86, 293);
            buttonOduncİade.Name = "buttonOduncİade";
            buttonOduncİade.Size = new Size(311, 83);
            buttonOduncİade.TabIndex = 2;
            buttonOduncİade.Text = "Ödünç ve İade İşlemleri";
            buttonOduncİade.UseVisualStyleBackColor = false;
            buttonOduncİade.Click += buttonOduncİade_Click;
            // 
            // buttonİstatistik
            // 
            buttonİstatistik.BackColor = Color.Cyan;
            buttonİstatistik.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonİstatistik.Location = new Point(86, 403);
            buttonİstatistik.Name = "buttonİstatistik";
            buttonİstatistik.Size = new Size(311, 83);
            buttonİstatistik.TabIndex = 3;
            buttonİstatistik.Text = "İstatistikler";
            buttonİstatistik.UseVisualStyleBackColor = false;
            buttonİstatistik.Click += buttonİstatistik_Click;
            // 
            // buttonLogKay
            // 
            buttonLogKay.BackColor = Color.Yellow;
            buttonLogKay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonLogKay.Location = new Point(86, 510);
            buttonLogKay.Name = "buttonLogKay";
            buttonLogKay.Size = new Size(311, 83);
            buttonLogKay.TabIndex = 4;
            buttonLogKay.Text = "Log Kayıtları";
            buttonLogKay.UseVisualStyleBackColor = false;
            buttonLogKay.Click += buttonLogKay_Click;
            // 
            // buttonKullaniciYon
            // 
            buttonKullaniciYon.BackColor = Color.FromArgb(255, 128, 0);
            buttonKullaniciYon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonKullaniciYon.Location = new Point(86, 620);
            buttonKullaniciYon.Name = "buttonKullaniciYon";
            buttonKullaniciYon.Size = new Size(311, 83);
            buttonKullaniciYon.TabIndex = 5;
            buttonKullaniciYon.Text = "Kullanıcı Yönetimi";
            buttonKullaniciYon.UseVisualStyleBackColor = false;
            buttonKullaniciYon.Click += buttonKullaniciYon_Click;
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(768, 750);
            Controls.Add(buttonLogKay);
            Controls.Add(buttonİstatistik);
            Controls.Add(buttonOduncİade);
            Controls.Add(buttonOgrenciYon);
            Controls.Add(buttonKitapYon);
            Controls.Add(buttonKullaniciYon);
            Name = "FrmAnaMenu";
            Text = "Ana Menü";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKitapYon;
        private Button buttonOgrenciYon;
        private Button buttonOduncİade;
        private Button buttonİstatistik;
        private Button buttonLogKay;
        private Button buttonKullaniciYon;
    }
}