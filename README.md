# Note To Music (NTM)

Note To Music (NTM) ile nota şemalarını saniyeler içinde dinleyebilirsiniz. Proje hâlen geliştirme aşamasındadır — temel akış (görüntü seçme, Audiveris ile `.mxl` oluşturma ve `.mxl` içinden MusicXML çıkarma) çalışır, ancak bazı dönüşüm ve oynatma adımları hâlâ tamamlanmadı.

## Özet
- Proje adı: Note To Music (NTM)  
- Amaç: Nota şeması (görsel) → müzik (ses) dönüşümünü kolaylaştırmak ve kullanıcıya hızlı önizleme sağlamak.  
- Lisans: MIT

## Mevcut (İlk) Özellikler
- Grafik arayüz üzerinden nota görseli seçme (`.jpg`, `.jpeg`, `.png`, `.bmp`, `.gif`).
- SoundFont (`.sf2`) dosyası ekleme.
- Audiveris kullanarak seçilen görseli `.mxl` formatına dönüştürme (harici `Audiveris.exe` gerektirir).
- `.mxl` dosyasından MusicXML (`.xml` veya `.musicxml`) çıkartma.
- Uygulama çalışma dizininde otomatik olarak `Assets` ve alt klasörlerini (`Notes`, `Soundfonts`, `Musics`, `Temp`) oluşturma.
- GUI öğeleri ile seçilen nota/soundfont listesini görüntüleme ve seçimi değiştirme.

## Eksik / Yapılacaklar (Önemli)
- `.mxl` → `.mid` (MIDI) dönüşümü — (şu an yorum satırı halinde, uygulanmadı).
- `.mid` → `.wav` (veya gerçek zamanlı oynatma) dönüşümü SoundFont kullanılarak — (şu an uygulanmadı).
- Uygulama içi ses oynatma kontrolü (şu an sadece buton metin toggle'ı var).
- Daha iyi hata yönetimi, ilerleme göstergesi ve temp dosyalarının temizlenmesi.
- Çok sayfalı nota desteği, daha sağlam MusicXML işleme ve kullanıcı ayarları UI'sı.

## Gereksinimler
- Windows
- .NET Framework 4.7.2 (proje zaten bu hedef ile oluşturulmuş)
- Visual Studio (ör. __Solution Explorer__ üzerinden projeyi açıp derleyebilirsiniz)
- Audiveris kurulumu (Java tabanlı; `Audiveris.exe` projenin `audiverisPath` değişkeninde belirtilen yolda bulunmalı)
- Bir SoundFont (`.sf2`) dosyası (kendi SoundFont'ınızı ekleyin)
- (İleride) SoundFont ile MIDI → WAV dönüştürmesi için ör. `fluidsynth`, `TiMidity++` veya benzeri araçlar

## Kurulum & Çalıştırma
1. Çözümü Visual Studio'da açın.
2. Hedef framework ` .NET Framework 4.7.2` olduğundan emin olun.
3. `Form1.cs` içindeki varsayılan Audiveris yolu gerektiğinde güncelleyin:
   - Dosyada bulunan satır:  
     `string audiverisPath = @"C:\Program Files\Audiveris\Audiveris.exe";`  
     Kendi kurulum yolunuza göre düzenleyin.
4. Projeyi derleyin (__Build > Rebuild Solution__) ve çalıştırın (__Start Debugging__ veya F5).
5. Uygulama çalışınca:
   - `Assets\Notes` içine nota görseli ekleyebilir veya GUI'den `Resim Dosyaları` seçerek yükleyebilirsiniz.
   - `Assets\Soundfonts` içine `.sf2` dosyası ekleyin veya GUI'den seçin.
   - `Dönüştür!` butonuyla Audiveris adımını çalıştırın; elde edilen `.mxl` içinden MusicXML çıkartılır.

Not: Uygulama, çalışma dizininde (`bin\Debug` gibi) `Assets` klasörünü oluşturur.

## Kullanım İpuçları & Hata Giderme
- Audiveris bulunamazsa veya yanlış yol verilmişse `btnConvert` çalışmaz; `audiverisPath` değerini doğru yola ayarlayın.
- Oluşan `.mxl` dosyası `Assets\Temp` içinde yer alır. Eğer `.mxl` oluşmuyorsa Audiveris çıktısını ve kurulumunu kontrol edin.
- SoundFont ile gerçek ses üretme şu an uygulanmadığı için dönüştürme sonrası oynatma yapılmayabilir. Bu adım eklendiğinde `Assets\Musics` klasörüne ses dosyaları yazılacaktır.
- Eğer GUI resim gösterirken dosya kilitleniyorsa uygulama zaten mevcut resmi `Dispose()` ediyor; yine de dosya erişim hatalarında uygulamayı kapatıp deneyin.

## Geliştirici Notları
- Ana akış `Form1.cs` içinde implement edilmiş: seçme, kopyalama, Audiveris çağrısı (`ProcessStartInfo`) ve `.mxl` içinden XML çıkartma (`System.IO.Compression.ZipFile`) adımları var.
- Eksik dönüşümler için iki ana entegrasyon önerisi:
  - `.mxl` → `.mid`: Audiveris veya MuseScore komut satırı kullanılabilir.
  - `.mid` → `.wav`: `fluidsynth` gibi bir renderer ile `.sf2` uygulanarak WAV üretilebilir.
- İleride cross-platform veya servis tabanlı iş akışı düşünülürse Audiveris / conversion pipeline ayrı bir servis olarak taşınabilir.

## Katkıda Bulunma
- Açık kaynak: katkılar kabul edilir. Lütfen önce issue açın, daha sonra pull request gönderin.
- Kod stilini ve mevcut yapılandırmayı koruyun.

## Lisans
Bu proje MIT lisansı altında yayınlanmıştır. Detaylar için `LICENSE` dosyasına bakın.

---
Not: Proje hâlen tamamlanmamıştır — eksik dönüşüm ve oynatma adımları belirlendi ve yapılması gerekmektedir.