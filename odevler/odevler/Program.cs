using System;

namespace odevler
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriName = "İbrahim ethem";
            musteri1.MusteriSurname = "İspir";
            musteri1.MusteriId = 50468524;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriName = "Eren";
            musteri2.MusteriSurname = "Kala";
            musteri2.MusteriId = 25489654;

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.Ekle(musteri1);
            musteriEkle.Ekle(musteri2);

            MusteriManager musterisil = new MusteriManager();
            musterisil.Ekle(musteri2);


            Musteri[] musteriList = { musteri1, musteri2 };
            foreach (var musteri in musteriList)
            {
                Console.WriteLine(musteri.MusteriName);
                Console.WriteLine(musteri.MusteriSurname);
                Console.WriteLine(musteri.MusteriId);
            }

            MusteriManager musteriListe = new MusteriManager();
            musteriListe.Listele(musteri1);
            musteriListe.Listele(musteri2);

            Console.ReadLine();
        }
    }
}
