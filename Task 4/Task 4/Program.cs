using System;

namespace Task_4
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
                if (i % 2 == 1)

                {
                    sum= sum + i;
                                        
                }
            }
            Console.WriteLine("Iki eded arasindaki tek ededlerin cemi:  " +sum);
        }
    }
}
