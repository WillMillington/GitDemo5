using System;

namespace GitDemo5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to this Demo!");

            Console.WriteLine(Testing123());
            HelloWorld();
        }

        private static void HelloWorld() => Console.WriteLine("Hello world!");

        static string Testing123() => "I wonder what we'll find here 🙂";
    }
}
