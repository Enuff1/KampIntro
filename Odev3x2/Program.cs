using System;

namespace Odev3x2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Enes";
            musteri1.Surname = "GÜVEN";
            musteri1.Age = 19;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Tuğba";
            musteri2.Surname = "GÜVEN";
            musteri2.Age = 44;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Hüseyin";
            musteri3.Surname = "GÜVEN";
            musteri3.Age = 48;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            musteriManager.Listele(musteriler);
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri1);



        }
    }
}
