using System;

namespace programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age  =int.Parse(Console.ReadLine());
            
            Console.WriteLine("Your Personal Info :\n Age : {0} -**- First & Last Name : {1} {2}",age,firstName,lastName);
            Console.ReadLine();
        }
    }
}
