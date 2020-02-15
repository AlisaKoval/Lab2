using System;

namespace Lab2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            if (day < 10 && month < 10)
            {
                Console.WriteLine("0{0}/0{1}/{2}", day, month, year);
            }
            else if (day < 10 && month >= 10)
            {
                Console.WriteLine("0{0}/{1}/{2}", day, month, year);
            }
            else if (day >= 10 && month < 10) 
            {
                Console.WriteLine("{0}/0{1}/{2}", day, month, year);
            }
            else
            {
                Console.WriteLine("{0}/{1}/{2}", day, month, year);
            }
        }
    }
}
