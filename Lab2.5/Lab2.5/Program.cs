using System;

namespace Lab2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        int sum = (int)(Math.Pow(i, 3) + Math.Pow(j, 3) + Math.Pow(k, 3));
                        if (N == sum)
                        {
                            Console.WriteLine("{0} {1} {2}", i, j, k);
                            Console.ReadKey();
                        }

                    }
                }

            }
                Console.WriteLine("No such combinations!");
                Console.ReadKey();
            
        }


    }
}
