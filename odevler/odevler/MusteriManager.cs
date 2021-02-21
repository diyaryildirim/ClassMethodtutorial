using System;
using System.Collections.Generic;
using System.Text;

namespace odevler
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + " " + musteri.MusteriId + " " + musteri.MusteriName + " " + musteri.MusteriSurname);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + " " + musteri.MusteriId + " " + musteri.MusteriName + " " + musteri.MusteriSurname);
        }

        public void Listele(Musteri[] musteri)
        {
            foreach (var item in musteri)
            {
                Console.WriteLine("Musteri Adı : " + item.MusteriName);
                Console.WriteLine("Musteri Soyadı : " + item.MusteriSurname);

            }

        }

        internal void Listele(Musteri musteri1) => throw new NotImplementedException();
    }
}
