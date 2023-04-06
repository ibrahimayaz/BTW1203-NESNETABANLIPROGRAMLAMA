// See https://aka.ms/new-console-template for more information

/*------------METHOD(METOD)FONKSİYONLAR----------------*/
// Normal () paranteziler ile  fonksiyon tanımı yapılır.
/***
Fonksiyon tanımlama
donuşTipi fonsiyonAdi(){
    kod bloğu
}
**/


// static void MyMethod() 
//   {
//     Console.WriteLine("Test");
//   }

//Fonksiyon çağırma/çalıştırma
//Bir fonksiyon tanımlandıktan sonra çağrılmadığı sürece çalışmaz!!!
// MyMethod();

//void: değer döndermeyen manasındadır. void varsa kod bloğunda return olmaz !
//Zorunlu parametreli fonksiyondur. iki parametresi vardır.
// static void Toplam(int x, int y){
//             Console.WriteLine(x+y);
// }

//  Toplam(5,10);
// Toplam(25,100);


//Varsayılan opsiyonel parametreli fonksiyondur. 
// static void Ulkeler(string ulke="Türkiye"){
//     Console.WriteLine(ulke);
// }

// Ulkeler("Almanya");

//Değer dönderen fonksiyon
//double tipinde değer dönderen tek zorunlu parametreli fonksiyondur.
// static double Karekok(int sayi){
// return Math.Sqrt(sayi);
// }

//  Console.WriteLine(Karekok(49));

static bool KimseVarmi(string isim){
    if(isim.ToLower()=="mehmet"){
        return true;
    }
    else{
        return false;
    }
}

// Console.WriteLine(KimseVarmi("Mehmet"));
// Console.WriteLine(KimseVarmi("AHmet"));
// Console.WriteLine(KimseVarmi("Murat"));

//İsimli parametreli fonksiyonlar
//Eğer parametreli isimli bir şekilde çağırmak isterseniz tüm paramatrelerin isimlerinin girilmesi gerekir.
//İsimli parametreli fonksiyonlar çağrılırken sırasız bir şekilde yazılabilir.
static int Hesapla(int x, int y, int z){
    return x+y+z;
}

Hesapla(z:5,y:7,x:6);