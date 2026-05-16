namespace Kutuphaneoto
{
    partial class FrmLogKayitlari
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
            buttonGeriLog = new Button();
            listBoxLoglar = new ListBox();
            SuspendLayout();
            // 
            // buttonGeriLog
            // 
            buttonGeriLog.BackColor = Color.CornflowerBlue;
            buttonGeriLog.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGeriLog.Location = new Point(2, 1);
            buttonGeriLog.Name = "buttonGeriLog";
            buttonGeriLog.Size = new Size(53, 59);
            buttonGeriLog.TabIndex = 0;
            buttonGeriLog.Text = "<";
            buttonGeriLog.UseVisualStyleBackColor = false;
            buttonGeriLog.Click += buttonGeriLog_Click;
            // 
            // listBoxLoglar
            // 
            listBoxLoglar.BackColor = SystemColors.Control;
            listBoxLoglar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBoxLoglar.FormattingEnabled = true;
            listBoxLoglar.ItemHeight = 32;
            listBoxLoglar.Location = new Point(61, 66);
            listBoxLoglar.Name = "listBoxLoglar";
            listBoxLoglar.Size = new Size(946, 516);
            listBoxLoglar.TabIndex = 1;
            // 
            // FrmLogKayitlari
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1047, 621);
            Controls.Add(listBoxLoglar);
            Controls.Add(buttonGeriLog);
            Name = "FrmLogKayitlari";
            Text = "Log Kayıtları";
            Activated += FrmLogKayitlari_Activated;
            Load += FrmLogKayitlari_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGeriLog;
        private ListBox listBoxLoglar;
    }
}