using System;

namespace _2013_06_28
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = f(f(15));
            Console.WriteLine(String.Format("{0}", result));
            Console.ReadLine();
        }

        static int f(int n)
        {
            if (n > 0)
            {
                if (n % 2 == 0)
                    return -1 * n + 1;
                else
                    return n + 1;
            }
            else
            {
                if (n % 2 == 0)
                    return -1 * n - 1;
                else
                    return n - 1;
            }
        }
    }
}
