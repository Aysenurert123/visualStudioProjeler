using System;
// Klavyeden girilen N sayısına göre 1'den N'e kadar olan tek sayıların toplamını ve çarpımını, çift sayıların ise kareleri toplamını bulan program
namespace carpim.toplam
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;
            int toplam=0;
            int carpim = 1;
            int karetoplam = 0;
            Console.WriteLine("N sayısını giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (sayac = 1; sayac <= n; sayac+=2)
            {
                toplam = toplam + sayac;
                carpim = carpim * sayac;
            }
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Çarpım: " + carpim);
            for (sayac = 0; sayac <= n; sayac += 2)
            {
                karetoplam+= sayac * sayac;
            }
            Console.WriteLine("Kareleri Toplamı: " + karetoplam);
        }

    }
}
