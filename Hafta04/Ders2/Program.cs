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

// Toplam(5,10);
// Toplam(25,100);


//Varsayılan parametreli fonksiyondur. Aynı zamanda opsiyonel parametreli fonksiyondur.
// static void Ulkeler(string ulke="Türkiye"){
//     Console.WriteLine(ulke);
// }

//double tipinde değer dönderen tek zorunlu parametreli fonksiyondur.
// static double Karekok(int sayi){
// return Math.Sqrt(sayi);
// }

// Console.WriteLine(Karekok(49));

static bool KimseVarmi(string isim){
    if(isim.ToLower()=="mehmet"){
        return true;
    }
    else{
        return false;
    }
}

Console.WriteLine(KimseVarmi("Mehmets"));