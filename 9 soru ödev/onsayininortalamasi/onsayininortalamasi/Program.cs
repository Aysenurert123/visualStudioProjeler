using System;

namespace onsayininortalamasi
{//Klavyeden girilen 10 sayının ortalamasını hesaplayıp yazdıran program
    class Program
    {
        static void Main(string[] args)
        {
  
            double toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz:");
                toplam += Convert.ToDouble(Console.ReadLine());
            }
            double ortalama = toplam / 10;
            Console.WriteLine("Toplam={0}\nOrtalama={1}", toplam, ortalama);
            Console.ReadKey();
        }
    }
}
