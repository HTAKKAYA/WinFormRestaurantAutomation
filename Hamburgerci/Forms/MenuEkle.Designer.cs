namespace Hamburgerci
{
    partial class MenuEkle
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
            groupBox1 = new GroupBox();
            numMenuFiyat = new NumericUpDown();
            txtMenuAd = new TextBox();
            btnMenuEkle = new Button();
            lblFiyat = new Label();
            lblAd = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numMenuFiyat);
            groupBox1.Controls.Add(txtMenuAd);
            groupBox1.Controls.Add(btnMenuEkle);
            groupBox1.Controls.Add(lblFiyat);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(24, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu Ekle";
            // 
            // numMenuFiyat
            // 
            numMenuFiyat.Location = new Point(132, 109);
            numMenuFiyat.Name = "numMenuFiyat";
            numMenuFiyat.Size = new Size(169, 25);
            numMenuFiyat.TabIndex = 4;
            // 
            // txtMenuAd
            // 
            txtMenuAd.Location = new Point(132, 53);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(169, 25);
            txtMenuAd.TabIndex = 3;
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Location = new Point(132, 161);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(169, 39);
            btnMenuEkle.TabIndex = 2;
            btnMenuEkle.Text = "Ekle";
            btnMenuEkle.UseVisualStyleBackColor = true;
            btnMenuEkle.Click += btnMenuEkle_Click_1;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyat.Location = new Point(22, 111);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(38, 16);
            lblFiyat.TabIndex = 1;
            lblFiyat.Text = "Fiyat";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAd.Location = new Point(21, 56);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(24, 16);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 279);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "MenuEkle";
            //Load += MenuEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMenuFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numMenuFiyat;
        private TextBox txtMenuAd;
        private Button btnMenuEkle;
        private Label lblFiyat;
        private Label lblAd;
    }
}