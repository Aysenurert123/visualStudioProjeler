using System;


namespace altaltayazdirma
{


        class Program

        {

            static void Main(string[] args)

            {    string mesaj;
                 int kac;
                 Console.Write("İsim giriniz : ");
                 mesaj = Console.ReadLine();
            Console.Write("Kaç defa yazılacak? : ");
            kac = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < kac; i++)
            {
                Console.WriteLine(mesaj);
            }
               Console.ReadLine();

            }

        }

    }

