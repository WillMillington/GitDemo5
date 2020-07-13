using System;

namespace GitDemo5
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello Thamish!");


            AwsomeSlide();
			      Console.WriteLine(Testing123());

        }

        public static void AwsomeSlide()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Weeeeeee....");
            }
            Console.WriteLine("That was a fun slide!!!");

            Console.WriteLine("Welcome to this Demo!");

            Console.WriteLine(Testing123());

            HelloWorld();
        }

        private static void HelloWorld() => Console.WriteLine("Hello world!");

        static string Testing123() => "I wonder what we'll find here 🙂";
    }
}
