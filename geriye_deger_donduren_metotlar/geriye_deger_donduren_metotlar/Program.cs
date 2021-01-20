using System;

namespace geriye_deger_donduren_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            işlem isl = new işlem();
            isl.topla(7, 6);
            isl.topla(4, 5);


            Console.WriteLine("\n\n\n");

            isl.kare(6);
            Console.Read();
        }
    }
}
