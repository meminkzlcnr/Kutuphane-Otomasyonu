namespace Kutuphaneoto
{
    partial class FrmIstatistikler
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
            buttonGeriIstatistik = new Button();
            grpEnCokAlinanKitaplar = new GroupBox();
            listBoxEnCokKitaplar = new ListBox();
            grpEnCokAlanOgrenciler = new GroupBox();
            listBoxEnCokOgrenciler = new ListBox();
            grpEnCokAlinanKitaplar.SuspendLayout();
            grpEnCokAlanOgrenciler.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGeriIstatistik
            // 
            buttonGeriIstatistik.BackColor = Color.CornflowerBlue;
            buttonGeriIstatistik.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGeriIstatistik.Location = new Point(1, 2);
            buttonGeriIstatistik.Name = "buttonGeriIstatistik";
            buttonGeriIstatistik.Size = new Size(55, 59);
            buttonGeriIstatistik.TabIndex = 0;
            buttonGeriIstatistik.Text = "<";
            buttonGeriIstatistik.UseVisualStyleBackColor = false;
            buttonGeriIstatistik.Click += buttonGeriİstatistik_Click;
            // 
            // grpEnCokAlinanKitaplar
            // 
            grpEnCokAlinanKitaplar.BackColor = Color.DarkSeaGreen;
            grpEnCokAlinanKitaplar.Controls.Add(listBoxEnCokKitaplar);
            grpEnCokAlinanKitaplar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpEnCokAlinanKitaplar.Location = new Point(12, 90);
            grpEnCokAlinanKitaplar.Name = "grpEnCokAlinanKitaplar";
            grpEnCokAlinanKitaplar.Size = new Size(471, 413);
            grpEnCokAlinanKitaplar.TabIndex = 1;
            grpEnCokAlinanKitaplar.TabStop = false;
            grpEnCokAlinanKitaplar.Text = "En Çok Alınan Kitaplar";
            // 
            // listBoxEnCokKitaplar
            // 
            listBoxEnCokKitaplar.FormattingEnabled = true;
            listBoxEnCokKitaplar.ItemHeight = 32;
            listBoxEnCokKitaplar.Location = new Point(29, 50);
            listBoxEnCokKitaplar.Name = "listBoxEnCokKitaplar";
            listBoxEnCokKitaplar.SelectionMode = SelectionMode.None;
            listBoxEnCokKitaplar.Size = new Size(412, 324);
            listBoxEnCokKitaplar.TabIndex = 0;
            // 
            // grpEnCokAlanOgrenciler
            // 
            grpEnCokAlanOgrenciler.BackColor = Color.DarkSeaGreen;
            grpEnCokAlanOgrenciler.Controls.Add(listBoxEnCokOgrenciler);
            grpEnCokAlanOgrenciler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grpEnCokAlanOgrenciler.Location = new Point(518, 90);
            grpEnCokAlanOgrenciler.Name = "grpEnCokAlanOgrenciler";
            grpEnCokAlanOgrenciler.Size = new Size(542, 413);
            grpEnCokAlanOgrenciler.TabIndex = 2;
            grpEnCokAlanOgrenciler.TabStop = false;
            grpEnCokAlanOgrenciler.Text = "En Çok Kitap Alan Öğrenciler";
            // 
            // listBoxEnCokOgrenciler
            // 
            listBoxEnCokOgrenciler.FormattingEnabled = true;
            listBoxEnCokOgrenciler.ItemHeight = 32;
            listBoxEnCokOgrenciler.Location = new Point(23, 50);
            listBoxEnCokOgrenciler.Name = "listBoxEnCokOgrenciler";
            listBoxEnCokOgrenciler.SelectionMode = SelectionMode.None;
            listBoxEnCokOgrenciler.Size = new Size(495, 324);
            listBoxEnCokOgrenciler.TabIndex = 0;
            // 
            // FrmIstatistikler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1072, 665);
            Controls.Add(grpEnCokAlanOgrenciler);
            Controls.Add(grpEnCokAlinanKitaplar);
            Controls.Add(buttonGeriIstatistik);
            Name = "FrmIstatistikler";
            Text = "İstatistikler";
            Load += FrmIstatistikler_Load;
            grpEnCokAlinanKitaplar.ResumeLayout(false);
            grpEnCokAlanOgrenciler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGeriIstatistik;
        private GroupBox grpEnCokAlinanKitaplar;
        private ListBox listBoxEnCokKitaplar;
        private GroupBox grpEnCokAlanOgrenciler;
        private ListBox listBoxEnCokOgrenciler;
    }
}