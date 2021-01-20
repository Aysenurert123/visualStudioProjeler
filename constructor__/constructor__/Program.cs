using System;

namespace constructor__
{
    class Program
    {
        static void Main(string[] args)
        {
            string blg;
            Console.Write("Ad - Kulüp");
            blg = Console.ReadLine();

            ogrenci ogr = new ogrenci(blg);



            Console.Read();



        }
    }
}
