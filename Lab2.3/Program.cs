using System;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 1;
            int f2= 2;
            int f=0 ;
            int k = 0;
            while (f2 < 10000)
            {
                f = f1 + f2;
                f1 = f2;
                f2 = f;
                if (f>999 && f<10000)
                {
                    k++;
                }
              
            }
            Console.WriteLine("k={0}",k);
            Console.ReadKey();
            
        }
    }
}
