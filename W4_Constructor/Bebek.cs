using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4P2_Constructor
{
    public class Bebek
    {
        public string Name; //alanlari olusturuyoruz
        public string Surname;
        public DateTime Birthday;

        public Bebek() //ici bos constructor
        { }

        public Bebek(string name, string surname) //sadece ad soyad alan bir constructor dogum tarihi icerisinde o anin dogum gunu olarak veriliyor
        {
            Name = name;
            Surname = surname;
            Birthday = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }



        public void PrintInfo() //konsola yazdirma icin bir metot
        {
            Console.WriteLine($"{Name} {Surname} adinda dogan bebegin dogum tarihi {Birthday}.");
        }

    }
}
