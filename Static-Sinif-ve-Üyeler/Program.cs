using System;

namespace Static_Sinif_ve_Üyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");
            Calisan calisan=new Calisan("Ayşe","Yılmaz","IK");
            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");
            Calisan calisan1=new Calisan("Deniz","Arda","IK");
            Calisan calisan2=new Calisan("Tunahan","Özcan","IK");

            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");

            Console.WriteLine($"Toplama İşleminin Sonucu: {Islemler.Topla(100,200)}");
            Console.WriteLine($"Çıkartma İşleminin Sonucu: {Islemler.Cikar(400,50)}");

           
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan(){
            calisanSayisi=0;
        }
        public Calisan(string ısim, string soyIsim, string departman){
            this.Isim=ısim;
            this.SoyIsim=soyIsim;
            this.Departman=departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2){
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2){
            return sayi1-sayi2;
        }
    }
}
