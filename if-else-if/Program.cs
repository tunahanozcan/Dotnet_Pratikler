using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;
            string sonuc;

            if(time>=6&&time<11)
                Console.WriteLine("Gunaydin saat:" +time);

            if(time<18)
                Console.WriteLine("Iyi gunler saat:" +time);
            
            else
                Console.WriteLine("İyi Aksamlar saat:" +time);

            sonuc= time>=6&&time<11 ? "Gunaydin" : time<18 ? "iyi Gunler" : "iyi geceler"; 
            
            Console.WriteLine(sonuc);
        }
    }
}
