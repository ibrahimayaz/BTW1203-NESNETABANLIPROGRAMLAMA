// Tip Dönüşümleri

int tamSayi = 5;

double ondalikli=5.0;

string sayi="5";

string kimseVarMi="true";


// int >> string dönüştürme
string deneme1=tamSayi.ToString();

// double >> int dönüştürme
int sayi2=Convert.ToInt32(ondalikli);
int sayi3=(int)(ondalikli);

// int>> double dönüştürme
double sayi4=Convert.ToDouble(sayi2);

// string >> int dönüştürme
int sayi5=Convert.ToInt32(sayi);

//string >> bool dönüştürme
bool kimseYokMu=bool.Parse(kimseVarMi);
bool kimseYokmu=Convert.ToBoolean(kimseVarMi);

//Ekrana yazı yazdırma
//Console.WriteLine("Kullanıcı Adınızı Giriniz: ");

//Kullanıcıdan veri girişi yapılmasını isteme
// string userName=Console.ReadLine();
// Console.WriteLine($"Kullanıcı Adınız: {userName}");

//Console.WriteLine("Yaşınızı Giriniz: ");
//int age=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Yaşınız : {age}");

//------------------------------------------------------

//Matematiksel Fonksiyonlar

//Dışarıdan girilen iki parametreden maksimum olanı bulur.
Math.Max(5,10);
//Dışarıdan girilen iki parametreden minimum olanı bulur.
Math.Min(5,10.5);
//Dışarıdan girilen sayının karekökünü alır.
Math.Sqrt(49);
//Dışarıdan girilen sayının kuvvetini(üssünü) alır.
//Örnek:2 üssü 3 
Math.Pow(2,3);
//Dışarıdan girilen sayının mutlak değerini alır.
Math.Abs(-5);

//Dışarıdan girilen sayı küsürattan sonraki sayı 5 ve yukarısı ise yukarı yuvarlar, değilse aşağı yuvarlar.
//Console.WriteLine(Math.Round(9.49));


//-- Birleştirme Fonksiyonları
string dunya="DÜNYA";
var a=string.Format("Merhaba {0}, {1}", dunya, tamSayi);

var a1=string.Concat("Merhaba ",dunya,tamSayi);

var a2="Merhaba "+dunya.ToLower();

var a3=$"Merhaba {dunya}";

//Console.WriteLine(a1);




// Full name
string name = "İbrahim AYAZ";

// İlgili karakterin kaçıncı indekste olduğunu söyler.
int charPos = name.IndexOf("A");

// Indexe göre metni parçalar. name.Substring(5) == >> im AYAZ
string lastName = name.Substring(charPos);
string lastName2 = name.Substring(2,2);

// Print the result
//Console.WriteLine(lastName2);

int day = 10;
switch (day) 
{
  case 1: 
    Console.WriteLine("Monday");
    break; 
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
  default: 
    Console.WriteLine("Bunların dışında başka bir gün...");
    break;
    
}

//Loop, Döngüler
//WHILE
// int i = 0;
// while (i <= 5) 
// {
//   i++;
// }
// Console.WriteLine(i);

//DO WHILE
//do kısmı bir kere çalışır, while kısmı ise şart sağlanıyorsa do kısmı çalışmaya deva eder sağlanmıyorsa çalışmaz.
// int i1 = 0;
// do 
// {
//   Console.WriteLine(i1);
//   i1++;
// }
// while (i1 > 5);


//0-10 arasında kaç tane çift sayı olduğunu bulan programı yazınız ?
// bool durum=true;
// int i=0;
// int toplam=0;
// while(durum){
//     i++;
//     if(i%2==0){
//         toplam++;
//     }
//     if(i>10){
//         durum=false;
//     }
// }

// Console.WriteLine($"{toplam} adet çift sayı vardır.");





















