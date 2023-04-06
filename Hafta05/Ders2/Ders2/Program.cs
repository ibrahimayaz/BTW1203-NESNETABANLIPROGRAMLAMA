// See https://aka.ms/new-console-template for more information

using Ders2;

internal class Program
{
    static void Main(string[] args)
    {

        //ÖNEMLİ !!!
        //new anahar cümlesi nesne türetmeye veya
        //sınıftan bir nesne örneği oluşturmaya yarar.
        Araba a1 = new Araba();
        
        Urun t1=new Urun("14 Pro Max","Xioami");

        Console.WriteLine(t1.adi);
        Console.WriteLine(t1.marka);

    }
}

