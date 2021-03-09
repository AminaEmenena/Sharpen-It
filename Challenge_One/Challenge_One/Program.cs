using System;

namespace Challenge_One
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();


            Console.WriteLine("Please enter your age");
            var age = Console.ReadLine();


            Console.WriteLine("Please entery your birthday month");
            var bday = Console.ReadLine();


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your name age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", bday);
        }
    }
}
