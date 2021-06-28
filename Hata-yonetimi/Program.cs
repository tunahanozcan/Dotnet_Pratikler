using System;

namespace Hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz: ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gridiginiz sayi: "+sayi);
                
            }
            catch(ArgumentNullException ex)
            {
                
                Console.WriteLine("Bos bir deger girdiniz!!:"+ex.Message.ToString());
            }

            catch(FormatException ex)
            {
                
                Console.WriteLine("Girdiginiz deger sayi degil!!:"+ex.Message.ToString());
            }

            catch(OverflowException ex)
            {
                
                Console.WriteLine("Fazla ya da az sayıda girdiniz var!!:"+ex.Message.ToString());
            }

            finally
            {
                Console.WriteLine("--İslem tamam--");
            }
        }
    }
}
