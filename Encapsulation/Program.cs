using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci=new Ogrenci();
            ogrenci.Isim="Ahmet";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo=12345;
            ogrenci.Sinif=3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1=new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value < 1)
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                else 
                    sinif = value; 
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}
        public void OgrenciBilgileriniGetir(){
            System.Console.WriteLine("******** Ogrenci Bilgileri ********");
            System.Console.WriteLine($"Öğrencinin Adı       :{this.isim}");
            System.Console.WriteLine($"Öğrencinin Soyadı    :{this.soyisim}");
            System.Console.WriteLine($"Öğrencinin Numarası  :{this.ogrenciNo}");
            System.Console.WriteLine($"Öğrencinin Sınıfı    :{this.sinif}");
        }
        public void SinifAtlat(){
            this.Sinif+=1;
        }
        public void SinifDusur(){
            this.Sinif-=1;
        }
    }
}
