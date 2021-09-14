using System;
using System.Collections.Generic;

namespace Generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi=new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi=new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi =>Console.WriteLine(sayi));
            renkListesi.ForEach(renk =>Console.WriteLine(renk));

            //Listeden eleman çıkartma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Liste içerisinde Arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste içerisinde bulundu!");
            
            //Eleman ile index'e erişme
            string[] hayvanlar ={"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi=new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi=new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1=new Kullanıcılar();
            kullanıcı1.isim="Ayşe";
            kullanıcı1.soyisim="Yılmaz";
            kullanıcı1.yas=26;

            Kullanıcılar kullanıcı2=new Kullanıcılar();
            kullanıcı2.isim="Özcan";
            kullanıcı2.soyisim="Çalışkan";
            kullanıcı2.yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar(){
                isim="Deniz",
                soyisim="Arda",
                yas=24
            });
            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.isim);
                Console.WriteLine("Kullanıcı : " + kullanıcı.soyisim);
                Console.WriteLine("Kullanıcı : " + kullanıcı.yas);
            }
            yeniListe.Clear();
        }
    }
            public class Kullanıcılar
            {
                public string isim { get; set; }
                public string soyisim { get; set; }
                public int yas { get; set; }
            }




}
