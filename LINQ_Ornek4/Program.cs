namespace LINQ_Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sayilar = new[] { 1, 11,11,11, 2, 12,12, 3, 13, 4, 14,14,14, 5, 15, 6, 16,777,888,999,11,12,13,14 };
            var adet = sayilar.Count();
            Console.WriteLine($"sayıların adadi={adet}");

            var tekadet=sayilar.Count(n=>n%2!=0);
            Console.WriteLine($" Tek sayıların adadi={tekadet}");

            var ciftadet = sayilar.Count(n => n % 2 == 0);
            Console.WriteLine($"Çift sayıların adadi={ciftadet}");

            //distinct: tekrarlı elemanların sadece bir tanesini alır
            var atekilListe = sayilar.Distinct();
            Console.WriteLine(string.Join(", ", atekilListe));

            //first()
           // var ilk=sayilar.First(n=>n==11);
            var ilk=sayilar.First();
            Console.WriteLine(ilk);

            //default
            var ilkDefault = sayilar.FirstOrDefault(n => n == 11);
            Console.WriteLine(ilkDefault);

            //empty
            IEnumerable<int>bosListe=Enumerable.Empty<int>();
            //skip:geç,değeri dikkate alma  ** Take: değeri al
            var ilkIkisiniAlma = sayilar.Skip(2);
            Console.WriteLine(string.Join(", ",ilkIkisiniAlma));

            var ilk5al = sayilar.Take(5);
            Console.WriteLine(string.Join(", ", ilk5al));
            Console.WriteLine("---------------------------------------");
            var tekSayilar=sayilar.SkipWhile(n=>n%2==0).Where(n=> n%2!=0);
            Console.WriteLine(string.Join(" ", tekSayilar));
            Console.WriteLine("---------------------------------------");
            var ciftSayilar = sayilar.TakeWhile(n => n%2!=0).Where(n=>n%2==0);
            Console.WriteLine(string.Join(" ", ciftSayilar));

        }
    }
}
