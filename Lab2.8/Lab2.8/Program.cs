using System;

namespace Lab2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number a<b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            
                if (a % 2 == 0)
                {
                    a++;
                }
                if (b % 2 == 0)
                {
                    b--;
                }
                if (a==b)
            {
                Console.WriteLine("sum={0}", a);
                Console.ReadKey();
            }
            while (a != b)
            {
                sum = sum + a ;
                a += 2;
                if (a == b)
                {
                    sum = sum + a;
                }
            }
            Console.WriteLine("sum={0}", sum);
                Console.ReadKey();
            }
        }
    }

