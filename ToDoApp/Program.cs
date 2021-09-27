using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoApp toDoApp = new ToDoApp();
            toDoApp.Baslangıc();
        }
    }
    public class ToDoApp
    {
        List<Gorev> toDoList = new List<Gorev>();
        List<Gorev> inProgressList = new List<Gorev>();
        List<Gorev> doneList = new List<Gorev>();
        List<Kullanıcı> kullanıcılar = new List<Kullanıcı>(){
            new Kullanıcı(){Id=1,Ad="Tunahan",SoyAd="Ozcan"},
            new Kullanıcı(){Id=2,Ad="Arda",SoyAd="Demir"},
            new Kullanıcı(){Id=3,Ad="İlyas",SoyAd="Yıldız"}
        };
        public ToDoApp()
        {
            inProgressList.Add(new Gorev()
            {
                Baslık = "CSharp Döküman Bitir",
                Acıklama = "CSharp örneklerini kolaydan zora hepsini kodla.",
                Asama = ((int)Asamalar.InProgress),
                KartBuyukluguId = 1,
                TanımlıKullanıcı = KullanıcıBulId(1)
            });
            doneList.Add(new Gorev()
            {
                Baslık = "HackerRank SQL",
                Acıklama = "HackerRank SQL sorgularının tamamını bitir.",
                Asama = ((int)Asamalar.Done),
                KartBuyukluguId = 2,
                TanımlıKullanıcı = KullanıcıBulId(2)
            });
        }
        public void Baslangıc()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Uygulamadan Çıkmak");

            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    {
                        //Listele
                        Listele();
                        break;
                    }
                case 2:
                    {
                        //görevEkle
                        GorevEkle();
                        break;
                    }
                case 3:
                    {
                        //gorevsil
                        GorevSil();
                        break;
                    }
                case 4:
                    {
                        //karttaşı
                        KartTası();
                        break;
                    }
                case 5:
                    {
                        //Çıkış
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hatalı seçim yaptınız.");
                        Baslangıc();
                        break;
                    }
            }
        }
        void Listele()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (toDoList.Count == 0)
            {
                Console.WriteLine("~BOŞ~\n");
            }
            else
            {
                foreach (var item in toDoList)
                {
                    Console.WriteLine($"Başlık : {item.Baslık}");
                    Console.WriteLine($"İçerik : {item.Acıklama}");
                    Console.WriteLine($"Atanan Kişi : {item.TanımlıKullanıcı.Ad + " " + item.TanımlıKullanıcı.SoyAd}");
                    Console.WriteLine($"Büyüklük : {KartBuyukluguIdBul(item.KartBuyukluguId)}");
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (inProgressList.Count == 0)
            {
                Console.WriteLine("~BOŞ~\n");
            }
            else
            {
                foreach (var item in inProgressList)
                {

                    Console.WriteLine($"Başlık : {item.Baslık}");
                    Console.WriteLine($"İçerik : {item.Acıklama}");
                    Console.WriteLine($"Atanan Kişi : {item.TanımlıKullanıcı.Ad + " " + item.TanımlıKullanıcı.SoyAd}");
                    Console.WriteLine($"Büyüklük : {KartBuyukluguIdBul(item.KartBuyukluguId)}");
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (doneList.Count == 0)
            {
                Console.WriteLine("~BOŞ~\n");
            }
            else
            {
                foreach (var item in doneList)
                {
                    Console.WriteLine($"Başlık : {item.Baslık}");
                    Console.WriteLine($"İçerik : {item.Acıklama}");
                    Console.WriteLine($"Atanan Kişi : {item.TanımlıKullanıcı.Ad + " " + item.TanımlıKullanıcı.SoyAd}");
                    Console.WriteLine($"Büyüklük : {KartBuyukluguIdBul(item.KartBuyukluguId)}");
                    Console.WriteLine("-");
                }
                Console.WriteLine("\n");
            }

            Baslangıc();
        }
        void GorevEkle()
        {
            Console.Write("Başlık Giriniz : ");
            string baslik = Console.ReadLine();

            Console.Write("İçerik Giriniz : ");
            string acıklama = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
            int buyukluk = int.Parse(Console.ReadLine());

            Console.Write("Kişinin ID'sini Giriniz : ");
            int id = int.Parse(Console.ReadLine());
            if (KullanıcıKontrol(id))
            {
                Gorev gorev = new Gorev()
                {
                    TanımlıKullanıcı = KullanıcıBulId(id),
                    Acıklama = acıklama,
                    KartBuyukluguId = buyukluk,
                    Baslık = baslik,
                    Asama=((int)Asamalar.ToDo)
                    
                };

                toDoList.Add(gorev);
                Console.WriteLine($"{baslik} başlığındaki göreviniz eklendi");
                Console.WriteLine();
                Baslangıc();
            }
            else
            {
                Console.WriteLine($"{id} ID'li kullanıcı bulunamadı");
            }

            Baslangıc();
        }
        void GorevSil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();

            if (!KartBulBaslik(baslik))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Baslangıc();
                            break;
                        }
                    case 2:
                        {
                            GorevSil();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Hatalı seçim yaptınız."); ;
                            Baslangıc();
                            break;
                        }
                }
            }
            else
            {
                KartSilBaslik(baslik);
                Console.WriteLine($"{baslik} başlığındaki görevleriniz silinmiştir");
                Baslangıc();
            }

        }
        void KartTası()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız : ");
            string baslik = Console.ReadLine();

            if (!KartBulBaslik(baslik))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            Baslangıc();
                            break;
                        }
                    case 2:
                        {
                            KartTası();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Hatalı seçim yaptınız.");
                            Baslangıc();
                            break;
                        }
                }
            }
            else
            {
                int asamaId = 0;
                asamaId = KartBulBaslik1(baslik).Asama;

                Gorev gorevBul = KartBulAsamaBaslık(asamaId, baslik);

                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine($"Başlık      : {gorevBul.Baslık}");
                Console.WriteLine($"İçerik      : {gorevBul.Acıklama}");
                Console.WriteLine($"Atanan Kişi : {gorevBul.TanımlıKullanıcı.Ad + " " + gorevBul.TanımlıKullanıcı.SoyAd}");
                Console.WriteLine($"Büyüklük    : {KartBuyukluguIdBul(gorevBul.KartBuyukluguId)}");
                Console.WriteLine($"Line        : {AsamaBulId(asamaId)}");

                Console.WriteLine();

                KartSilAsamaIdBaslık(asamaId, baslik);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            toDoList.Add(gorevBul);
                            Baslangıc();
                            break;
                        }
                    case 2:
                        {
                            inProgressList.Add(gorevBul);
                            Baslangıc();
                            break;
                        }
                    case 3:
                        {
                            doneList.Add(gorevBul);
                            Baslangıc();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Hatalı seçim yaptınız.");
                            Baslangıc();
                            break;
                        }

                }
            }
        }
        Gorev KartBulAsamaBaslık(int asamaId, string baslik)
        {
            switch (asamaId)
            {
                case 1:
                    {
                        return toDoList.Find(x => x.Baslık == baslik);
                    }
                case 2:
                    {
                        return inProgressList.Find(x => x.Baslık == baslik);
                    }
                case 3:
                    {
                        return doneList.Find(x => x.Baslık == baslik);
                    }
                default:
                    return null;
            }
        }
        private void KartSilAsamaIdBaslık(int asamaId, string baslik)
        {
            switch (asamaId)
            {
                case 1:
                    {
                        toDoList.Remove(toDoList.Find(x => x.Baslık == baslik));
                        break;
                    }
                case 2:
                    {
                        inProgressList.Remove(inProgressList.Find(x => x.Baslık == baslik));
                        break;
                    }
                case 3:
                    {
                        doneList.Remove(doneList.Find(x => x.Baslık == baslik));
                        break;
                    }

            }
        }
        string AsamaBulId(int AsamaId)
        {
            string asama = "";

            switch (AsamaId)
            {
                case 1:
                    {
                        asama = "TODO";
                        break;
                    }
                case 2:
                    {
                        asama = "IN PROGRESS";
                        break;
                    }
                case 3:
                    {
                        asama = "DONE";
                        break;
                    }
            }

            return asama;
        }
        static KartBuyuklugu KartBuyukluguIdBul(int Id)
        {
            KartBuyuklugu returnBuyukluk = (KartBuyuklugu)0;
            switch (Id)
            {
                case 1:
                    {
                        returnBuyukluk = KartBuyuklugu.XS;
                        break;
                    }
                case 2:
                    {
                        returnBuyukluk = KartBuyuklugu.S;
                        break;
                    }
                case 3:
                    {
                        returnBuyukluk = KartBuyuklugu.M;
                        break;
                    }
                case 4:
                    {
                        returnBuyukluk = KartBuyuklugu.L;
                        break;
                    }
                case 5:
                    {
                        returnBuyukluk = KartBuyuklugu.XL;
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Hatalı giriş yaptınız.");
                        break;
                    }
            }
            return returnBuyukluk;
        }
        bool KullanıcıKontrol(int id)
        {
            Kullanıcı bulKullanıcı = kullanıcılar.Find(k => k.Id == id);
            return bulKullanıcı == null ? false : true;
        }
        Kullanıcı KullanıcıBulId(int id)
        {
            return kullanıcılar.Find(k => k.Id == id);
        }
        bool KartBulBaslik(string baslik)
        {
            Gorev gorevToDo = toDoList.Find(x => x.Baslık == baslik);
            Gorev gorevProgress = inProgressList.Find(x => x.Baslık == baslik);
            Gorev gorevDone = doneList.Find(x => x.Baslık == baslik);
            if (gorevToDo != null || gorevProgress != null || gorevDone != null)
                return true;
            else
                return false;
        }

        void KartSilBaslik(string baslik)
        {
            if (KartBulBaslik1(baslik).Asama == ((int)Asamalar.ToDo))
            {
                toDoList.Remove(toDoList.Find(x => x.Baslık == baslik));
            }
            else if (KartBulBaslik1(baslik).Asama == ((int)Asamalar.InProgress))
            {
                inProgressList.Remove(inProgressList.Find(x => x.Baslık == baslik));
            }
            else
            {
                doneList.Remove(doneList.Find(x => x.Baslık == baslik));
            }
        }
        Gorev KartBulBaslik1(string baslik)
        {
            Gorev gorevToDo = toDoList.Find(x => x.Baslık == baslik);
            Gorev gorevProgress = inProgressList.Find(x => x.Baslık == baslik);
            Gorev gorevDone = doneList.Find(x => x.Baslık == baslik);
            if (gorevToDo != null || gorevProgress != null || gorevDone != null)
            {
                if (gorevToDo != null)
                    return gorevToDo;
                else if (gorevProgress != null)
                    return gorevProgress;
                else
                    return gorevDone;
            }
            else
                return null;
        }



    }
    class Kullanıcı
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }

    }
    class Gorev
    {
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public Kullanıcı TanımlıKullanıcı { get; set; }
        public int KartBuyukluguId { get; set; }
        public int Asama { get; set; }
    }
    enum KartBuyuklugu
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
    enum Asamalar
    {
        ToDo = 1,
        InProgress,
        Done
    }
}