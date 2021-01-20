using System;
using System.Collections.Generic;
using System.Text;

namespace geriye_deger_donduren_metotlar
{
    class işlem

    {
        public int topla(int s1,int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine ("Sonuc: " +s3);
            return s3;
        }

        public int kare(int deger)
        {
            int sonuc = deger * deger;
            Console.WriteLine("Sonuc: " + sonuc);
            return sonuc;
                }
    }
}
