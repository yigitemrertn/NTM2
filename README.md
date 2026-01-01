# 🎵 Note To Music (NTM2)

**Nota görsellerini saniyeler içinde müziğe dönüştürün!**

Note To Music, nota şemalarını (PDF, resim vb.) otomatik olarak tanıyıp MIDI ve WAV formatına çeviren, oynatmanıza ve yönetmenize olanak sağlayan bir Windows masaüstü uygulamasıdır.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)

---

## ✨ Özellikler

### 🎼 Temel Özellikler
- **Nota Tanıma:** Görsel nota dosyalarını (`.jpg`, `.png`, `.pdf`, `.bmp` vb.) otomatik olarak tanıma (Audiveris entegrasyonu)
- **Çoklu Dönüşüm:**
  - Görsel → MusicXML (`.mxl`)
  - MusicXML → MIDI (`.mid`)
  - MIDI + SoundFont → WAV (`.wav`)
- **Ses Oynatma:** Oluşturulan müzik dosyalarını uygulama içinde oynatma
- **SoundFont Desteği:** `.sf2` ve `.sf3` dosyalarıyla zengin ses kitaplığı kullanımı
- **BPM Ayarlama:** Tempo kontrolü ile müzik hızını ayarlama

### 🌐 Online Özellikler
- **IMSLP Entegrasyonu:** Ücretsiz klasik müzik notaları için online arama ve erişim
- **Online SoundFont Kaynakları:** Popüler SoundFont sitelerine (MuseScore, Musical Artifacts) kolay erişim
- **Feedback Sistemi:** Kullanıcı geri bildirimleri ve öneriler (Supabase backend)

### 🎨 Kullanıcı Arayüzü
- Modern, kullanıcı dostu Windows Forms arayüzü
- Canlı arama/filtreleme (nota ve SoundFont listeleri)
- Zaman çubuğu ve ses seviyesi kontrolü
- Sürükle-bırak dosya ekleme desteği

### 👨‍💼 Yönetim
- Login sistemi
- Admin paneli (Ctrl + Shift + A)
- Kullanıcı geri bildirimlerini görüntüleme ve yönetme

---

## 📥 İndirme ve Kurulum

### 🚀 Son Kullanıcılar İçin (Önerilen)

1. [**Releases sayfasından**](https://github.com/yigitemrertn/NTM2/releases/latest) en son sürümü indirin
2. `NoteToMusic-Setup-v1.0.2.exe` dosyasını çalıştırın (~185 MB)
3. Kurulum sihirbazını takip edin
4. Masaüstü veya Başlat menüsünden uygulamayı başlatın

**Sistem Gereksinimleri:**
- Windows 10/11 (64-bit)
- ~~.NET 8.0 Runtime~~ **Dahil! Ek kurulum gerekmez**
- ~~Audiveris~~ **Dahil! Otomatik kullanıma hazır**
- En az 4 GB RAM
- 500 MB boş disk alanı

---

## 🛠️ Geliştiriciler İçin

### Gereksinimler
- Windows 10/11
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 veya üzeri (Community Edition yeterli)
- [Audiveris](https://github.com/Audiveris/audiveris/releases) kurulumu
- Git

### Kurulum

```bash
# Repository'yi klonlayın
git clone https://github.com/yigitemrertn/NTM2.git
cd NTM2

# Visual Studio ile açın
start NoteToMusic.slnx

# VEYA komut satırından derleyin
dotnet build -c Release
```

### Proje Yapısı

```
NoteToMusic/
├── Forms/              # Windows Forms (UI)
│   ├── FrmMain.cs      # Ana ekran
│   ├── FrmLogin.cs     # Giriş ekranı
│   ├── FrmAdmin.cs     # Admin paneli
│   ├── FrmBpm.cs       # BPM ayarlama
│   ├── FrmFeedback.cs  # Geri bildirim
│   ├── FrmOnlineNotes.cs      # IMSLP arama
│   └── FrmOnlineSoundFonts.cs # SoundFont kaynakları
├── Services/           # İş mantığı servisleri
│   ├── SAudiveris.cs   # Audiveris entegrasyonu
│   ├── SNaudio.cs      # MIDI işlemleri
│   ├── SMeltySynth.cs  # MIDI → WAV dönüşümü
│   ├── SImslp.cs       # IMSLP API
│   ├── SSoundFontCdn.cs # SoundFont kaynakları
│   ├── SFeedback.cs    # Feedback yönetimi
│   └── SupabaseClient.cs # Database bağlantısı
├── Entities/           # Veri modelleri
├── Helpers/            # Yardımcı sınıflar
└── Interfaces/         # Service arayüzleri
```

### Bağımlılıklar

Proje aşağıdaki NuGet paketlerini kullanır:

- **NAudio** `2.2.1` - Ses işleme ve MIDI operasyonları
- **MeltySynth** `2.4.1` - SoundFont tabanlı MIDI sentezleme (SF2 desteği)
- **Newtonsoft.Json** `13.0.3` - JSON işleme
- **EPPlus** `7.0.5` - Excel operasyonları (Admin paneli)
- **System.Configuration.ConfigurationManager** `8.0.0` - Ayarlar yönetimi
- **Supabase** - Backend (feedback sistemi için)

### Ayarlar (app.config)

İlk çalıştırmada `App.config` dosyasında aşağıdaki ayarları yapılandırmanız gerekebilir:

```xml
<appSettings>
    <add key="AudiverisPath" value="C:\Program Files\Audiveris\Audiveris.exe"/>
    <!-- Diğer ayarlar otomatik yönetilir -->
</appSettings>
```

**Not:** Audiveris yolu ilk çalıştırmada uygulama tarafından sorulur ve otomatik kaydedilir.

---

## 📖 Kullanım

### Temel Kullanım

1. **Nota Ekleme:**
   - "Nota Ekle" butonuna tıklayın veya dosyayı sürükleyip bırakın
   - Desteklenen formatlar: `.jpg`, `.png`, `.pdf`, `.bmp`, `.gif`

2. **SoundFont Seçme:**
   - "SoundFont Ekle" butonuyla `.sf2` veya `.sf3` dosyası ekleyin
   - VEYA "Online SoundFonts" ile internet üzerinden indirin

3. **Dönüştürme:**
   - Listeden bir nota seçin
   - "Dönüştür" butonuna tıklayın
   - İşlem: Görsel → MusicXML → MIDI → WAV

4. **Oynatma:**
   - Oluşan müzik dosyasını seçin
   - Play/Pause butonuyla kontrolü sağlayın
   - Zaman çubuğu ve ses seviyesini ayarlayın

### Online Özellikler

#### IMSLP Nota Arama
- "Online Notalar" butonuna tıklayın
- Besteci veya eser adını arayın
- IMSLP sitesinde açın ve indirin

#### SoundFont Kaynakları
- "Online SoundFonts" butonuna tıklayın
- Önerilen kaynaklara (MuseScore, Musical Artifacts, Archive.org) göz atın
- İndirdiğiniz `.sf2` dosyalarını "SoundFont Ekle" ile projeye dahil edin

### Kısayollar

- **Ctrl + Shift + A:** Admin paneli (şifre gerekli)
- **Arama kutuları:** Canlı filtreleme
- **Enter:** Seçili öğeyi oyna

---

## 🔧 Sorun Giderme

### Audiveris Bulunamadı
**Sorun:** "Audiveris path'i bulunamadı" hatası  
**Çözüm:** 
1. [Audiveris'i indirin](https://github.com/Audiveris/audiveris/releases)
2. Uygulama sizden yolu istediğinde `Audiveris.exe` dosyasını seçin
3. Ayarlar otomatik kaydedilir

### .NET Runtime Hatası
**Sorun:** "You must install .NET to run this application"  
**Çözüm:** [.NET 8.0 Runtime'ı indirin](https://dotnet.microsoft.com/download/dotnet/8.0)

### Ses Çıkmıyor
**Sorun:** Oynatma başlatıldığında ses yok  
**Çözüm:**
- Geçerli bir `.wav` dosyası seçtiğinizden emin olun
- Ses seviyesi kontrolünü kontrol edin
- Windows ses ayarlarını kontrol edin

### Dönüştürme Başarısız
**Sorun:** Görsel dosya dönüştürülemiyor  
**Çözüm:**
- Nota görselinin kaliteli ve net olduğundan emin olun
- PDF dosyaları için önce görsel formatına çevirin
- Audiveris'in doğru kurulduğunu kontrol edin

### BPM Değişmiyor
**Sorun:** Tempo ayarı uygulanmıyor  
**Çözüm:**
- Dönüştürmeden ÖNCE BPM butonuyla tempoyu ayarlayın
- Varsayılan değer 90 BPM'dir

---

## 🧩 Teknoloji Stack

- **Framework:** .NET 8.0 (Windows Forms)
- **Nota Tanıma:** [Audiveris](https://github.com/Audiveris/audiveris) 5.3+
- **MIDI İşleme:** NAudio
- **Sentezleme:** MeltySynth (SoundFont renderer)
- **Backend:** Supabase (optional, feedback için)
- **Lisans:** MIT

---

## 🤝 Katkıda Bulunma

Katkılarınızı memnuniyetle karşılıyoruz! 

1. **Fork** edin
2. Feature branch oluşturun (`git checkout -b feature/harika-ozellik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Harika özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/harika-ozellik`)
5. **Pull Request** açın

### Geliştirme Kuralları
- Kod stilini koruyun (C# standartları)
- Yorum satırlarını Türkçe yazın
- Her servis için interface kullanın
- Exception handling yapın

---

## 📄 Lisans

Bu proje MIT lisansı altında yayınlanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

---

## 👨‍💻 Geliştirici

**Yiğit Emre ERTEN**
- GitHub: [@yigitemrertn](https://github.com/yigitemrertn)

---

## 🙏 Teşekkürler

- [Audiveris](https://github.com/Audiveris/audiveris) - OMR (Optical Music Recognition) motoru
- [NAudio](https://github.com/naudio/NAudio) - Ses ve MIDI kütüphanesi
- [MeltySynth](https://github.com/sinshu/meltysynth) - SoundFont synthesizer
- [IMSLP](https://imslp.org) - Ücretsiz nota kütüphanesi
- [MuseScore](https://musescore.org) - SoundFont kaynakları

---

## 📸 Ekran Görüntüleri

*Ekran görüntüleri yakında eklenecek...*

---

## 🗺️ Yol Haritası

- [ ] PDF desteğinin iyileştirilmesi
- [ ] Çoklu sayfa desteği
- [ ] Batch (toplu) dönüştürme
- [ ] Cloud sync özellikleri
- [ ] Mobil uygulama (PWA)
- [ ] VST plugin desteği
- [ ] Daha fazla dil desteği

---

**Not:** Proje aktif geliştirme aşamasındadır. Sorunlar ve öneriler için [Issues](https://github.com/yigitemrertn/NTM2/issues) sayfasını kullanabilirsiniz.