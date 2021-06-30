using System;

namespace Ornek1_2
{
    class Program
    {
        static void Main(string[] args)
        {/*
        Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.        
        */
            Console.Write("Kaç adet sayı girilecek? ");
            int sayiAdet=int.Parse(Console.ReadLine());
            Console.Write("Girilen sayılar hangi sayıya bölünecek? ");
            int sayiBolen=int.Parse(Console.ReadLine());

            int sayac=0;
            int[] tamBolunen=new int[sayiAdet];

            for (int i = 0; i < sayiAdet; i++)
            {
                Console.Write("{0}. sayıyı girin: ",i+1);
                int sayi=int.Parse(Console.ReadLine());

                if(sayi%sayiBolen==0){
                    tamBolunen[sayac]=sayi;
                    sayac++;
                }
            }
            Console.WriteLine($"{sayiBolen} sayısına tam bölünenler;");
            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine(tamBolunen[i]);
            }

        }
    }
}
