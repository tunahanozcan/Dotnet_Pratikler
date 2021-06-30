using System;

namespace Ornek1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */
            Console.Write("Kaç adet sayı gireceksiniz: ");
            int sayiAdet=int.Parse(Console.ReadLine());
            int sayac=0;
            int[] cift=new int[sayiAdet];
            for (int i = 0; i < sayiAdet; i++)
            {
                Console.Write("{0}. sayıyı girin: ",i+1);
                int sayi =int.Parse(Console.ReadLine());

                if(sayi%2==0)
                    {
                        cift[sayac]=sayi;
                        sayac++;
                    }
            }
            Console.WriteLine("Çift olanlar;");
            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine(cift[i]);
            }
        }
    }
}
