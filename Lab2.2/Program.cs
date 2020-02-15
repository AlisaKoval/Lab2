using System;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0;
            int a = 1;
            int denom = 1;
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; i++)
            {
                pi = pi + 4 * 1.0 / denom * a;
                denom += 2;
                a = -a;
            }
            Console.WriteLine("pi={0}",pi);
            Console.ReadKey();
            
        }
    }
}
