using System;

namespace kdvli.satis
{
    class Program
    {
        static void Main(string[] args)
        {
           

            float fiyat, kdv, tutar, oran;
            Console.Write("Fiyatı Giriniz:");
            fiyat = Convert.ToSingle(Console.ReadLine());
            Console.Write("KDV oranını Giriniz:");
            oran = Convert.ToSingle(Console.ReadLine());
            kdv = fiyat * oran;
            tutar = fiyat + kdv;
            Console.WriteLine("Kdv = {0:f2}tl ----- Tutar = {1:f2}tl", kdv, tutar);
            Console.ReadKey();

        }
    }
}


