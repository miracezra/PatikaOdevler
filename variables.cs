static void Main(string[] args)
{
    Console.WriteLine("");

    byte b = 5;              //1 byte
    sbyte s = 5;           //1 byte

    short s1 = 5;           //2 byte
    ushort s2 = 5;          //2 byte

    Int16 i16 = 2;          //2 byte
    int i = 2;              //4 byte
    Int32 i32 = 2;          //4 byte
    Int64 i64 = 2;          //8 byte

    uint ui = 2;            //4 byte
    long l = 2;             //8 byte
    ulong ul = 2;           //8 byte

    //reel Sayılar

    float f = 2;              //4 byte
    double d = 2;             //8 byte
    decimal de = 2;           //16 byte

    char ch = '2';            //2 byte
    string str = "mirac";      //sınırsız

    bool t = true;
    bool f = false;

    DateTime dt = DateTime.Now;
    Console.WriteLine(dt);

    object o1 = "x";
    object o2 = 'x';
    object o3 = 4;
    object o4 = 4.3;

    string str1 = null;
    string str2 = string.Empty;
    str1 = "Mirac Ezra";

    string ad = "Mirac";
    string soyad = "ezra";
    string tamAd = ad + "" + soyad;

    //integer tanımlama şekilleri

    int int1 = 5;
    int int2 = 3;
    int carp = int1 * int2;

    bool bool1 = 10 < 2;

    string str20 = "20";
    int int20 = 20;

    string newVal = str20 + int20.ToString();

    int int21 = int20 + Convert.ToInt32(str20);

    int int22 = int20 + int.Parse(str20);

    string datetime = DateTime.Now.ToString("dd.MM.yyyy");
    Console.WriteLine(datetime);
    
    string datetime2 = DateTime.Now.ToString("dd.MM.yyyy");
    Console.WriteLine(datetime2);
    
    string time = DateTime.Now.ToString("HH:mm");
    Console.WriteLine(time);
}