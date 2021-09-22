using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonRehberiApp
{
    public class AdresDefteri
    {
        List<Kullanıcı> KullanıcıListesi = new List<Kullanıcı>(){
                new Kullanıcı(){Ad="Isım-1",Soyad="soyısım-1",Numara="nummero-1"},
                new Kullanıcı(){Ad="Isım-2",Soyad="soyısım-2",Numara="nummero-2"},
                new Kullanıcı(){Ad="Isım-3",Soyad="soyısım-3",Numara="nummero-3"},
                new Kullanıcı(){Ad="Isım-4",Soyad="soyısım-4",Numara="nummero-4"},
                new Kullanıcı(){Ad="Isım-5",Soyad="soyısım-5",Numara="nummero-5"}
            };
        public void SecimListesi()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************\n(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak");
            var secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Lütfen isim giriniz             :");
                    var yeniad = Console.ReadLine();
                    Console.Write("Lütfen soyisim giriniz          :");
                    var yenisoyad = Console.ReadLine();
                    Console.Write("Lütfen telefon numarası giriniz :");
                    var yeninumara = Console.ReadLine();
                    NumaraKaydet(yeniad, yenisoyad, yeninumara);
                    SecimListesi();
                    break;
                case 2:
                    Console.Write("Silmek istediğiniz kişinin adını yazın: ");
                    string silad = Console.ReadLine();
                    Console.Write("Silmek istediğiniz kişinin soyadını yazın: ");
                    string silsoyad = Console.ReadLine();
                    NumaraSil(silad, silsoyad);
                    SecimListesi();
                    break;
                case 3:
                    GuncellenecekKisi();
                    SecimListesi();
                    break;
                case 4:
                    Listele();
                    SecimListesi();
                    break;
                case 5:
                    Console.Write("Aramak istediğiniz kişinin adını girin: ");
                    var araisim = Console.ReadLine();
                    Console.Write("Aramak istediğiniz kişinin soyadını girin: ");
                    var arasoyisim = Console.ReadLine();
                    var bulunan=KullanıcıBul(araisim, arasoyisim);
                    Console.WriteLine($"Bulunan kişinin adı      :{bulunan.Ad}\nBulunan kişinin soyadı   :{bulunan.Soyad},\nBulunan kişinin numarası :{bulunan.Numara}");
                    SecimListesi();
                    break;
                default:
                    break;
            }
        }
        void NumaraKaydet(string yeniad, string yenisoyad, string yeninumara)
        {
            if (KullanıcıBul(yeniad, yenisoyad) != null)
                Console.WriteLine("Kaydetmek istediğiniz kişi sistemde kayıtlı.");
            else
            {
                KullanıcıListesi.Add(new Kullanıcı() { Ad = yeniad, Soyad = yenisoyad, Numara = yeninumara });
                Console.Write($"{yeniad} isimli kişi sisteme eklendi.");
            }

        }
        void NumaraSil(string silad, string silsoyad)
        {
            var silinecek = KullanıcıBul(silad, silsoyad);
            if (silinecek == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
                var deger = int.Parse(Console.ReadLine());
                if (deger == 1)
                {
                    SecimListesi();
                }
                else if (deger == 2)
                {
                    Console.Write("Silmek istediğiniz kişinin adını yazın: ");
                    string silad1 = Console.ReadLine();
                    Console.Write("Silmek istediğiniz kişinin soyadını yazın: ");
                    string silsoyad1 = Console.ReadLine();
                    NumaraSil(silad1, silsoyad1);
                    SecimListesi();
                }
            }
            else
            {
                Console.Write($"{silinecek.Ad} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                var yesno = Console.ReadLine();
                if (yesno == "y" || yesno == "Y")
                {
                    KullanıcıListesi.Remove(silinecek);
                    Console.WriteLine($"{silinecek.Ad} isimli kayıt rehberden silindi.");
                }
                else if (yesno == "n" || yesno == "N")
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                }
            }
        }
        void Listele()
        {
            foreach (var item in KullanıcıListesi)
            {
                Console.WriteLine($"isim: {item.Ad}, Soyad: {item.Soyad}, Numara: {item.Numara}");
            }
        }
        Kullanıcı KullanıcıBul(string ad, string soyad)
        {
            return KullanıcıListesi.FirstOrDefault(x => x.Ad == ad || x.Soyad == soyad);
        }
        public void GuncellenecekKisi()
        {
            Console.Write("Güncellemek istediğiniz kişinin adını yazın: ");
            string guncellead = Console.ReadLine();
            Console.Write("Güncellemek istediğiniz kişinin soyadını yazın: ");
            string guncellesoyad = Console.ReadLine();
            var guncellenecek = KullanıcıBul(guncellead, guncellesoyad);
            if (guncellenecek == null)
                GuncellenecekBulunamadı();
            else
                GuncellenecekBulundu(guncellenecek);
            void GuncellenecekBulunamadı()
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için    : (1)\n* Yeniden denemek için              : (2)");
                var deger = int.Parse(Console.ReadLine());
                if (deger == 1)
                {
                    SecimListesi();
                }
                else if (deger == 2)
                {
                    Console.Write("Güncellemek istediğiniz kişinin adını yazın: ");
                    string guncellead1 = Console.ReadLine();
                    Console.Write("Güncellemek istediğiniz kişinin soyadını yazın: ");
                    string guncellesoyad1 = Console.ReadLine();
                    var guncellenecek1 = KullanıcıBul(guncellead1, guncellesoyad1);
                    if (guncellenecek1 == null)
                        GuncellenecekBulunamadı();
                    else
                    {
                        GuncellenecekBulundu(guncellenecek);
                    }
                }
            }
            void GuncellenecekBulundu(Kullanıcı guncellenecek)
            {
                Console.Write($"{guncellenecek.Ad} isimli kişinin yeni numarasını yazın :");
                var yenino = Console.ReadLine();
                if (yenino != null)
                {
                    Console.Write($"{guncellenecek.Ad} isimli kişi rehberden güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                    var yesno = Console.ReadLine();
                    if (yesno == "y" || yesno == "Y")
                    {
                        guncellenecek.Numara = yenino;
                        Console.WriteLine($"{guncellenecek.Ad} isimli kayıt güncellendi.");
                    }
                    else if (yesno == "n" || yesno == "N")
                    {
                        Console.WriteLine("Güncelleme işlemi iptal edildi.");
                    }
                }
            }
        }
    }
    public class Kullanıcı
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
    }

}