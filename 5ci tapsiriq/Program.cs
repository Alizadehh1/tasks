using System;

namespace _5ci_tapsiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50; i > 0; i--)
            {
                if (i%3==0 && i%7==0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
