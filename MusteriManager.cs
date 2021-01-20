using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Customer was added : " + musteri.Id);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Customer was deleted." + musteri.Id);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi: " + musteri.Id );
          
        }

    }

}