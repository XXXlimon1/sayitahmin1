namespace sayitahmin
{
    partial class MAINFORM
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
            btnSayiAvcisi = new Button();
            btnNumWordle = new Button();
            SuspendLayout();
            // 
            // btnSayiAvcisi
            // 
            btnSayiAvcisi.Location = new Point(111, 139);
            btnSayiAvcisi.Name = "btnSayiAvcisi";
            btnSayiAvcisi.Size = new Size(161, 45);
            btnSayiAvcisi.TabIndex = 0;
            btnSayiAvcisi.Text = "SayıAvcısı (Klasik Mod)";
            btnSayiAvcisi.UseVisualStyleBackColor = true;
            btnSayiAvcisi.Click += btnSayiAvcisi_Click;
            // 
            // btnNumWordle
            // 
            btnNumWordle.Location = new Point(301, 139);
            btnNumWordle.Name = "btnNumWordle";
            btnNumWordle.Size = new Size(161, 45);
            btnNumWordle.TabIndex = 1;
            btnNumWordle.Text = "NumWordle (Wordle Mod)";
            btnNumWordle.UseVisualStyleBackColor = true;
            btnNumWordle.Click += btnNumWordle_Click;
            // 
            // MAINFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnNumWordle);
            Controls.Add(btnSayiAvcisi);
            Name = "MAINFORM";
            Text = "Sayı Tahmin Oyunları";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSayiAvcisi;
        private Button btnNumWordle;
    }
}
