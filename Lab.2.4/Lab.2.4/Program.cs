using System;

namespace Lab._2._4
{
    class Program
    {
        public static long factorial (int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
            {
                long res = 1;
                for (int i=1;i<=n;i++)
                {
                    res *= i;
                }
                return res;
            }
        }
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double q = double.Parse(Console.ReadLine());
            double resoult = 0;
            int s = 1;
            double term = 0;
            x = x * Math.PI / 180;
            int k = 0;
            for (int i = 0; i >= 0; i += 2)
            {
                term = Math.Pow(x, i) / factorial(i) * s;

                if (Math.Abs(term) < q)
                    break;
                resoult = resoult + term;
                s = -s;
                 k++;
            }
            Console.WriteLine("cos(x)={0}, k={1}", resoult,k);
            Console.ReadKey();
        }

    }
}
    

