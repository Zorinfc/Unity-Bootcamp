# Unity-Bootcamp
Bootcamp Ödevi


Eksikler
========================================================================================

* Playerın coinleri topladığında particle çıkıyor ama hiçbir zaman durmuyordu. OnAwake tikini kapattım ve doğru şekilde çalışıyor sadece oynayan için görünür değil particle'lar. 
* Platformları oluşturduğum birim kareler arasında boşluk bırakmadan zemin oluşturmaya çalıştım ama oyun içerisinde aralarında boşluklar var, ayrıca sahnedeki rampa olarak yaptığım bir platformda 1 tane birim kare oyun ekranında görünmez oluyor. Sorunu çözemedim.
* Coin toplandığında coin opjelerini destroy ediyorum ve ardından "CoinCount" adlı değişkeni arttırmayı deniyorum. 0'dan 1'e çıkıyor ama daha ileri gitmiyor.
* Karakterin yürürken çıkarması gereken toz particle'ını yaptım, karakter havadayken particle yok. Ancak bazı rampalardan sağ veya sol hareketini gerçekleştirirken uçar ise; karakterim toz particle'ını yine gerçekleştiriyor.
* Zıplama sınırsız. Kapatmayı nasıl yapacağımı çözemedim açıkcası .
* Karakter platformdan aşağı düştüğünde respawn pozisyonuna gönderen bi collider ve script ekledim. Fakat bi ölüm ekranı eklemedim.
* Spike eklemedim.


Yaptıklarım
========================================================================================

* Karaktere farklı bir kod ile hareket etme özelliği ve ayrıca zıplama gücü verdim.
* Karaktere ve coinlere animasyon verdim. Karakter hareket yönüne göre x eksenine göre rotate oluyor. 
* Karakterde kullanılan spritelar az sayıda olduğu için zıplama animasyonu ile yürüme animasyonu pek seçilemiyor.
* Platform oluşturuken ilerde işime yarayacağını düşündüğüm bazı prefablar oluşturdum. (rampa, zıplanabilir platform vs. )
* Google'dan arayarak oyuncuyu takip eden kamera scripti buldum ve ekledim.


Hedefler
========================================================================================
* Hareket eden platformlar.
* Platformlarımı tilemaps kullanarak yeniden düzenlemeyi düşünüyorum.
* Parallax efekti ile arka planın daha göze güzel gelmesini sağlamayı hedefliyorum. 
* İleri geri hareket edebilen ve karakterimize temas ettiğinde hasar veren objeler. 
* Karaktere bi can hakkı ve altın dışında toplanabilen can değeri-nesnesi.
* Coinlerin değerlerine göre erişilebilirliğinin daha zor ayarlanması.
* Farklı seviyeler ve farklı atmosferler. Kısacası yeni sahneler oluşturup bitiş bayrağını triggerlediğimde yeni sahneye geçiş yapma 
* Karakterin düşmanlara karşı hasar verebilme yeteneği.(Mario'daki gibi üstüne temas ettiğinde düşmanların ölmesi.)
* Yine mario oyununda olduğu gibi bir tuşa bastığımızda ateş topu yollamak.
*  Slow motion kullanmayı istiyorum ve buna özel bir level yapmayı düşünüyorum. (Veya toplanan altınlarla belli bir süreliğine slowmo yapabilme özelliği)
