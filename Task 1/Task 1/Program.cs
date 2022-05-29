using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Birinci eded daxil edin:   ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci eded daxil edin:   ");
            int m = int.Parse(Console.ReadLine());

            for (int i = n; i < m; i++)
            {
                sum += i;

            }
            Console.WriteLine("Daxil etdiyiniz iki eded arasindaki ededlerin cemi:  " +sum);
        }
    }
}
