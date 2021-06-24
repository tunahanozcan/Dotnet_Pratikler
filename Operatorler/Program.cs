using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // operatörler
            int x = 3;
            int y = 5;
        
            y = y + 2;
            Console.WriteLine(y);
        
            y = y + 2;
            Console.WriteLine(y);
            
            y = y / 2;
            Console.WriteLine(y);
            
            x = x * 2;
            Console.WriteLine(x);

            //Matıksal Operatörler  ||,&&,!
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Harika!");
            }
            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Güzel");
            }
            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("İyi");
            }

            // İlişkisel Operatörler <,>,<=,>=,==,!=
            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler /,*,+,-
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sayi1);

            // % = Mod alır 

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
