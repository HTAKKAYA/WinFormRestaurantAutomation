namespace Hamburgerci
{
    partial class MalzemeEkle
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
            gbxEkstraMalzeme = new GroupBox();
            numMalzemeFiyat = new NumericUpDown();
            txtMalzemeAd = new TextBox();
            btnEkleMalzeme = new Button();
            lblFiyatMalzeme = new Label();
            lblAdMalzeme = new Label();
            gbxEkstraMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // gbxEkstraMalzeme
            // 
            gbxEkstraMalzeme.Controls.Add(numMalzemeFiyat);
            gbxEkstraMalzeme.Controls.Add(txtMalzemeAd);
            gbxEkstraMalzeme.Controls.Add(btnEkleMalzeme);
            gbxEkstraMalzeme.Controls.Add(lblFiyatMalzeme);
            gbxEkstraMalzeme.Controls.Add(lblAdMalzeme);
            gbxEkstraMalzeme.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbxEkstraMalzeme.Location = new Point(12, 27);
            gbxEkstraMalzeme.Name = "gbxEkstraMalzeme";
            gbxEkstraMalzeme.Size = new Size(329, 216);
            gbxEkstraMalzeme.TabIndex = 1;
            gbxEkstraMalzeme.TabStop = false;
            gbxEkstraMalzeme.Text = "Ekstra Malzeme Ekle";
            // 
            // numMalzemeFiyat
            // 
            numMalzemeFiyat.Location = new Point(132, 109);
            numMalzemeFiyat.Name = "numMalzemeFiyat";
            numMalzemeFiyat.Size = new Size(169, 25);
            numMalzemeFiyat.TabIndex = 4;
            // 
            // txtMalzemeAd
            // 
            txtMalzemeAd.Location = new Point(132, 53);
            txtMalzemeAd.Name = "txtMalzemeAd";
            txtMalzemeAd.Size = new Size(169, 25);
            txtMalzemeAd.TabIndex = 3;
            // 
            // btnEkleMalzeme
            // 
            btnEkleMalzeme.Location = new Point(132, 161);
            btnEkleMalzeme.Name = "btnEkleMalzeme";
            btnEkleMalzeme.Size = new Size(169, 39);
            btnEkleMalzeme.TabIndex = 2;
            btnEkleMalzeme.Text = "Ekle";
            btnEkleMalzeme.UseVisualStyleBackColor = true;
            btnEkleMalzeme.Click += btnEkleMalzeme_Click;
            // 
            // lblFiyatMalzeme
            // 
            lblFiyatMalzeme.AutoSize = true;
            lblFiyatMalzeme.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyatMalzeme.Location = new Point(22, 111);
            lblFiyatMalzeme.Name = "lblFiyatMalzeme";
            lblFiyatMalzeme.Size = new Size(38, 16);
            lblFiyatMalzeme.TabIndex = 1;
            lblFiyatMalzeme.Text = "Fiyat";
            // 
            // lblAdMalzeme
            // 
            lblAdMalzeme.AutoSize = true;
            lblAdMalzeme.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdMalzeme.Location = new Point(21, 56);
            lblAdMalzeme.Name = "lblAdMalzeme";
            lblAdMalzeme.Size = new Size(24, 16);
            lblAdMalzeme.TabIndex = 0;
            lblAdMalzeme.Text = "Ad";
            // 
            // MalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 281);
            Controls.Add(gbxEkstraMalzeme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MalzemeEkle";
            Text = "MalzemeEkle";
            gbxEkstraMalzeme.ResumeLayout(false);
            gbxEkstraMalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMalzemeFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxEkstraMalzeme;
        private NumericUpDown numMalzemeFiyat;
        private TextBox txtMalzemeAd;
        private Button btnEkleMalzeme;
        private Label lblFiyatMalzeme;
        private Label lblAdMalzeme;
    }
}