using System;

namespace Console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arabanızın markasını girin");
            string marka=Console.ReadLine();
            Console.WriteLine("Arabanızın modelini girin");
            string model=Console.ReadLine();
            Console.WriteLine($"{marka} marka arabanın {model} modelini kullanıyorsun."  );
            Console.ReadLine();
        }
    }
}
