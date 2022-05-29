using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int count = 0;
            int avg = 0;
            Console.WriteLine("Birinci eded daxil edin:   ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci eded daxil edin:   ");
            int m = int.Parse(Console.ReadLine());
            for (int i = n; i < m; i++)

            {
                sum = sum + i;
                count++;

            }
            avg = sum / count;
            Console.WriteLine("Iki eded arasindaki ededlerin ededi ortasi:  " + avg);
        }
    }
}
