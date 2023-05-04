using Inheritance;

Bisiklet b = new Bisiklet();

Ucak u = new Ucak();

Otomobil o = new Otomobil("Elektrikli");

Publication p = new Publication("Nisan Manşetleri", 5, 20);

Book b1 = new Book("Flutter ile programlamaya giriş", 7, 10);

Magazine m = new Magazine("Mayıs Manşetleri", 1, 10);

Console.WriteLine(b1.SellCopy());
