using System;

namespace uzunlukdonüsümleri
{//Klavyeden metre (m) cinsinden girilen uzunluğu, kilometre (km) , santimetre (cm) desimetre (dm) cinsine dönüştürüp yazdıran program
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Uzunluk giriniz (M): ");
            int metre = Convert.ToInt32(Console.ReadLine());
            int olcu = metre.ToString().Length;
            int kmislem = olcu - 1;

            string cm = "00";
            string km = "0000";
            string dm = "0";
            Console.Write("Cm= {0}{1}\n",metre,cm);
            Console.Write("Dm= {0}{1}\n", metre, dm);
            Console.Write("Km= {0}{1}\n", metre, km);
            if (olcu < 3)
            {

                Console.Write("Km= {0}{1}", km.Substring(olcu),metre);
            }
            else if (olcu == 4)
            {
                Console.Write("Km= {0}", metre.ToString().Substring(0,olcu-kmislem));
            }
            else if (olcu >= 5)
            {
                Console.Write("Km= {0}", metre.ToString().Substring(0, olcu - 3));
            }
            Console.ReadKey();
        }
    }
}
