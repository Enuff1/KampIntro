using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3x2
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " başarıyla eklendi!");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
                Console.WriteLine(musteri.Age);
                Console.WriteLine(" ");
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " başarıyla silindi!");
        }
    }
}
