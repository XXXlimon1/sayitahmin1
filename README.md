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
- ✅ Wordle mantığı
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

---

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

---

**Son Güncelleme:** 2025  
**Versiyon:** 1.0  
**Dil:** C# (.NET Framework)  
**Platform:** Windows Forms

---

**🎮 İyi Oyunlar! 🎯**
