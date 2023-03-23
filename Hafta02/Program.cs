// VERİ TİPLERİ

//Sayısal veri tipleri
// int, double, decimal, float, long, byte

// veriTipi degiskenAdi=alcağı_değer;

// Değişken Tanımlama Kuralları
/*
- değişken ismi türkçe karakter içermemelidir.
- değişken adı özel karakter ve boşluk içermemelidir. (_ alt tire hariç)
- değişken adı c# özel ifadeleri içermemelidir.
- değişken adı sayısal ifadelerle başlamamalıdır.
- aynı isimde iki değişken olmamalıdır. Büyük küçük harf duyarlılığı vardır.
*/

//tam sayı değişkeni tanımlama
//camelCase
int tamSayi = 5;


//Ondalıklı sayı için
double ondalikliSayi = 5.0;
float ondalikliSayi2 = 5F;
decimal ondalikliSayi3 = 5M;

//0-255 arasındaki sayıları kabul eder
byte kucukSayi = 255;

//tek karakterlik veri tipi
char karakter = 'E';

//metinsel veri tipi

string ad = "Ahmet5";
string soyad = "YILMAZZ";



string sonuc = tamSayi.ToString() + " " + ad + " " + soyad;


//String Interpolation
string sonuc2 = $"{tamSayi} {ad} {soyad}";
string sonuc3 = $"{2+3} {ad} {soyad}";


//Doğru/yanlış, 0/1 veya true/false gibi değerlere denk gelen veri tipi
bool dogruMu = true;
bool isBlock = false;


object kimseVarMi = true;
object mesaj = "Hello World";

//Eşitiliğin sağındaki değere göre veri tipini belirler.
var sayilar = 5;
var cinsiyet = 'E';

//PascalCase
//Mantıksal Operatörler
// || -- veya operatörü
// && --ve operatörü
// ! --değil

int tamSayi2=25;
tamSayi2=30;

const int yas=18;
const string cevap="Merhaba";

// Console.WriteLine(yas);
if (yas>30)
{
    Console.WriteLine("Yaşım 30dan büyüktür");
}
else if (yas>45)
{
    Console.WriteLine("Yaşım 45den büyüktür");
}
else if (yas<=18)
{
    // True && False => False
    // True || False => True
    // !True => False
    // !False=> True
    // !True || False = False || False => False
    if(!(yas>15) || (yas<18)){       
        Console.WriteLine(string.Concat(yas,tamSayi2));
    }
}
else
{
    Console.WriteLine("Diğer");
}

if(yas<25){
Console.WriteLine("Diğer");
}
