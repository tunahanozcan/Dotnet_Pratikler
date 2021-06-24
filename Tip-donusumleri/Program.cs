using System;

namespace Tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
        //implicit conversion

        Console.WriteLine("**implicit version**");

        short a=5;
        byte b=9;

        int c=a+b;
        Console.WriteLine("c:"+ c);

        long d=c+b;
        Console.WriteLine("d:"+d);

        float e=d+a+b;
        Console.WriteLine("e:"+e);

        string k="zodiac";
        char l='a';
        object m=k+" "+l;
        Console.WriteLine("m:"+m);

        //explicit conversion
        Console.WriteLine("**explicit version**");

        int x=9;
        short y=(short)x;
        Console.WriteLine("y1:"+y);

        float z=19.8f;
        y=(short)z;
        Console.WriteLine("y2:"+y);

        //tostring
        Console.WriteLine("**toString Methodu**");
        int xx=28;
        string yy=xx.ToString();
        Console.WriteLine("yy:"+yy);

        string gg=61.1f.ToString();
        Console.WriteLine("gg:"+gg);

        
        //toConvert metodu
        Console.WriteLine("**System.Convert**");
        string mm="10",nn="20";
        
        int op=Convert.ToInt32(mm);
        int po=Convert.ToInt32(nn);

        int toplam=op+po;
        Console.WriteLine("toplam:"+toplam);

        //Parse Meodu
        Console.WriteLine("**System.Parse**");
        parsedonusum();
        }
        public static void parsedonusum()
        {
            string ol="8.98",lo="7";
            int ip;
            double pi;

            ip=Int32.Parse(lo);
            pi=Double.Parse(ol);

            pi=ip+pi;
            Console.WriteLine(pi);
        }
    }
}
