using Polimorfizm2;

Calisan c1= new Calisan();

Calisan c2 = new Memur();
Calisan c3 = new BilgiIslem();
GuvenlikGorevlisi c4 = new GuvenlikGorevlisi();



c1.Giris(1);
c2.Giris(2);
c3.Giris(3);
c4.Giris(5, true);

/****************************/


Akademisyen a1 = new Akademisyen();

Akademisyen a2 = new OgretimGorevlisi();
Akademisyen a3 = new Asistan();
Akademisyen a4 = new LabAsistani();


a1.derseGir();
a2.derseGir();
a3.derseGir();
a4.derseGir();
