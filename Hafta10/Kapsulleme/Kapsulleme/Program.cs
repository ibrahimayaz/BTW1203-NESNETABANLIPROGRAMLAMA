
using Kapsulleme;

Ogrenci o=new Ogrenci();

o.Ad = "Murat";
o.Soyad = "Yamanoğlu";
o.DogumTarihi = new DateTime(2002, 07, 21);



Urun u=new Urun();
u.Ad = "Iphone 14 Pro Max";
u.BirimFiyat = 100;
u.KdvOrani = 1.20;

Kullanici k= new Kullanici("Devran", "Erdemir", "Merhaba Dünya", "123");

Console.WriteLine(k.Sonuc);

