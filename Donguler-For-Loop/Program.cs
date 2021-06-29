using System;

namespace Donguler_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Bir sayı giriniz: ");
            // int sayac=int.Parse(Console.ReadLine());
            // for (int i = 0; i <= sayac; i++)
            // {
            //     if(i%2==1)
            //         Console.WriteLine(i);
            // }

            // int tekToplam=0;
            // int ciftToplam=0;
            // for (int i = 0; i <= 100; i++)
            // {
            //     if(i%2==1)
            //         tekToplam+=i;
            //     else
            //         ciftToplam+=i;
            // }
            // Console.WriteLine("100'e kadar olan çift sayıların toplamı: "+ ciftToplam);
            // Console.WriteLine("100'e kadar olan tek sayıların toplamı: "+ tekToplam);

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                else if(i==8)
                    break;
                Console.WriteLine(i);

            }
        }
    }
}
