using W4P2_Constructor;

Bebek bebek1 = new Bebek(); //ici bos constructori yaparsak asagidaki gibi tek tek tanimlamamiz gerekir
bebek1.Name = "Esra";
bebek1.Surname = "Suluoglu";
bebek1.Birthday = new DateTime(1990, 01, 01);

bebek1.PrintInfo();

Console.WriteLine("---------------------------");

Bebek bebek2 = new Bebek("aysel", "bilmez"); //ici dolu constructor yazarsak tek satirda isi halledebiliriz

bebek2.PrintInfo();

Console.ReadKey();
