using System;

namespace Kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1=new Calisan("Tunahan","Özcan",852456,"IT");
            Calisan calisan2=new Calisan("Ahmet","Demir");
            Calisan calisan3=new Calisan();

            calisan3.Ad="İlyas";
            calisan3.Soyad="Yılmaz";
            calisan3.No=741258;
            calisan3.Departman="İnsan Kaynakları";

            Console.WriteLine("***** Çalışan 1 ******");
            calisan1.CalisanBilgileri();
            Console.WriteLine("***** Çalışan 2 ******");
            calisan2.CalisanBilgileri();
            Console.WriteLine("***** Çalışan 3 ******");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad,string soyad,int no,string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad,string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri(){
            Console.WriteLine($"Çalışanın Adı: {Ad}");
            Console.WriteLine($"Çalışanın Soyadı: {Soyad}");
            Console.WriteLine($"Çalışanın Numarası: {No}");
            Console.WriteLine($"Çalışanın Departmanı: {Departman}");
        }
    }
}
