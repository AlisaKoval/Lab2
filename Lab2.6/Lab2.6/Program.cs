using System;

namespace Lab2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            for (int N = 0; N <= 100; N++)
            {
                if (N % 10 == 1 && N!=11)
                {
                    Console.WriteLine("{0} год", N);

                }

                else if (N % 10 >= 2 && N % 10 <= 4 && N/10!=1)
                {
                    Console.WriteLine("{0} года", N);
                }
                else
                {
                    Console.WriteLine("{0} лет", N);
                }
            }
                Console.ReadKey();
            }
        }
    }

