using System;
using System.Drawing;
using System.Windows.Forms;

namespace sayitahmin
{
    public partial class NUMWORDLEFORM : Form
    {
        private string gizliSayi = ""; // baslangic degerini kaydediyoruz
        private int mevcutTahmin = 0;
        private const int MAKSIMUM_TAHMIN = 6;

        public NUMWORDLEFORM()
        {
            InitializeComponent();
            YeniOyun();
        }

        private void YeniOyun()
        {
            // rastgele sayı üretme
            Random rnd = new Random();
            gizliSayi = rnd.Next(1000, 10000).ToString();
            mevcutTahmin = 0;

            TumKutulariTemizle();

            // İlk satırı aktif yap
            txt1_1.ReadOnly = false;
            txt1_2.ReadOnly = false;
            txt1_3.ReadOnly = false;
            txt1_4.ReadOnly = false;

            lblDurum.Text = "4 basamaklı sayıyı tahmin et (Wordle gibi)";
            txt1_1.Focus();
        }

        private void TumKutulariTemizle()
        {
            // Satır 1
            TemizleVeKilitle(txt1_1); TemizleVeKilitle(txt1_2); TemizleVeKilitle(txt1_3); TemizleVeKilitle(txt1_4);
            // Satır 2
            TemizleVeKilitle(txt2_1); TemizleVeKilitle(txt2_2); TemizleVeKilitle(txt2_3); TemizleVeKilitle(txt2_4);
            // Satır 3
            TemizleVeKilitle(txt3_1); TemizleVeKilitle(txt3_2); TemizleVeKilitle(txt3_3); TemizleVeKilitle(txt3_4);
            // Satır 4
            TemizleVeKilitle(txt4_1); TemizleVeKilitle(txt4_2); TemizleVeKilitle(txt4_3); TemizleVeKilitle(txt4_4);
            // Satır 5
            TemizleVeKilitle(txt5_1); TemizleVeKilitle(txt5_2); TemizleVeKilitle(txt5_3); TemizleVeKilitle(txt5_4);
            // Satır 6
            TemizleVeKilitle(txt6_1); TemizleVeKilitle(txt6_2); TemizleVeKilitle(txt6_3); TemizleVeKilitle(txt6_4);
        }

        private void TemizleVeKilitle(TextBox txt)
        {
            txt.Text = "";
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
            txt.ReadOnly = true;
        }

        private void Kutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam girişine izin verme
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Enter'a basınca tahmini kontrol etme
            if (e.KeyChar == (char)Keys.Enter)
            {
                TahminiKontrolEt();
                e.Handled = true;
            }
        }

        private void Kutu_TextChanged(object sender, EventArgs e)
        {
            TextBox aktifKutu = sender as TextBox;

            // Bir karakter girildiyse sonraki kutuya geçme kısmı
            if (aktifKutu.Text.Length == 1)
            {
                // Hangi satırdayız?
                TextBox[] mevcutSatir = MevcutSatiriGetir();

                for (int i = 0; i < 3; i++)
                {
                    if (mevcutSatir[i] == aktifKutu)
                    {
                        mevcutSatir[i + 1].Focus();
                        return;
                    }
                }
            }
        }

        private TextBox[] MevcutSatiriGetir()
        {
            switch (mevcutTahmin)
            {
                case 0: return new TextBox[] { txt1_1, txt1_2, txt1_3, txt1_4 };
                case 1: return new TextBox[] { txt2_1, txt2_2, txt2_3, txt2_4 };
                case 2: return new TextBox[] { txt3_1, txt3_2, txt3_3, txt3_4 };
                case 3: return new TextBox[] { txt4_1, txt4_2, txt4_3, txt4_4 };
                case 4: return new TextBox[] { txt5_1, txt5_2, txt5_3, txt5_4 };
                case 5: return new TextBox[] { txt6_1, txt6_2, txt6_3, txt6_4 };
                default: return new TextBox[] { txt1_1, txt1_2, txt1_3, txt1_4 };
            }
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            TahminiKontrolEt();
        }

        private void TahminiKontrolEt()
        {
            TextBox[] mevcutSatir = MevcutSatiriGetir();

            // Tüm kutular dolu mu diye kontrol edelim
            string tahmin = "";
            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(mevcutSatir[i].Text))
                {
                    MessageBox.Show("Lütfen 4 rakamı da girin!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tahmin += mevcutSatir[i].Text;
            }

            // Renklendirme - Wordle gibisinden
            bool[] kullanildi = new bool[4]; // gizli sayıdaki hangi rakamlar kullanıldı

            // Yeşil (doğru yer)
            for (int i = 0; i < 4; i++)
            {
                if (tahmin[i] == gizliSayi[i])
                {
                    mevcutSatir[i].BackColor = Color.FromArgb(106, 170, 100); // Yeşil
                    mevcutSatir[i].ForeColor = Color.White;
                    kullanildi[i] = true;
                }
            }

            // Sarı (yanlış yer) ve Gri (yok)
            for (int i = 0; i < 4; i++)
            {
                if (tahmin[i] != gizliSayi[i])
                {
                    bool bulundu = false;

                    // Sayı başka bir yerde var mı?
                    for (int j = 0; j < 4; j++)
                    {
                        if (!kullanildi[j] && tahmin[i] == gizliSayi[j])
                        {
                            mevcutSatir[i].BackColor = Color.FromArgb(201, 180, 88); // Sarı
                            mevcutSatir[i].ForeColor = Color.White;
                            kullanildi[j] = true;
                            bulundu = true;
                            break;
                        }
                    }

                    if (!bulundu)
                    {
                        mevcutSatir[i].BackColor = Color.FromArgb(120, 124, 126); // Gri
                        mevcutSatir[i].ForeColor = Color.White;
                    }
                }
            }

            // Kazandı mı?
            if (tahmin == gizliSayi)
            {
                MessageBox.Show($"Tebrikler! Sayıyı {mevcutTahmin + 1}. tahminde buldunuz!",
                    "Kazandınız!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YeniOyun();
                return;
            }

            // Mevcut satırı kilitle
            for (int i = 0; i < 4; i++)
            {
                mevcutSatir[i].ReadOnly = true;
            }

            mevcutTahmin++;

            // Hak bitti mi?
            if (mevcutTahmin >= MAKSIMUM_TAHMIN)
            {
                MessageBox.Show($"Üzgünüm, hakkınız bitti!\n\nDoğru Sayı: {gizliSayi}",
                    "Kaybettiniz!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YeniOyun();
                return;
            }

            // Yeni satırı aktif yap
            TextBox[] yeniSatir = MevcutSatiriGetir();
            for (int i = 0; i < 4; i++)
            {
                yeniSatir[i].ReadOnly = false;
            }

            lblDurum.Text = $"Tahmin {mevcutTahmin + 1} / {MAKSIMUM_TAHMIN}";
            yeniSatir[0].Focus();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeni oyun başlatmak istiyor musunuz?",
                "Yeni Oyun", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                YeniOyun();
            }
        }

        // SAYI TUŞLARI (1-9 ve Sil butonu)
        private void SayiTusu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string sayi = btn.Text;

            // Mevcut satırdaki ilk boş kutuyu bul ve sayıyı yaz
            TextBox[] mevcutSatir = MevcutSatiriGetir();

            for (int i = 0; i < 4; i++)
            {
                if (string.IsNullOrEmpty(mevcutSatir[i].Text))
                {
                    mevcutSatir[i].Text = sayi;

                    // Eğer son kutu değilse bir sonrakine geçiş yap
                    if (i < 3)
                    {
                        mevcutSatir[i + 1].Focus();
                    }
                    break;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TextBox[] mevcutSatir = MevcutSatiriGetir();

            // Son dolu kutuyu bul ve sil
            for (int i = 3; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(mevcutSatir[i].Text))
                {
                    mevcutSatir[i].Text = "";
                    mevcutSatir[i].Focus();
                    break;
                }
            }
        }
    }
}