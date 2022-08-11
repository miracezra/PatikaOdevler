static void Main(string[] args)
{
    int x = 3;
    int y = 3;
    y =y+ 3;

    Console.WriteLine(y);
    y += 3;
    Console.WriteLine(y);
    y /= 3;
    Console.WriteLine(y);
    y *= 3;

    bool isSuccess = true;
    bool isCompleted = false;

    if (isSuccess && isCompleted)
    {
        Console.WriteLine("Perfect!");
    }

    if (isSuccess || isCompleted)
    {
        Console.WriteLine("Greate!");
    }

    if (isSuccess && !isCompleted)
    {
        Console.WriteLine("Fine!");
    }

    int a =3;
    int b = 4;
    bool sonuc  =a<b;
    
    Console.WriteLine(sonuc);
    sonuc=a>b;
    Console.WriteLine(sonuc);
    sonuc=a>=b;
    Console.WriteLine(sonuc);
    sonuc=a<=b;
    Console.WriteLine(sonuc);
    sonuc=a==b;
    Console.WriteLine(sonuc);
    sonuc=a!=b;
    Console.WriteLine(sonuc);
    
    
    Console.WriteLine("****Aritmetik Operatörler****");

    
    int sayi1 =3;
    int sayi2 =4;

    int sonuc1  =sayi1/sayi2;

    Console.WriteLine(sonuc1);
    sonuc1=sayi1*sayi2;
    Console.WriteLine(sonuc1);
    sonuc1=sayi1+sayi2;
    Console.WriteLine(sonuc1);
    sonuc1=sayi1-sayi2;
    Console.WriteLine(sonuc1);
    sonuc1=sayi1++;
    Console.WriteLine(sonuc1);

    int sonuc2 = 20%3;
    Console.WriteLine(sonuc2);

}