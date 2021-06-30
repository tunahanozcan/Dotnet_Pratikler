using System;

namespace Ornek1_4
{
    class Program
    {
        static void Main(string[] args)
        {/*
        Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */
            Console.Write("Cümleyi girin: ");
            string cumle=Console.ReadLine();
            string[] kelimeler=cumle.Split(" ");
            var kelimeSayisi=0;

            foreach (var kelime in kelimeler)
            {
            if (kelime != "")
                kelimeSayisi++;
            }
            var harfSayisi=cumle.Replace(" ", string.Empty).Length;
            Console.WriteLine("Kelime sayısı: "+kelimeSayisi);
            Console.WriteLine("Harf sayısı: "+harfSayisi);
            
        }
    }
}
