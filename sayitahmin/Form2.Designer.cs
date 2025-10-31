namespace sayitahmin
{
    partial class SAYIAVCISIFORM
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
            lblBaslik = new Label();
            lblAciklama = new Label();
            lblKalanHak = new Label();
            txtTahmin = new TextBox();
            btnTahminEt = new Button();
            lstTahminler = new ListBox();
            btnYeniOyun = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaslik.Location = new Point(298, 26);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(185, 21);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "SayıAvcısı - Klasik Mod";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 13F);
            lblAciklama.Location = new Point(75, 47);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(669, 25);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "4 basamaklı sayıyı tahmin et! Sadece kaç rakamın doğru yerde olduğunu bileceksin.";
            // 
            // lblKalanHak
            // 
            lblKalanHak.AutoSize = true;
            lblKalanHak.Font = new Font("Segoe UI", 11F);
            lblKalanHak.Location = new Point(338, 106);
            lblKalanHak.Name = "lblKalanHak";
            lblKalanHak.Size = new Size(99, 20);
            lblKalanHak.TabIndex = 2;
            lblKalanHak.Text = "Kalan Hak: 15";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(337, 148);
            txtTahmin.MaxLength = 4;
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(100, 23);
            txtTahmin.TabIndex = 3;
            txtTahmin.KeyPress += txtTahmin_KeyPress;
            // 
            // btnTahminEt
            // 
            btnTahminEt.Location = new Point(350, 197);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(75, 23);
            btnTahminEt.TabIndex = 4;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // lstTahminler
            // 
            lstTahminler.FormattingEnabled = true;
            lstTahminler.ItemHeight = 15;
            lstTahminler.Location = new Point(212, 245);
            lstTahminler.Name = "lstTahminler";
            lstTahminler.Size = new Size(354, 124);
            lstTahminler.TabIndex = 5;
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(350, 402);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(75, 23);
            btnYeniOyun.TabIndex = 6;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // SAYIAVCISIFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYeniOyun);
            Controls.Add(lstTahminler);
            Controls.Add(btnTahminEt);
            Controls.Add(txtTahmin);
            Controls.Add(lblKalanHak);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            Name = "SAYIAVCISIFORM";
            Text = "SayıAvcısı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private Label lblKalanHak;
        private TextBox txtTahmin;
        private Button btnTahminEt;
        private ListBox lstTahminler;
        private Button btnYeniOyun;
    }
}