

/*
ifade1:Kod bloğu yürültümeden önce bir kere çalışır.
ifade2:Kod bloğu yürültüğü sürece şart kontrolüdür.
ifade3:Kod bloğu yürültüldükten sonra artış veya azalış yapacak koddur.
for(ifade1; ifade2; ifade3){
    kod bloğu
}
*/

// for(int i=0; i<5;i++){
//     Console.WriteLine("Bingöl");
// }


//1-9 rakamları arasındaki sayılardan kaç tanesi 3'e tam bölünür. Problemi çözen kodu yazınız ?
// int toplam=0;
// for(int i=1; i<=9;i++){
//     if(i%3==0){
//         toplam++;
//     }
// }
// Console.WriteLine(toplam);


//1-100 arasındaki 10 ile bölünebilen sayıları toplayan programı yazınız.
// int toplam=0;
// for(int i=1; i<=100;i++){
//     if(i%10==0){
//         toplam+=i; //toplam=toplam+i;
//     }
// }
// Console.WriteLine(toplam);

//FOREACH DÖNGÜSÜ
// string[] arabalar={"Toros","Toyota","Volvo","Toyota","Audi","Toyota"}; //Eleman Sayısı : 6 ,
// foreach(var x in arabalar){
//     if(x=="Toyota"){
//         Console.WriteLine(x);
//     }
// }
//Bir array(dizi)nin uzunluğu Lenght ifadesiyle bulunur.
// for(int i=0;i<arabalar.Length;i++){
//     if(arabalar[i]=="Toyota"){
//         Console.WriteLine(arabalar[i]);
//     }
// }


//BREAK: DÖNGÜYÜ KIRMA VE ÇIKMA


// foreach(var x in arabalar){
//     if(x=="Toyota"){
//         Console.WriteLine(x);
//                 break;
//     }
// }

string[] arabalar={"Toros","Volvo","Toyota","Toyota","Audi","Toyota"}; //Eleman Sayısı : 6 ,
int sayac=0;
while(true){
    if(arabalar[sayac]=="Toyota"){
        break;
    }
    Console.WriteLine(arabalar[sayac]);
    sayac++;
}


// string[] arabalar={"Toros","Toyota","Volvo","Toyota","Audi","Toyota"}; //Eleman Sayısı : 6 ,

//CONTINUE: Döngü şartını sağlayan değeri atlar.
// for(int i=0;i<arabalar.Length;i++){
//     if(arabalar[i]=="Toyota"){
//         continue;
//         Console.WriteLine(arabalar[i]);
//     }
//     Console.WriteLine(arabalar[i]);
// }

/*----------------ARRAY(DİZİLER)------------------*/
//Diziler 0. indeksten başlar.
//Diziler tanımlanırken köşeli parantezler kullanılmalıdır.
//Örnek: string[] kullanicilar;
//Sözdizimi(Syntax): veriTipi[] degiskenAdi;
//Bir dizinin elemanına erişmek için diziAdi[indexNo] şeklinde yazılmalıdır.
//Bir diziye eleman ataması yapabilmek için süslü parantezler kullanılmalıdır.
//Örneğin: int[] yaslar={10,20,30};
//Dizinin elemanını değiştirmek için diziAdi[indexNo]="atanacakdeğer";

//nesne türetmek veya nesneden bir örnek çıkarmak için new anahtarı kullanılır.

//4 elemanlı bir dizidir.
// string[] cars = new string[4];

//4 elemanlı ve argumanları atanmış bir dizidir.
// string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};


//eleman sayısı belli olmayan argumanları atanmış dizidir.
// string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};


//eleman sayısı belli olmayan argumanları atanmış dizidir. Ayrıca new anahtarı kullanılmamıştır.
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};


//Bir dizi tanımlandıktan sonra eğer arguman/değer ataması yapılmamış ise mutlaka ve mutlaka new anahtar cümlesiyle 
//atama yapmanız gerekiyor.
// int[] plakalar;
// plakalar= new int[] {20,30,10,5};

// //Dizinin elemanını değiştirme
// plakalar[1]=13;

// //Diziyi A-Z veya 0-9 doğru sıralama yapar.
// Array.Sort(plakalar);

// foreach(var p in plakalar){
//     Console.WriteLine(p);
// }







