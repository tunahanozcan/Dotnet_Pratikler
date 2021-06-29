using System;

namespace While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Sayı giriniz.");
            // int sayi=int.Parse(Console.ReadLine());
            // int toplam=0;
            // int sayac=1;
            // while (sayac<=sayi)
            // {
            //     toplam+=sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi);

            // char character='a';
            // while (character <='z')
            // {
            //     Console.WriteLine(character);
            //     character++;
            // }

            string[] arabalar={"Ford","Range-Rover","Audi","BMW"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
