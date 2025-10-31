using System;
using System.Windows.Forms;

namespace sayitahmin
{
    public partial class SAYIAVCISIFORM : Form
    {
        private string gizliSayi = "";
        private int kalanHak = 15;

        public SAYIAVCISIFORM()
        {
            InitializeComponent();
            YeniOyun();
        }

        private void YeniOyun()
        {
            // rastgele sayı üret
            Random rnd = new Random();
            gizliSayi = rnd.Next(1000, 10000).ToString();
            kalanHak = 15;

            // Labelları güncelle
            lblKalanHak.Text = "Kalan Hak: 15";
            lstTahminler.Items.Clear();
            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            string tahmin = txtTahmin.Text;

            // Kontrol
            if (tahmin.Length != 4)
            {
                MessageBox.Show("Lütfen 4 basamaklı bir sayı girin!", "Uyarı");
                return;
            }

            if (!int.TryParse(tahmin, out _))
            {
                MessageBox.Show("Lütfen sadece rakam girin!", "Uyarı");
                return;
            }

            bool[] gizliKullanildi = new bool[4];
            bool[] tahminKullanildi = new bool[4];

            int dogruYer = 0;      // Doğru yerde doğru rakam (+)
            int yanlisYer = 0;     // Yanlış yerde doğru rakam (-)

            //doğru yerdeki rakamları bul
            for (int i = 0; i < 4; i++)
            {
                if (tahmin[i] == gizliSayi[i])
                {
                    dogruYer++;
                    gizliKullanildi[i] = true;
                    tahminKullanildi[i] = true;
                }
            }

            //yanlış yerdeki doğru rakamları bul
            for (int i = 0; i < 4; i++)
            {
                if (!tahminKullanildi[i]) // teker teker bool kontrolü yapıp aynı sayıyı tekrar tekrar kontrol etmiyor
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (!gizliKullanildi[j] && tahmin[i] == gizliSayi[j])
                        {
                            yanlisYer++;
                            gizliKullanildi[j] = true;
                            break;
                        }
                    }
                }
            }

            kalanHak--;

            // Sonucu gösterme yeri
            string sonuc = $"{tahmin} → +{dogruYer} (doğru sayı,doğru yer), -{yanlisYer} (doğru sayı,yanlış yer)";
            lstTahminler.Items.Add(sonuc);

            // Kalan hakkı güncelleme yeri
            lblKalanHak.Text = $"Kalan Hak: {kalanHak}";

            txtTahmin.Clear();

            // Kazanıp kazanmadığını kontrol eden yer
            if (dogruYer == 4)
            {
                MessageBox.Show($"Tebrikler! Sayıyı {15 - kalanHak}. tahminde buldunuz!\n\nDoğru Sayı: {gizliSayi}");
                YeniOyun();
                return;
            }

            if (kalanHak == 0)
            {
                MessageBox.Show($"Üzgünüm, hakkınız bitti!\n\nDoğru Sayı: {gizliSayi}");
                YeniOyun();
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeni oyun başlatmak istiyor musunuz?");

            if (result == DialogResult.Yes)
            {
                YeniOyun();
            }
        }

        private void txtTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam girişine izin verme kontrolü yeri
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Entera basınca da kabul etmesi
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTahminEt_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}