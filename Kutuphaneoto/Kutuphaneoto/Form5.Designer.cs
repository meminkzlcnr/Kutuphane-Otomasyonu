namespace Kutuphaneoto
{
    partial class FrmOduncIade
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
            buttonGeriOdunc = new Button();
            btnOduncVer = new Button();
            btnIadeAl = new Button();
            SuspendLayout();
            // 
            // buttonGeriOdunc
            // 
            buttonGeriOdunc.BackColor = Color.CornflowerBlue;
            buttonGeriOdunc.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonGeriOdunc.Location = new Point(3, 2);
            buttonGeriOdunc.Name = "buttonGeriOdunc";
            buttonGeriOdunc.Size = new Size(57, 55);
            buttonGeriOdunc.TabIndex = 0;
            buttonGeriOdunc.Text = "<";
            buttonGeriOdunc.UseVisualStyleBackColor = false;
            buttonGeriOdunc.Click += buttonGeriOdunc_Click;
            // 
            // btnOduncVer
            // 
            btnOduncVer.BackColor = Color.CornflowerBlue;
            btnOduncVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnOduncVer.Location = new Point(119, 93);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(277, 77);
            btnOduncVer.TabIndex = 1;
            btnOduncVer.Text = "Ödünç Verme";
            btnOduncVer.UseVisualStyleBackColor = false;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnIadeAl
            // 
            btnIadeAl.BackColor = Color.Crimson;
            btnIadeAl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnIadeAl.Location = new Point(119, 221);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(277, 74);
            btnIadeAl.TabIndex = 2;
            btnIadeAl.Text = "İade Alma";
            btnIadeAl.UseVisualStyleBackColor = false;
            btnIadeAl.Click += btnIadeAl_Click;
            // 
            // FrmOduncIade
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(644, 421);
            Controls.Add(btnIadeAl);
            Controls.Add(btnOduncVer);
            Controls.Add(buttonGeriOdunc);
            Name = "FrmOduncIade";
            Text = "Ödünç ve İade İşlemleri";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGeriOdunc;
        private Button btnOduncVer;
        private Button btnIadeAl;
    }
}