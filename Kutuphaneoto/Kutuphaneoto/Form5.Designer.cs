namespace Kutuphaneoto
{
    partial class FrmOduncIade
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
            buttonGeriOdunc   = new Button();
            btnOduncVer       = new Button();
            btnIadeAl         = new Button();
            btnGecikmisList   = new Button();
            SuspendLayout();

            // buttonGeriOdunc
            buttonGeriOdunc.BackColor = Color.CornflowerBlue;
            buttonGeriOdunc.Font      = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGeriOdunc.Location  = new Point(3, 2);
            buttonGeriOdunc.Name      = "buttonGeriOdunc";
            buttonGeriOdunc.Size      = new Size(57, 55);
            buttonGeriOdunc.TabIndex  = 0;
            buttonGeriOdunc.Text      = "<";
            buttonGeriOdunc.UseVisualStyleBackColor = false;
            buttonGeriOdunc.Click    += buttonGeriOdunc_Click;

            // btnOduncVer
            btnOduncVer.BackColor = Color.FromArgb(128, 255, 128);
            btnOduncVer.Font      = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOduncVer.Location  = new Point(86, 72);
            btnOduncVer.Name      = "btnOduncVer";
            btnOduncVer.Size      = new Size(311, 83);
            btnOduncVer.TabIndex  = 1;
            btnOduncVer.Text      = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click    += btnOduncVer_Click;

            // btnIadeAl
            btnIadeAl.BackColor = Color.FromArgb(255, 128, 128);
            btnIadeAl.Font      = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIadeAl.Location  = new Point(86, 181);
            btnIadeAl.Name      = "btnIadeAl";
            btnIadeAl.Size      = new Size(311, 83);
            btnIadeAl.TabIndex  = 2;
            btnIadeAl.Text      = "İade Al";
            btnIadeAl.UseVisualStyleBackColor = false;
            btnIadeAl.Click    += btnIadeAl_Click;

            // btnGecikmisList  ── YENİ ──
            btnGecikmisList.BackColor = Color.FromArgb(255, 200, 0);
            btnGecikmisList.Font      = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGecikmisList.Location  = new Point(86, 290);
            btnGecikmisList.Name      = "btnGecikmisList";
            btnGecikmisList.Size      = new Size(311, 83);
            btnGecikmisList.TabIndex  = 3;
            btnGecikmisList.Text      = "⚠ Gecikmiş İadeler";
            btnGecikmisList.UseVisualStyleBackColor = false;
            btnGecikmisList.Click    += btnGecikmisList_Click;

            // Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode       = AutoScaleMode.Font;
            BackColor           = Color.Cornsilk;
            ClientSize          = new Size(484, 430);
            Controls.Add(buttonGeriOdunc);
            Controls.Add(btnOduncVer);
            Controls.Add(btnIadeAl);
            Controls.Add(btnGecikmisList);
            Name  = "FrmOduncIade";
            Text  = "Ödünç ve İade İşlemleri";
            ResumeLayout(false);
        }

        private Button buttonGeriOdunc;
        private Button btnOduncVer;
        private Button btnIadeAl;
        private Button btnGecikmisList;
    }
}
