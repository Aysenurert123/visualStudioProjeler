
using System;

namespace haftanin.günleri
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                string gun;
                Console.Write("1-7 Arasında Bir rakam giriniz: ");
                gun = Console.ReadLine();

                switch (gun)
                {
                    case "1": Console.Write("PAZARTESİ"); break;
                    case "2": Console.Write("SALI"); break;
                    case "3": Console.Write("ÇARŞAMBA"); break;
                    case "4": Console.Write("PERŞEMBE"); break;
                    case "5": Console.Write("CUMA"); break;
                    case "6": Console.Write("CUMARTESİ"); break;
                    case "7": Console.Write("PAZAR"); break;
                    default: Console.Write("Lütfen 1-7 arasında bir sayı giriniz."); break;
                }
                Console.ReadKey();
            }
        }
    }
}