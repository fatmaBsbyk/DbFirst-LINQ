namespace LINQ_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var musteriler = new[]
             {
                new Musteri{
                    Faturalar=new[]
                    {
                    new Fatura{Id=1,Toplam=1000},
                    new Fatura{Id=2,Toplam=1100},
                    }
                    },
                new Musteri{
                    Faturalar=new[]
                    {
                    new Fatura{Id=3,Toplam=1300},
                    new Fatura{Id=4,Toplam=1400},
                    }
                    },
                new Musteri{
                    Faturalar=new[]
                    {
                    new Fatura{Id=5,Toplam=1500},
                    new Fatura{Id=6,Toplam=1600},
                    }
                    }
            };
            var butunFaturalar=musteriler.SelectMany(m=>m.Faturalar); // tamamı koleksiyon olarak dönmüş oluyor.
            //Console.WriteLine(butunFaturalar.Select(i=>i.Id).ToArray()); 
            Console.WriteLine(string.Join(", ", butunFaturalar.Select(i => i.Id).ToArray()));
            Console.WriteLine(string.Join(", ", butunFaturalar.Select(i => i.Toplam).ToArray()));
            Console.WriteLine("------------------------------------------------------------------");
            var isimler = new[] { "Ali", "Veli", "Alican", "Velican", "Can", "Mercan", "Gürcan", "Alim" };
            var aIleBaslayanlar = isimler.Where(i => i.StartsWith("A"));
            Console.WriteLine(string.Join(", ", aIleBaslayanlar));
            var canIleBitenler = isimler.Where(i => i.EndsWith("can"));
            Console.WriteLine(string.Join(", ", canIleBitenler));
            //içerisinde li olanlar
            var liIcerenler = isimler.Where(i => i.Contains("li"));
            Console.WriteLine(string.Join(", ", liIcerenler));
            //ilk iki harf
            var ikiHarf = isimler.Select(i => i.Substring(0,2));
            Console.WriteLine(string.Join(", ", ikiHarf));
            Console.WriteLine();
            //any():bool herhangi bir değere bakar
            var liste = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1 };
           // var liste = new int[10];
            var listeBosMu = liste.Any();
           // if(listeBosMu==false)
            if(!listeBosMu)
            {
                Console.WriteLine("Listede eleman yok");
            }
            else
            {
                Console.WriteLine("Listede eleman var.");
            }
            var sayiBirVar=liste.Any(n=>n==1);
            Console.WriteLine(sayiBirVar);

            var sayi13Var = liste.Any(n => n == 13);
            Console.WriteLine(sayi13Var);

            var negatifVarMi = liste.Any(n => n < 0);
            Console.WriteLine(negatifVarMi);
            //all:hepsini döndürür
            var tum=liste.All(n=>n>4);
            //foreach (var item in tum as List<int>)
            //{
            //    Console.WriteLine(item);
            //}

            //sum:toplam
            var toplam = liste.Sum();
            Console.WriteLine($"toplam:{toplam}");
            var sehirler = new[]
            {
                new{Sehir="Ankara",Nüfus=6000000},
                new{Sehir="İstanbul",Nüfus=20000000},
                new{Sehir="İzmir",Nüfus=460000},
                new{Sehir="Çorum",Nüfus=525000},
            };
            var toplamNufüs=sehirler.Sum(s=>s.Nüfus);
            Console.WriteLine($"toplam nufüs:{toplamNufüs}");
            //min max
            var mininmum = sehirler.Min(s=>s.Nüfus);
            Console.WriteLine(mininmum);
            var maksimum = sehirler.Max(s => s.Nüfus);
            Console.WriteLine(maksimum);
        } 
    }
}
