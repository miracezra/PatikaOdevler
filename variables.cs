static void Main(string[] args)
{
    Console.WriteLine("");

    byte b =5;              //1 byte
    sbyte s  = 5;           //1 byte

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
    string str ="mirac";      //sınırsız

    bool t = true;
    bool f = false;
    

    DateTime dt = DateTime.Now;
    Console.WriteLine(dt);

    object o1 ="x";
    object o2 ='x';
    object o3 =4;
    object o4 =4.3;

    string str1 = null;
    string str2 = string.Empty;
    
    
}