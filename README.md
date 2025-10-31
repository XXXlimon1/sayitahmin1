<img width="815" height="489" alt="image" src="https://github.com/user-attachments/assets/1f9fb2db-757d-4ba1-8c98-2d15ede78b05" />

<img width="707" height="718" alt="image" src="https://github.com/user-attachments/assets/288be464-2f57-4a71-a136-c5e7fd3aaf3d" />


# 🎮 4 HANELİ SAYI TAHMİN OYUNU

C# Windows Forms ile geliştirilmiş iki farklı sayı tahmin oyunu projesi.

## 📋 İçindekiler
- [Oyunlar](#-oyunlar)
- [Kurulum](#-kurulum)
- [Nasıl Oynanır](#-nasıl-oynanır)
- [Teknik Detaylar](#-teknik-detaylar)
- [Kontrol Listesi](#-kontrol-listesi)

---

## 🎯 Oyunlar

### 1️⃣ SayıAvcısı (Klasik Mod)
- 4 haneli sayı tahmin oyunu
- **15 tahmin hakkı**
- **+/- sistemi ile geri bildirim**
  - **+** → Doğru yerde doğru rakam sayısı
  - **-** → Yanlış yerde doğru rakam sayısı
- Hangi rakamların nerede olduğu söylenmez

**Örnek:**
```
Gizli Sayı: 1234
Tahmin: 5124
Sonuç: +1, -2
Açıklama: 1 rakam doğru yerde, 2 rakam doğru ama yanlış yerde
```

---

### 2️⃣ NumWordle (Wordle Mod)
- 4 haneli sayı tahmin oyunu
- **6 tahmin hakkı**
- **Renkli kutularla geri bildirim (Wordle mantığı)**
  - 🟩 **Yeşil:** Doğru yerde doğru rakam
  - 🟨 **Sarı:** Yanlış yerde doğru rakam
  - ⬜ **Gri:** Bu rakam sayıda yok
- **Sayı tuş takımı** ile hızlı giriş
- Manuel klavye girişi de desteklenir

**Örnek:**
```
Gizli Sayı: 1234
Tahmin: 5124
Görünüm: 🟨🟩🟨🟩
```

---

## 💻 Kurulum

### Gereksinimler
- Visual Studio 2019 veya üzeri
- .NET Framework 4.7.2 veya üzeri
- Windows Forms desteği

### Adımlar

1. **Proje Oluştur**
   - Visual Studio'yu aç
   - `Create a new project` → `Windows Forms App (.NET Framework)`
   - Proje adı: `sayitahmin`
   - Namespace: `sayitahmin`

2. **Form'ları Ekle**
   - Solution Explorer → Sağ tık → `Add` → `Form (Windows Forms)`
   - 3 form ekle:
     - `MAINFORM.cs`
     - `SAYIAVCISIFORM.cs`
     - `NUMWORDLEFORM.cs`

3. **Kodları Yapıştır**
   - Her form için `.cs` dosyasına ilgili kodu yapıştır

4. **Başlangıç Formunu Ayarla**
   - `Program.cs` dosyasını aç
   - `Application.Run(new MAINFORM());` olarak değiştir

5. **Designer'da Kontrolleri Ekle**
   - Her form için aşağıdaki kontrol listesine göre tasarımı yap

---

## 🎮 Nasıl Oynanır

### Ana Menü
1. Uygulamayı çalıştır
2. İki oyundan birini seç:
   - **SayıAvcısı** → Klasik +/- sistemi
   - **NumWordle** → Renkli Wordle sistemi

### SayıAvcısı
1. "Yeni Oyun" butonuna tıkla
2. 4 haneli sayı gir (örn: 1234)
3. "Tahmin Et" butonuna tıkla veya Enter'a bas
4. Sonuçları değerlendir:
   - `+2` = 2 rakam doğru yerde
   - `-1` = 1 rakam doğru ama yanlış yerde
5. 15 tahmin içinde bulmaya çalış!

### NumWordle
1. "Yeni Oyun" butonuna tıkla
2. 4 rakam gir:
   - **Klavye ile** doğrudan yaz, VEYA
   - **Sayı butonlarına** tıkla (1-9)
3. "Tahmini Kontrol Et" butonuna tıkla
4. Renklere göre stratejini belirle
5. 6 tahmin içinde bulmaya çalış!

---

## 🛠️ Teknik Detaylar

### Algoritma: Wordle Mantığı

**Çift Sayma Önleme Sistemi:**
```csharp
// Örnek: Gizli 1234, Tahmin 5124

// 1. AŞAMA: Doğru yer (Yeşil/+)
bool[] gizliKullanildi = new bool[4];
bool[] tahminKullanildi = new bool[4];

for (int i = 0; i < 4; i++)
{
    if (tahmin[i] == gizliSayi[i])
    {
        dogruYer++;  // +1
        gizliKullanildi[i] = true;
        tahminKullanildi[i] = true;
    }
}
// Sonuç: +1 (4 doğru yerde)

// 2. AŞAMA: Yanlış yer (Sarı/-)
for (int i = 0; i < 4; i++)
{
    if (!tahminKullanildi[i])  // Henüz işlenmemiş rakamlar
    {
        for (int j = 0; j < 4; j++)
        {
            if (!gizliKullanildi[j] && tahmin[i] == gizliSayi[j])
            {
                yanlisYer++;  // -1
                gizliKullanildi[j] = true;
                break;
            }
        }
    }
}
// Sonuç: -2 (1 ve 2 yanlış yerde)

// Final: +1, -2
```

### Özellikler
- ✅ Tekrarlı rakamlar kabul edilir (1111, 2222 gibi)
- ✅ Her tahmin için bool dizileri yeniden oluşturulur
- ✅ Çift sayma sorunu yok
- ✅ Enter tuşu desteği
- ✅ Otomatik fokus geçişi (NumWordle'da)
- ✅ Input validasyonu (sadece rakam)

### Renk Kodları (NumWordle)
```csharp
Yeşil (Doğru Yer):  Color.FromArgb(106, 170, 100)
Sarı (Yanlış Yer):  Color.FromArgb(201, 180, 88)
Gri (Yok):          Color.FromArgb(120, 124, 126)
```

---

## 📋 Kontrol Listesi

### MAINFORM

**Kontrollar:**
- `btnSayiAvcisi` (Button) → Text: "SayıAvcısı"
- `btnNumWordle` (Button) → Text: "NumWordle"

**Event'ler:**
```csharp
btnSayiAvcisi.Click → btnSayiAvcisi_Click
btnNumWordle.Click → btnNumWordle_Click
```

---

### SAYIAVCISIFORM

**Kontrollar:**
1. `lblBaslik` (Label) → Text: "SayıAvcısı - Klasik Mod"
2. `lblKalanHak` (Label) → Text: "Kalan Hak: 15"
3. `txtTahmin` (TextBox) → MaxLength: 4
4. `btnTahminEt` (Button) → Text: "Tahmin Et"
5. `btnYeniOyun` (Button) → Text: "Yeni Oyun"
6. `lstTahminler` (ListBox) → Geçmiş tahminler için

**Event'ler:**
```csharp
txtTahmin.KeyPress → txtTahmin_KeyPress
btnTahminEt.Click → btnTahminEt_Click
btnYeniOyun.Click → btnYeniOyun_Click
```

**Örnek Çıktı:**
```
5124 → +1 (doğru yer), -2 (yanlış yer)
1523 → +2 (doğru yer), -1 (yanlış yer)
1234 → KAZANDINIZ! 🎉
```

---

### NUMWORDLEFORM

**Kontrollar:**

**Label'lar:**
- `lblBaslik` (Label) → Text: "NumWordle"
- `lblDurum` (Label) → Text: "4 basamaklı sayıyı tahmin et!"

**Butonlar:**
- `btnTahminEt` (Button) → Text: "Tahmini Kontrol Et"
- `btnYeniOyun` (Button) → Text: "Yeni Oyun"

**Sayı Tuş Takımı (10 buton):**
- `btn1`, `btn2`, `btn3`, `btn4`, `btn5`, `btn6`, `btn7`, `btn8`, `btn9`
  - Text: "1" - "9"
  - Size: 50x50 (önerim)
  - Font: Segoe UI, 16pt, Bold
- `btnSil`
  - Text: "⌫ Sil" veya "DEL"
  - Size: 110x50

**TextBox Grid (24 adet - 6 satır x 4 sütun):**

| Satır | TextBox İsimleri |
|-------|------------------|
| 1 | `txt1_1`, `txt1_2`, `txt1_3`, `txt1_4` |
| 2 | `txt2_1`, `txt2_2`, `txt2_3`, `txt2_4` |
| 3 | `txt3_1`, `txt3_2`, `txt3_3`, `txt3_4` |
| 4 | `txt4_1`, `txt4_2`, `txt4_3`, `txt4_4` |
| 5 | `txt5_1`, `txt5_2`, `txt5_3`, `txt5_4` |
| 6 | `txt6_1`, `txt6_2`, `txt6_3`, `txt6_4` |

**Tüm TextBox Özellikleri:**
- MaxLength: 1
- TextAlign: Center
- Font: Segoe UI, 24pt, Bold
- ReadOnly: true (başlangıçta)
- BackColor: White
- Size: 60x60

**Event'ler:**
```csharp
// Sadece 1. satır için (txt1_1, txt1_2, txt1_3, txt1_4):
txt1_1.KeyPress → Kutu_KeyPress
txt1_1.TextChanged → Kutu_TextChanged
txt1_2.KeyPress → Kutu_KeyPress
txt1_2.TextChanged → Kutu_TextChanged
txt1_3.KeyPress → Kutu_KeyPress
txt1_3.TextChanged → Kutu_TextChanged
txt1_4.KeyPress → Kutu_KeyPress
txt1_4.TextChanged → Kutu_TextChanged

// Butonlar:
btnTahminEt.Click → btnTahminEt_Click
btnYeniOyun.Click → btnYeniOyun_Click

// Sayı tuşları (HEPSİ AYNI EVENT):
btn1.Click → SayiTusu_Click
btn2.Click → SayiTusu_Click
btn3.Click → SayiTusu_Click
btn4.Click → SayiTusu_Click
btn5.Click → SayiTusu_Click
btn6.Click → SayiTusu_Click
btn7.Click → SayiTusu_Click
btn8.Click → SayiTusu_Click
btn9.Click → SayiTusu_Click

// Sil butonu:
btnSil.Click → btnSil_Click
```

**Sayı Tuş Takımı Düzen Önerileri:**

**Seçenek 1 (3x3 + Sil):**
```
[1] [2] [3]
[4] [5] [6]
[7] [8] [9]
[  ⌫ Sil  ]
```

**Seçenek 2 (2 satır):**
```
[1] [2] [3] [4] [5]
[6] [7] [8] [9] [⌫]
```

**Seçenek 3 (Tek satır - kompakt):**
```
[1][2][3][4][5][6][7][8][9][⌫]
```

---

## 🎨 Tasarım Önerileri

### Form Boyutları
- **MAINFORM:** 600x400
- **SAYIAVCISIFORM:** 500x600
- **NUMWORDLEFORM:** 450x750

### Font Önerileri
- **Başlıklar:** Segoe UI, 18-24pt, Bold
- **Normal metin:** Segoe UI, 10-12pt
- **TextBox (Wordle):** Segoe UI, 24pt, Bold
- **Butonlar:** Segoe UI, 12-16pt, Bold

### Renk Paleti
```
Yeşil:      #6AAA64 (106, 170, 100)
Sarı:       #C9B458 (201, 180, 88)
Gri:        #787C7E (120, 124, 126)
Açık Gri:   #D3D6DA (211, 214, 218)
Koyu Gri:   #878A8C (135, 138, 140)
Beyaz:      #FFFFFF (255, 255, 255)
```

---

## 🐛 Bilinen Sorunlar ve Çözümler

### Warning: "Non-nullable field must contain a non-null value"
**Çözüm:** Değişken tanımlarken başlangıç değeri ver:
```csharp
private string gizliSayi = "";  // Boş string ile başlat
```

### Problem: TextBox'a harf giriliyor
**Çözüm:** `KeyPress` eventinde kontrol var:
```csharp
if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
{
    e.Handled = true;
}
```

### Problem: NumWordle'da kutular renklenmedi
**Çözüm:** Event'leri kontrol et:
- İlk satır için `Kutu_KeyPress` ve `Kutu_TextChanged` bağlı mı?
- `btnTahminEt.Click` eventi bağlı mı?

---

## 📚 Öğrenilen Konseptler

### C# Konuları
- ✅ Windows Forms tasarımı
- ✅ Event handling (Click, KeyPress, TextChanged)
- ✅ String manipülasyonu
- ✅ Array ve bool dizileri
- ✅ For döngüleri ve algoritma mantığı
- ✅ Color kullanımı (RGB)
- ✅ MessageBox kullanımı
- ✅ Form'lar arası geçiş

### Algoritma Konseptleri
- ✅ Wordle mantığı (çift sayma önleme)
- ✅ Lokal vs Global değişkenler
- ✅ Boolean flag kullanımı
- ✅ İki aşamalı kontrol sistemi

---

## 🚀 Geliştirme Fikirleri

### Kolay Eklemeler
- [ ] Zorluk seviyesi (5 haneli, 6 haneli sayılar)
- [ ] Zamanlayıcı (kaç saniye sürdü)
- [ ] High score sistemi
- [ ] Ses efektleri
- [ ] Animasyonlar (kutular renklenirken)

### Orta Zorluk
- [ ] Veritabanı ile kayıt tutma
- [ ] İstatistikler (kazanma oranı, ortalama tahmin sayısı)
- [ ] Tema seçenekleri (dark mode)
- [ ] Çoklu dil desteği

### Zor Eklemeler
- [ ] Online multiplayer
- [ ] Günlük challenge sistemi (herkes aynı sayıyı tahmin eder)
- [ ] Liderlik tablosu
- [ ] Yapay zeka rakip

---

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

---

## 👨‍💻 Geliştirici Notları

### Önemli Dosyalar
```
sayitahmin/
├── MAINFORM.cs           # Ana menü
├── SAYIAVCISIFORM.cs     # Klasik mod
├── NUMWORDLEFORM.cs      # Wordle mod
└── Program.cs            # Başlangıç noktası
```

### Test Senaryoları

**SayıAvcısı Test:**
```
Gizli: 1234
Test 1: 1111 → +1, -0 (sadece 1 doğru yerde)
Test 2: 4321 → +0, -4 (hepsi yanlış yerde)
Test 3: 5678 → +0, -0 (hiçbiri yok)
Test 4: 1534 → +2, -1 (1 ve 4 doğru, 3 yanlış yerde)
Test 5: 1234 → KAZANDIN!
```

**NumWordle Test:**
```
Gizli: 1234
Test 1: 5124 → 🟨🟩🟨🟩
Test 2: 1523 → 🟩🟨🟨🟨
Test 3: 1234 → 🟩🟩🟩🟩 KAZANDIN!
```

---

## ❓ Sık Sorulan Sorular

**S: Tekrarlı rakamlar kabul ediliyor mu?**  
C: Evet! 1111, 2222, 5555 gibi sayılar hem gizli sayı hem de tahmin olarak geçerli.

**S: NumWordle'da klavye ile de yazabilir miyim?**  
C: Evet! Hem klavye hem de sayı butonları çalışıyor.

**S: İlk rakam 0 olabilir mi?**  
C: Hayır, 0234 gibi sayılar üretilmez. Sayılar 1000-9999 arasında.

**S: Her tahminde bool dizileri sıfırlanıyor mu?**  
C: Evet! Her `btnTahminEt_Click` çağrıldığında yeni diziler oluşturuluyor.

**S: Wordle mantığı nedir?**  
C: İki aşamalı kontrol: Önce doğru yerdekiler işaretlenir, sonra yanlış yerdekiler bulunur. Çift sayma önlenir.

---

## 📧 İletişim

Sorularınız için:
- GitHub Issues
- Pull Request'ler kabul edilir

---

**Son Güncelleme:** 2025  
**Versiyon:** 1.0  
**Dil:** C# (.NET Framework)  
**Platform:** Windows Forms

---

**🎮 İyi Oyunlar! 🎯**
