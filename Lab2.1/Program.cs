using System;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            double pi = 0;
            int a = 1;
            
            int k = int.Parse(Console.ReadLine());
            for (int denom = 1,i = 1; i <= k; i++,denom += 2)
            {
                pi = pi + 4 * 1.0 / denom * a;
                a = -a;
            }
            Console.WriteLine("pi={0}", pi);
            Console.ReadKey();
         }
    }
}
