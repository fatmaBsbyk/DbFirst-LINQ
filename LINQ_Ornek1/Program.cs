using System.Security.Cryptography;

namespace LINQ_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 12, 33, 5, 15, 3, 18, 19, 0, 6, -11, 3, -2, 0 };
            IEnumerable<int> tumSayilar =
                from n in sayilar
                select n;
            Console.WriteLine("Tüm Sayılar");
            foreach (var x in sayilar) 
            {
                Console.Write(x +" ");
            }
            IEnumerable<int>ondanKucukSayilar=
                from n in sayilar
                where n<10
                select n;
            Console.WriteLine("\n10 dan küçük sayılar:");
            foreach (var x in ondanKucukSayilar)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            IEnumerable<int> ondanBuyukSayilar =
                from n in sayilar
                where n > 10
                select n;
            Console.WriteLine("\n10 dan Büyük sayılar:");
            foreach (var x in ondanBuyukSayilar)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            var sayilarMethodIle = sayilar.Where(N => N < 20);
            Console.WriteLine("\n20 dan Büyük sayılar:");
            foreach (var x in sayilarMethodIle)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            int sayiAdet=(from n in sayilar
                         where n<20
                         select n).Count();
            Console.WriteLine("\n20 dan Büyük sayıların adedi:{0}", sayiAdet);

            Console.WriteLine("----------------------------------------------");
            var ogrenciler = new Ogrenci[]
            {
                new(){Id=1,Ad="Adem",Soyad="AKKUŞ",Bolum="Bilgisayar M.",GNO=2.64},
                new(){Id=2,Ad="Elif",Soyad="GÖKMEN",Bolum="Endüstri M.",GNO=2.84},
                new(){Id=3,Ad="Mert",Soyad="KAYA",Bolum="Makine M.",GNO=3.04},
                new(){Id=4,Ad="Canberk",Soyad="KALELİ",Bolum="Çevre M.",GNO=1.64},
                new(){Id=5,Ad="Cansu",Soyad="DEVECİ",Bolum="Otomotiv M.",GNO=3.6},
            };
            var sorgu4 = from s in ogrenciler
                         where s.Id ==1
                         select new { s.Ad, s.Soyad, s.Bolum, s.GNO };
            Console.WriteLine();


            var sorguIsimler = from s in ogrenciler
                               select new { s.Ad };
            foreach (var isim in sorguIsimler)
            {
                Console.Write(isim.Ad + " ");
            }
           

            var sorgu2 = from s in ogrenciler
                               select new { s.Ad,s.Soyad,s.Bolum,s.GNO };
            Console.WriteLine("-\nAd----Soyad-----Bölüm--------- GNO-");
            foreach (var ogr in sorgu2)
            {
                Console.Write(ogr.Ad+" "+ogr.Soyad+" "+ogr.Bolum + " "+ ogr.GNO+"\n");
            }
            Console.WriteLine("\n****************************");
            var sorgu3 = from s in ogrenciler
                         where s.GNO>3.0
                         select new { s.Ad, s.Soyad, s.Bolum, s.GNO };
            Console.WriteLine("-\nAd----Soyad-----Bölüm--------- GNO-");
            foreach (var ogr in sorgu3)
            {
                Console.Write(ogr.Ad + " " + ogr.Soyad + " " + ogr.Bolum + " " + ogr.GNO + "\n");
            }
        }
    }
}
