

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

// string[] arabalar={"Toros","Toyota","Volvo","Toyota","Audi","Toyota"}; //Eleman Sayısı : 6 ,

//BREAK: DÖNGÜYÜ KIRMA VE ÇIKMA


// foreach(var x in arabalar){
//     if(x=="Toyota"){
//         Console.WriteLine(x);
//                 break;
//     }
// }
// int sayac=0;
// while(true){
//     if(arabalar[sayac]=="Volvo"){
//         Console.WriteLine(arabalar[sayac]);
//         break;
//     }
//     sayac++;
// }


string[] arabalar={"Toros","Toyota","Volvo","Toyota","Audi","Toyota"}; //Eleman Sayısı : 6 ,

//CONTINUE: Döngü şartını sağlayan değeri atlar.

for(int i=0;i<arabalar.Length;i++){
    if(arabalar[i]=="Toyota"){
        continue;
        Console.WriteLine(arabalar[i]);
    }
    Console.WriteLine(arabalar[i]);
}



