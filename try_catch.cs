using System;
namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("sayı gir");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girmiş olduğunuz sayı {sayi}");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata {ex.Message.ToString()}");

            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");

            }

            try
            {
                int a = int.Parse(null);
                int a = int.Parse("test");
                int a = int.Parse(-2000000000000000000);
            }

            catch (ArgumentNullException ex)
            {

                Console.WriteLine($"Boş değer girdiniz {ex}");

            }

            catch (FormatException ex)
            {

                Console.WriteLine($"Veri Tipi uyumlu değil {ex}");

            }
            catch (OverflowException ex)
            {

                Console.WriteLine($"çok küçük ya da çok büyük bir değer girdiniz {ex}");
            }
            finally
            {
                Console.WriteLine("İşlem Başarılı");

            }
        }
    }
}