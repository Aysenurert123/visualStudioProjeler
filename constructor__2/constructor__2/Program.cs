using System;

namespace constructor__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Ayşenur";
            kml.SOYAD = "Ertürk";
            kml.MEMLEKET = "Ankara";
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);


            Console.Read();
        }
    }
}
