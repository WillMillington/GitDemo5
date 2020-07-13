using System;

namespace GitDemo5
{
    class Program
    {
        static void Main()
        {

            int num = 0;
            for (int i = 0; i < 10; i++)
            {
                num += 1;
            }
            Console.WriteLine("Welcome to this Demo!");

            Console.WriteLine(Testing123());
        }

        static string Testing123() => "I wonder what we'll find here 🙂";
    }
}
