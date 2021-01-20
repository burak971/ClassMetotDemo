using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = ("Burak");
            musteri1.Soyad = ("Karapınar");
            musteri1.Id= 123456789;
            

            Musteri musteri2 = new Musteri();
            musteri2.Ad = ("Mesut");
            musteri2.Soyad = ("özil");
            musteri2.Id= 987654324;
            

            Musteri musteri3 = new Musteri();
            musteri3.Ad = ("Polat");
            musteri3.Soyad = ("Alemdar");
            musteri3.Id= 741258963;
            
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("PROFİLİNİZ OLUŞTURULUYOR ");
            Console.WriteLine(" ");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            Console.WriteLine(" ");
            Console.WriteLine("MÜŞTERİLER LİSTELENİYOR");
            Console.WriteLine(" ");
            musteriManager.Liste(musteri1);
            Console.WriteLine(" ");
            musteriManager.Liste(musteri2);
            Console.WriteLine(" ");
            musteriManager.Liste(musteri3);
            Console.WriteLine(" ");

            Console.WriteLine("MÜŞTERİLER SİLİNİYOR");
            Console.WriteLine(" ");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
        }
    }
}
