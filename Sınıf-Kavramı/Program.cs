using System;

namespace Sınıf_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1=new Calisan();
            Calisan calisan2=new Calisan();
            calisan1.Ad="Tunahan";
            calisan1.Soyad="Özcan";
            calisan1.No=852456;
            calisan1.Departman="IT";

            calisan2.Ad="İlyas";
            calisan2.Soyad="Yılmaz";
            calisan2.No=741258;
            calisan2.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public void CalisanBilgileri(){
            Console.WriteLine($"Çalışanın Adı: {Ad}");
            Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Departman}");
        }
    }
}
