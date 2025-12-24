# Note To Music - Inno Setup Kurulum Paketi Oluşturma Rehberi

## 📋 İçindekiler
1. [Gereksinimler](#gereksinimler)
2. [Adım Adım Kurulum](#adım-adım-kurulum)
3. [Setup Oluşturma](#setup-oluşturma)
4. [GitHub'da Yayınlama](#githubda-yayınlama)
5. [Sorun Giderme](#sorun-giderme)

---

## Gereksinimler

### 1. Inno Setup Kurulumu
1. [Inno Setup indirme sayfasına](https://jrsoftware.org/isdl.php) gidin
2. **"Inno Setup 6.x.x"** versiyonunu indirin (ücretsiz)
3. İndirdiğiniz dosyayı çalıştırarak kurun
4. Kurulum sırasında varsayılan ayarları kabul edin

### 2. .NET 8.0 Runtime
- Projeniz .NET 8.0 kullandığı için hedef bilgisayarlarda bu runtime bulunmalıdır
- Kullanıcılarınıza [.NET 8.0 Runtime](https://dotnet.microsoft.com/download/dotnet/8.0) indirmelerini söyleyebilirsiniz
- VEYA installer içine dahil edebilirsiniz (daha büyük dosya boyutu)

---

## Adım Adım Kurulum

### Adım 1: Projenizi Release Modunda Derleyin

**Visual Studio'da:**
1. Visual Studio'da projeyi açın
2. Üst menüden **Build > Configuration Manager** seçin
3. Active solution configuration'ı **Debug** yerine **Release** yapın
4. **Build > Rebuild Solution** (veya **Ctrl+Shift+B**)
5. Derleme tamamlandığında `bin\Release\net8.0-windows\` klasöründe dosyalar oluşacak

**PowerShell ile:**
```powershell
cd "c:\Users\morgensonne\OneDrive\Belgeler\Software\Visual Studio Projects\NTM2"
dotnet build -c Release
```

### Adım 2: Icon Dosyası Ekleyin (Opsiyonel ama Önerilen)

Eğer projenizde bir icon dosyanız varsa:
1. `icon.ico` dosyasını `NoteToMusic` klasörüne kopyalayın
2. Yoksa, icon satırını Inno Setup scriptinden kaldırın (`NoteToMusic-Setup.iss` dosyasında):
   - Şu satırı silin veya başına `;` ekleyin:
   ```
   ;SetupIconFile=NoteToMusic\icon.ico
   ```

### Adım 3: GUID Oluşturun

Inno Setup script'inde benzersiz bir GUID gerekli:

1. Inno Setup Compiler'ı açın
2. **Tools > Generate GUID** seçin
3. Oluşan GUID'i kopyalayın
4. `NoteToMusic-Setup.iss` dosyasını bir metin editöründe açın
5. `AppId={{YOUR-GUID-HERE}}` satırını bulun ve GUID'i yapıştırın
   ```
   AppId={{12345678-1234-1234-1234-123456789012}}
   ```

### Adım 4: Kişisel Bilgilerinizi Güncelleyin

`NoteToMusic-Setup.iss` dosyasında şu satırları düzenleyin:

```pascal
#define MyAppPublisher "Your Name"  ← Adınızı yazın
#define MyAppURL "https://github.com/yigitemrertn/NTM2"  ← Doğru mu kontrol edin
```

---

## Setup Oluşturma

### Yöntem 1: Inno Setup Compiler ile (Önerilen - Kolay)

1. **Inno Setup Compiler**'ı açın
2. **File > Open** ile `NoteToMusic-Setup.iss` dosyasını açın
3. **Build > Compile** (veya **Ctrl+F9**) tıklayın
4. Derleme başarılı olursa `Setup` klasöründe **`NoteToMusic-Setup-v1.0.0.exe`** oluşur
5. Bu `.exe` dosyası kurulum dosyanızdır!

### Yöntem 2: Komut Satırı ile

```powershell
cd "c:\Users\morgensonne\OneDrive\Belgeler\Software\Visual Studio Projects\NTM2"
& "C:\Program Files (x86)\Inno Setup 6\ISCC.exe" "NoteToMusic-Setup.iss"
```

---

## GitHub'da Yayınlama

### 1. GitHub Release Oluşturma

1. GitHub repository'nize gidin: https://github.com/yigitemrertn/NTM2
2. **Releases** sekmesine tıklayın (sağ tarafta)
3. **"Draft a new release"** butonuna tıklayın
4. **Tag version** girin: `v1.0.0`
5. **Release title** girin: `Note To Music v1.0.0 - İlk Sürüm`
6. **Description** alanına şunları yazın:

```markdown
## 🎵 Note To Music v1.0.0 - İlk Sürüm

### 📥 Kurulum
1. Aşağıdan `NoteToMusic-Setup-v1.0.0.exe` dosyasını indirin
2. İndirilen dosyayı çalıştırın ve kurulum talimatlarını takip edin
3. **Gereksinim:** [.NET 8.0 Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)

### ✨ Özellikler
- Nota şeması (görsel) → müzik (ses) dönüşümü
- SoundFont (.sf2) desteği
- Audiveris entegrasyonu
- Kullanıcı dostu arayüz

### 📖 Dokümantasyon
Kullanım talimatları için [README.md](https://github.com/yigitemrertn/NTM2/blob/main/README.md) dosyasına bakın.

### 🐛 Bilinen Sorunlar
- Audiveris'in sisteminizde kurulu olması gerekir
- .NET 8.0 Runtime gereklidir
```

7. **Attach binaries** kısmına sürükleyerek dosyaları ekleyin:
   - `Setup\NoteToMusic-Setup-v1.0.0.exe` (kurulum dosyası)
   - İsteğe bağlı: `Setup\NoteToMusic-Setup-v1.0.0.exe` yanında bir `.zip` versiyonu da ekleyebilirsiniz

8. **Publish release** butonuna tıklayın

### 2. README.md Güncelleme

GitHub'daki `README.md` dosyanıza şu bölümü ekleyin:

```markdown
## 📥 İndirme ve Kurulum

### Kolay Kurulum (Önerilen)
1. [En son sürümü indirin](https://github.com/yigitemrertn/NTM2/releases/latest)
2. `NoteToMusic-Setup-v1.0.0.exe` dosyasını çalıştırın
3. Kurulum sihirbazını takip edin
4. Masaüstü kısayolundan uygulamayı başlatın

### Gereksinimler
- Windows 10 veya üzeri
- [.NET 8.0 Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Audiveris](https://github.com/Audiveris/audiveris) (nota tanıma için)

### Geliştiriciler için
Kaynak koddan derlemek için [Kurulum & Çalıştırma](#kurulum--çalıştırma) bölümüne bakın.
```

---

## Sorun Giderme

### ❌ "File not found" hatası
**Sorun:** `NoteToMusic.exe` bulunamıyor  
**Çözüm:** 
- Projenin Release modunda derlendiğinden emin olun
- `bin\Release\net8.0-windows\` klasörünü kontrol edin
- Klasör yolu script'te doğru mu kontrol edin

### ❌ Icon hatası
**Sorun:** `icon.ico` bulunamıyor  
**Çözüm:**
- Icon dosyasını ekleyin VEYA
- Script'te icon satırını yorum satırı yapın:
  ```
  ;SetupIconFile=NoteToMusic\icon.ico
  ```

### ❌ DLL eksik
**Sorun:** Kurulum sonrası uygulama çalışmıyor  
**Çözüm:**
- Tüm `.dll` dosyalarının kopyalandığından emin olun
- `runtimeconfig.json` ve `deps.json` dosyalarını da ekleyin
- Self-contained publish kullanın:
  ```powershell
  dotnet publish -c Release --self-contained true -r win-x64
  ```

### ❌ .NET Runtime hatası
**Sorun:** Kullanıcı bilgisayarında .NET 8.0 yok  
**Çözüm:**
- README'de .NET 8.0 Runtime gereksinimini belirtin
- VEYA self-contained build yapın (daha büyük dosya)

---

## 🎯 Hızlı Başlangıç Özeti

```powershell
# 1. Projeyi Release modunda derle
cd "c:\Users\morgensonne\OneDrive\Belgeler\Software\Visual Studio Projects\NTM2"
dotnet build -c Release

# 2. Inno Setup'ı indir ve kur
# https://jrsoftware.org/isdl.php

# 3. GUID ekle ve bilgileri güncelle
# NoteToMusic-Setup.iss dosyasını düzenle

# 4. Setup'ı derle
& "C:\Program Files (x86)\Inno Setup 6\ISCC.exe" "NoteToMusic-Setup.iss"

# 5. Setup\NoteToMusic-Setup-v1.0.0.exe dosyası oluştu!
# GitHub'da Release oluştur ve bu dosyayı yükle
```

---

## 📚 Ek Kaynaklar

- [Inno Setup Dokümantasyonu](https://jrsoftware.org/ishelp/)
- [GitHub Releases Rehberi](https://docs.github.com/en/repositories/releasing-projects-on-github/managing-releases-in-a-repository)
- [.NET Deployment Guide](https://docs.microsoft.com/en-us/dotnet/core/deploying/)

---

## 💡 Pro İpuçları

1. **Versiyon Numarası:** Her sürümde version numarasını artırın (`1.0.0` → `1.0.1`)
2. **Changelog:** Her release'de değişiklikleri listeleyin
3. **Test:** Setup'ı farklı Windows sürümlerinde test edin
4. **İmzalama:** Güvenilirlik için setup'ı code signing sertifikası ile imzalayın
5. **Otomatik Güncelleme:** İleride otomatik güncelleme sistemi ekleyebilirsiniz
