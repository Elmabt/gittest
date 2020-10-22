using System;

namespace gittest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("sqlt({0})^2 = {1}", i, Math.Sqrt (i));
            }

        }
    }
}

