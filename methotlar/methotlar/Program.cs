using System;

namespace methotlar
{
    class Program
    { 
        
        

    static void Main(string[] args)
        {
            emlak eml = new emlak();
            eml.SEMTİ = "Keçiören";
            eml.Rengi = "mavi";
            eml.ODASAYİSİ = 4;
            eml.KATNO = 5;
            eml.ALAN = 120;
            Console.WriteLine("evin bulunduğu semt: " + eml.SEMTİ);
            Console.WriteLine("evin oda renleri: "+eml.Rengi );
            Console.WriteLine("evin toplamoda sayısı: "+eml.ODASAYİSİ);
            Console.WriteLine("evin bulunduğu kat: "+eml.ODASAYİSİ);
            Console.WriteLine("evin toplam alanı: "+eml.ALAN+" metrekare");
            Console.Read();






































        }
    }
}
