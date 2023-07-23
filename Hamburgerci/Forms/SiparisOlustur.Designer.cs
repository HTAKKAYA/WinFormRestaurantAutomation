namespace Hamburgerci
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            label3 = new Label();
            label2 = new Label();
            btnSiparisOnayla = new Button();
            btnEkle = new Button();
            numAdet = new NumericUpDown();
            label1 = new Label();
            rbnBuyuk = new RadioButton();
            rbnOrta = new RadioButton();
            rbnKucuk = new RadioButton();
            cbxHamburger = new ComboBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(478, 495);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 25;
            label3.Text = "0 ₺";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(393, 495);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 24;
            label2.Text = "Toplam : ";
            // 
            // btnSiparisOnayla
            // 
            btnSiparisOnayla.Location = new Point(593, 466);
            btnSiparisOnayla.Name = "btnSiparisOnayla";
            btnSiparisOnayla.Size = new Size(177, 73);
            btnSiparisOnayla.TabIndex = 23;
            btnSiparisOnayla.Text = "Siparişi Onayla";
            btnSiparisOnayla.UseVisualStyleBackColor = true;
            btnSiparisOnayla.Click += btnSiparisOnayla_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(22, 487);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(210, 52);
            btnEkle.TabIndex = 22;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // numAdet
            // 
            numAdet.Location = new Point(88, 432);
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(144, 23);
            numAdet.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 434);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 20;
            label1.Text = "Adet";
            // 
            // rbnBuyuk
            // 
            rbnBuyuk.AutoSize = true;
            rbnBuyuk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbnBuyuk.Location = new Point(174, 376);
            rbnBuyuk.Name = "rbnBuyuk";
            rbnBuyuk.Size = new Size(64, 21);
            rbnBuyuk.TabIndex = 19;
            rbnBuyuk.TabStop = true;
            rbnBuyuk.Text = "Büyük";
            rbnBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbnOrta
            // 
            rbnOrta.AutoSize = true;
            rbnOrta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbnOrta.Location = new Point(101, 376);
            rbnOrta.Name = "rbnOrta";
            rbnOrta.Size = new Size(53, 21);
            rbnOrta.TabIndex = 18;
            rbnOrta.TabStop = true;
            rbnOrta.Text = "Orta";
            rbnOrta.UseVisualStyleBackColor = true;
            // 
            // rbnKucuk
            // 
            rbnKucuk.AutoSize = true;
            rbnKucuk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbnKucuk.Location = new Point(22, 376);
            rbnKucuk.Name = "rbnKucuk";
            rbnKucuk.Size = new Size(63, 21);
            rbnKucuk.TabIndex = 17;
            rbnKucuk.TabStop = true;
            rbnKucuk.Text = "Küçük";
            rbnKucuk.UseVisualStyleBackColor = true;
            // 
            // cbxHamburger
            // 
            cbxHamburger.FormattingEnabled = true;
            cbxHamburger.Location = new Point(36, 168);
            cbxHamburger.Name = "cbxHamburger";
            cbxHamburger.Size = new Size(196, 23);
            cbxHamburger.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(36, 211);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(196, 138);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(277, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(493, 424);
            listBox1.TabIndex = 27;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 566);
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSiparisOnayla);
            Controls.Add(btnEkle);
            Controls.Add(numAdet);
            Controls.Add(label1);
            Controls.Add(rbnBuyuk);
            Controls.Add(rbnOrta);
            Controls.Add(rbnKucuk);
            Controls.Add(cbxHamburger);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button btnSiparisOnayla;
        private Button btnEkle;
        private NumericUpDown numAdet;
        private Label label1;
        private RadioButton rbnBuyuk;
        private RadioButton rbnOrta;
        private RadioButton rbnKucuk;
        private ComboBox cbxHamburger;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBox1;
    }
}