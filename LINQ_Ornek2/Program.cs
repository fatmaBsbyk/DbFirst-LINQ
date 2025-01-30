namespace LINQ_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //anonim tipler
            var arabalar = new[]
            {
                 new {Id  = 111, Marka ="Ford",   Model ="Focus",  Renk="Beyaz"},
                 new { Id = 222, Marka = "Honda", Model = "Jazz",  Renk = "Kırmızı" },
                 new { Id = 333, Marka = "WV",  Model = "Jetta", Renk = "Gri" },
                 new { Id = 333, Marka = "Toyota",  Model = "Corolla", Renk = "Mavi" },
                 new { Id = 333, Marka = "Tofaş",  Model = "Murat", Renk = "Sarı" },
            };
            var markaModel= from arb in arabalar
                            select new {arb.Marka, arb.Model};
            foreach (var a in markaModel)
            {
                Console.WriteLine(a.Marka + " " + a.Model);
            }
            //group by: belli bir sütuna göre gruplandırmak için kullanılır.
            var sorgu1 = from arb in arabalar
                         group arb by arb.Marka;
            Console.WriteLine("---------------------------------");
            foreach (var a in sorgu1)
            {
                //Console.WriteLine(a.Key);
                foreach(var b in a)
                {
                    Console.WriteLine($"Id:{b.Id}, Marka:{b.Marka}, Model:{b.Model} ve Renk:{b.Renk}");
                }
                
            }

        }
    }
}
