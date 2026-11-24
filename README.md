# Nesne Yönelimli Programlama – Ders Deposu

Bu depo, **Nesne Yönelimli Programlama** dersine ait ders materyallerini, sunumları, uygulama örneklerini ve laboratuvar çalışmalarını bir arada tutar. Depo iki ayrı ancak birbiriyle ilişkili içeriği kapsar:

- **Nesne Yönelimli Programlama (ders):** Ders notları, sunumlar ve konu bazlı uygulama örnekleri.
- **Nesne Yönelimli Programlama Lab (laboratuvar):** Haftalık laboratuvar çalışmaları ve laboratuvar föyleri.

Kodların çoğu **C#** ile yazılmıştır ve .NET çözüm/proje dosyaları (`.csproj`, `.slnx`) içerir.

## Klasör yapısı

```
github/
├── ders-notlari/    Ders notları (konu bazlı alt klasörler)
├── sunumlar/        Ders sunumları (PDF, numaralı sırayla)
├── uygulamalar/     Konu başına hazırlanmış örnek uygulamalar
├── labs/            Laboratuvar çalışmaları ve föyleri
└── README.md
```

### `ders-notlari/`

Ders notlarını konu adlarıyla alt klasörlerde tutar. Her konu, o konuya ait notları (ör. PDF) içerir.

| Alt klasör | İçerik |
| --- | --- |
| `procedural-programming/` | Prosedürel programlamaya ait ders notu (`prosedurel-programlama.pdf`). |

### `sunumlar/`

Derste kullanılan sunumlar, dosya adının başındaki numara ile işlenme sırasına göre adlandırılmıştır. Sunumlar PDF biçimindedir.

| Dosya | Konu |
| --- | --- |
| `01_tanitim.pdf` | Tanıtım |
| `02_csharp_giris.pdf` | C# giriş |
| `03_programciliga_giris.pdf` | Programcılığa giriş |
| `04_veri_turleri.pdf` | Veri türleri |
| `05_diziler_ve_donguler.pdf` | Diziler ve döngüler |
| `06_string_veri_yapisi.pdf` | String veri yapısı |
| `07_nesne_yonelimli_programlama.pdf` | Nesne yönelimli programlama |
| `08_nesne_yonelimli_programlama.pdf` | Nesne yönelimli programlama (devam) |
| `09_arayuz.pdf` | Arayüz |
| `10_soyut_siniflar.pdf` | Soyut sınıflar |
| `11_erisim_bildirgec_sistemi_ve_koleksiyonlar.pdf` | Erişim belirteçleri ve koleksiyonlar |
| `12_yapici_bloklar_deger_ve_referans_tipleri.pdf` | Yapıcı bloklar; değer ve referans tipleri |
| `13_koleksiyonlar.pdf` | Koleksiyonlar |
| `14_koleksiyonlar.pdf` | Koleksiyonlar (devam) |
| `15_hata_yonetimi.pdf` | Hata yönetimi |

### `uygulamalar/`

Derste işlenen kavramları gösteren, her biri bağımsız bir .NET projesi olan örnek uygulamaları içerir. Her proje kendi klasöründe bulunur ve `.csproj` dosyası ile çalıştırılabilir.

| Klasör | Kavram / amaç |
| --- | --- |
| `AbstractApp/` | Soyut sınıflar; `Heap` temel sınıfı ile `MinHeap` ve `MaxHeap` türevleri. Sınıf diyagramı: `Model.puml`. |
| `Library/` | Kütüphane öğeleri; `LibraryItem` temel sınıfı ile `Book` ve `DVD` türevleri. |
| `NumbersApp/` | `Number` ve `Employee` sınıfları. Sınıf diyagramları: `Number.puml`, `Employee.puml`. |
| `Vehicles/` | Araç hiyerarşisi; `Vehicle` temel sınıfı ve `Car` türevi. |

### `labs/`

Laboratuvar dersine ait çalışmalar `labs/YZM205/` altında toplanır.

| Klasör / dosya | İçerik |
| --- | --- |
| `Week1/` | 1. hafta laboratuvar çalışması. |
| `Week3/` | 3. hafta: `Student` ve `ClassReport` sınıfları. |
| `Week4/` | 4. hafta: `Author`, `BlogPost` ve `Message` sınıfları. |
| `Week5/` | 5. hafta: `Employee`, `Manager` ve `Developer` sınıfları. |
| `Week6/` | 6. hafta: `UniversityUnit`, `AcademicUnit` ve `AdministrativeUnit` sınıfları. |
| `YZM205_2026/` | Haftalık laboratuvar föyleri (PDF): 1, 3, 4, 5 ve 6. hafta. |
| `YZM205.slnx` | Haftalık projeleri bir arada açan çözüm dosyası. |

Not: 2. hafta için bu depoda ayrı bir klasör yoktur.

## Çalıştırma

1. Güncel bir Visual Studio sürümü veya .NET SDK kurulu olmalıdır. Çözüm dosyaları (`.slnx`) yeni Visual Studio sürümleri gerektirebilir.
2. Çalıştırmak istediğiniz projeyi `.csproj` dosyasından açın veya bir çözüm dosyası üzerinden açın.
3. Terminalden çalıştırmak için proje klasöründe `dotnet run` komutunu kullanın.

Derleme çıktıları (`bin/`, `obj/`) depoda tutulmaz; `.gitignore` dosyası bunları dışarıda bırakır.

## Katkı ve düzen kuralları

- Yeni bir konu eklerken ders notlarını `ders-notlari/` altında, sunumları `sunumlar/` altında numaralandırarak ekleyin.
- Yeni bir uygulama örneğini `uygulamalar/` altında kendi klasöründe oluşturun.
- Yeni bir laboratuvar haftası için `labs/YZM205/WeekN/` klasörünü açın ve çözüm dosyasına ekleyin.
