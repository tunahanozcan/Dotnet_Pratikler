using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
            (Array sınıfını kullanarak yazınız.)*/

            List<int> sayı=new List<int>();
            while (sayı.Count<=20)
            {
            var girilen=Console.ReadLine();
            if(IsNumeric(girilen))
                sayı.Add(Convert.ToInt32(girilen));
            else
                Console.WriteLine("Lütfen sayı giriniz.");
            }
            sayı.Sort();
            Console.WriteLine("Girilen sayılardan en kücük 3 tanesinin ortalaması: "+(sayı[0]+sayı[1]+sayı[2])/3);
            sayı.Reverse();
            Console.WriteLine("Girilen sayılardan en büyük 3 tanesinin ortalaması: "+(sayı[0]+sayı[1]+sayı[2])/3);
        }
        private static bool IsNumeric(string text)
        {
            foreach (char chr in text)
            {
            if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
    }
}
