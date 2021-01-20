using System;

namespace ucgen.Turu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Kenar Uzunluğu = ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Kenar Uzunluğu = ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Kenar Uzunluğu = ");
            int kenar3 = Convert.ToInt32(Console.ReadLine());
            if (((kenar1 + kenar2) < kenar3) || ((kenar1 - kenar2) > kenar3))
            {
                Console.WriteLine("Bu kenar uzunluklarina sahip bir ucgen olamaz.\n");
            }
            else if ((kenar1 == kenar2) && (kenar3 == kenar1))
            {
                Console.WriteLine("Eşkenar Üçgen.\n");
            }
            else if ((kenar1 == kenar2) || (kenar2 == kenar3) || (kenar1 == kenar3))
            {
                Console.WriteLine("İkiz Kenar Üçgen.\n");
            }
            else
            {
                Console.WriteLine("Çeşit Kenar Üçgen.\n");
            }
            Console.ReadKey();

        }
    }
}


