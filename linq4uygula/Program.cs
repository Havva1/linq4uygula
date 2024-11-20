using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4uygula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arabalar = new List<string> { "Renault", "Bmv", "Mercedes", "Honda", "Suzuki", "Halil Havva", "Toyota", "Tog" };
            // orderBy küçükten büyüğe a-z ,0-9 yazar
            //Order By descending büyükten küçüğe z-a,9-0 sıralar
            foreach (string s in arabalar.OrderByDescending(x => x))
            {
                Console.WriteLine(s);
            }
            List<Personel> person = new List<Personel>

            {
                new Personel{Adi="Furkan",numara=20},
                new Personel{Adi="Buğra",numara=30},
                new Personel{Adi="Burak",numara=24},
                new Personel{Adi="Vahide",numara=21},
                new Personel{Adi="Yasin",numara=42},
                new Personel{Adi="Sedef",numara=43},
                new Personel{Adi="Soner",numara=44},
                new Personel{Adi="Halil",numara=40},
                new Personel{Adi="Furkan",numara=20},
                new Personel{Adi="Buğra",numara=30},
                new Personel{Adi="Burak",numara=24},
                new Personel{Adi="Vahide",numara=21},
                new Personel{Adi="Yasin",numara=42},
                new Personel{Adi="Sedef",numara=43},
                new Personel{Adi="Soner",numara=44},
                 new Personel{Adi="Halil",numara=40},
            };
             foreach (var item in person.OrderBy(x => x.numara).ThenBy(x => x.Adi))
            {
                Console.WriteLine($"Kişinin Adı {item.Adi} Numarası{item.numara}");
            }
            Console.WriteLine("---------------------------------");
            var secim = person.Select(x => x.Adi);// Adı Bilgisini
            var secim2 = person.Select(x => x.numara);//Numara Bilgisini 
            //numarası 24 den biyük 40 dan küçük eşit olan verileri getir
            //
            var liste = person.Where(x => x.numara > 24 && x.numara <= 40).Select(x => x.Adi);
            foreach (var item in liste.Skip(1).Take(1))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
            var liste2 = person.GroupBy(x => x.Adi);
            foreach (var item in liste2)
            {
                Console.WriteLine(item.Sum(x=>x.numara));
                var liste3 = person.Where(x => x.Adi.StartsWith("B")); //Baş harfi B ile başlayan
                var liste4 = person.Where(x => x.Adi.EndsWith("n"));// son harfi n ile biten
                var liste5 = person.Where(x => x.Adi.Contains("a"));// herhangi bir yerinde a harfi geçen
                Console.ReadKey();
        } 
    }
}
