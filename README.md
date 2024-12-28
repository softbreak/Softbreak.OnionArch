# Softbreak.OnionArch

Youtube kanalımızda "Onion Mimari" serisi kapsamında anlatılan bu proje, katmanlı yazılım yapılarının en iyi uygulamalarını göstermek amacıyla hazırlanmıştır. Proje, modern yazılım geliştirme ilkelerini benimseyen ve anlaşılır bir şekilde organize edilmiş bir Onion mimarisi örneğidir.

## Proje Katmanları

Bu proje, Youtube kanalımızda "Onion Mimari" serisi kapsamında detaylı bir şekilde anlatılmaktadır. Her bölüm, farklı bir katman ve uygulama senaryosunu ele almaktadır. İlgili video bağlantılarını aşağıda bulabilirsiniz:

1. [Bölüm 1: Onion Mimari Nedir? Katmanlı Yazılım Yapıları](https://youtu.be/97vwRWysViE?si=IUvTKEyBMKiGdImu)
2. [Bölüm 2: Proje Oluşturma ve Uygulamalı Tasarım](https://youtu.be/evRBFPShuJA?si=fZw2dGB2sjq4_wt3)
3. [Bölüm 3: Contract Katmanından Somut Sınıflara Geçiş](https://youtu.be/_9FiqFQrw4A?si=-gFein7sM4ULSlLi)

💡 **Proje serisi Youtube kanalımızda güncellenmeye devam edecektir. Yeni bölümler için takipte kalın!**

### 1. Core (Çekirdek Katman)
- Bu katman, projenin iş mantığı ve temel kurallarını içerir.
- Bu katman aynı zamanda bağımlılıkları en aza indirerek, tüm sistemi merkezden yönetir.
- İçeriğinde veri modelleri (Entities) ve iş kurallarına yönelik soyutlamalar (Interfaces) bulunmaktadır.

### 2. Infrastructure (Altyapı Katmanı)
- Soyutlamaların implementasyonlarını içerir.
- Veritabanı işlemleri ve dış sistemlerle entegrasyonlar bu katmanda yer alır.

### 3. Presentation (Sunum Katmanı)
- Kullanıcı ile etkileşim kurulan katmandır.
- Web API, MVC veya diğer kullanıcı arayüzü araçları aracılığıyla Core ve Infrastructure katmanlarını kullanıcıya sunar.

### 4. Contract (Sözleşme Katmanı)
- Verilerin taşınmasını ve katmanlar arasındaki etkileşimi standart hale getirir.
- DTO’lar (Data Transfer Objects) ve diğer sözleşmeler burada yer alır.

## Gereksinimler
Projenin çalıştırılabilmesi için aşağıdaki araçların yüklü olması gerekmektedir:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio veya Visual Studio Code
- MSSQL Server (Veritabanı bağlantısı için)



## İletişim

- Video Çalma Listesi: [Onion Mimari Serisi](https://www.youtube.com/watch?v=evRBFPShuJA&list=PLDSvesNxEuJNJNMidHT68yrjRfAhLsQxb)
Proje hakkında sorularınız veya geri bildirimleriniz için bizimle iletişime geçebilirsiniz:

- YouTube Kanalı: [Softbreak](https://www.youtube.com/softbreak)
- Discord Sunucusu: [Softbreak Discord](https://discord.com/invite/tkZBnuba8h)
- Email: [info@softbreak.net](mailto:info@softbreak.net)
