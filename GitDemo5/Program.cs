using System;

namespace GitDemo5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to this Demo!");

            Console.WriteLine(Testing123());
            AwsomeSlide();
        }
        public static void AwsomeSlide()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Weeeeeee....");
            }
            Console.WriteLine("That was a fun slide!!!");
        }

        static string Testing123() => "I wonder what we'll find here 🙂";
    }
}
