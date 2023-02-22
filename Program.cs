using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_içinde_3_e_bölünen_isimler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100, -88, 78, 11, 1, 5, 25, -14, 57, 15, -101 };
            for (int i = 1; i <= sayilar; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    sayac++;
                }
            }
            Console.WriteLine("3'e Tam Bölünen Sayı Adeti={0}", sayac);
            Console.ReadKey();


        }

    }
}
