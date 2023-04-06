// See https://aka.ms/new-console-template for more information

internal class Program
{
    //Overloading (Aşırı Yükleme)
    //Aynı isimde method(fonksiyon) tanımı yapılabilir ancak aşağıdaki kurallara uyulması gerekiyor.
    //1- Method ismi aynı ise parametre sayısı farklı olabilir.
    //2- Method ismi aynı ise parametrenin veri tipleri farklı olabilir.




    static void Main(string[] args)
    {
        Console.WriteLine(PlusMethod(5)); // ÇIKTI : False
        Console.WriteLine(PlusMethod(5,6)); // ÇIKTI : True
        Console.WriteLine(PlusMethod(1)); // ÇIKTI : ?

    }

    static bool PlusMethod(int x, int y)
    {
        var c = x + y;
        if (c > 9)
        {
            return true;
        }
        return false;
    }


    static bool PlusMethod(int x)
    {
        var c = x + 5;
        if (c>9)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static bool PlusMethod(double x)
    {
        var c = x + 2;
        if (c < 9)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
