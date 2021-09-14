using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Soru - 3:
         Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/
         Console.Write("Cümle giriniz: ");
         List<char> harfler=new List<char>();
         var girilen=Console.ReadLine();
         foreach (var harf in girilen)
         {
             if(harf=='a'||harf=='A'||harf=='e'||harf=='E'||harf=='ı'||harf=='I'||harf=='i'||harf=='İ'||harf=='o'||harf=='O'||harf=='ö'||harf=='Ö'||harf=='u'||harf=='U'||harf=='ü'||harf=='Ü')
                harfler.Add(harf);
         }
            harfler.ForEach(item=>Console.Write(item+" "));
        }
    }
}
