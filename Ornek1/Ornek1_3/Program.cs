using System;

namespace Ornek1_3
{
    class Program
    {
        static void Main(string[] args)
        {/*
        Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
        Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        */
            Console.WriteLine("Kaç adet kelime girilecek? ");
            int kelimeSay=int.Parse(Console.ReadLine());
            string[] kelimeler=new string[kelimeSay];

            for (int i = 0; i < kelimeSay; i++)
            {
                Console.Write("{0}. kelimeyi girin ",i+1);
                kelimeler[i]=Console.ReadLine();
            }
            Array.Reverse(kelimeler);

            foreach (var kelime in kelimeler)
                Console.WriteLine(kelime);
                
        }
    }
}
