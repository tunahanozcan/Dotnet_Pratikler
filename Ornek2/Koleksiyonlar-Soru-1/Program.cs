using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            (ArrayList sınıfını kullanara yazınız.)
            -Negatif ve numeric olmayan girişleri engelleyin.
            -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
            ArrayList liste=new ArrayList();
            ArrayList asallar=new ArrayList();
            ArrayList asalDegil=new ArrayList();

            var sayac=0;
            double asalToplam=0;
            double asalDegilToplam=0;
            
            Console.WriteLine("Pozitif Sayı Giriniz. ");
            while (sayac<5)
            {   var girilen=Console.ReadLine();
                if(IsNumeric(girilen)){
                    var sayi=Convert.ToInt32(girilen);
                    if(sayi==Math.Abs(sayi)){
                        if(Asalmi(sayi)==0){
                            asalDegilToplam+=sayi;
                            asalDegil.Add(sayi);
                        }
                        else{
                            asalToplam+=sayi;
                            asallar.Add(sayi);
                        }
                    }
                    sayac=asallar.Count + asalDegil.Count;
                }
                else
                    Console.WriteLine("Lütfen Pozitif Sayı Giriniz.");
            }   
            asalDegil.Sort();
                Console.WriteLine("******Asal Olmayanlar*********");
            foreach (var item in asalDegil)
                Console.WriteLine(item);

            Console.WriteLine("Asal Olmayan Sayıların Sayısı: "+asalDegil.Count);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması: "+asalDegilToplam/asalDegil.Count);

            asallar.Sort();
                Console.WriteLine("******Asallar********");
            foreach (var item in asallar)
                Console.WriteLine(item);

            Console.WriteLine("Asal Olan Sayıların Sayısı: "+Convert.ToDouble(asallar.Count));
            Console.WriteLine("Asal Olan Sayıların Ortalaması: "+Convert.ToDouble(asalToplam/asallar.Count));
        }
        private static int Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }
            if (i == sayi)
            {
                return 1;
            }
            return 0;
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
