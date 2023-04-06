using Ders1;

internal class Program
{
    static void Main(string[] args)
    {
        //new anahtar sözcüğü nesne türetmek diğer bir deyişle
        //nesne örneği oluşturmak için kullanılır.
        Kitap k1 = new Kitap("İncir Ağacı", "Sertaç .. ", 2010, 1000);

        Kitap k2 = new Kitap("Son Ada", "Zülfü", 2010, 2000);

        Console.WriteLine(k2.SayfaDegistir(1));

    }
}