using System;
class Program
{
    static void Main(string[] args)
    {
        byte a = 5;
        sbyte b = 30;
        short c = 10;

        int d = a + b + c;
        Console.WriteLine("d : " + d);

        long h = a + b + c;
        Console.WriteLine("h : " + h);

        float i = a + b + c;
        Console.WriteLine("i : " + i);

        string e = "mirac";
        char f = 'q';
        object g = e + f + d;
        Console.WriteLine("g" + g);

        int x = 30;
        byte y = (byte)x;
        Console.WriteLine("y: " + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t: " + t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v: " + v);


        int xx = 30;
        string yy = xx.ToString();
        Console.WriteLine("yy: " + yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz: " + zz);

        string s11 = "10", s22 = "20";
        int sayi11, sayi22;
        int top;

        sayi11 = Convert.ToInt32(s11);
        sayi22 = Convert.ToInt32(s22);

        top = sayi11 + sayi22;

        Console.WriteLine(top);

        ParseMethod();


    }
    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        double1 = Double.Parse(metin2);

        Console.WriteLine(double1);
        Console.WriteLine(rakam1);
    }
}