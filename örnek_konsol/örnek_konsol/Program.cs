using System;

namespace örnek_konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Kişiler ks = new Kişiler();
            string ads;
            Console.Write("isim girin: ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);


            //ks.kisilistesi("Ayşenur Ertürk");
            //ks.kisilistesi("Fatih Ertürk");


           //Mesaj msj = new Mesaj();
           // msj.metin();
            Console.Read();



        //    int sayi = 5;
        //    Console.Write(sayi);
        //    Console.Read();
        //    Console.ReadKey();
              

                
            //string kelime;
            //kelime = "26 Ekim";
            //Console.WriteLine(kelime);
            //Console.Read();
            //Console.WriteLine("Mehaba");
            //Console.Write("Dünya");
            //Console.Read();
        }
    }
}
